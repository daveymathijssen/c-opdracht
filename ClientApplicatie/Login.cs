using System;
using System.Threading;
using System.Windows.Forms;
using NetworkLibrary;

namespace ClientApplication
{
    public partial class Login : Form
    {
        private Network network;

        public Login()
        {
            InitializeComponent();
            network = new Network("127.0.0.1", 130);
            Thread connectionThread = new Thread(new ThreadStart(ConnectThread));
            connectionThread.IsBackground = true;
            connectionThread.Start();
        }

        //error als de applicatie via "kruisje" wordt afgesloten, omdat statusLabel.Text dan niet meer bestaat
        private void ConnectThread()
        {
            while (statusLabel.Text != "Connected")
            {
                SetStatusLabel(network.status);
            }
        }

        delegate void SetTextLabel(string text);

        //Hier ook een error, zie comment bij ConnectThread()
        private void SetStatusLabel(string status)
        {
            if (this.statusLabel.InvokeRequired)
            {
                SetTextLabel d = new SetTextLabel(SetStatusLabel);
                this.Invoke(d, new object[] { status });
            }
            else
                this.statusLabel.Text = status;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Connected")
            {
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    Tuple<bool, User.AccessRights> login = network.login(usernameTextBox.Text, passwordTextBox.Text);
                    if (login.Item1)
                    {
                        Form form = new ClientApplication(network, usernameTextBox.Text.ToLower(), login.Item2);
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.Cancel)
                            this.Dispose();
                    }
                    else
                        MessageBox.Show("Wrong username or password");
                }
                else
                    MessageBox.Show("Please enter a username and a password!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
