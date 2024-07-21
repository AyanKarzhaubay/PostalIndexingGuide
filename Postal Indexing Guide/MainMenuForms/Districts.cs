using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postal_Indexing_Guide.MainMenuForms
{
    public partial class Districts : Form
    {
        public Districts()
        {
            InitializeComponent(); 
            WindowState = FormWindowState.Maximized;

        }

        private void districtsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.districtsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postalIndexingGuide_DataSet);

        }

        private void Districts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postalIndexingGuide_DataSet.Districts". При необходимости она может быть перемещена или удалена.
            this.districtsTableAdapter.Fill(this.postalIndexingGuide_DataSet.Districts);

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

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
