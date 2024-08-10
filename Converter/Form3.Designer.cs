namespace Converter
{
    partial class Form3
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
            RegisterNameTextBox = new TextBox();
            RegisterPasswordTextBox = new TextBox();
            RegisterButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // RegisterNameTextBox
            // 
            RegisterNameTextBox.Location = new Point(332, 97);
            RegisterNameTextBox.Name = "RegisterNameTextBox";
            RegisterNameTextBox.Size = new Size(139, 23);
            RegisterNameTextBox.TabIndex = 0;
            // 
            // RegisterPasswordTextBox
            // 
            RegisterPasswordTextBox.Location = new Point(332, 149);
            RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            RegisterPasswordTextBox.Size = new Size(139, 23);
            RegisterPasswordTextBox.TabIndex = 1;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(396, 193);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 97);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 157);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(RegisterPasswordTextBox);
            Controls.Add(RegisterNameTextBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegisterNameTextBox;
        private TextBox RegisterPasswordTextBox;
        private Button RegisterButton;
        private Label label1;
        private Label label2;
    }
}