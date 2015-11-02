using NetworkLibrary;
using System;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class ClientApplication : Form
    {
        private Network network;
        private string username;
        private User.AccessRights accessRights;

        public ClientApplication(Network network, string username, User.AccessRights accessRights)
        {
            InitializeComponent();
            this.network = network;
            this.username = username;
            this.accessRights = accessRights;

            User.AccessRights allRights = User.AccessRights.Leidinggevende | User.AccessRights.KantoorMedewerker;
            User.AccessRights viewRights = User.AccessRights.Kitter;

            if ((accessRights & allRights) != 0)
            {
                MessageBox.Show("Logged in as leidinggevende or kantoormedewerker");
            }
            if((accessRights & User.AccessRights.Leidinggevende) != 0)
            {
                MessageBox.Show("Logged in as leidinggevende");
                //Show tab only for leidinggevende
            }
            else if((accessRights & viewRights) != 0)
            {
                MessageBox.Show("Logged in as kitter");
            }
        }

    }
}
