
namespace Othello
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PlayerTwoTxt = new System.Windows.Forms.TextBox();
            this.PlayerOneTxt = new System.Windows.Forms.TextBox();
            this.PlayerTwoImg = new System.Windows.Forms.PictureBox();
            this.PlayerOneImg = new System.Windows.Forms.PictureBox();
            this.PlayerTwoXLbl = new System.Windows.Forms.Label();
            this.PlayerTwoCountLbl = new System.Windows.Forms.Label();
            this.PlayerOneCountLbl = new System.Windows.Forms.Label();
            this.PlayerOneXLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.PlayerTwoTxt);
            this.panel1.Controls.Add(this.PlayerOneTxt);
            this.panel1.Controls.Add(this.PlayerTwoImg);
            this.panel1.Controls.Add(this.PlayerOneImg);
            this.panel1.Controls.Add(this.PlayerTwoXLbl);
            this.panel1.Controls.Add(this.PlayerTwoCountLbl);
            this.panel1.Controls.Add(this.PlayerOneCountLbl);
            this.panel1.Controls.Add(this.PlayerOneXLbl);
            this.panel1.Location = new System.Drawing.Point(12, 715);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 126);
            this.panel1.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(785, 80);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(60, 29);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PlayerTwoTxt
            // 
            this.PlayerTwoTxt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoTxt.Location = new System.Drawing.Point(559, 72);
            this.PlayerTwoTxt.Name = "PlayerTwoTxt";
            this.PlayerTwoTxt.Size = new System.Drawing.Size(186, 36);
            this.PlayerTwoTxt.TabIndex = 9;
            // 
            // PlayerOneTxt
            // 
            this.PlayerOneTxt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneTxt.Location = new System.Drawing.Point(160, 72);
            this.PlayerOneTxt.Name = "PlayerOneTxt";
            this.PlayerOneTxt.Size = new System.Drawing.Size(186, 36);
            this.PlayerOneTxt.TabIndex = 8;
            // 
            // PlayerTwoImg
            // 
            this.PlayerTwoImg.Image = global::Othello.Properties.Resources.Black_Square;
            this.PlayerTwoImg.InitialImage = null;
            this.PlayerTwoImg.Location = new System.Drawing.Point(489, 47);
            this.PlayerTwoImg.Name = "PlayerTwoImg";
            this.PlayerTwoImg.Size = new System.Drawing.Size(64, 62);
            this.PlayerTwoImg.TabIndex = 6;
            this.PlayerTwoImg.TabStop = false;
            // 
            // PlayerOneImg
            // 
            this.PlayerOneImg.Image = global::Othello.Properties.Resources.White_Square;
            this.PlayerOneImg.InitialImage = null;
            this.PlayerOneImg.Location = new System.Drawing.Point(90, 47);
            this.PlayerOneImg.Name = "PlayerOneImg";
            this.PlayerOneImg.Size = new System.Drawing.Size(64, 62);
            this.PlayerOneImg.TabIndex = 5;
            this.PlayerOneImg.TabStop = false;
            // 
            // PlayerTwoXLbl
            // 
            this.PlayerTwoXLbl.AutoSize = true;
            this.PlayerTwoXLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoXLbl.Location = new System.Drawing.Point(443, 63);
            this.PlayerTwoXLbl.Name = "PlayerTwoXLbl";
            this.PlayerTwoXLbl.Size = new System.Drawing.Size(40, 46);
            this.PlayerTwoXLbl.TabIndex = 2;
            this.PlayerTwoXLbl.Text = "X";
            // 
            // PlayerTwoCountLbl
            // 
            this.PlayerTwoCountLbl.AutoSize = true;
            this.PlayerTwoCountLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoCountLbl.Location = new System.Drawing.Point(411, 63);
            this.PlayerTwoCountLbl.Name = "PlayerTwoCountLbl";
            this.PlayerTwoCountLbl.Size = new System.Drawing.Size(38, 46);
            this.PlayerTwoCountLbl.TabIndex = 3;
            this.PlayerTwoCountLbl.Text = "2";
            // 
            // PlayerOneCountLbl
            // 
            this.PlayerOneCountLbl.AutoSize = true;
            this.PlayerOneCountLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneCountLbl.Location = new System.Drawing.Point(13, 63);
            this.PlayerOneCountLbl.Name = "PlayerOneCountLbl";
            this.PlayerOneCountLbl.Size = new System.Drawing.Size(38, 45);
            this.PlayerOneCountLbl.TabIndex = 4;
            this.PlayerOneCountLbl.Text = "2";
            // 
            // PlayerOneXLbl
            // 
            this.PlayerOneXLbl.AutoSize = true;
            this.PlayerOneXLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneXLbl.Location = new System.Drawing.Point(44, 63);
            this.PlayerOneXLbl.Name = "PlayerOneXLbl";
            this.PlayerOneXLbl.Size = new System.Drawing.Size(40, 46);
            this.PlayerOneXLbl.TabIndex = 1;
            this.PlayerOneXLbl.Text = "X";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.serToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // serToolStripMenuItem
            // 
            this.serToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEBUGToolStripMenuItem});
            this.serToolStripMenuItem.Name = "serToolStripMenuItem";
            this.serToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.serToolStripMenuItem.Text = "Settings";
            // 
            // dEBUGToolStripMenuItem
            // 
            this.dEBUGToolStripMenuItem.Name = "dEBUGToolStripMenuItem";
            this.dEBUGToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.dEBUGToolStripMenuItem.Text = "DEBUG";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "Form1";
            this.Text = "O’Neillo v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlayerOneXLbl;
        private System.Windows.Forms.Label PlayerTwoXLbl;
        private System.Windows.Forms.Label PlayerTwoCountLbl;
        private System.Windows.Forms.Label PlayerOneCountLbl;
        private System.Windows.Forms.PictureBox PlayerOneImg;
        private System.Windows.Forms.PictureBox PlayerTwoImg;
        private System.Windows.Forms.TextBox PlayerTwoTxt;
        private System.Windows.Forms.TextBox PlayerOneTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEBUGToolStripMenuItem;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

