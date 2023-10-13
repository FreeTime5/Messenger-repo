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
    public partial class correspondenceForm : Form
    {

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void correspondenceForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Reciver.Username;
            if (Reciver.Online)
            {
                dateOnlineLabel.Text = "Online";
            }
            else
            {
                dateOnlineLabel.Text = Reciver.LastOnline;
            }
        }
    }
}
