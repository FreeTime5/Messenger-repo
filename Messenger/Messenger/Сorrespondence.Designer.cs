using MessLibrary;

namespace Messenger
{
    partial class correspondenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public User Writter { get; private set; }
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
        public correspondenceForm(User writter, User reciver)
        {
            InitializeComponent();
            Writter = writter;
            Reciver = reciver;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            messegeTestBox = new TextBox();
            sendMessageButton = new Button();
            dialogueListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            online = new Label();
            menuButton = new Button();
            usernameLabel = new Label();
            dateOnlineLabel = new Label();
            SuspendLayout();
            // 
            // messegeTestBox
            // 
            messegeTestBox.BackColor = SystemColors.Menu;
            messegeTestBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            messegeTestBox.Location = new Point(0, 414);
            messegeTestBox.Name = "messegeTestBox";
            messegeTestBox.Size = new Size(660, 38);
            messegeTestBox.TabIndex = 0;
            // 
            // sendMessageButton
            // 
            sendMessageButton.Location = new Point(650, 414);
            sendMessageButton.Name = "sendMessageButton";
            sendMessageButton.Size = new Size(84, 38);
            sendMessageButton.TabIndex = 1;
            sendMessageButton.Text = "Send";
            sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // dialogueListView
            // 
            dialogueListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            dialogueListView.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            dialogueListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            dialogueListView.Location = new Point(0, 46);
            dialogueListView.Name = "dialogueListView";
            dialogueListView.Size = new Size(734, 362);
            dialogueListView.TabIndex = 2;
            dialogueListView.UseCompatibleStateImageBehavior = false;
            dialogueListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ColumnashfiasfhsiHeader";
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
            // correspondenceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(732, 453);
            Controls.Add(dateOnlineLabel);
            Controls.Add(usernameLabel);
            Controls.Add(menuButton);
            Controls.Add(online);
            Controls.Add(dialogueListView);
            Controls.Add(sendMessageButton);
            Controls.Add(messegeTestBox);
            Name = "correspondenceForm";
            Text = "Messenger";
            Load += correspondenceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messegeTestBox;
        private Button sendMessageButton;
        private ListView dialogueListView;
        private Label online;
        private Button menuButton;
        private Label usernameLabel;
        private Label dateOnlineLabel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}