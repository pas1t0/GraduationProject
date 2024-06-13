namespace WinFormsApplication.Forms
{
    partial class RegistrationForm
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
            titleLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            middleNameTextBox = new TextBox();
            middleNameLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            loginTextBox = new TextBox();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            sendButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(226, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(96, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Регистрация";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(14, 26);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(58, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 44);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(310, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 88);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(310, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(14, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(31, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Имя";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(12, 132);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(310, 23);
            middleNameTextBox.TabIndex = 6;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(14, 114);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(58, 15);
            middleNameLabel.TabIndex = 5;
            middleNameLabel.Text = "Отчество";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 176);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(310, 23);
            phoneTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 158);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(55, 15);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Телефон";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 220);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(310, 23);
            emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 202);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 15);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Почта";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 264);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(310, 23);
            loginTextBox.TabIndex = 12;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 246);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 11;
            loginLabel.Text = "Логин";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 308);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(310, 23);
            passwordTextBox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(14, 290);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Пароль";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(239, 351);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(83, 23);
            sendButton.TabIndex = 17;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 383);
            Controls.Add(sendButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(middleNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(350, 422);
            MinimumSize = new Size(350, 422);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox middleNameTextBox;
        private Label middleNameLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox loginTextBox;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button sendButton;
    }
}