namespace WinFormsApplication.Forms
{
    partial class RequestsForm
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
            descriptionLabel = new Label();
            titleLabel = new Label();
            requestsContainer = new FlowLayoutPanel();
            servicesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 15);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(197, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Здесь находятся созданные заявки";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(730, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(58, 20);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Заявки";
            // 
            // requestsContainer
            // 
            requestsContainer.AutoScroll = true;
            requestsContainer.FlowDirection = FlowDirection.TopDown;
            requestsContainer.Location = new Point(12, 62);
            requestsContainer.Name = "requestsContainer";
            requestsContainer.Size = new Size(776, 372);
            requestsContainer.TabIndex = 4;
            requestsContainer.WrapContents = false;
            // 
            // servicesComboBox
            // 
            servicesComboBox.FormattingEnabled = true;
            servicesComboBox.Location = new Point(12, 34);
            servicesComboBox.Name = "servicesComboBox";
            servicesComboBox.Size = new Size(197, 23);
            servicesComboBox.TabIndex = 5;
            servicesComboBox.SelectedIndexChanged += servicesComboBox_SelectedIndexChanged;
            // 
            // RequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(servicesComboBox);
            Controls.Add(requestsContainer);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "RequestsForm";
            Text = "Направления услуг";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private Label titleLabel;
        private FlowLayoutPanel requestsContainer;
        private ComboBox servicesComboBox;
    }
}