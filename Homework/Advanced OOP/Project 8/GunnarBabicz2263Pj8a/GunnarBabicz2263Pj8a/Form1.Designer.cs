namespace GunnarBabicz2263Pj8a
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
            this.lblAsteroidsTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.btnTestAsteroid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsteroidsTitle
            // 
            this.lblAsteroidsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAsteroidsTitle.AutoSize = true;
            this.lblAsteroidsTitle.Font = new System.Drawing.Font("Agency FB", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAsteroidsTitle.ForeColor = System.Drawing.Color.White;
            this.lblAsteroidsTitle.Location = new System.Drawing.Point(418, 9);
            this.lblAsteroidsTitle.Name = "lblAsteroidsTitle";
            this.lblAsteroidsTitle.Size = new System.Drawing.Size(424, 143);
            this.lblAsteroidsTitle.TabIndex = 0;
            this.lblAsteroidsTitle.Text = "Asteroids";
            this.lblAsteroidsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Location = new System.Drawing.Point(117, 641);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(161, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play (test ship)";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1193, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblControls
            // 
            this.lblControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(2, 587);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(109, 124);
            this.lblControls.TabIndex = 7;
            this.lblControls.Text = "left: a      right: d  forward: w shoot: space";
            // 
            // btnTestAsteroid
            // 
            this.btnTestAsteroid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestAsteroid.Location = new System.Drawing.Point(117, 670);
            this.btnTestAsteroid.Name = "btnTestAsteroid";
            this.btnTestAsteroid.Size = new System.Drawing.Size(161, 23);
            this.btnTestAsteroid.TabIndex = 8;
            this.btnTestAsteroid.Text = "Test Asteroid (runs for 3s)";
            this.btnTestAsteroid.UseVisualStyleBackColor = true;
            this.btnTestAsteroid.Click += new System.EventHandler(this.btnTestAsteroid_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(941, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Work in Progress. Threading has not been implemented yet.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestAsteroid);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblAsteroidsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAsteroidsTitle;
        private Button btnPlay;
        private Button btnExit;
        private Label lblControls;
        private Button btnTestAsteroid;
        private Label label1;
    }
}