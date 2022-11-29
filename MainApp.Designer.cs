namespace Gomoku
{
    partial class MainApp
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바둑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.다시하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.boardPanel.Location = new System.Drawing.Point(0, 27);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(760, 760);
            this.boardPanel.TabIndex = 0;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            this.boardPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseDown);
            this.boardPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.turnToolStripTextBox});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(760, 26);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.다시하기ToolStripMenuItem,
            this.게임ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 게임ToolStripMenuItem
            // 
            this.게임ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.오목ToolStripMenuItem,
            this.바둑ToolStripMenuItem});
            this.게임ToolStripMenuItem.Name = "게임ToolStripMenuItem";
            this.게임ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.게임ToolStripMenuItem.Text = "게임";
            // 
            // 오목ToolStripMenuItem
            // 
            this.오목ToolStripMenuItem.Name = "오목ToolStripMenuItem";
            this.오목ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.오목ToolStripMenuItem.Text = "오목";
            // 
            // 바둑ToolStripMenuItem
            // 
            this.바둑ToolStripMenuItem.Name = "바둑ToolStripMenuItem";
            this.바둑ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.바둑ToolStripMenuItem.Text = "바둑";
            // 
            // turnToolStripTextBox
            // 
            this.turnToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.turnToolStripTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.turnToolStripTextBox.Enabled = false;
            this.turnToolStripTextBox.Font = new System.Drawing.Font("궁서체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.turnToolStripTextBox.Name = "turnToolStripTextBox";
            this.turnToolStripTextBox.ReadOnly = true;
            this.turnToolStripTextBox.Size = new System.Drawing.Size(48, 22);
            this.turnToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 다시하기ToolStripMenuItem
            // 
            this.다시하기ToolStripMenuItem.Name = "다시하기ToolStripMenuItem";
            this.다시하기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.다시하기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.다시하기ToolStripMenuItem.Text = "다시하기";
            this.다시하기ToolStripMenuItem.Click += new System.EventHandler(this.다시하기ToolStripMenuItem_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 787);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainApp";
            this.Text = "오목";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오목ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox turnToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem 다시하기ToolStripMenuItem;
    }
}

