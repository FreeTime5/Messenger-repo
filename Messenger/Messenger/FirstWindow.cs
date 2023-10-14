using MessLibrary;
using Microsoft.EntityFrameworkCore;

namespace Messenger
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private async void logInButton_Click(object sender, EventArgs e)
        {
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
                this.Close();
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
                user = new User(usernameTextBox.Text, passwordTextBox.Text);
                using (var db = new PostgreConnection())
                {
                    db.AddUser(user);
                }
                var form = new mainMenuForm(user);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private User? GetUser()
        {
            User? user;
            using (var db = new ProgramContext())
            {
                user = db.Users.Find(usernameTextBox.Text);
            }
            return user;
        }
    }
}