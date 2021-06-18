using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatStarterBasic
{
    public partial class Form_Main : Form
    {
        public enum ChatStatus { Initial = 0, Connected = 1, Error = 2 };
        public ChatStatus Status { get; set; }
        public ChatSession Chat { get; set; }

        public Form_Main()
        {
            InitializeComponent();
            this.Text += string.Format(" - {0}", Network.GetLocalIP().ToString());
            textBox_message_TextChanged(null, null);
            button_on.PerformClick();
            InitializeChat();
        }

        public void SetStatus(ChatStatus status)
        {
            switch (status)
            {
                case ChatStatus.Initial:
                    button_online.BackColor = Color.Silver;
                    button_online.Text = "Offline";
                    textBox_message.Enabled = false;
                    button_on.Enabled = true;
                    button_off.Enabled = false;
                    break;
                case ChatStatus.Connected:
                    button_online.BackColor = Color.Green;
                    button_online.Text = "Online";
                    textBox_message.Enabled = true;
                    button_on.Enabled = false;
                    button_off.Enabled = true;
                    break;
                case ChatStatus.Error:
                    button_online.BackColor = Color.Red;
                    button_online.Text = "Error";
                    textBox_message.Enabled = false;
                    button_off.Enabled = true;
                    button_on.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        public void InitializeChat()
        {
            Chat = new ChatSession();

            Chat.MessageReceived += (s, e) =>
            {
                listBox_conversation.Items.Add(
                    string.Format("Anonymous@{0}: {1}", e.SenderIP, e.Message)
                );
            };

            try
            {
                Chat.ConnectAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus(ChatStatus.Error);
                return;
            }

            SetStatus(ChatStatus.Connected);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_message.Text))
            {
                try
                {
                    Chat.SendMessage(textBox_message.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetStatus(ChatStatus.Error);
                }

                listBox_conversation.Items.Add(string.Format("Me: {0}", textBox_message.Text));
                textBox_message.Clear();
            }
        }

        private void textBox_message_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_message.Text))
            {
                button_send.ForeColor = Color.Gray;
                button_send.Cursor = Cursors.No;
            }
            else
            {
                button_send.ForeColor = Color.White;
                button_send.Cursor = Cursors.Hand;
            }
        }

        private void button_config_Click(object sender, EventArgs e)
        {
            
        }

        private void button_online_Click(object sender, EventArgs e)
        {
            button_on.PerformClick();
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            if (button_on.Enabled)
            {
                Chat.ConnectAsync();
                SetStatus(ChatStatus.Connected);
            }
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            if (button_off.Enabled)
            {
                Chat.Disconnect();
                SetStatus(ChatStatus.Initial);
            }
        }
    }
}
