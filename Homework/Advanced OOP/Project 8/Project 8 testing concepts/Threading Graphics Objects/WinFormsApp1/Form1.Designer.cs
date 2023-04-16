namespace WinFormsApp1
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
            this.btnNewThread = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblnumEntities = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewThread
            // 
            this.btnNewThread.Location = new System.Drawing.Point(219, 0);
            this.btnNewThread.Name = "btnNewThread";
            this.btnNewThread.Size = new System.Drawing.Size(140, 23);
            this.btnNewThread.TabIndex = 2;
            this.btnNewThread.Text = "Create Another Thread";
            this.btnNewThread.UseVisualStyleBackColor = true;
            this.btnNewThread.Click += new System.EventHandler(this.btnNewThread_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(880, 890);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblnumEntities
            // 
            this.lblnumEntities.AutoSize = true;
            this.lblnumEntities.Location = new System.Drawing.Point(826, 9);
            this.lblnumEntities.Name = "lblnumEntities";
            this.lblnumEntities.Size = new System.Drawing.Size(118, 15);
            this.lblnumEntities.TabIndex = 4;
            this.lblnumEntities.Text = "Number of Entities: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.lblnumEntities);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewThread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNewThread;
        private Button btnExit;
        private Label lblnumEntities;
    }
}