using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postal_Indexing_Guide.SearchForms
{
    public partial class SearchInInternet : Form
    {
        public SearchInInternet()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            webBrowser.Url = new Uri("http://google.com"); // бірінші қосқан кезде google.com іздеу жүйесіне кіріліп тұрады
        }

        private void toolStripSearchButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/search?q=Почтовый индекс " + toolStripSearchTextBox.Text); // кейін өзіміз сәйкес іздеу жолы арқылы пошталық индекстерді іздей бере аламыз
        }
    }
}
