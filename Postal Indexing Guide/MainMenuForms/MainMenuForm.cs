using System;
using System.Windows.Forms;

namespace Postal_Indexing_Guide
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void postalIndexesFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.postcodes.Show();
        }
        private void republicsFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.republics.Show();
        }

        private void regionsFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.regions.Show();
        }

        private void districtsFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.districts.Show();
        }

        private void villagesFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.villages.Show();
        }
        private void searchFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm.searchForm.Show();
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
        }
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
