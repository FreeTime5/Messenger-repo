using MessLibrary;
namespace Messenger
{
    partial class mainMenuForm
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

        public User CurrentUser { get; private set; }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usersComboBox = new ComboBox();
            addContactLabel = new LinkLabel();
            startDialogueButton = new Button();
            statusLabel = new Label();
            contactsLabel = new Label();
            SuspendLayout();
            // 
            // usersComboBox
            // 
            usersComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usersComboBox.FormattingEnabled = true;
            usersComboBox.Location = new Point(41, 54);
            usersComboBox.Name = "usersComboBox";
            usersComboBox.Size = new Size(225, 39);
            usersComboBox.TabIndex = 0;
            usersComboBox.SelectedIndexChanged += usersComboBox_SelectedIndexChanged;
            // 
            // addContactLabel
            // 
            addContactLabel.AutoSize = true;
            addContactLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addContactLabel.LinkColor = Color.Black;
            addContactLabel.Location = new Point(510, 57);
            addContactLabel.Name = "addContactLabel";
            addContactLabel.Size = new Size(139, 31);
            addContactLabel.TabIndex = 1;
            addContactLabel.TabStop = true;
            addContactLabel.Text = "Add contact";
            addContactLabel.LinkClicked += addContactLabel_LinkClicked;
            // 
            // startDialogueButton
            // 
            startDialogueButton.Location = new Point(307, 342);
            startDialogueButton.Name = "startDialogueButton";
            startDialogueButton.Size = new Size(122, 44);
            startDialogueButton.TabIndex = 2;
            startDialogueButton.Text = "Start dialogue";
            startDialogueButton.UseVisualStyleBackColor = true;
            startDialogueButton.Click += startDialogueButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(307, 389);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 3;
            statusLabel.Click += label1_Click;
            // 
            // contactsLabel
            // 
            contactsLabel.AutoSize = true;
            contactsLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            contactsLabel.Location = new Point(41, 20);
            contactsLabel.Name = "contactsLabel";
            contactsLabel.Size = new Size(103, 31);
            contactsLabel.TabIndex = 4;
            contactsLabel.Text = "Contacts";
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(732, 453);
            Controls.Add(contactsLabel);
            Controls.Add(statusLabel);
            Controls.Add(startDialogueButton);
            Controls.Add(addContactLabel);
            Controls.Add(usersComboBox);
            Name = "mainMenuForm";
            Text = "Messenger";
            FormClosing += mainMenuForm_FormClosing;
            Load += mainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox usersComboBox;
        private LinkLabel addContactLabel;
        private Button startDialogueButton;
        private Label statusLabel;
        private Label contactsLabel;
    }
}