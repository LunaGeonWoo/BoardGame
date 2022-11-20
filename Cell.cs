using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    internal class Cell
    {

        private int owner;
        private PictureBox pictureBox;
        Bitmap blackBitmap;
        Bitmap whiteBitmap;

        public Cell(int x, int y, int len)
        {
            pictureBox = new PictureBox();
            blackBitmap = new Bitmap("흑돌 (사용자 지정).png");
            whiteBitmap = new Bitmap("백돌 (사용자 지정).png");
            pictureBox.Location = new Point(x*len, y*len);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(len, len);
            pictureBox.Image = blackBitmap;
        }

        public int Owner {
            get { return owner; } 
            set { 
                owner = value;
                switch (owner)
                {
                    case 0:
                        pictureBox.Hide();
                        break;
                    case 1:
                        pictureBox.Image = blackBitmap;
                        pictureBox.Show();
                        break;
                    case 2:
                        pictureBox.Image = whiteBitmap;
                        pictureBox.Show();
                        break;
                }
            } 
        }

        public PictureBox PictureBox
        {
            get { return pictureBox; }
            set { pictureBox = value; }
        }
    }
}
