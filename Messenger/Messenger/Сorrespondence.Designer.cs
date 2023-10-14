using MessLibrary;

namespace Messenger
{
    partial class correspondenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public User Sender { get; private set; }
        public User Reciver { get; private set; }
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
        public correspondenceForm(User sender, User reciver)
        {
            InitializeComponent();
            Reciver = sender;
            Reciver = reciver;
            pageLayoutPanel.ControlAdded += pageLayoutPanel_ControlAdded;
            pageLayoutPanel.ControlRemoved += pageLayoutPanel_ControlRemoved;
            pageLayoutPanel.VerticalScroll.Value = pageLayoutPanel.VerticalScroll.Maximum;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageTextBox = new TextBox();
            sendMessageButton = new Button();
            online = new Label();
            menuButton = new Button();
            usernameLabel = new Label();
            dateOnlineLabel = new Label();
            pageLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.BackColor = SystemColors.Menu;
            messageTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            messageTextBox.Location = new Point(0, 414);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(660, 38);
            messageTextBox.TabIndex = 0;
            // 
            // sendMessageButton
            // 
            sendMessageButton.Location = new Point(650, 414);
            sendMessageButton.Name = "sendMessageButton";
            sendMessageButton.Size = new Size(84, 38);
            sendMessageButton.TabIndex = 1;
            sendMessageButton.Text = "Send";
            sendMessageButton.UseVisualStyleBackColor = true;
            sendMessageButton.Click += sendMessageButton_Click;
            // 
            // online
            // 
            online.AutoSize = true;
            online.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            online.Location = new Point(354, 10);
            online.Name = "online";
            online.Size = new Size(73, 28);
            online.TabIndex = 3;
            online.Text = "Online:";
            online.Click += label1_Click;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton.Location = new Point(-1, -2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(94, 48);
            menuButton.TabIndex = 4;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(156, 6);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(110, 31);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Unknown";
            // 
            // dateOnlineLabel
            // 
            dateOnlineLabel.AutoSize = true;
            dateOnlineLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateOnlineLabel.Location = new Point(433, 10);
            dateOnlineLabel.Name = "dateOnlineLabel";
            dateOnlineLabel.Size = new Size(110, 31);
            dateOnlineLabel.TabIndex = 6;
            dateOnlineLabel.Text = "Unknown";
            dateOnlineLabel.Click += label2_Click;
            // 
            // pageLayoutPanel
            // 
            pageLayoutPanel.AutoScroll = true;
            pageLayoutPanel.BackColor = Color.WhiteSmoke;
            pageLayoutPanel.Location = new Point(12, 56);
            pageLayoutPanel.Name = "pageLayoutPanel";
            pageLayoutPanel.Size = new Size(708, 352);
            pageLayoutPanel.TabIndex = 9;
            pageLayoutPanel.ControlAdded += pageLayoutPanel_ControlAdded;
            pageLayoutPanel.ControlRemoved += pageLayoutPanel_ControlRemoved;
            // 
            // correspondenceForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(732, 453);
            Controls.Add(pageLayoutPanel);
            Controls.Add(dateOnlineLabel);
            Controls.Add(usernameLabel);
            Controls.Add(menuButton);
            Controls.Add(online);
            Controls.Add(sendMessageButton);
            Controls.Add(messageTextBox);
            Name = "correspondenceForm";
            Text = "Messenger";
            Load += correspondenceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private Button sendMessageButton;
        private Label online;
        private Button menuButton;
        private Label usernameLabel;
        private Label dateOnlineLabel;
        private FlowLayoutPanel pageLayoutPanel;
    }
}