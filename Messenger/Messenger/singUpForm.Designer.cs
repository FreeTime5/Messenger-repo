namespace Messenger
{
    partial class singUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Size _startSize;
        private Size _startTextBoxSize;
        private Size _startSingUpButtonSize;
        private Font _startTextFont;
        private Font _startStatusLabelFont;

        private int _startDistanceBetweenLabelAndTextBoxY;
        private int _startDistanceBetweenTextBoxAndLabelY;
        private int _startDistanceBetweenControlsX;
        private Point _startUsernameLabelLocation;
        private Point _startSingUpButtonLocation;


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
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            singUpButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(50, 70);
            usernameTextBox.MaxLength = 20;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 34);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(50, 30);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 28);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(50, 120);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 28);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(50, 160);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 34);
            passwordTextBox.TabIndex = 5;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordLabel.Location = new Point(50, 210);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(170, 28);
            confirmPasswordLabel.TabIndex = 6;
            confirmPasswordLabel.Text = "Confirm password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(50, 250);
            confirmPasswordTextBox.MaxLength = 50;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(250, 34);
            confirmPasswordTextBox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(450, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 28);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(450, 70);
            firstNameTextBox.MaxLength = 50;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(250, 34);
            firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(450, 160);
            lastNameTextBox.MaxLength = 50;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(250, 34);
            lastNameTextBox.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(450, 120);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(99, 28);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last name";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(450, 250);
            emailTextBox.MaxLength = 100;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(250, 34);
            emailTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(450, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 28);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // singUpButton
            // 
            singUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            singUpButton.Location = new Point(320, 350);
            singUpButton.Name = "singUpButton";
            singUpButton.Size = new Size(120, 50);
            singUpButton.TabIndex = 14;
            singUpButton.Text = "Sing Up";
            singUpButton.UseVisualStyleBackColor = true;
            singUpButton.Click += singUpButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(50, 300);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 15;
            // 
            // singUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 244, 255);
            ClientSize = new Size(732, 453);
            Controls.Add(statusLabel);
            Controls.Add(singUpButton);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            MinimumSize = new Size(750, 500);
            Name = "singUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            SizeChanged += singUpForm_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTextBox;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Button singUpButton;
        private Label statusLabel;
    }
}