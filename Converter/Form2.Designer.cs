namespace Converter
{
    partial class Form2
    {


        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loginButton = new Button();
            UserNameTextBox = new TextBox();
            PasswordtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RegButton = new Button();
            errorProviderUserName = new ErrorProvider(components);
            errorProviderPassword = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(403, 258);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(267, 149);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(211, 23);
            UserNameTextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(267, 209);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(211, 23);
            PasswordtextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 149);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 217);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // RegButton
            // 
            RegButton.Location = new Point(267, 258);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(75, 23);
            RegButton.TabIndex = 5;
            RegButton.Text = "Register";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // errorProviderUserName
            // 
            errorProviderUserName.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            errorProviderPassword.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordtextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(loginButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox UserNameTextBox;
        private TextBox PasswordtextBox;
        private Label label1;
        private Label label2;
        private Button RegButton;
        private System.ComponentModel.IContainer components;
        private ErrorProvider errorProviderUserName;
        private ErrorProvider errorProviderPassword;
    }
}