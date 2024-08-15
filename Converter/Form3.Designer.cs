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
            components = new System.ComponentModel.Container();
            RegisterNameTextBox = new TextBox();
            RegisterPasswordTextBox = new TextBox();
            RegisterButton = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProviderName = new ErrorProvider(components);
            errorProviderPassword = new ErrorProvider(components);
            ConfirmPasswordTextBox = new TextBox();
            label3 = new Label();
            ShowPasswordcheckBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).BeginInit();
            SuspendLayout();
            // 
            // RegisterNameTextBox
            // 
            RegisterNameTextBox.Location = new Point(332, 120);
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
            RegisterButton.Location = new Point(396, 237);
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
            label1.Location = new Point(222, 123);
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
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            errorProviderPassword.ContainerControl = this;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(332, 178);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(139, 23);
            ConfirmPasswordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 186);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 3;
            label3.Text = "Confirm password";
            // 
            // ShowPasswordcheckBox2
            // 
            ShowPasswordcheckBox2.AutoSize = true;
            ShowPasswordcheckBox2.Location = new Point(477, 182);
            ShowPasswordcheckBox2.Name = "ShowPasswordcheckBox2";
            ShowPasswordcheckBox2.Size = new Size(15, 14);
            ShowPasswordcheckBox2.TabIndex = 5;
            ShowPasswordcheckBox2.UseVisualStyleBackColor = true;
            ShowPasswordcheckBox2.CheckedChanged += ShowPasswordcheckBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(477, 151);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // backButton
            // 
            backButton.Location = new Point(222, 237);
            backButton.Name = "backButton";
            backButton.Size = new Size(124, 23);
            backButton.TabIndex = 7;
            backButton.Text = "Back to login";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(checkBox1);
            Controls.Add(ShowPasswordcheckBox2);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(RegisterPasswordTextBox);
            Controls.Add(RegisterNameTextBox);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegisterNameTextBox;
        private TextBox RegisterPasswordTextBox;
        private Button RegisterButton;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderPassword;
        private CheckBox ShowPasswordcheckBox2;
        private TextBox ConfirmPasswordTextBox;
        private Label label3;
        private CheckBox checkBox1;
        private Button backButton;
    }
}