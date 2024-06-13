namespace WinFormsApplication.Forms
{
    partial class CreateRequestForm
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
            addressTextBox = new TextBox();
            addressLabel = new Label();
            titleLabel = new Label();
            serveTimeLabel = new Label();
            serveTimePicker = new DateTimePicker();
            sendButton = new Button();
            SuspendLayout();
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 53);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(389, 23);
            addressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 35);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(40, 15);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(221, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(180, 20);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Форма создания заявки";
            // 
            // serveTimeLabel
            // 
            serveTimeLabel.AutoSize = true;
            serveTimeLabel.Location = new Point(12, 95);
            serveTimeLabel.Name = "serveTimeLabel";
            serveTimeLabel.Size = new Size(104, 15);
            serveTimeLabel.TabIndex = 9;
            serveTimeLabel.Text = "Дата выполнения";
            // 
            // serveTimePicker
            // 
            serveTimePicker.Location = new Point(12, 113);
            serveTimePicker.Name = "serveTimePicker";
            serveTimePicker.Size = new Size(389, 23);
            serveTimePicker.TabIndex = 10;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(285, 176);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(116, 23);
            sendButton.TabIndex = 11;
            sendButton.Text = "Создать";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // CreateRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 211);
            Controls.Add(sendButton);
            Controls.Add(serveTimePicker);
            Controls.Add(serveTimeLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(429, 250);
            MinimumSize = new Size(429, 250);
            Name = "CreateRequestForm";
            Text = "Создание заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addressTextBox;
        private Label addressLabel;
        private Label titleLabel;
        private Label serveTimeLabel;
        private DateTimePicker serveTimePicker;
        private Button sendButton;
    }
}