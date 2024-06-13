namespace WinFormsApplication.Components
{
    partial class ServiceControl
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
            nameLabel = new Label();
            descriptionLabel = new Label();
            imageBox = new PictureBox();
            submitButton = new Button();
            priceLabel = new Label();
            categoryLabel = new Label();
            categoryDiscriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(16, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(711, 36);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(16, 39);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(538, 54);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Очень длинное очень очень чуть чуть можно много нельзя описание";
            // 
            // imageBox
            // 
            imageBox.Location = new Point(560, 39);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(183, 122);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 3;
            imageBox.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(641, 164);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(102, 23);
            submitButton.TabIndex = 4;
            submitButton.Text = "Приобрести";
            submitButton.UseMnemonic = false;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceLabel.Location = new Point(16, 164);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(52, 13);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Цена: {0}";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(16, 93);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(83, 15);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Категория: {0}";
            // 
            // categoryDiscriptionLabel
            // 
            categoryDiscriptionLabel.Location = new Point(16, 111);
            categoryDiscriptionLabel.Name = "categoryDiscriptionLabel";
            categoryDiscriptionLabel.Size = new Size(538, 53);
            categoryDiscriptionLabel.TabIndex = 6;
            categoryDiscriptionLabel.Text = "Описание категории: {0}";
            // 
            // ServiceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(categoryDiscriptionLabel);
            Controls.Add(categoryLabel);
            Controls.Add(submitButton);
            Controls.Add(imageBox);
            Controls.Add(priceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Name = "ServiceControl";
            Size = new Size(746, 191);
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label descriptionLabel;
        private PictureBox imageBox;
        private Button submitButton;
        private Label priceLabel;
        private Label categoryLabel;
        private Label categoryDiscriptionLabel;
    }
}
