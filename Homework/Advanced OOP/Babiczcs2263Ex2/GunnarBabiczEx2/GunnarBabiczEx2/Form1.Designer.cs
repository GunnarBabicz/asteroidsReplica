namespace GunnarBabiczEx2
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(346, 146);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(86, 35);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(290, 236);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(204, 15);
            this.lblOut.TabIndex = 1;
            this.lblOut.Text = "Enter a year to see if it was a leap year";
            this.lblOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(210, 187);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(366, 23);
            this.txtIn.TabIndex = 2;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnter;
        private Label lblOut;
        private TextBox txtIn;
    }
}