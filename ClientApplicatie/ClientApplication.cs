using NetworkLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class ClientApplication : Form
    {
        private Network network;
        private string username;
        private User.AccessRights accessRights;
        private List<User> users;
        private List<Werkbon> werkbonnen;

        public ClientApplication(Network network, string username, User.AccessRights accessRights)
        {
            InitializeComponent();
            this.network = network;
            this.username = username;
            this.accessRights = accessRights;
            Agenda();

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
                projectLijstTab.Hide();
                addUserButton.Hide();
                changeUserButton.Hide();
                removeUserButton.Hide();
                werkbonComboBox.Hide();
                addButon.Hide();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String newTabName = tabControl1.SelectedTab.Name;
            switch (newTabName)
            {
                case "gebruikersTab":
                    UsersTab();
                    break;
                case "agendaTab":
                    Agenda();
                    break;
            }
        }

        /// <summary>
        /// The werknemer tab:
        /// </summary>

        //Fills users tab: 
        private void UsersTab()
        {
            //test data
            //users = new List<User>();
            //users.Add(new User("Davey", "Davey", User.AccessRights.Leidinggevende));
            //users.Add(new User("Wesley", "Wesley", User.AccessRights.KantoorMedewerker));

            //get users from network here...
            users = network.GetUsers();
            fillUsersList();
        }

        //Filter for users:
        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            usersDataGridView.Rows.Clear();
            foreach (User user in users)
            {
                if(user.username.ToLower().Contains(filterTextBox.Text.ToLower()))
                    usersDataGridView.Rows.Add(user.username, user.accessRights);
            }
            if(!(usersDataGridView.Rows.Count > 0))
            {
                foreach (User user in users)
                {
                    if (user.accessRights.ToString().ToLower().Contains(filterTextBox.Text.ToLower()))
                        usersDataGridView.Rows.Add(user.username, user.accessRights);
                }
            }
        }

        //Fill the users list;
        private void fillUsersList()
        {
            usersDataGridView.Rows.Clear();
            foreach (User user in users)
            {
                usersDataGridView.Rows.Add(user.username, user.accessRights);
            }
        }

        //Remove a user:
        private void removeUserButton_Click(object sender, EventArgs e)
        {
            string username = usersDataGridView.CurrentCell.Value.ToString();
            for (int x = users.Count - 1; x >= 0; x--)
                if (users[x].username.Equals(username))
                    users.RemoveAt(x);
            fillUsersList();
            //Send users to server here:
            //Not yet...
        }

        //Add a user
        private void addUserButton_Click(object sender, EventArgs e)
        {
            AlterUser form = new AlterUser(null);
            DialogResult dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                bool count = false;
                foreach (User user in users)
                    if (user.username.Equals(form.user.username))
                        count = true;
                if (!count)
                {
                    users.Add(form.user);
                    //Send users to server
                    network.AddUser(form.user);
                    fillUsersList();
                }
                form.Dispose();
            }  
        }

        //Alter user
        private void changeUserButton_Click(object sender, EventArgs e)
        {
            String username = usersDataGridView.CurrentCell.Value.ToString();
            DialogResult dialogResult;
            foreach (User user in users)
            {
                if (user.username.Equals(username))
                {
                    Form form = new AlterUser(user);
                    dialogResult = form.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        //Send users to server
                        fillUsersList();
                        form.Dispose();
                    }
                }
            }     
        }

        /// <summary>
        /// The Agenda tab
        /// </summary>
        private void Agenda()
        {
            werkbonnen = new List<Werkbon>();
           // werkbonnen.Add(new Werkbon("hoi"));
           // werkbonnen.Add(new Werkbon("doei"));
            
            //get werkbonnen van server hier
            werkbonnen = network.GetWerkbonnen();
            System.Diagnostics.Debug.WriteLine("hoi: " + werkbonnen.Count);
            fillWerkbonList();

        }

        private void fillWerkbonList()
        {
            //Filling them in list:
            DateTime day = werkbonCalander.SelectionRange.Start;
            werkbonList.DataSource = null;
            List<Werkbon> dayList = new List<Werkbon>();
            foreach (Werkbon werkbon in werkbonnen)
            {
                if(werkbon.uitvoerDatum.Equals(day))
                    dayList.Add(werkbon);
            }
            werkbonList.DataSource = dayList;

            //Filling the not yet used werkbonnen:
            werkbonComboBox.Items.Clear();
            foreach (Werkbon werkbon in werkbonnen)
            {
                if(werkbon.uitvoerDatum == DateTime.MinValue)
                    werkbonComboBox.Items.Add(werkbon);
            }
        }

        private void addButon_Click(object sender, EventArgs e)
        {
            DateTime day = werkbonCalander.SelectionRange.Start;
            Werkbon werkbon = (Werkbon) werkbonComboBox.SelectedItem;
            System.Diagnostics.Debug.WriteLine(werkbon.werkbon);
            //alter the datetime field in werkbon 
            werkbon.uitvoerDatum = day;
            fillWerkbonList();
        }

        private void werkbonCalander_DateChanged(object sender, DateRangeEventArgs e)
        {
            fillWerkbonList();
        }
    }
}
