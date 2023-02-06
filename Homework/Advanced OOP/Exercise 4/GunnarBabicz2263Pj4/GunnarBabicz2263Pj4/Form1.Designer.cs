namespace GunnarBabicz2263Pj4
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
            this.btnRot13Run = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.lblDirectionsDecodeFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.txtFileChosen = new System.Windows.Forms.TextBox();
            this.lblDirectionsDecodeText = new System.Windows.Forms.Label();
            this.btnSaveEncodedFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRot13Run
            // 
            this.btnRot13Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRot13Run.Location = new System.Drawing.Point(544, 166);
            this.btnRot13Run.Name = "btnRot13Run";
            this.btnRot13Run.Size = new System.Drawing.Size(75, 22);
            this.btnRot13Run.TabIndex = 0;
            this.btnRot13Run.Text = "Encode";
            this.btnRot13Run.UseVisualStyleBackColor = true;
            this.btnRot13Run.Click += new System.EventHandler(this.btnRot13Run_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(447, 135);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(275, 23);
            this.txtIn.TabIndex = 1;
            // 
            // lblDirectionsDecodeFile
            // 
            this.lblDirectionsDecodeFile.Location = new System.Drawing.Point(58, 100);
            this.lblDirectionsDecodeFile.Name = "lblDirectionsDecodeFile";
            this.lblDirectionsDecodeFile.Size = new System.Drawing.Size(224, 26);
            this.lblDirectionsDecodeFile.TabIndex = 2;
            this.lblDirectionsDecodeFile.Text = "Choose a txt file to encode";
            this.lblDirectionsDecodeFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Location = new System.Drawing.Point(304, 135);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(26, 25);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnClearFile
            // 
            this.btnClearFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFile.Location = new System.Drawing.Point(69, 165);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(75, 23);
            this.btnClearFile.TabIndex = 4;
            this.btnClearFile.Text = "Clear File";
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.btnClearFile_Click);
            // 
            // txtFileChosen
            // 
            this.txtFileChosen.Location = new System.Drawing.Point(12, 136);
            this.txtFileChosen.Name = "txtFileChosen";
            this.txtFileChosen.Size = new System.Drawing.Size(295, 23);
            this.txtFileChosen.TabIndex = 5;
            // 
            // lblDirectionsDecodeText
            // 
            this.lblDirectionsDecodeText.AutoSize = true;
            this.lblDirectionsDecodeText.Location = new System.Drawing.Point(447, 106);
            this.lblDirectionsDecodeText.Name = "lblDirectionsDecodeText";
            this.lblDirectionsDecodeText.Size = new System.Drawing.Size(275, 15);
            this.lblDirectionsDecodeText.TabIndex = 6;
            this.lblDirectionsDecodeText.Text = "Type anything in the text box to encode with Rot13";
            // 
            // btnSaveEncodedFile
            // 
            this.btnSaveEncodedFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEncodedFile.Location = new System.Drawing.Point(191, 165);
            this.btnSaveEncodedFile.Name = "btnSaveEncodedFile";
            this.btnSaveEncodedFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEncodedFile.TabIndex = 8;
            this.btnSaveEncodedFile.Text = "Save File";
            this.btnSaveEncodedFile.UseVisualStyleBackColor = true;
            this.btnSaveEncodedFile.Click += new System.EventHandler(this.btnSaveEncodedFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveEncodedFile);
            this.Controls.Add(this.lblDirectionsDecodeText);
            this.Controls.Add(this.txtFileChosen);
            this.Controls.Add(this.btnClearFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblDirectionsDecodeFile);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.btnRot13Run);
            this.Name = "Form1";
            this.Text = "Rot13 Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRot13Run;
        private TextBox txtIn;
        private Label lblDirectionsDecodeFile;
        private Button btnOpenFile;
        private Button btnClearFile;
        private TextBox txtFileChosen;
        private Label lblDirectionsDecodeText;
        private Button btnSaveEncodedFile;
    }
}