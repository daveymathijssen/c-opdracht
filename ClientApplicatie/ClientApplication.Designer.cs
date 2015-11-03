namespace ClientApplication
{
    partial class ClientApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientApplication));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.agendaTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButon = new System.Windows.Forms.Button();
            this.werkbonComboBox = new System.Windows.Forms.ComboBox();
            this.werkbonCalander = new System.Windows.Forms.MonthCalendar();
            this.werkbonList = new System.Windows.Forms.ListBox();
            this.gebruikersTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.Gebruikernaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toegangsrechten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectLijstTab = new System.Windows.Forms.TabPage();
            this.werkOpdrachtenTab = new System.Windows.Forms.TabPage();
            this.werkBonnenTab = new System.Windows.Forms.TabPage();
            this.OpdrachtgeversTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.agendaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gebruikersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.agendaTab);
            this.tabControl1.Controls.Add(this.gebruikersTab);
            this.tabControl1.Controls.Add(this.projectLijstTab);
            this.tabControl1.Controls.Add(this.werkOpdrachtenTab);
            this.tabControl1.Controls.Add(this.werkBonnenTab);
            this.tabControl1.Controls.Add(this.OpdrachtgeversTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 430);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // agendaTab
            // 
            this.agendaTab.Controls.Add(this.splitContainer2);
            this.agendaTab.Location = new System.Drawing.Point(4, 22);
            this.agendaTab.Name = "agendaTab";
            this.agendaTab.Size = new System.Drawing.Size(713, 404);
            this.agendaTab.TabIndex = 5;
            this.agendaTab.Text = "Agenda";
            this.agendaTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel1.Controls.Add(this.werkbonCalander);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.werkbonList);
            this.splitContainer2.Size = new System.Drawing.Size(713, 404);
            this.splitContainer2.SplitterDistance = 387;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.addButon);
            this.flowLayoutPanel2.Controls.Add(this.werkbonComboBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 375);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(309, 3);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(75, 23);
            this.addButon.TabIndex = 0;
            this.addButon.Text = "Voeg Toe";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // werkbonComboBox
            // 
            this.werkbonComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.werkbonComboBox.FormattingEnabled = true;
            this.werkbonComboBox.Location = new System.Drawing.Point(182, 3);
            this.werkbonComboBox.Name = "werkbonComboBox";
            this.werkbonComboBox.Size = new System.Drawing.Size(121, 21);
            this.werkbonComboBox.TabIndex = 1;
            // 
            // werkbonCalander
            // 
            this.werkbonCalander.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.werkbonCalander.Dock = System.Windows.Forms.DockStyle.Fill;
            this.werkbonCalander.Location = new System.Drawing.Point(0, 0);
            this.werkbonCalander.MaxSelectionCount = 1;
            this.werkbonCalander.Name = "werkbonCalander";
            this.werkbonCalander.TabIndex = 1;
            this.werkbonCalander.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.werkbonCalander_DateChanged);
            // 
            // werkbonList
            // 
            this.werkbonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.werkbonList.FormattingEnabled = true;
            this.werkbonList.Location = new System.Drawing.Point(0, 0);
            this.werkbonList.Name = "werkbonList";
            this.werkbonList.Size = new System.Drawing.Size(322, 404);
            this.werkbonList.TabIndex = 0;
            // 
            // gebruikersTab
            // 
            this.gebruikersTab.Controls.Add(this.splitContainer1);
            this.gebruikersTab.Location = new System.Drawing.Point(4, 22);
            this.gebruikersTab.Name = "gebruikersTab";
            this.gebruikersTab.Size = new System.Drawing.Size(713, 404);
            this.gebruikersTab.TabIndex = 4;
            this.gebruikersTab.Text = "Gebruikers";
            this.gebruikersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.usersDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.filterTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(713, 404);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 1;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gebruikernaam,
            this.Toegangsrechten});
            this.usersDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(713, 268);
            this.usersDataGridView.TabIndex = 0;
            // 
            // Gebruikernaam
            // 
            this.Gebruikernaam.HeaderText = "Gebruikersnaam";
            this.Gebruikernaam.Name = "Gebruikernaam";
            this.Gebruikernaam.ReadOnly = true;
            // 
            // Toegangsrechten
            // 
            this.Toegangsrechten.HeaderText = "Toegangsrechten";
            this.Toegangsrechten.Name = "Toegangsrechten";
            this.Toegangsrechten.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.addUserButton);
            this.flowLayoutPanel1.Controls.Add(this.changeUserButton);
            this.flowLayoutPanel1.Controls.Add(this.removeUserButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(586, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 132);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addUserButton
            // 
            this.addUserButton.AutoSize = true;
            this.addUserButton.Location = new System.Drawing.Point(3, 3);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(121, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Gebruiker Toevoegen";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.AutoSize = true;
            this.changeUserButton.Location = new System.Drawing.Point(18, 32);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(106, 23);
            this.changeUserButton.TabIndex = 1;
            this.changeUserButton.Text = "Gebruiker Wijzigen";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.AutoSize = true;
            this.removeUserButton.Location = new System.Drawing.Point(3, 61);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(121, 23);
            this.removeUserButton.TabIndex = 3;
            this.removeUserButton.Text = "Gebruiker Verwijderen";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(73, 12);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter:";
            // 
            // projectLijstTab
            // 
            this.projectLijstTab.Location = new System.Drawing.Point(4, 22);
            this.projectLijstTab.Name = "projectLijstTab";
            this.projectLijstTab.Padding = new System.Windows.Forms.Padding(3);
            this.projectLijstTab.Size = new System.Drawing.Size(713, 404);
            this.projectLijstTab.TabIndex = 0;
            this.projectLijstTab.Text = "Projectlijst";
            this.projectLijstTab.UseVisualStyleBackColor = true;
            // 
            // werkOpdrachtenTab
            // 
            this.werkOpdrachtenTab.Location = new System.Drawing.Point(4, 22);
            this.werkOpdrachtenTab.Name = "werkOpdrachtenTab";
            this.werkOpdrachtenTab.Padding = new System.Windows.Forms.Padding(3);
            this.werkOpdrachtenTab.Size = new System.Drawing.Size(713, 404);
            this.werkOpdrachtenTab.TabIndex = 1;
            this.werkOpdrachtenTab.Text = "Werkopdrachten";
            this.werkOpdrachtenTab.UseVisualStyleBackColor = true;
            // 
            // werkBonnenTab
            // 
            this.werkBonnenTab.Location = new System.Drawing.Point(4, 22);
            this.werkBonnenTab.Name = "werkBonnenTab";
            this.werkBonnenTab.Size = new System.Drawing.Size(713, 404);
            this.werkBonnenTab.TabIndex = 2;
            this.werkBonnenTab.Text = "Werkbonnen";
            this.werkBonnenTab.UseVisualStyleBackColor = true;
            // 
            // OpdrachtgeversTab
            // 
            this.OpdrachtgeversTab.Location = new System.Drawing.Point(4, 22);
            this.OpdrachtgeversTab.Name = "OpdrachtgeversTab";
            this.OpdrachtgeversTab.Size = new System.Drawing.Size(713, 404);
            this.OpdrachtgeversTab.TabIndex = 3;
            this.OpdrachtgeversTab.Text = "Opdrachtgevers";
            this.OpdrachtgeversTab.UseVisualStyleBackColor = true;
            // 
            // ClientApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 430);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientApplication";
            this.Text = "Beheer Systeem";
            this.tabControl1.ResumeLayout(false);
            this.agendaTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gebruikersTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage projectLijstTab;
        private System.Windows.Forms.TabPage werkOpdrachtenTab;
        private System.Windows.Forms.TabPage werkBonnenTab;
        private System.Windows.Forms.TabPage OpdrachtgeversTab;
        private System.Windows.Forms.TabPage gebruikersTab;
        private System.Windows.Forms.TabPage agendaTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gebruikernaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toegangsrechten;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox werkbonList;
        private System.Windows.Forms.MonthCalendar werkbonCalander;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.ComboBox werkbonComboBox;
    }
}

