namespace GunnarBabiczEx1
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
            this.btnDone = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblWhenDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(393, 239);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 186);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(173, 189);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(150, 15);
            this.lblEnterName.TabIndex = 2;
            this.lblEnterName.Text = "Enter your name in the box";
            this.lblEnterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWhenDone
            // 
            this.lblWhenDone.AutoSize = true;
            this.lblWhenDone.Location = new System.Drawing.Point(168, 243);
            this.lblWhenDone.Name = "lblWhenDone";
            this.lblWhenDone.Size = new System.Drawing.Size(155, 15);
            this.lblWhenDone.TabIndex = 3;
            this.lblWhenDone.Text = "Press the button when done";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWhenDone);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDone);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hello!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDone;
        private TextBox txtName;
        private Label lblEnterName;
        private Label lblWhenDone;
    }
}