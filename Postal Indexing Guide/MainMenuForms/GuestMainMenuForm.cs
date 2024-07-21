using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Postal_Indexing_Guide.SearchForms;

namespace Postal_Indexing_Guide.MainMenuForms
{
    public partial class GuestMainMenuForm : Form
    {
        public GuestMainMenuForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
