namespace WinFormsApplication.Forms
{
    partial class ServicesForm
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
            descriptionLabel = new Label();
            servicesContainer = new FlowLayoutPanel();
            createButton = new Button();
            categoryComboBox = new ComboBox();
            searchButton = new Button();
            searchTextBox = new TextBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(733, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Услуги";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 12);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(219, 15);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Здесь находятся все доступные услуги";
            // 
            // servicesContainer
            // 
            servicesContainer.AutoScroll = true;
            servicesContainer.FlowDirection = FlowDirection.TopDown;
            servicesContainer.Location = new Point(12, 64);
            servicesContainer.Name = "servicesContainer";
            servicesContainer.Size = new Size(776, 374);
            servicesContainer.TabIndex = 2;
            servicesContainer.WrapContents = false;
            // 
            // createButton
            // 
            createButton.Location = new Point(652, 6);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Visible = false;
            createButton.Click += createButton_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 35);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(219, 23);
            categoryComboBox.TabIndex = 3;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(713, 35);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(358, 36);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(349, 23);
            searchTextBox.TabIndex = 5;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(categoryComboBox);
            Controls.Add(createButton);
            Controls.Add(servicesContainer);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "ServicesForm";
            Text = "Услуги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private FlowLayoutPanel servicesContainer;
        private Button createButton;
        private ComboBox categoryComboBox;
        private Button searchButton;
        private TextBox searchTextBox;
    }
}