namespace Converter
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
            Input = new ComboBox();
            OutPut = new ComboBox();
            button1 = new Button();
            number = new TextBox();
            resultLable = new Label();
            SuspendLayout();
            // 
            // Input
            // 
            Input.FormattingEnabled = true;
            Input.Items.AddRange(new object[] { "Binary", "Octal", "Decimal", "Hexadecimal", "2sComplement" });
            Input.Location = new Point(95, 41);
            Input.Margin = new Padding(3, 2, 3, 2);
            Input.Name = "Input";
            Input.Size = new Size(133, 23);
            Input.TabIndex = 0;
            Input.Text = " ";
            // 
            // OutPut
            // 
            OutPut.FormattingEnabled = true;
            OutPut.Items.AddRange(new object[] { "Binary", "Octal", "Decimal", "Hexadecimal", "2sComplement" });
            OutPut.Location = new Point(435, 41);
            OutPut.Margin = new Padding(3, 2, 3, 2);
            OutPut.Name = "OutPut";
            OutPut.Size = new Size(133, 23);
            OutPut.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(289, 118);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonCalc;
            // 
            // number
            // 
            number.Location = new Point(261, 80);
            number.Margin = new Padding(3, 2, 3, 2);
            number.Name = "number";
            number.Size = new Size(139, 23);
            number.TabIndex = 4;
            // 
            // resultLable
            // 
            resultLable.AutoSize = true;
            resultLable.Location = new Point(289, 170);
            resultLable.Name = "resultLable";
            resultLable.Size = new Size(36, 15);
            resultLable.TabIndex = 5;
            resultLable.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(resultLable);
            Controls.Add(number);
            Controls.Add(button1);
            Controls.Add(OutPut);
            Controls.Add(Input);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Input;
        private ComboBox OutPut;
      
        private Button button1;
        private TextBox number;
        private Label resultLable;
    }
}
