using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class singUpForm : Form
    {
        public singUpForm(string username)
        {
            InitializeComponent();
            _startSize = Size;
            _startTextBoxSize = usernameTextBox.Size;
            _startSingUpButtonSize = singUpButton.Size;
            _startTextFont = usernameTextBox.Font;
            _startStatusLabelFont = statusLabel.Font;

            _startUsernameLabelLocation = usernameLabel.Location;
            _startSingUpButtonLocation = singUpButton.Location;
            _startDistanceBetweenLabelAndTextBoxY = usernameTextBox.Location.Y - usernameLabel.Location.Y;
            _startDistanceBetweenTextBoxAndLabelY = passwordLabel.Location.Y - usernameTextBox.Location.Y;
            _startDistanceBetweenControlsX = firstNameLabel.Location.X - usernameLabel.Location.X;
            usernameTextBox.Text = username;
        }

        private bool IsCorrectInput()
        {
            if (usernameTextBox.Text.Length < 3)
            {
                statusLabel.Text = "Incorrect length of username";
                return false;
            }
            if (passwordTextBox.Text.Length < 8)
            {

            }
            return true;
        }

        private void singUpButton_Click(object sender, EventArgs e)
        {

        }

        private void singUpForm_SizeChanged(object sender, EventArgs e)
        {
            usernameTextBox.Size = passwordTextBox.Size = confirmPasswordTextBox.Size = firstNameTextBox.Size = lastNameTextBox.Size = emailTextBox.Size = NewSizeOfButton(_startTextBoxSize);
            usernameTextBox.Font = passwordTextBox.Font = confirmPasswordTextBox.Font = firstNameTextBox.Font = lastNameTextBox.Font = emailTextBox.Font = NewFontOfTextControl(_startTextFont);

            singUpButton.Font = usernameLabel.Font = passwordLabel.Font = confirmPasswordLabel.Font = firstNameLabel.Font = lastNameLabel.Font = emailLabel.Font = NewFontOfTextControl(_startTextFont);
            singUpButton.Size = NewSizeOfButton(_startSingUpButtonSize);
            singUpButton.Location = NewLocationOfFirstControl(_startSingUpButtonLocation);

            usernameLabel.Location = NewLocationOfFirstControl(_startUsernameLabelLocation);
            firstNameLabel.Location = NewLocationOfControlsX(usernameLabel.Location);
            usernameTextBox.Location = NewLocationOfControlsLABTY(usernameLabel.Location);
            firstNameTextBox.Location = NewLocationOfControlsX(usernameTextBox.Location);
            passwordLabel.Location = NewLocationOfControlsBTALY(usernameTextBox.Location);
            lastNameLabel.Location = NewLocationOfControlsX(passwordLabel.Location);
            passwordTextBox.Location = NewLocationOfControlsLABTY(passwordLabel.Location);
            lastNameTextBox.Location = NewLocationOfControlsX(passwordTextBox.Location);
            confirmPasswordLabel.Location = NewLocationOfControlsBTALY(passwordTextBox.Location);
            emailLabel.Location = NewLocationOfControlsX(confirmPasswordLabel.Location);
            confirmPasswordTextBox.Location = NewLocationOfControlsLABTY(confirmPasswordLabel.Location);
            emailTextBox.Location = NewLocationOfControlsX(confirmPasswordTextBox.Location);


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

        private Point NewLocationOfFirstControl(Point startControlLocation)
        {
            double ratioX = (double)_startSize.Width / startControlLocation.X;
            double ratioY = (double)_startSize.Height / startControlLocation.Y;
            return new Point((int)(Size.Width / ratioX), (int)(Size.Height / ratioY));
        }

        private Point NewLocationOfControlsLABTY(Point startControlLocation)
        {
            var ratio = (float)Size.Height / _startSize.Height;
            return new Point(startControlLocation.X, (int)(_startDistanceBetweenLabelAndTextBoxY * ratio) + startControlLocation.Y);
        }

        private Point NewLocationOfControlsBTALY(Point startControlLocation)
        {
            var ratio = (float)Size.Height / _startSize.Height;
            return new Point(startControlLocation.X, (int)(_startDistanceBetweenTextBoxAndLabelY * ratio) + startControlLocation.Y);
        }

        private Point NewLocationOfControlsX(Point startControlLocation)
        {
            var ratio = (float)Size.Width / _startSize.Width;
            return new Point(startControlLocation.X + (int)(_startDistanceBetweenControlsX * ratio), startControlLocation.Y);
        }
    }
}
