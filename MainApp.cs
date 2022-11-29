using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class MainApp : Form
    {
        private static class Owner
        {
            public const int Less = 0;
            public const int Black = 1;
            public const int White = 2;
        }

        private const int CellLen = 40;
        private int turn = 0;
        private int lastIndex = -1;
        private List<Cell> cells = new List<Cell>();

        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            for(int i=0; i < 19; i++)
            {
                for(int j=0; j<19; j++)
                {
                    Cell cell = new Cell(j, i, CellLen);
                    cell.Owner = Owner.Less;
                    cell.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    boardPanel.Controls.Add(cell.PictureBox);
                    cells.Add(cell);
                }
            }
        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics fromGraphics = boardPanel.CreateGraphics();

            for (int i = 0; i < 19; i++)
            {
                fromGraphics.DrawLine(Pens.Black,
                    new Point(CellLen / 2, CellLen / 2 + CellLen * i),
                    new Point(CellLen / 2 + CellLen * 18, CellLen / 2 + CellLen * i));
                fromGraphics.DrawLine(Pens.Black,
                    new Point(CellLen / 2 + CellLen * i, CellLen / 2),
                    new Point(CellLen / 2 + CellLen * i, CellLen / 2 + CellLen * 18));
            }

            const int circleLen = 10;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fromGraphics.FillEllipse(Brushes.Black,
                        i * CellLen * 6 + CellLen * 3 + CellLen / 2 - circleLen / 2,
                        j * CellLen * 6 + CellLen * 3 + CellLen / 2 - circleLen / 2,
                        circleLen, circleLen);
                }
            }
        }

        private void boardPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / CellLen;
            int y = e.Y / CellLen;
            int index = y * 19 + x;

            cells[index].Owner = turn % 2 + 1;
            if (lastIndex != -1)
                cells[lastIndex].Text = "";
            cells[index].Text = "●";
            lastIndex= index;
            turnToolStripTextBox.Text = (turn+1).ToString() + "수";
            turn++;

            if (WinCheck(index))
            {
                string winer = cells[index].Owner == Owner.Black ? "흑" : "백";

                if (MessageBox.Show($"{winer} 승리. 다시하시겠습니까?", "게임 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearBoard();
                }
            }
        }

        private bool WinCheck(int index)
        {
            int owner = cells[index].Owner;
            int tempIndex, cnt;
            //가로 검사
            tempIndex = index;
            cnt = 0;
            while (cells[tempIndex].Owner == owner)
                tempIndex--;
            tempIndex++;
            while (cells[tempIndex].Owner == owner)
            {
                tempIndex += 1;
                cnt++;
            }
            if (cnt == 5) return true;
            //세로 검사
            tempIndex = index;
            cnt = 0;
            while (cells[tempIndex].Owner == owner)
                tempIndex -= 19;
            tempIndex += 19;
            while (cells[tempIndex].Owner == owner)
            {
                tempIndex += 19;
                cnt++;
            }
            if (cnt == 5) return true;

            //대각선 검사
            tempIndex = index;
            cnt = 0;
            while (cells[tempIndex].Owner == owner)
                tempIndex -= 20;
            tempIndex += 20;
            while (cells[tempIndex].Owner == owner)
            {
                tempIndex += 20;
                cnt++;
            }
            if (cnt == 5) return true;

            tempIndex = index;
            cnt = 0;
            while (cells[tempIndex].Owner == owner)
                tempIndex -= 18;
            tempIndex += 18;
            while (cells[tempIndex].Owner == owner)
            {
                tempIndex += 18;
                cnt++;
            }
            if (cnt == 5) return true;

            return false;
        }

        private void ClearBoard()
        {
            for(int i=0; i<19; i++)
                for(int j=0; j<19; j++)
                    cells[i * 19 + j].Owner = Owner.Less;
            turn = 0;
            turnToolStripTextBox.Text = "";
        }

        private void boardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / CellLen;
            int y = e.Y / CellLen;
            Graphics graphics = boardPanel.CreateGraphics();
        }

        private void 다시하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }
    }
}
