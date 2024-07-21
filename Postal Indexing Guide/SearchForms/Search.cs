using System;
using System.Windows.Forms;

namespace Postal_Indexing_Guide.SearchForms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchTableAdapter.Fill(this.postalIndexingGuide_DataSet.Search, strToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            if (Program.isGuest)
                AuthorizationForm.guestMainMenuForm.Show();
            else
                AuthorizationForm.mainMenuForm.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearchInInternet_Click(object sender, EventArgs e)
        {
            AuthorizationForm.SearchInInternet.Show();
        }

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

