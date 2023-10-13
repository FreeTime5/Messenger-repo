using MessLibrary;

namespace Messenger
{
    partial class addUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public User CurrentUser { get; private set; }

        public addUserForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }
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
            addUsernameTextBox = new TextBox();
            statusLabel = new Label();
            addButton = new Button();
            menuButton = new Button();
            usernameLabel = new Label();
            SuspendLayout();
            // 
            // addUsernameTextBox
            // 
            addUsernameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addUsernameTextBox.Location = new Point(98, 40);
            addUsernameTextBox.MaxLength = 20;
            addUsernameTextBox.Name = "addUsernameTextBox";
            addUsernameTextBox.Size = new Size(250, 38);
            addUsernameTextBox.TabIndex = 0;
            addUsernameTextBox.TextChanged += addUsernameTextBox_TextChanged;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(98, 81);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(173, 156);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 49);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // menuButton
            // 
            menuButton.Location = new Point(-3, -4);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(68, 35);
            menuButton.TabIndex = 3;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(98, 17);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username";
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(438, 250);
            Controls.Add(usernameLabel);
            Controls.Add(menuButton);
            Controls.Add(addButton);
            Controls.Add(statusLabel);
            Controls.Add(addUsernameTextBox);
            Name = "addUserForm";
            Text = "Messenger";
            Load += addUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addUsernameTextBox;
        private Label statusLabel;
        private Button addButton;
        private Button menuButton;
        private Label usernameLabel;
    }
}