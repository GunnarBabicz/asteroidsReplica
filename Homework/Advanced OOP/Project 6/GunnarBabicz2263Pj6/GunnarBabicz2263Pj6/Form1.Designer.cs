namespace GunnarBabicz2263Pj6
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
            this.lblStack = new System.Windows.Forms.Label();
            this.lblDequeue = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.txtStackContents = new System.Windows.Forms.TextBox();
            this.txtDequeueContents = new System.Windows.Forms.TextBox();
            this.txtQueueContents = new System.Windows.Forms.TextBox();
            this.lblStackContents = new System.Windows.Forms.Label();
            this.lblDequeueContents = new System.Windows.Forms.Label();
            this.lblQueueContents = new System.Windows.Forms.Label();
            this.lblStackPop = new System.Windows.Forms.Label();
            this.lblDequeuePop = new System.Windows.Forms.Label();
            this.txtStackPop = new System.Windows.Forms.TextBox();
            this.btnStackPushRandom = new System.Windows.Forms.Button();
            this.btnStackPop = new System.Windows.Forms.Button();
            this.btnQueuePop = new System.Windows.Forms.Button();
            this.btnQueuePushRandom = new System.Windows.Forms.Button();
            this.txtQueuePop = new System.Windows.Forms.TextBox();
            this.lblQueuePop = new System.Windows.Forms.Label();
            this.btnDequeuePopLeft = new System.Windows.Forms.Button();
            this.txtDequeuePop = new System.Windows.Forms.TextBox();
            this.btnDequeuePopRight = new System.Windows.Forms.Button();
            this.btnDequeuePushRandomLeft = new System.Windows.Forms.Button();
            this.btnDequeuePushRandomRight = new System.Windows.Forms.Button();
            this.btnClearStack = new System.Windows.Forms.Button();
            this.btnClearDequeue = new System.Windows.Forms.Button();
            this.btnClearQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStack.Location = new System.Drawing.Point(155, 20);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(78, 37);
            this.lblStack.TabIndex = 1;
            this.lblStack.Text = "Stack";
            // 
            // lblDequeue
            // 
            this.lblDequeue.AutoSize = true;
            this.lblDequeue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDequeue.Location = new System.Drawing.Point(629, 20);
            this.lblDequeue.Name = "lblDequeue";
            this.lblDequeue.Size = new System.Drawing.Size(124, 37);
            this.lblDequeue.TabIndex = 2;
            this.lblDequeue.Text = "Dequeue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQueue.Location = new System.Drawing.Point(1151, 20);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(95, 37);
            this.lblQueue.TabIndex = 3;
            this.lblQueue.Text = "Queue";
            // 
            // txtStackContents
            // 
            this.txtStackContents.Location = new System.Drawing.Point(93, 113);
            this.txtStackContents.Name = "txtStackContents";
            this.txtStackContents.Size = new System.Drawing.Size(199, 23);
            this.txtStackContents.TabIndex = 4;
            // 
            // txtDequeueContents
            // 
            this.txtDequeueContents.Location = new System.Drawing.Point(594, 113);
            this.txtDequeueContents.Name = "txtDequeueContents";
            this.txtDequeueContents.Size = new System.Drawing.Size(199, 23);
            this.txtDequeueContents.TabIndex = 5;
            // 
            // txtQueueContents
            // 
            this.txtQueueContents.Location = new System.Drawing.Point(1099, 113);
            this.txtQueueContents.Name = "txtQueueContents";
            this.txtQueueContents.Size = new System.Drawing.Size(199, 23);
            this.txtQueueContents.TabIndex = 6;
            // 
            // lblStackContents
            // 
            this.lblStackContents.AutoSize = true;
            this.lblStackContents.Location = new System.Drawing.Point(147, 77);
            this.lblStackContents.Name = "lblStackContents";
            this.lblStackContents.Size = new System.Drawing.Size(86, 15);
            this.lblStackContents.TabIndex = 7;
            this.lblStackContents.Text = "Stack Contents";
            // 
            // lblDequeueContents
            // 
            this.lblDequeueContents.AutoSize = true;
            this.lblDequeueContents.Location = new System.Drawing.Point(639, 77);
            this.lblDequeueContents.Name = "lblDequeueContents";
            this.lblDequeueContents.Size = new System.Drawing.Size(105, 15);
            this.lblDequeueContents.TabIndex = 8;
            this.lblDequeueContents.Text = "Dequeue Contents";
            // 
            // lblQueueContents
            // 
            this.lblQueueContents.AutoSize = true;
            this.lblQueueContents.Location = new System.Drawing.Point(1153, 77);
            this.lblQueueContents.Name = "lblQueueContents";
            this.lblQueueContents.Size = new System.Drawing.Size(93, 15);
            this.lblQueueContents.TabIndex = 9;
            this.lblQueueContents.Text = "Queue Contents";
            // 
            // lblStackPop
            // 
            this.lblStackPop.AutoSize = true;
            this.lblStackPop.Location = new System.Drawing.Point(93, 171);
            this.lblStackPop.Name = "lblStackPop";
            this.lblStackPop.Size = new System.Drawing.Size(106, 15);
            this.lblStackPop.TabIndex = 10;
            this.lblStackPop.Text = "Last Popped Value:";
            // 
            // lblDequeuePop
            // 
            this.lblDequeuePop.AutoSize = true;
            this.lblDequeuePop.Location = new System.Drawing.Point(582, 192);
            this.lblDequeuePop.Name = "lblDequeuePop";
            this.lblDequeuePop.Size = new System.Drawing.Size(106, 15);
            this.lblDequeuePop.TabIndex = 11;
            this.lblDequeuePop.Text = "Last Popped Value:";
            // 
            // txtStackPop
            // 
            this.txtStackPop.Location = new System.Drawing.Point(205, 168);
            this.txtStackPop.Name = "txtStackPop";
            this.txtStackPop.Size = new System.Drawing.Size(54, 23);
            this.txtStackPop.TabIndex = 15;
            // 
            // btnStackPushRandom
            // 
            this.btnStackPushRandom.Location = new System.Drawing.Point(131, 216);
            this.btnStackPushRandom.Name = "btnStackPushRandom";
            this.btnStackPushRandom.Size = new System.Drawing.Size(128, 23);
            this.btnStackPushRandom.TabIndex = 16;
            this.btnStackPushRandom.Text = "Push a random value";
            this.btnStackPushRandom.UseVisualStyleBackColor = true;
            this.btnStackPushRandom.Click += new System.EventHandler(this.btnStackPushRandom_Click);
            // 
            // btnStackPop
            // 
            this.btnStackPop.Location = new System.Drawing.Point(265, 167);
            this.btnStackPop.Name = "btnStackPop";
            this.btnStackPop.Size = new System.Drawing.Size(36, 23);
            this.btnStackPop.TabIndex = 17;
            this.btnStackPop.Text = "Pop";
            this.btnStackPop.UseVisualStyleBackColor = true;
            this.btnStackPop.Click += new System.EventHandler(this.btnStackPop_Click);
            // 
            // btnQueuePop
            // 
            this.btnQueuePop.Location = new System.Drawing.Point(1271, 188);
            this.btnQueuePop.Name = "btnQueuePop";
            this.btnQueuePop.Size = new System.Drawing.Size(36, 23);
            this.btnQueuePop.TabIndex = 24;
            this.btnQueuePop.Text = "Pop";
            this.btnQueuePop.UseVisualStyleBackColor = true;
            this.btnQueuePop.Click += new System.EventHandler(this.btnQueuePop_Click);
            // 
            // btnQueuePushRandom
            // 
            this.btnQueuePushRandom.Location = new System.Drawing.Point(1135, 234);
            this.btnQueuePushRandom.Name = "btnQueuePushRandom";
            this.btnQueuePushRandom.Size = new System.Drawing.Size(130, 23);
            this.btnQueuePushRandom.TabIndex = 23;
            this.btnQueuePushRandom.Text = "Push a random value";
            this.btnQueuePushRandom.UseVisualStyleBackColor = true;
            this.btnQueuePushRandom.Click += new System.EventHandler(this.btnQueuePushRandom_Click);
            // 
            // txtQueuePop
            // 
            this.txtQueuePop.Location = new System.Drawing.Point(1211, 189);
            this.txtQueuePop.Name = "txtQueuePop";
            this.txtQueuePop.Size = new System.Drawing.Size(54, 23);
            this.txtQueuePop.TabIndex = 22;
            // 
            // lblQueuePop
            // 
            this.lblQueuePop.AutoSize = true;
            this.lblQueuePop.Location = new System.Drawing.Point(1099, 192);
            this.lblQueuePop.Name = "lblQueuePop";
            this.lblQueuePop.Size = new System.Drawing.Size(106, 15);
            this.lblQueuePop.TabIndex = 19;
            this.lblQueuePop.Text = "Last Popped Value:";
            // 
            // btnDequeuePopLeft
            // 
            this.btnDequeuePopLeft.Location = new System.Drawing.Point(594, 153);
            this.btnDequeuePopLeft.Name = "btnDequeuePopLeft";
            this.btnDequeuePopLeft.Size = new System.Drawing.Size(71, 30);
            this.btnDequeuePopLeft.TabIndex = 26;
            this.btnDequeuePopLeft.Text = "Pop Left";
            this.btnDequeuePopLeft.UseVisualStyleBackColor = true;
            this.btnDequeuePopLeft.Click += new System.EventHandler(this.btnDequeuePopLeft_Click);
            // 
            // txtDequeuePop
            // 
            this.txtDequeuePop.Location = new System.Drawing.Point(694, 189);
            this.txtDequeuePop.Name = "txtDequeuePop";
            this.txtDequeuePop.Size = new System.Drawing.Size(54, 23);
            this.txtDequeuePop.TabIndex = 25;
            // 
            // btnDequeuePopRight
            // 
            this.btnDequeuePopRight.Location = new System.Drawing.Point(722, 153);
            this.btnDequeuePopRight.Name = "btnDequeuePopRight";
            this.btnDequeuePopRight.Size = new System.Drawing.Size(71, 30);
            this.btnDequeuePopRight.TabIndex = 27;
            this.btnDequeuePopRight.Text = "Pop Right";
            this.btnDequeuePopRight.UseVisualStyleBackColor = true;
            this.btnDequeuePopRight.Click += new System.EventHandler(this.btnDequeuePopRight_Click);
            // 
            // btnDequeuePushRandomLeft
            // 
            this.btnDequeuePushRandomLeft.Location = new System.Drawing.Point(541, 234);
            this.btnDequeuePushRandomLeft.Name = "btnDequeuePushRandomLeft";
            this.btnDequeuePushRandomLeft.Size = new System.Drawing.Size(147, 23);
            this.btnDequeuePushRandomLeft.TabIndex = 31;
            this.btnDequeuePushRandomLeft.Text = "Push random value left";
            this.btnDequeuePushRandomLeft.UseVisualStyleBackColor = true;
            this.btnDequeuePushRandomLeft.Click += new System.EventHandler(this.btnDequeuePushRandomLeft_Click);
            // 
            // btnDequeuePushRandomRight
            // 
            this.btnDequeuePushRandomRight.Location = new System.Drawing.Point(694, 234);
            this.btnDequeuePushRandomRight.Name = "btnDequeuePushRandomRight";
            this.btnDequeuePushRandomRight.Size = new System.Drawing.Size(147, 23);
            this.btnDequeuePushRandomRight.TabIndex = 33;
            this.btnDequeuePushRandomRight.Text = "Push random value right";
            this.btnDequeuePushRandomRight.UseVisualStyleBackColor = true;
            this.btnDequeuePushRandomRight.Click += new System.EventHandler(this.btnDequeuePushRandomRight_Click);
            // 
            // btnClearStack
            // 
            this.btnClearStack.Location = new System.Drawing.Point(131, 245);
            this.btnClearStack.Name = "btnClearStack";
            this.btnClearStack.Size = new System.Drawing.Size(128, 23);
            this.btnClearStack.TabIndex = 34;
            this.btnClearStack.Text = "Clear Stack";
            this.btnClearStack.UseVisualStyleBackColor = true;
            this.btnClearStack.Click += new System.EventHandler(this.btnClearStack_Click);
            // 
            // btnClearDequeue
            // 
            this.btnClearDequeue.Location = new System.Drawing.Point(652, 278);
            this.btnClearDequeue.Name = "btnClearDequeue";
            this.btnClearDequeue.Size = new System.Drawing.Size(92, 23);
            this.btnClearDequeue.TabIndex = 35;
            this.btnClearDequeue.Text = "Clear Dequeue";
            this.btnClearDequeue.UseVisualStyleBackColor = true;
            this.btnClearDequeue.Click += new System.EventHandler(this.btnClearDequeue_Click);
            // 
            // btnClearQueue
            // 
            this.btnClearQueue.Location = new System.Drawing.Point(1161, 278);
            this.btnClearQueue.Name = "btnClearQueue";
            this.btnClearQueue.Size = new System.Drawing.Size(85, 23);
            this.btnClearQueue.TabIndex = 36;
            this.btnClearQueue.Text = "Clear Queue";
            this.btnClearQueue.UseVisualStyleBackColor = true;
            this.btnClearQueue.Click += new System.EventHandler(this.btnClearQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 884);
            this.Controls.Add(this.btnClearQueue);
            this.Controls.Add(this.btnClearDequeue);
            this.Controls.Add(this.btnClearStack);
            this.Controls.Add(this.btnDequeuePushRandomRight);
            this.Controls.Add(this.btnDequeuePushRandomLeft);
            this.Controls.Add(this.btnDequeuePopRight);
            this.Controls.Add(this.btnDequeuePopLeft);
            this.Controls.Add(this.txtDequeuePop);
            this.Controls.Add(this.btnQueuePop);
            this.Controls.Add(this.btnQueuePushRandom);
            this.Controls.Add(this.txtQueuePop);
            this.Controls.Add(this.lblQueuePop);
            this.Controls.Add(this.btnStackPop);
            this.Controls.Add(this.btnStackPushRandom);
            this.Controls.Add(this.txtStackPop);
            this.Controls.Add(this.lblDequeuePop);
            this.Controls.Add(this.lblStackPop);
            this.Controls.Add(this.lblQueueContents);
            this.Controls.Add(this.lblDequeueContents);
            this.Controls.Add(this.lblStackContents);
            this.Controls.Add(this.txtQueueContents);
            this.Controls.Add(this.txtDequeueContents);
            this.Controls.Add(this.txtStackContents);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblDequeue);
            this.Controls.Add(this.lblStack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblStack;
        private Label lblDequeue;
        private Label lblQueue;
        private TextBox txtStackContents;
        private TextBox txtDequeueContents;
        private TextBox txtQueueContents;
        private Label lblStackContents;
        private Label lblDequeueContents;
        private Label lblQueueContents;
        private Label lblStackPop;
        private Label lblDequeuePop;
        private TextBox txtStackPop;
        private Button btnStackPushRandom;
        private Button btnStackPop;
        private Button btnQueuePop;
        private Button btnQueuePushRandom;
        private TextBox txtQueuePop;
        private Label lblQueuePop;
        private Button btnDequeuePopLeft;
        private TextBox txtDequeuePop;
        private Button btnDequeuePopRight;
        private Button btnDequeuePushRandomLeft;
        private Button btnDequeuePushRandomRight;
        private Button btnClearStack;
        private Button btnClearDequeue;
        private Button btnClearQueue;
    }
}