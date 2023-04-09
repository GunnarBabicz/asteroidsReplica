namespace GunnarBabicz2263Pj7
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
            this.lblTesting = new System.Windows.Forms.Label();
            this.lblChooseAlgorithm = new System.Windows.Forms.Label();
            this.btnTestRQuickSort = new System.Windows.Forms.Button();
            this.btnTestNRQuickSort = new System.Windows.Forms.Button();
            this.btnTestBubbleSort = new System.Windows.Forms.Button();
            this.btnTestIndexedQuickSort = new System.Windows.Forms.Button();
            this.txtUnsortedRandom1 = new System.Windows.Forms.TextBox();
            this.lblUnsortedTestArrays = new System.Windows.Forms.Label();
            this.txtSortedRandom1 = new System.Windows.Forms.TextBox();
            this.lblSortedArrays = new System.Windows.Forms.Label();
            this.txtUnsortedRandom2 = new System.Windows.Forms.TextBox();
            this.txtSortedRandom2 = new System.Windows.Forms.TextBox();
            this.lblTestSortingSpeed = new System.Windows.Forms.Label();
            this.lblSpeedRQuickSort = new System.Windows.Forms.Label();
            this.lblArrayLength = new System.Windows.Forms.Label();
            this.txtArrayLength = new System.Windows.Forms.TextBox();
            this.txtRecursiveQuickSortSpeed = new System.Windows.Forms.TextBox();
            this.txtNonRecursiveQuickSortSpeed = new System.Windows.Forms.TextBox();
            this.lblNonRecursiveQuickSortSpeed = new System.Windows.Forms.Label();
            this.txtBubbleSortSpeed = new System.Windows.Forms.TextBox();
            this.lblBubbleSortSpeed = new System.Windows.Forms.Label();
            this.btnRunSpeedTest = new System.Windows.Forms.Button();
            this.btnRunMonkeySim = new System.Windows.Forms.Button();
            this.txtMonkeySimGuessesCorrect = new System.Windows.Forms.TextBox();
            this.txtMonkeySimTimeElapsed = new System.Windows.Forms.TextBox();
            this.lblMonkeySimChooseMinutes = new System.Windows.Forms.Label();
            this.txtMonkeySimMinutes = new System.Windows.Forms.TextBox();
            this.lblMonkeySimTitle = new System.Windows.Forms.Label();
            this.lblMonkeySimCharsCorrect = new System.Windows.Forms.Label();
            this.lblMonkeySimTimeElapsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTesting
            // 
            this.lblTesting.AutoSize = true;
            this.lblTesting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTesting.Location = new System.Drawing.Point(240, 36);
            this.lblTesting.Name = "lblTesting";
            this.lblTesting.Size = new System.Drawing.Size(218, 21);
            this.lblTesting.TabIndex = 0;
            this.lblTesting.Text = "Testing for Sorting Algorithms";
            // 
            // lblChooseAlgorithm
            // 
            this.lblChooseAlgorithm.Location = new System.Drawing.Point(139, 72);
            this.lblChooseAlgorithm.Name = "lblChooseAlgorithm";
            this.lblChooseAlgorithm.Size = new System.Drawing.Size(398, 34);
            this.lblChooseAlgorithm.TabIndex = 1;
            this.lblChooseAlgorithm.Text = "Choose an algorithm to test. On each button press, two random arrays will be gene" +
    "rated to sort. An array of length 0 may also be included.\r\n\r\n";
            this.lblChooseAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTestRQuickSort
            // 
            this.btnTestRQuickSort.Location = new System.Drawing.Point(139, 109);
            this.btnTestRQuickSort.Name = "btnTestRQuickSort";
            this.btnTestRQuickSort.Size = new System.Drawing.Size(95, 43);
            this.btnTestRQuickSort.TabIndex = 2;
            this.btnTestRQuickSort.Text = "Recursive Quick Sort";
            this.btnTestRQuickSort.UseVisualStyleBackColor = true;
            this.btnTestRQuickSort.Click += new System.EventHandler(this.btnTestRQuickSort_Click);
            // 
            // btnTestNRQuickSort
            // 
            this.btnTestNRQuickSort.Location = new System.Drawing.Point(442, 109);
            this.btnTestNRQuickSort.Name = "btnTestNRQuickSort";
            this.btnTestNRQuickSort.Size = new System.Drawing.Size(95, 43);
            this.btnTestNRQuickSort.TabIndex = 3;
            this.btnTestNRQuickSort.Text = "Non Recursive Quick Sort";
            this.btnTestNRQuickSort.UseVisualStyleBackColor = true;
            this.btnTestNRQuickSort.Click += new System.EventHandler(this.btnTestNRQuickSort_Click);
            // 
            // btnTestBubbleSort
            // 
            this.btnTestBubbleSort.Location = new System.Drawing.Point(240, 109);
            this.btnTestBubbleSort.Name = "btnTestBubbleSort";
            this.btnTestBubbleSort.Size = new System.Drawing.Size(95, 43);
            this.btnTestBubbleSort.TabIndex = 4;
            this.btnTestBubbleSort.Text = "Bubble Sort";
            this.btnTestBubbleSort.UseVisualStyleBackColor = true;
            this.btnTestBubbleSort.Click += new System.EventHandler(this.btnTestBubbleSort_Click);
            // 
            // btnTestIndexedQuickSort
            // 
            this.btnTestIndexedQuickSort.Location = new System.Drawing.Point(341, 109);
            this.btnTestIndexedQuickSort.Name = "btnTestIndexedQuickSort";
            this.btnTestIndexedQuickSort.Size = new System.Drawing.Size(95, 43);
            this.btnTestIndexedQuickSort.TabIndex = 5;
            this.btnTestIndexedQuickSort.Text = "Indexed Quick Sort";
            this.btnTestIndexedQuickSort.UseVisualStyleBackColor = true;
            this.btnTestIndexedQuickSort.Click += new System.EventHandler(this.btnTestIndexedQuickSort_Click);
            // 
            // txtUnsortedRandom1
            // 
            this.txtUnsortedRandom1.Location = new System.Drawing.Point(139, 197);
            this.txtUnsortedRandom1.Name = "txtUnsortedRandom1";
            this.txtUnsortedRandom1.Size = new System.Drawing.Size(196, 23);
            this.txtUnsortedRandom1.TabIndex = 6;
            // 
            // lblUnsortedTestArrays
            // 
            this.lblUnsortedTestArrays.Location = new System.Drawing.Point(139, 166);
            this.lblUnsortedTestArrays.Name = "lblUnsortedTestArrays";
            this.lblUnsortedTestArrays.Size = new System.Drawing.Size(196, 15);
            this.lblUnsortedTestArrays.TabIndex = 7;
            this.lblUnsortedTestArrays.Text = "Unsorted Arrays";
            this.lblUnsortedTestArrays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSortedRandom1
            // 
            this.txtSortedRandom1.Location = new System.Drawing.Point(341, 197);
            this.txtSortedRandom1.Name = "txtSortedRandom1";
            this.txtSortedRandom1.Size = new System.Drawing.Size(196, 23);
            this.txtSortedRandom1.TabIndex = 8;
            // 
            // lblSortedArrays
            // 
            this.lblSortedArrays.Location = new System.Drawing.Point(341, 166);
            this.lblSortedArrays.Name = "lblSortedArrays";
            this.lblSortedArrays.Size = new System.Drawing.Size(196, 15);
            this.lblSortedArrays.TabIndex = 9;
            this.lblSortedArrays.Text = "Sorted Arrays";
            this.lblSortedArrays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnsortedRandom2
            // 
            this.txtUnsortedRandom2.Location = new System.Drawing.Point(139, 235);
            this.txtUnsortedRandom2.Name = "txtUnsortedRandom2";
            this.txtUnsortedRandom2.Size = new System.Drawing.Size(196, 23);
            this.txtUnsortedRandom2.TabIndex = 10;
            // 
            // txtSortedRandom2
            // 
            this.txtSortedRandom2.Location = new System.Drawing.Point(341, 235);
            this.txtSortedRandom2.Name = "txtSortedRandom2";
            this.txtSortedRandom2.Size = new System.Drawing.Size(196, 23);
            this.txtSortedRandom2.TabIndex = 11;
            // 
            // lblTestSortingSpeed
            // 
            this.lblTestSortingSpeed.AutoSize = true;
            this.lblTestSortingSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTestSortingSpeed.Location = new System.Drawing.Point(216, 301);
            this.lblTestSortingSpeed.Name = "lblTestSortingSpeed";
            this.lblTestSortingSpeed.Size = new System.Drawing.Size(275, 21);
            this.lblTestSortingSpeed.TabIndex = 12;
            this.lblTestSortingSpeed.Text = "Comparing speed between algorithms";
            // 
            // lblSpeedRQuickSort
            // 
            this.lblSpeedRQuickSort.AutoSize = true;
            this.lblSpeedRQuickSort.Location = new System.Drawing.Point(133, 386);
            this.lblSpeedRQuickSort.Name = "lblSpeedRQuickSort";
            this.lblSpeedRQuickSort.Size = new System.Drawing.Size(115, 15);
            this.lblSpeedRQuickSort.TabIndex = 13;
            this.lblSpeedRQuickSort.Text = "Recursive Quick Sort";
            // 
            // lblArrayLength
            // 
            this.lblArrayLength.AutoSize = true;
            this.lblArrayLength.Location = new System.Drawing.Point(161, 350);
            this.lblArrayLength.Name = "lblArrayLength";
            this.lblArrayLength.Size = new System.Drawing.Size(153, 15);
            this.lblArrayLength.TabIndex = 14;
            this.lblArrayLength.Text = "Enter length of array to test:";
            // 
            // txtArrayLength
            // 
            this.txtArrayLength.Location = new System.Drawing.Point(320, 347);
            this.txtArrayLength.Name = "txtArrayLength";
            this.txtArrayLength.Size = new System.Drawing.Size(85, 23);
            this.txtArrayLength.TabIndex = 16;
            // 
            // txtRecursiveQuickSortSpeed
            // 
            this.txtRecursiveQuickSortSpeed.Location = new System.Drawing.Point(140, 404);
            this.txtRecursiveQuickSortSpeed.Name = "txtRecursiveQuickSortSpeed";
            this.txtRecursiveQuickSortSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtRecursiveQuickSortSpeed.TabIndex = 17;
            // 
            // txtNonRecursiveQuickSortSpeed
            // 
            this.txtNonRecursiveQuickSortSpeed.Location = new System.Drawing.Point(284, 404);
            this.txtNonRecursiveQuickSortSpeed.Name = "txtNonRecursiveQuickSortSpeed";
            this.txtNonRecursiveQuickSortSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtNonRecursiveQuickSortSpeed.TabIndex = 19;
            // 
            // lblNonRecursiveQuickSortSpeed
            // 
            this.lblNonRecursiveQuickSortSpeed.AutoSize = true;
            this.lblNonRecursiveQuickSortSpeed.Location = new System.Drawing.Point(264, 386);
            this.lblNonRecursiveQuickSortSpeed.Name = "lblNonRecursiveQuickSortSpeed";
            this.lblNonRecursiveQuickSortSpeed.Size = new System.Drawing.Size(141, 15);
            this.lblNonRecursiveQuickSortSpeed.TabIndex = 18;
            this.lblNonRecursiveQuickSortSpeed.Text = "Non Recursive Quick Sort";
            // 
            // txtBubbleSortSpeed
            // 
            this.txtBubbleSortSpeed.Location = new System.Drawing.Point(423, 404);
            this.txtBubbleSortSpeed.Name = "txtBubbleSortSpeed";
            this.txtBubbleSortSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtBubbleSortSpeed.TabIndex = 21;
            // 
            // lblBubbleSortSpeed
            // 
            this.lblBubbleSortSpeed.AutoSize = true;
            this.lblBubbleSortSpeed.Location = new System.Drawing.Point(440, 386);
            this.lblBubbleSortSpeed.Name = "lblBubbleSortSpeed";
            this.lblBubbleSortSpeed.Size = new System.Drawing.Size(68, 15);
            this.lblBubbleSortSpeed.TabIndex = 20;
            this.lblBubbleSortSpeed.Text = "Bubble Sort";
            // 
            // btnRunSpeedTest
            // 
            this.btnRunSpeedTest.BackColor = System.Drawing.SystemColors.Control;
            this.btnRunSpeedTest.Location = new System.Drawing.Point(423, 346);
            this.btnRunSpeedTest.Name = "btnRunSpeedTest";
            this.btnRunSpeedTest.Size = new System.Drawing.Size(100, 23);
            this.btnRunSpeedTest.TabIndex = 28;
            this.btnRunSpeedTest.Text = "Run Speed Test";
            this.btnRunSpeedTest.UseVisualStyleBackColor = false;
            this.btnRunSpeedTest.Click += new System.EventHandler(this.btnRunSpeedTest_Click);
            // 
            // btnRunMonkeySim
            // 
            this.btnRunMonkeySim.Location = new System.Drawing.Point(320, 671);
            this.btnRunMonkeySim.Name = "btnRunMonkeySim";
            this.btnRunMonkeySim.Size = new System.Drawing.Size(114, 23);
            this.btnRunMonkeySim.TabIndex = 29;
            this.btnRunMonkeySim.Text = "Run Monkey Sim";
            this.btnRunMonkeySim.UseVisualStyleBackColor = true;
            this.btnRunMonkeySim.Click += new System.EventHandler(this.btnRunMonkeySim_Click);
            // 
            // txtMonkeySimGuessesCorrect
            // 
            this.txtMonkeySimGuessesCorrect.Location = new System.Drawing.Point(341, 700);
            this.txtMonkeySimGuessesCorrect.Name = "txtMonkeySimGuessesCorrect";
            this.txtMonkeySimGuessesCorrect.Size = new System.Drawing.Size(150, 23);
            this.txtMonkeySimGuessesCorrect.TabIndex = 30;
            // 
            // txtMonkeySimTimeElapsed
            // 
            this.txtMonkeySimTimeElapsed.Location = new System.Drawing.Point(341, 729);
            this.txtMonkeySimTimeElapsed.Name = "txtMonkeySimTimeElapsed";
            this.txtMonkeySimTimeElapsed.Size = new System.Drawing.Size(150, 23);
            this.txtMonkeySimTimeElapsed.TabIndex = 31;
            // 
            // lblMonkeySimChooseMinutes
            // 
            this.lblMonkeySimChooseMinutes.Location = new System.Drawing.Point(141, 616);
            this.lblMonkeySimChooseMinutes.Name = "lblMonkeySimChooseMinutes";
            this.lblMonkeySimChooseMinutes.Size = new System.Drawing.Size(295, 36);
            this.lblMonkeySimChooseMinutes.TabIndex = 32;
            this.lblMonkeySimChooseMinutes.Text = "Enter the amount of minutes you would like the monkeys to try a 64 character sect" +
    "ion of Shakespeare:";
            // 
            // txtMonkeySimMinutes
            // 
            this.txtMonkeySimMinutes.Location = new System.Drawing.Point(439, 629);
            this.txtMonkeySimMinutes.Name = "txtMonkeySimMinutes";
            this.txtMonkeySimMinutes.Size = new System.Drawing.Size(46, 23);
            this.txtMonkeySimMinutes.TabIndex = 33;
            // 
            // lblMonkeySimTitle
            // 
            this.lblMonkeySimTitle.AutoSize = true;
            this.lblMonkeySimTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonkeySimTitle.Location = new System.Drawing.Point(264, 570);
            this.lblMonkeySimTitle.Name = "lblMonkeySimTitle";
            this.lblMonkeySimTitle.Size = new System.Drawing.Size(221, 21);
            this.lblMonkeySimTitle.TabIndex = 34;
            this.lblMonkeySimTitle.Text = "Monkeys Writing Shakespeare";
            // 
            // lblMonkeySimCharsCorrect
            // 
            this.lblMonkeySimCharsCorrect.AutoSize = true;
            this.lblMonkeySimCharsCorrect.Location = new System.Drawing.Point(161, 703);
            this.lblMonkeySimCharsCorrect.Name = "lblMonkeySimCharsCorrect";
            this.lblMonkeySimCharsCorrect.Size = new System.Drawing.Size(165, 15);
            this.lblMonkeySimCharsCorrect.TabIndex = 35;
            this.lblMonkeySimCharsCorrect.Text = "Amount of characters correct:";
            // 
            // lblMonkeySimTimeElapsed
            // 
            this.lblMonkeySimTimeElapsed.AutoSize = true;
            this.lblMonkeySimTimeElapsed.Location = new System.Drawing.Point(247, 732);
            this.lblMonkeySimTimeElapsed.Name = "lblMonkeySimTimeElapsed";
            this.lblMonkeySimTimeElapsed.Size = new System.Drawing.Size(79, 15);
            this.lblMonkeySimTimeElapsed.TabIndex = 36;
            this.lblMonkeySimTimeElapsed.Text = "Time Elapsed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 962);
            this.Controls.Add(this.lblMonkeySimTimeElapsed);
            this.Controls.Add(this.lblMonkeySimCharsCorrect);
            this.Controls.Add(this.lblMonkeySimTitle);
            this.Controls.Add(this.txtMonkeySimMinutes);
            this.Controls.Add(this.lblMonkeySimChooseMinutes);
            this.Controls.Add(this.txtMonkeySimTimeElapsed);
            this.Controls.Add(this.txtMonkeySimGuessesCorrect);
            this.Controls.Add(this.btnRunMonkeySim);
            this.Controls.Add(this.btnRunSpeedTest);
            this.Controls.Add(this.txtBubbleSortSpeed);
            this.Controls.Add(this.lblBubbleSortSpeed);
            this.Controls.Add(this.txtNonRecursiveQuickSortSpeed);
            this.Controls.Add(this.lblNonRecursiveQuickSortSpeed);
            this.Controls.Add(this.txtRecursiveQuickSortSpeed);
            this.Controls.Add(this.txtArrayLength);
            this.Controls.Add(this.lblArrayLength);
            this.Controls.Add(this.lblSpeedRQuickSort);
            this.Controls.Add(this.lblTestSortingSpeed);
            this.Controls.Add(this.txtSortedRandom2);
            this.Controls.Add(this.txtUnsortedRandom2);
            this.Controls.Add(this.lblSortedArrays);
            this.Controls.Add(this.txtSortedRandom1);
            this.Controls.Add(this.lblUnsortedTestArrays);
            this.Controls.Add(this.txtUnsortedRandom1);
            this.Controls.Add(this.btnTestIndexedQuickSort);
            this.Controls.Add(this.btnTestBubbleSort);
            this.Controls.Add(this.btnTestNRQuickSort);
            this.Controls.Add(this.btnTestRQuickSort);
            this.Controls.Add(this.lblChooseAlgorithm);
            this.Controls.Add(this.lblTesting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTesting;
        private Label lblChooseAlgorithm;
        private Button btnTestRQuickSort;
        private Button btnTestNRQuickSort;
        private Button btnTestBubbleSort;
        private Button btnTestIndexedQuickSort;
        private TextBox txtUnsortedRandom1;
        private Label lblUnsortedTestArrays;
        private TextBox txtSortedRandom1;
        private Label lblSortedArrays;
        private TextBox txtUnsortedRandom2;
        private TextBox txtSortedRandom2;
        private Label lblTestSortingSpeed;
        private Label lblSpeedRQuickSort;
        private Label lblArrayLength;
        private TextBox txtArrayLength;
        private TextBox txtRecursiveQuickSortSpeed;
        private TextBox txtNonRecursiveQuickSortSpeed;
        private Label lblNonRecursiveQuickSortSpeed;
        private TextBox txtBubbleSortSpeed;
        private Label lblBubbleSortSpeed;
        private Button btnRunSpeedTest;
        private Button btnRunMonkeySim;
        private TextBox txtMonkeySimGuessesCorrect;
        private TextBox txtMonkeySimTimeElapsed;
        private Label lblMonkeySimChooseMinutes;
        private TextBox txtMonkeySimMinutes;
        private Label lblMonkeySimTitle;
        private Label lblMonkeySimCharsCorrect;
        private Label lblMonkeySimTimeElapsed;
    }
}