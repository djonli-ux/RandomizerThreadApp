namespace Randomizer_threads
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
            label1 = new Label();
            label2 = new Label();
            minValue = new TextBox();
            maxValue = new TextBox();
            generateBtn = new Button();
            showNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 180);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Min:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 239);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Max:";
            // 
            // minValue
            // 
            minValue.Location = new Point(75, 173);
            minValue.Name = "minValue";
            minValue.Size = new Size(125, 27);
            minValue.TabIndex = 2;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(75, 232);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(125, 27);
            maxValue.TabIndex = 3;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(414, 230);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(82, 29);
            generateBtn.TabIndex = 4;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // showNumber
            // 
            showNumber.AutoSize = true;
            showNumber.Location = new Point(260, 26);
            showNumber.Name = "showNumber";
            showNumber.Size = new Size(17, 20);
            showNumber.TabIndex = 5;
            showNumber.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 321);
            Controls.Add(showNumber);
            Controls.Add(generateBtn);
            Controls.Add(maxValue);
            Controls.Add(minValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox minValue;
        private TextBox maxValue;
        private Button generateBtn;
        private Label showNumber;
    }
}