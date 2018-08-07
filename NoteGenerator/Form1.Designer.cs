namespace NoteGenerator
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
            this.question = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.reverseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstString = new System.Windows.Forms.RadioButton();
            this.secondString = new System.Windows.Forms.RadioButton();
            this.thirdString = new System.Windows.Forms.RadioButton();
            this.fifthString = new System.Windows.Forms.RadioButton();
            this.fourthString = new System.Windows.Forms.RadioButton();
            this.sixthString = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(32, 49);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(226, 113);
            this.question.TabIndex = 0;
            this.question.Text = "Fret";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(386, 49);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(260, 113);
            this.answer.TabIndex = 1;
            this.answer.Text = "Note";
            // 
            // reverseButton
            // 
            this.reverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseButton.Location = new System.Drawing.Point(508, 404);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(196, 114);
            this.reverseButton.TabIndex = 2;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstString);
            this.groupBox1.Controls.Add(this.secondString);
            this.groupBox1.Controls.Add(this.thirdString);
            this.groupBox1.Controls.Add(this.fifthString);
            this.groupBox1.Controls.Add(this.fourthString);
            this.groupBox1.Controls.Add(this.sixthString);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String Select";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstString
            // 
            this.firstString.AutoSize = true;
            this.firstString.Location = new System.Drawing.Point(531, 63);
            this.firstString.Name = "firstString";
            this.firstString.Size = new System.Drawing.Size(58, 40);
            this.firstString.TabIndex = 5;
            this.firstString.TabStop = true;
            this.firstString.Text = "1";
            this.firstString.UseVisualStyleBackColor = true;
            // 
            // secondString
            // 
            this.secondString.AutoSize = true;
            this.secondString.Location = new System.Drawing.Point(416, 63);
            this.secondString.Name = "secondString";
            this.secondString.Size = new System.Drawing.Size(58, 40);
            this.secondString.TabIndex = 4;
            this.secondString.TabStop = true;
            this.secondString.Text = "2";
            this.secondString.UseVisualStyleBackColor = true;
            // 
            // thirdString
            // 
            this.thirdString.AutoSize = true;
            this.thirdString.Location = new System.Drawing.Point(309, 63);
            this.thirdString.Name = "thirdString";
            this.thirdString.Size = new System.Drawing.Size(58, 40);
            this.thirdString.TabIndex = 3;
            this.thirdString.TabStop = true;
            this.thirdString.Text = "3";
            this.thirdString.UseVisualStyleBackColor = true;
            // 
            // fifthString
            // 
            this.fifthString.AutoSize = true;
            this.fifthString.Location = new System.Drawing.Point(102, 63);
            this.fifthString.Name = "fifthString";
            this.fifthString.Size = new System.Drawing.Size(58, 40);
            this.fifthString.TabIndex = 2;
            this.fifthString.TabStop = true;
            this.fifthString.Text = "5";
            this.fifthString.UseVisualStyleBackColor = true;
            // 
            // fourthString
            // 
            this.fourthString.AutoSize = true;
            this.fourthString.Location = new System.Drawing.Point(206, 63);
            this.fourthString.Name = "fourthString";
            this.fourthString.Size = new System.Drawing.Size(58, 40);
            this.fourthString.TabIndex = 1;
            this.fourthString.TabStop = true;
            this.fourthString.Text = "4";
            this.fourthString.UseVisualStyleBackColor = true;
            // 
            // sixthString
            // 
            this.sixthString.AutoSize = true;
            this.sixthString.Location = new System.Drawing.Point(6, 63);
            this.sixthString.Name = "sixthString";
            this.sixthString.Size = new System.Drawing.Size(58, 40);
            this.sixthString.TabIndex = 0;
            this.sixthString.TabStop = true;
            this.sixthString.Text = "6";
            this.sixthString.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(51, 326);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(164, 26);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guess Time (seconds)";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(51, 404);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(196, 114);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(281, 404);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(196, 114);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 581);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.question);
            this.Name = "Form1";
            this.Text = "Freatboard Guessing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton firstString;
        private System.Windows.Forms.RadioButton secondString;
        private System.Windows.Forms.RadioButton thirdString;
        private System.Windows.Forms.RadioButton fifthString;
        private System.Windows.Forms.RadioButton fourthString;
        private System.Windows.Forms.RadioButton sixthString;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
    }
}

