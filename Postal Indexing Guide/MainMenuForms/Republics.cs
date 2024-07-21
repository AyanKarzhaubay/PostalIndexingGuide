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
    public partial class Republics : Form
    {
        public Republics()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void republicsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.republicsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postalIndexingGuide_DataSet);

        }

        private void Republics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postalIndexingGuide_DataSet.Republics". При необходимости она может быть перемещена или удалена.
            this.republicsTableAdapter.Fill(this.postalIndexingGuide_DataSet.Republics);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm.mainMenuForm.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {

        }
    }
}
