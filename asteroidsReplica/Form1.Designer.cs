namespace asteroids
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnNicknameEnter = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Agency FB", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1280, 143);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Asteroids";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(565, 307);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPlay_Click);
            // 
            // lblControls
            // 
            this.lblControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(12, 587);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(109, 124);
            this.lblControls.TabIndex = 7;
            this.lblControls.Text = "left: a      right: d  forward: w shoot: space";
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 20;
            this.tmrMovement.Tick += new System.EventHandler(this.tmrTickUpdate);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(565, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMainMenu.BackColor = System.Drawing.Color.Black;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(565, 658);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMainMenu.TabIndex = 14;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.Text = "Return to Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(600, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 32);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(94, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(68, 32);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "Level: 1";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(0, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(74, 32);
            this.lblLives.TabIndex = 12;
            this.lblLives.Text = "Lives: 0";
            // 
            // pnlBorder
            // 
            this.pnlBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBorder.AutoSize = true;
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBorder.Controls.Add(this.lblLives);
            this.pnlBorder.Controls.Add(this.lblLevel);
            this.pnlBorder.Controls.Add(this.lblScore);
            this.pnlBorder.ForeColor = System.Drawing.Color.Black;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.MaximumSize = new System.Drawing.Size(2560, 30);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1280, 30);
            this.pnlBorder.TabIndex = 15;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(535, 433);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(200, 51);
            this.lblWarning.TabIndex = 17;
            this.lblWarning.Text = "** WARNING: This game includes audio. Consider starting with low volume";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScoreboard.BackColor = System.Drawing.Color.Black;
            this.lblScoreboard.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreboard.ForeColor = System.Drawing.Color.White;
            this.lblScoreboard.Location = new System.Drawing.Point(0, 176);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(1280, 479);
            this.lblScoreboard.TabIndex = 18;
            this.lblScoreboard.Text = "Scoreboard";
            this.lblScoreboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNickname.BackColor = System.Drawing.Color.Black;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNickname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNickname.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickname.ForeColor = System.Drawing.Color.White;
            this.txtNickname.Location = new System.Drawing.Point(565, 359);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.PlaceholderText = "AAA";
            this.txtNickname.Size = new System.Drawing.Size(150, 71);
            this.txtNickname.TabIndex = 19;
            this.txtNickname.TabStop = false;
            this.txtNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNickname.TextChanged += new System.EventHandler(this.txtNickname_TextChanged);
            // 
            // btnNicknameEnter
            // 
            this.btnNicknameEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNicknameEnter.BackColor = System.Drawing.Color.Black;
            this.btnNicknameEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNicknameEnter.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNicknameEnter.ForeColor = System.Drawing.Color.White;
            this.btnNicknameEnter.Location = new System.Drawing.Point(565, 521);
            this.btnNicknameEnter.Name = "btnNicknameEnter";
            this.btnNicknameEnter.Size = new System.Drawing.Size(150, 50);
            this.btnNicknameEnter.TabIndex = 20;
            this.btnNicknameEnter.TabStop = false;
            this.btnNicknameEnter.Text = "Enter";
            this.btnNicknameEnter.UseVisualStyleBackColor = false;
            this.btnNicknameEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNicknameEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnNicknameEnter);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.lblScoreboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        GameEvent Event = new GameEvent();
        
        private Label lblTitle;
        private Button btnPlay;
        private Label lblControls;
        private System.Windows.Forms.Timer tmrMovement;
        private Button btnExit;
        private Button btnMainMenu;
        private Label lblScore;
        private Label lblLevel;
        private Label lblLives;
        private Panel pnlBorder;
        private Label lblWarning;
        private Label lblScoreboard;
        private TextBox txtNickname;
        private Button btnNicknameEnter;
    }
}