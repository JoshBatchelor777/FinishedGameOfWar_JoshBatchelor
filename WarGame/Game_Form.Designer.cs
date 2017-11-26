namespace WarGame
{
    partial class Game_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.player1Box = new System.Windows.Forms.GroupBox();
            this.p1Label = new System.Windows.Forms.Label();
            this.player2Box = new System.Windows.Forms.GroupBox();
            this.p2Label = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dankModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameResultLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dealButton = new System.Windows.Forms.Button();
            this.programDialogBox = new System.Windows.Forms.GroupBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.readmeLabel = new System.Windows.Forms.Label();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.player1Box.SuspendLayout();
            this.player2Box.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.programDialogBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(333, 221);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(578, 589);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // player1Box
            // 
            this.player1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.player1Box.Controls.Add(this.p1Label);
            this.player1Box.Location = new System.Drawing.Point(2, 155);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(149, 121);
            this.player1Box.TabIndex = 4;
            this.player1Box.TabStop = false;
            this.player1Box.Text = "Player 1 Score";
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Label.ForeColor = System.Drawing.Color.Blue;
            this.p1Label.Location = new System.Drawing.Point(31, 38);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(0, 55);
            this.p1Label.TabIndex = 0;
            // 
            // player2Box
            // 
            this.player2Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.player2Box.Controls.Add(this.p2Label);
            this.player2Box.Location = new System.Drawing.Point(157, 155);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(149, 121);
            this.player2Box.TabIndex = 5;
            this.player2Box.TabStop = false;
            this.player2Box.Text = "Player 2 Score";
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Label.ForeColor = System.Drawing.Color.Red;
            this.p2Label.Location = new System.Drawing.Point(29, 38);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(0, 55);
            this.p2Label.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.dankModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // dankModeToolStripMenuItem
            // 
            this.dankModeToolStripMenuItem.Name = "dankModeToolStripMenuItem";
            this.dankModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.dankModeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dankModeToolStripMenuItem.Text = "Dank Mode";
            this.dankModeToolStripMenuItem.Click += new System.EventHandler(this.dankModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReadmeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openReadmeToolStripMenuItem
            // 
            this.openReadmeToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.openReadmeToolStripMenuItem.Name = "openReadmeToolStripMenuItem";
            this.openReadmeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openReadmeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openReadmeToolStripMenuItem.Text = "Open Readme";
            this.openReadmeToolStripMenuItem.Click += new System.EventHandler(this.openReadmeToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(665, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // gameResultLabel
            // 
            this.gameResultLabel.AutoSize = true;
            this.gameResultLabel.Location = new System.Drawing.Point(3, 0);
            this.gameResultLabel.Name = "gameResultLabel";
            this.gameResultLabel.Size = new System.Drawing.Size(70, 13);
            this.gameResultLabel.TabIndex = 7;
            this.gameResultLabel.Text = "Game Output";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.gameResultLabel);
            this.panel2.Location = new System.Drawing.Point(2, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 298);
            this.panel2.TabIndex = 8;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(615, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 296);
            this.vScrollBar1.TabIndex = 8;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(333, 182);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 9;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // programDialogBox
            // 
            this.programDialogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.programDialogBox.Controls.Add(this.activityLabel);
            this.programDialogBox.Location = new System.Drawing.Point(430, 155);
            this.programDialogBox.Name = "programDialogBox";
            this.programDialogBox.Size = new System.Drawing.Size(223, 121);
            this.programDialogBox.TabIndex = 10;
            this.programDialogBox.TabStop = false;
            this.programDialogBox.Text = "Game Stats";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(6, 15);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(0, 13);
            this.activityLabel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::WarGame.Properties.Resources._8;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 27);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(320, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 145);
            this.label1.TabIndex = 3;
            this.label1.Text = "WAR!";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.readmeLabel);
            this.panel3.Controls.Add(this.vScrollBar2);
            this.panel3.Location = new System.Drawing.Point(333, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 294);
            this.panel3.TabIndex = 11;
            // 
            // readmeLabel
            // 
            this.readmeLabel.AutoSize = true;
            this.readmeLabel.Location = new System.Drawing.Point(3, 0);
            this.readmeLabel.Name = "readmeLabel";
            this.readmeLabel.Size = new System.Drawing.Size(121, 26);
            this.readmeLabel.TabIndex = 1;
            this.readmeLabel.Text = "Go to \"Help\" for readme\r\nfile, or press F3.\r\n";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(300, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(16, 290);
            this.vScrollBar2.TabIndex = 0;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(665, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.programDialogBox);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Game_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAR!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.player1Box.ResumeLayout(false);
            this.player1Box.PerformLayout();
            this.player2Box.ResumeLayout(false);
            this.player2Box.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.programDialogBox.ResumeLayout(false);
            this.programDialogBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox player1Box;
        private System.Windows.Forms.GroupBox player2Box;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dankModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gameResultLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox programDialogBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label readmeLabel;
        public System.Windows.Forms.Label activityLabel;
    }
}

