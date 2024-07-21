using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postal_Indexing_Guide
{
    public partial class Villages : Form
    {
        public Villages()
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

        private void villagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.villagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postalIndexingGuide_DataSet);

        }

        private void Villages_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postalIndexingGuide_DataSet.Villages". При необходимости она может быть перемещена или удалена.
            this.villagesTableAdapter.Fill(this.postalIndexingGuide_DataSet.Villages);

        }
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
