using MessLibrary;
using Microsoft.EntityFrameworkCore;

namespace Messenger
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
            _startSize = Size;
            _startTextBoxSize = usernameTextBox.Size;
            _startSingUpButtonSize = singUpButton.Size;
            _startLogInButtonSize = logInButton.Size;
            _startTextFont = usernameTextBox.Font;
            _startStatusLabelFont = statusLabel.Font;

            _startUsernameTextBoxLocation = usernameTextBox.Location;
            _startUsernameLabelLocation = usernameLabel.Location;
            _startPasswordTextBoxLocation = passwordTextBox.Location;
            _startPasswordLabelLocation = passwordLabel.Location;
            _startStatusLabelLocation = statusLabel.Location;
            _startLogInButtonLocation = logInButton.Location;
            _startSingUpButtonLocation = singUpButton.Location;
        }

        private async void logInButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3 || passwordTextBox.Text.Length < 8)
            {
                statusLabel.Text = "Incorrect username or password length";
                return;
            }
            User? user = GetUser();
            if (user == null || user.Password != passwordTextBox.Text)
            {
                statusLabel.Text = "Incorrect username or password";
                passwordTextBox.Text = "";
            }
            else
            {
                var form = new mainMenuForm(user);
                this.Hide();
                form.ShowDialog();
                passwordTextBox.Text = "";
                usernameTextBox.Text = "";
                statusLabel.Text = "";
                this.Show();
            }

        }



        private void singUpButton_Click(object sender, EventArgs e)
        {

            User? user = GetUser();
            if (user != null)
            {
                statusLabel.Text = "This username is already exist";
                passwordTextBox.Text = "";
            }
            else
            {
                var form = new singUpForm(usernameTextBox.Text);
                this.Hide();
                form.ShowDialog();
                passwordTextBox.Text = "";
                usernameTextBox.Text = "";
                statusLabel.Text = "";
                this.Show();
            }
        }

        private User? GetUser()
        {
            User? user;
            using (var db = new PostgreConnection())
            {
                user = db.GetInfoUser(usernameTextBox.Text);
            }
            return user;
        }

        private void FirstWindow_SizeChanged(object sender, EventArgs e)
        {
            logInButton.Size = NewSizeOfButton(_startLogInButtonSize);
            logInButton.Font = NewFontOfTextControl(_startTextFont);

            singUpButton.Size = NewSizeOfButton(_startSingUpButtonSize);
            singUpButton.Font = NewFontOfTextControl(_startStatusLabelFont);

            usernameTextBox.Size =  passwordTextBox.Size = NewSizeOfButton(_startTextBoxSize);
            usernameTextBox.Font = NewFontOfTextControl(_startTextFont);
            passwordTextBox.Font = NewFontOfTextControl(_startTextFont);


            usernameLabel.Font = NewFontOfTextControl(_startTextFont);

            passwordLabel.Font = NewFontOfTextControl(_startTextFont);

            statusLabel.Font = NewFontOfTextControl(_startStatusLabelFont);


            usernameTextBox.Location = NewLocation(_startUsernameTextBoxLocation);
            usernameLabel.Location = NewLocation(_startUsernameLabelLocation);
            passwordTextBox.Location = NewLocation(_startPasswordTextBoxLocation);
            passwordLabel.Location = NewLocation(_startPasswordLabelLocation);
            singUpButton.Location = NewLocation(_startSingUpButtonLocation);
            logInButton.Location = NewLocation(_startLogInButtonLocation);
            statusLabel.Location = NewLocation(_startStatusLabelLocation);



        }

        private Font NewFontOfTextControl(Font startControlFont)
        {
            var ratio = _startSize.Height / startControlFont.Size;
            return new Font(startControlFont.Name, Size.Height / ratio);
        }

        private Size NewSizeOfButton(Size startControlSize)
        {
            double ratioX = (double)_startSize.Width / startControlSize.Width;
            double ratioY = (double)_startSize.Height / startControlSize.Height;
            return new Size((int)(Size.Width / ratioX), (int)(Size.Height / ratioY));
        }

        private Point NewLocation(Point startControlLocation)
        {
            double ratioX = (double)_startSize.Width / startControlLocation.X;
            double ratioY = (double)_startSize.Height / startControlLocation.Y;
            return new Point((int)(Size.Width / ratioX), (int)(Size.Height / ratioY));
        }

        private void usernameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && usernameTextBox.Text.Length >= 3)
            {
                Console.Beep();
                passwordTextBox.Select();
            }
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter && usernameTextBox.Text.Length >= 3)
            {
                Console.Beep();
                logInButton_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Up)
                usernameTextBox.Select();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

    }
}