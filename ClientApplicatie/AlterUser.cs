using NetworkLibrary;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class AlterUser : Form
    {
        public User user { get; set; }

        public AlterUser(User user)
        {
            this.user = user;
            InitializeComponent();
            if(user == null) //new user
                identifierLabel.Text = "Gebruiker Toevoegen";
            else //alter user
            {
                identifierLabel.Text = "Gebruiker Wijzigen";
                userNameTextBox.Text = user.username;
                userRightsComboBox.Text = user.accessRights.ToString();
            }
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void submintButton_Click(object sender, System.EventArgs e)
        {
            if(user == null)
            {
                switch(userRightsComboBox.Text)
                {
                    case "Kitter":
                        user = new User(userNameTextBox.Text,passwordTextBox.Text.ToLower(),User.AccessRights.Kitter);
                        break;
                    case "KantoorMedewerker":
                        user = new User(userNameTextBox.Text, passwordTextBox.Text.ToLower(), User.AccessRights.KantoorMedewerker);
                        break;
                    case "Leidinggevende":
                        user = new User(userNameTextBox.Text, passwordTextBox.Text.ToLower(), User.AccessRights.Leidinggevende);
                        break;
                } 
            }
            else
            {
                if(userNameTextBox.Text != "")
                    user.username = userNameTextBox.Text;
                if(passwordTextBox.Text != "")
                    user.password = passwordTextBox.Text;
                switch (userRightsComboBox.Text)
                {
                    case "Kitter":
                        user.accessRights = User.AccessRights.Kitter;
                        break;
                    case "KantoorMedewerker":
                        user.accessRights = User.AccessRights.KantoorMedewerker;
                        break;
                    case "Leidinggevende":
                        user.accessRights = User.AccessRights.Leidinggevende;
                        break;
                }
            }
        }
    }
}
