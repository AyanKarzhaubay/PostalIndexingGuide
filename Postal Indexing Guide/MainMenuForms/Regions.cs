using System;
using System.Windows.Forms;

namespace Postal_Indexing_Guide
{
    public partial class Regions : Form
    {
        public Regions()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm.mainMenuForm.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postalIndexingGuide_DataSet);

        }

        private void Regions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postalIndexingGuide_DataSet.Regions". При необходимости она может быть перемещена или удалена.
            this.regionsTableAdapter.Fill(this.postalIndexingGuide_DataSet.Regions);

        }

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
