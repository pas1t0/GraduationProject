namespace WinFormsApplication
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            titleLabel = new Label();
            quitButton = new Button();
            servicesButton = new Button();
            requestsButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(161, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Добро пожаловать!";
            // 
            // quitButton
            // 
            quitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quitButton.Location = new Point(448, 141);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(89, 23);
            quitButton.TabIndex = 1;
            quitButton.Text = "Выйти";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // servicesButton
            // 
            servicesButton.Location = new Point(12, 141);
            servicesButton.Name = "servicesButton";
            servicesButton.Size = new Size(93, 23);
            servicesButton.TabIndex = 2;
            servicesButton.Text = "Услуги";
            servicesButton.UseVisualStyleBackColor = true;
            servicesButton.Click += servicesButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.Location = new Point(111, 141);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(91, 23);
            requestsButton.TabIndex = 3;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = true;
            requestsButton.Click += requestsButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(525, 98);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 171);
            Controls.Add(label1);
            Controls.Add(requestsButton);
            Controls.Add(servicesButton);
            Controls.Add(quitButton);
            Controls.Add(titleLabel);
            MaximumSize = new Size(565, 210);
            MinimumSize = new Size(565, 210);
            Name = "Home";
            Text = "Домашняя страница";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button quitButton;
        private Button servicesButton;
        private Button requestsButton;
        private Label label1;
    }
}
