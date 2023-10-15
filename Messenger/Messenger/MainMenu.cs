using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessLibrary;

namespace Messenger
{
    public partial class mainMenuForm : Form
    {

        public mainMenuForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            user.Online = true;
            using (var db = new PostgreConnection())
            {
                db.UpdateUsers(user);
            }
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Contacts != null)
                usersComboBox.Items.AddRange(CurrentUser.Contacts);
        }

        private void addContactLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new addUserForm(CurrentUser);
            this.Hide();
            form.ShowDialog();
            usersComboBox.Items.Clear();
            usersComboBox.Items.AddRange(CurrentUser!.Contacts);
            this.Show();
        }

        private void startDialogueButton_Click(object sender, EventArgs e)
        {
            if (usersComboBox.Text == "")
            {
                statusLabel.Text = "Choose user";
            }
            else
            {
                User user;
                using (var db = new PostgreConnection())
                {
                    user = db.GetInfoUser(usersComboBox.Text)!;
                }
                var from = new correspondenceForm(CurrentUser, user);
                this.Hide();
                statusLabel.Text = "";
                from.ShowDialog();
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentUser.Online = false;
            CurrentUser.LastOnline = DateTime.Now.ToString("dd-MM, hh:mm");
            using (var db = new PostgreConnection())
            {
                db.UpdateUsers(CurrentUser);
            }
        }
    }
}
