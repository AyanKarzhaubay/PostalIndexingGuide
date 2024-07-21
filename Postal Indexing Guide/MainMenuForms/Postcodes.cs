using System;
using System.Windows.Forms;

namespace Postal_Indexing_Guide.MainMenuForms
{
    public partial class Postcodes : Form
    {
        public Postcodes()
        {
            InitializeComponent();
        }

        private void postalCodesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postalCodesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postalIndexingGuide_DataSet);

        }

        private void Postcodes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postalIndexingGuide_DataSet.PostalCodes". При необходимости она может быть перемещена или удалена.
            this.postalCodesTableAdapter.Fill(this.postalIndexingGuide_DataSet.PostalCodes);

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
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
