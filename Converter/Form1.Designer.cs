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
            Input.Items.AddRange(new object[] { "Binary", "Octal", "Decimal", "Hexadecimal" });
            Input.Location = new Point(109, 55);
            Input.Name = "Input";
            Input.Size = new Size(151, 28);
            Input.TabIndex = 0;
            Input.Text = " ";
            // 
            // OutPut
            // 
            OutPut.FormattingEnabled = true;
            OutPut.Items.AddRange(new object[] { "Binary", "Octal", "Decimal", "Hexadecimal" });
            OutPut.Location = new Point(497, 55);
            OutPut.Name = "OutPut";
            OutPut.Size = new Size(151, 28);
            OutPut.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(330, 158);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonCalc;
            // 
            // number
            // 
            number.Location = new Point(298, 107);
            number.Name = "number";
            number.Size = new Size(158, 27);
            number.TabIndex = 4;
            // 
            // resultLable
            // 
            resultLable.AutoSize = true;
            resultLable.Location = new Point(330, 227);
            resultLable.Name = "resultLable";
            resultLable.Size = new Size(63, 20);
            resultLable.TabIndex = 5;
            resultLable.Text = "rnnkvrkv";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLable);
            Controls.Add(number);
            Controls.Add(button1);
            Controls.Add(OutPut);
            Controls.Add(Input);
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
