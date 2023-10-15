using MessLibrary;
namespace Messenger
{
    partial class FirstWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Size _startSize;
        private Size _startUsernameTextBoxSize;
        private Size _startPasswordTextBoxSize;
        private Size _startSingUpButtonSize;
        private Size _startLogInButtonSize;
        private Font _startTextFont;
        private Font _startStatusLabelFont;
        private Point _startUsernameTextBoxLocation;
        private Point _startUsernameLabelLocation;
        private Point _startPasswordTextBoxLocation;
        private Point _startPasswordLabelLocation;
        private Point _startLogInButtonLocation;
        private Point _startSingUpButtonLocation;
        private Point _startStatusLabelLocation;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            usernameTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            logInButton = new Button();
            singUpButton = new Button();
            statusLabel = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(250, 115);
            usernameTextBox.MaxLength = 20;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 34);
            usernameTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripSeparator1, toolStripTextBox1, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 95);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(208, 6);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 24);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(250, 80);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 28);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label1_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(250, 189);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 34);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(250, 155);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 28);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.Location = new Point(315, 256);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(120, 50);
            logInButton.TabIndex = 5;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // singUpButton
            // 
            singUpButton.Location = new Point(325, 316);
            singUpButton.Name = "singUpButton";
            singUpButton.Size = new Size(100, 40);
            singUpButton.TabIndex = 6;
            singUpButton.Text = "Sing up";
            singUpButton.UseVisualStyleBackColor = true;
            singUpButton.Click += singUpButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(250, 230);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Click += statusLabel_Click;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(732, 453);
            Controls.Add(statusLabel);
            Controls.Add(singUpButton);
            Controls.Add(logInButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            MinimumSize = new Size(750, 500);
            Name = "FirstWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            SizeChanged += FirstWindow_SizeChanged;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button logInButton;
        private Button singUpButton;
        private Label statusLabel;
    }
}