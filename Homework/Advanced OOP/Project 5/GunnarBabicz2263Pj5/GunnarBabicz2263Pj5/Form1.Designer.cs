namespace GunnarBabicz2263Pj5
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInsertFirst = new System.Windows.Forms.Button();
            this.btnInsertTail = new System.Windows.Forms.Button();
            this.btnInsertHead = new System.Windows.Forms.Button();
            this.btnInsertAfterCurrent = new System.Windows.Forms.Button();
            this.btnDeleteHead = new System.Windows.Forms.Button();
            this.btnDeleteTail = new System.Windows.Forms.Button();
            this.btnDeleteCurrent = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtNumberOfNodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentNode = new System.Windows.Forms.Label();
            this.txtCurrentNode = new System.Windows.Forms.TextBox();
            this.btnNextNode = new System.Windows.Forms.Button();
            this.btnPreviousNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(44, 99);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(451, 23);
            this.txtOutput.TabIndex = 0;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(219, 81);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(110, 15);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "All strings in the list";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(901, 99);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(222, 23);
            this.txtInput.TabIndex = 2;
            // 
            // btnInsertFirst
            // 
            this.btnInsertFirst.Location = new System.Drawing.Point(958, 128);
            this.btnInsertFirst.Name = "btnInsertFirst";
            this.btnInsertFirst.Size = new System.Drawing.Size(116, 23);
            this.btnInsertFirst.TabIndex = 3;
            this.btnInsertFirst.Text = "Insert First Node";
            this.btnInsertFirst.UseVisualStyleBackColor = true;
            this.btnInsertFirst.Click += new System.EventHandler(this.anyInsertButton_Click);
            // 
            // btnInsertTail
            // 
            this.btnInsertTail.Location = new System.Drawing.Point(1080, 157);
            this.btnInsertTail.Name = "btnInsertTail";
            this.btnInsertTail.Size = new System.Drawing.Size(116, 23);
            this.btnInsertTail.TabIndex = 4;
            this.btnInsertTail.Text = "Insert at Tail";
            this.btnInsertTail.UseVisualStyleBackColor = true;
            this.btnInsertTail.Click += new System.EventHandler(this.anyInsertButton_Click);
            // 
            // btnInsertHead
            // 
            this.btnInsertHead.Location = new System.Drawing.Point(836, 157);
            this.btnInsertHead.Name = "btnInsertHead";
            this.btnInsertHead.Size = new System.Drawing.Size(116, 23);
            this.btnInsertHead.TabIndex = 5;
            this.btnInsertHead.Text = "Insert at Head";
            this.btnInsertHead.UseVisualStyleBackColor = true;
            this.btnInsertHead.Click += new System.EventHandler(this.anyInsertButton_Click);
            // 
            // btnInsertAfterCurrent
            // 
            this.btnInsertAfterCurrent.Location = new System.Drawing.Point(958, 157);
            this.btnInsertAfterCurrent.Name = "btnInsertAfterCurrent";
            this.btnInsertAfterCurrent.Size = new System.Drawing.Size(116, 23);
            this.btnInsertAfterCurrent.TabIndex = 6;
            this.btnInsertAfterCurrent.Text = "Insert After Current";
            this.btnInsertAfterCurrent.UseVisualStyleBackColor = true;
            this.btnInsertAfterCurrent.Click += new System.EventHandler(this.anyInsertButton_Click);
            // 
            // btnDeleteHead
            // 
            this.btnDeleteHead.Location = new System.Drawing.Point(54, 136);
            this.btnDeleteHead.Name = "btnDeleteHead";
            this.btnDeleteHead.Size = new System.Drawing.Size(97, 22);
            this.btnDeleteHead.TabIndex = 7;
            this.btnDeleteHead.Text = "Delete Head";
            this.btnDeleteHead.UseVisualStyleBackColor = true;
            this.btnDeleteHead.Click += new System.EventHandler(this.anyDeleteButton_Click);
            // 
            // btnDeleteTail
            // 
            this.btnDeleteTail.Location = new System.Drawing.Point(398, 137);
            this.btnDeleteTail.Name = "btnDeleteTail";
            this.btnDeleteTail.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteTail.TabIndex = 8;
            this.btnDeleteTail.Text = "Delete Tail";
            this.btnDeleteTail.UseVisualStyleBackColor = true;
            this.btnDeleteTail.Click += new System.EventHandler(this.anyDeleteButton_Click);
            // 
            // btnDeleteCurrent
            // 
            this.btnDeleteCurrent.Location = new System.Drawing.Point(219, 136);
            this.btnDeleteCurrent.Name = "btnDeleteCurrent";
            this.btnDeleteCurrent.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteCurrent.TabIndex = 9;
            this.btnDeleteCurrent.Text = "Delete Current";
            this.btnDeleteCurrent.UseVisualStyleBackColor = true;
            this.btnDeleteCurrent.Click += new System.EventHandler(this.anyDeleteButton_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(970, 81);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(93, 15);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "Enter Input Here";
            // 
            // txtNumberOfNodes
            // 
            this.txtNumberOfNodes.Location = new System.Drawing.Point(208, 198);
            this.txtNumberOfNodes.Name = "txtNumberOfNodes";
            this.txtNumberOfNodes.ReadOnly = true;
            this.txtNumberOfNodes.Size = new System.Drawing.Size(68, 23);
            this.txtNumberOfNodes.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of Nodes in List:";
            // 
            // lblCurrentNode
            // 
            this.lblCurrentNode.AutoSize = true;
            this.lblCurrentNode.Location = new System.Drawing.Point(101, 253);
            this.lblCurrentNode.Name = "lblCurrentNode";
            this.lblCurrentNode.Size = new System.Drawing.Size(82, 15);
            this.lblCurrentNode.TabIndex = 13;
            this.lblCurrentNode.Text = "Current Node:";
            // 
            // txtCurrentNode
            // 
            this.txtCurrentNode.Location = new System.Drawing.Point(208, 250);
            this.txtCurrentNode.Name = "txtCurrentNode";
            this.txtCurrentNode.Size = new System.Drawing.Size(68, 23);
            this.txtCurrentNode.TabIndex = 14;
            // 
            // btnNextNode
            // 
            this.btnNextNode.Location = new System.Drawing.Point(275, 303);
            this.btnNextNode.Name = "btnNextNode";
            this.btnNextNode.Size = new System.Drawing.Size(100, 23);
            this.btnNextNode.TabIndex = 15;
            this.btnNextNode.Text = "Next Node";
            this.btnNextNode.UseVisualStyleBackColor = true;
            this.btnNextNode.Click += new System.EventHandler(this.btnNextNode_Click);
            // 
            // btnPreviousNode
            // 
            this.btnPreviousNode.Location = new System.Drawing.Point(112, 303);
            this.btnPreviousNode.Name = "btnPreviousNode";
            this.btnPreviousNode.Size = new System.Drawing.Size(100, 23);
            this.btnPreviousNode.TabIndex = 16;
            this.btnPreviousNode.Text = "Previous Node";
            this.btnPreviousNode.UseVisualStyleBackColor = true;
            this.btnPreviousNode.Click += new System.EventHandler(this.btnPreviousNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 740);
            this.Controls.Add(this.btnPreviousNode);
            this.Controls.Add(this.btnNextNode);
            this.Controls.Add(this.txtCurrentNode);
            this.Controls.Add(this.lblCurrentNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfNodes);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnDeleteCurrent);
            this.Controls.Add(this.btnDeleteTail);
            this.Controls.Add(this.btnDeleteHead);
            this.Controls.Add(this.btnInsertAfterCurrent);
            this.Controls.Add(this.btnInsertHead);
            this.Controls.Add(this.btnInsertTail);
            this.Controls.Add(this.btnInsertFirst);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOutput;
        private Label lblOutput;
        private TextBox txtInput;
        private Button btnInsertFirst;
        private Button btnInsertTail;
        private Button btnInsertHead;
        private Button btnInsertAfterCurrent;
        private Button btnDeleteHead;
        private Button btnDeleteTail;
        private Button btnDeleteCurrent;
        private Label lblInput;
        private TextBox txtNumberOfNodes;
        private Label label1;
        private Label lblCurrentNode;
        private TextBox txtCurrentNode;
        private Button btnNextNode;
        private Button btnPreviousNode;
    }
}