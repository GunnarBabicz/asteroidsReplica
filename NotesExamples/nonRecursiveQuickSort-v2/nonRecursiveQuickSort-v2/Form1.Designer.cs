namespace nonRecursiveQuickSort_v2
{
    partial class Form1
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
            this.btnStuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStuff
            // 
            this.btnStuff.Location = new System.Drawing.Point(105, 106);
            this.btnStuff.Name = "btnStuff";
            this.btnStuff.Size = new System.Drawing.Size(75, 23);
            this.btnStuff.TabIndex = 0;
            this.btnStuff.Text = "do stuff";
            this.btnStuff.UseVisualStyleBackColor = true;
            this.btnStuff.Click += new System.EventHandler(this.btnStuff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStuff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStuff;
    }
}

