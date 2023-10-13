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
    public partial class addUserForm : Form
    {

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }

        private void addUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            User? user;
            if (CurrentUser.Contacts != null && (CurrentUser.Contacts.Contains(addUsernameTextBox.Text) || CurrentUser.Username == addUsernameTextBox.Text))
            {
                statusLabel.Text = "This user is alredy in your contacts list";
                addUsernameTextBox.Text = "";
                return;
            }
            using (var db = new PostgreConnection())
            {
                user = db.GetInfoUser(addUsernameTextBox.Text);
                if (user != null)
                {
                    List<string> contacts, contactsUser;
                    if (CurrentUser.Contacts == null)
                    {
                        contacts = new List<string>();
                    }
                    else
                    {
                        contacts = CurrentUser.Contacts.ToList();
                    }
                    if (user.Contacts == null)
                    {
                        contactsUser = new List<string>();
                    }
                    else
                    {
                        contactsUser = user.Contacts.ToList();
                    }
                    contacts.Add(user.Username);
                    contactsUser.Add(CurrentUser.Username);
                    user.Contacts = contactsUser.ToArray();
                    CurrentUser.Contacts = contacts.ToArray();
                    statusLabel.Text = "Contact added successfully";
                    db.UpdateUsers(CurrentUser);
                }
                else
                {
                    statusLabel.Text = "There are no users with this username";
                }
                addUsernameTextBox.Text = "";
            }
        }
    }
}
