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
            _startDistanceBetweenLabelAndTextBoxY = usernameLabel.Location.Y - usernameTextBox.Location.Y;
            _startDistanceBetweenTextBoxAndLabelY = usernameTextBox.Location.Y - passwordLabel.Location.Y;
            _startDistanceBetweenControlsX = usernameLabel.Location.X - firstNameLabel.Location.X;
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

            usernameLabel.Font = passwordLabel.Font = confirmPasswordLabel.Font = firstNameLabel.Font = lastNameLabel.Font = emailLabel.Font = NewFontOfTextControl(_startTextFont);

            usernameLabel.Location = NewLocationOfFirstControl(_startUsernameLabelLocation);

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

        private Point NewLocationOfControls(Point startControlLocation)
        {
            var ratioDistanceX = (double)Size.Width / _startSize.Width;
            var ratioDistanceY = (double)Size.Height / _startSize.Height;
            return new Point(startControlLocation.X * (int)ratioDistanceX, startControlLocation.Y * (int)ratioDistanceY);
        }
    }
}
