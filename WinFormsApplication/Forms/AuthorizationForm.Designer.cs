namespace WinFormsApplication.Forms
{
    partial class AuthorizationForm
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
            loginLabel = new Label();
            loginTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            errorLabel = new Label();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 39);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 57);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(343, 23);
            loginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(343, 21);
            label2.TabIndex = 2;
            label2.Text = "Вход в терминал услуг сплит-систем";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 108);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(343, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 90);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(12, 201);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(343, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.MistyRose;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(97, 144);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(167, 15);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "Неверный логин или пароль";
            errorLabel.Visible = false;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(12, 169);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(343, 23);
            registrationButton.TabIndex = 7;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 236);
            Controls.Add(registrationButton);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            MaximumSize = new Size(383, 275);
            MinimumSize = new Size(383, 275);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox loginTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button loginButton;
        private Label errorLabel;
        private Button registrationButton;
    }
}