using MessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pageLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            pageLayoutPanel.VerticalScroll.Value = pageLayoutPanel.VerticalScroll.Maximum;
        }

        private void pageLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            pageLayoutPanel.VerticalScroll.Value = pageLayoutPanel.VerticalScroll.Maximum;
        }

        private void pageScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            var message = new MessageInfo(messageTextBox.Text, Sender, Reciver);
            using (var db = new PostgreConnection())
            {
                db.AddMessage(message);
            }
        }
    }
}
