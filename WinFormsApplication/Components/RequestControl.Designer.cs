namespace WinFormsApplication.Components
{
    partial class RequestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            positionLabel = new Label();
            executorFullNameLabel = new Label();
            customerFullNameLabel = new Label();
            serviceImageBox = new PictureBox();
            serviceDescriptionLabel = new Label();
            serviceNameLabel = new Label();
            isCompletedCheckBox = new CheckBox();
            periodLabel = new Label();
            categoryDiscriptionLabel = new Label();
            categoryLabel = new Label();
            priceLabel = new Label();
            pinButton = new Button();
            isPayedCheckbox = new CheckBox();
            serveTimeLabel = new Label();
            addressLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).BeginInit();
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(9, 211);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(89, 15);
            positionLabel.TabIndex = 21;
            positionLabel.Text = "Должность: {0}";
            // 
            // executorFullNameLabel
            // 
            executorFullNameLabel.AutoSize = true;
            executorFullNameLabel.Location = new Point(9, 189);
            executorFullNameLabel.Name = "executorFullNameLabel";
            executorFullNameLabel.Size = new Size(101, 15);
            executorFullNameLabel.TabIndex = 19;
            executorFullNameLabel.Text = "Исполнитель: {0}";
            // 
            // customerFullNameLabel
            // 
            customerFullNameLabel.AutoSize = true;
            customerFullNameLabel.Location = new Point(9, 161);
            customerFullNameLabel.Name = "customerFullNameLabel";
            customerFullNameLabel.Size = new Size(77, 15);
            customerFullNameLabel.TabIndex = 18;
            customerFullNameLabel.Text = "Заказчик: {0}";
            // 
            // serviceImageBox
            // 
            serviceImageBox.Location = new Point(502, 7);
            serviceImageBox.Name = "serviceImageBox";
            serviceImageBox.Size = new Size(234, 284);
            serviceImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            serviceImageBox.TabIndex = 17;
            serviceImageBox.TabStop = false;
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.Location = new Point(9, 42);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new Size(487, 41);
            serviceDescriptionLabel.TabIndex = 16;
            serviceDescriptionLabel.Text = "Очень длинное очень очень чуть чуть можно много нельзя описание";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            serviceNameLabel.Location = new Point(9, 0);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new Size(711, 36);
            serviceNameLabel.TabIndex = 15;
            serviceNameLabel.Text = "Название";
            serviceNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // isCompletedCheckBox
            // 
            isCompletedCheckBox.AutoCheck = false;
            isCompletedCheckBox.Location = new Point(3, 272);
            isCompletedCheckBox.Name = "isCompletedCheckBox";
            isCompletedCheckBox.Size = new Size(89, 19);
            isCompletedCheckBox.TabIndex = 27;
            isCompletedCheckBox.Text = "Завершено";
            isCompletedCheckBox.UseVisualStyleBackColor = true;
            isCompletedCheckBox.CheckedChanged += isCompletedCheckBox_CheckedChanged;
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new Point(9, 247);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new Size(169, 15);
            periodLabel.TabIndex = 26;
            periodLabel.Text = "Период направления: {0} - {1}";
            // 
            // categoryDiscriptionLabel
            // 
            categoryDiscriptionLabel.Location = new Point(9, 121);
            categoryDiscriptionLabel.Name = "categoryDiscriptionLabel";
            categoryDiscriptionLabel.Size = new Size(487, 40);
            categoryDiscriptionLabel.TabIndex = 24;
            categoryDiscriptionLabel.Text = "Описание категории: {0}";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(9, 103);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(83, 15);
            categoryLabel.TabIndex = 23;
            categoryLabel.Text = "Категория: {0}";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceLabel.Location = new Point(193, 274);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(52, 13);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Цена: {0}";
            // 
            // pinButton
            // 
            pinButton.Location = new Point(91, 185);
            pinButton.Name = "pinButton";
            pinButton.Size = new Size(131, 23);
            pinButton.TabIndex = 28;
            pinButton.Text = "Назначить себя";
            pinButton.UseVisualStyleBackColor = true;
            pinButton.Visible = false;
            pinButton.Click += pinButton_Click;
            // 
            // isPayedCheckbox
            // 
            isPayedCheckbox.AutoCheck = false;
            isPayedCheckbox.Location = new Point(98, 272);
            isPayedCheckbox.Name = "isPayedCheckbox";
            isPayedCheckbox.Size = new Size(89, 19);
            isPayedCheckbox.TabIndex = 29;
            isPayedCheckbox.Text = "Оплачено";
            isPayedCheckbox.UseVisualStyleBackColor = true;
            isPayedCheckbox.CheckedChanged += isPayedCheckbox_CheckedChanged;
            // 
            // serveTimeLabel
            // 
            serveTimeLabel.AutoSize = true;
            serveTimeLabel.Location = new Point(9, 231);
            serveTimeLabel.Name = "serveTimeLabel";
            serveTimeLabel.Size = new Size(122, 15);
            serveTimeLabel.TabIndex = 30;
            serveTimeLabel.Text = "Дата исполнения: {0}";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(9, 83);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(60, 15);
            addressLabel.TabIndex = 31;
            addressLabel.Text = "Адрес: {0}";
            // 
            // RequestControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(addressLabel);
            Controls.Add(serveTimeLabel);
            Controls.Add(isPayedCheckbox);
            Controls.Add(pinButton);
            Controls.Add(isCompletedCheckBox);
            Controls.Add(periodLabel);
            Controls.Add(categoryDiscriptionLabel);
            Controls.Add(categoryLabel);
            Controls.Add(priceLabel);
            Controls.Add(positionLabel);
            Controls.Add(executorFullNameLabel);
            Controls.Add(customerFullNameLabel);
            Controls.Add(serviceImageBox);
            Controls.Add(serviceDescriptionLabel);
            Controls.Add(serviceNameLabel);
            Name = "RequestControl";
            Size = new Size(746, 294);
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label positionLabel;
        private Label executorFullNameLabel;
        private Label customerFullNameLabel;
        private PictureBox serviceImageBox;
        private Label serviceDescriptionLabel;
        private Label serviceNameLabel;
        private CheckBox isCompletedCheckBox;
        private Label periodLabel;
        private Label categoryDiscriptionLabel;
        private Label categoryLabel;
        private Label priceLabel;
        private Button pinButton;
        private CheckBox isPayedCheckbox;
        private Label serveTimeLabel;
        private Label addressLabel;
    }
}
