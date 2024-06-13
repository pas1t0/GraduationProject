namespace WinFormsApplication.Forms
{
    partial class ServiceSetForm
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
            categoryComboBox = new ComboBox();
            categoryLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            imageLabel = new Label();
            imageComboBox = new ComboBox();
            submitButton = new Button();
            imageBox = new PictureBox();
            amountInput = new NumericUpDown();
            amountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(274, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(127, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Обновить услугу";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 358);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(389, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 340);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(63, 15);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Категория";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 53);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(389, 23);
            nameTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 106);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(389, 53);
            descriptionTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(9, 88);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(62, 15);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Описание";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 162);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Цена";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(12, 180);
            priceInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(389, 23);
            priceInput.TabIndex = 9;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(12, 208);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(83, 15);
            imageLabel.TabIndex = 11;
            imageLabel.Text = "Изображение";
            // 
            // imageComboBox
            // 
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(12, 226);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(389, 23);
            imageComboBox.TabIndex = 10;
            imageComboBox.SelectedValueChanged += imageComboBox_SelectedValueChanged;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(311, 444);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(90, 23);
            submitButton.TabIndex = 12;
            submitButton.Text = "Отправить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // imageBox
            // 
            imageBox.BackColor = SystemColors.ControlLight;
            imageBox.Location = new Point(12, 255);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(389, 82);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 13;
            imageBox.TabStop = false;
            // 
            // amountInput
            // 
            amountInput.Location = new Point(12, 402);
            amountInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(389, 23);
            amountInput.TabIndex = 15;
            amountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(12, 384);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(72, 15);
            amountLabel.TabIndex = 14;
            amountLabel.Text = "Количетсво";
            // 
            // ServiceSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 479);
            Controls.Add(amountInput);
            Controls.Add(amountLabel);
            Controls.Add(imageBox);
            Controls.Add(submitButton);
            Controls.Add(imageLabel);
            Controls.Add(imageComboBox);
            Controls.Add(priceInput);
            Controls.Add(priceLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(titleLabel);
            MaximumSize = new Size(429, 518);
            MinimumSize = new Size(429, 518);
            Name = "ServiceSetForm";
            Text = "Обновить услугу";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label priceLabel;
        private NumericUpDown priceInput;
        private Label imageLabel;
        private ComboBox imageComboBox;
        private Button submitButton;
        private PictureBox imageBox;
        private NumericUpDown amountInput;
        private Label amountLabel;
    }
}