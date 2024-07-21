using System;
using System.Windows.Forms;
using Postal_Indexing_Guide.SearchForms;
using Postal_Indexing_Guide.MainMenuForms;

namespace Postal_Indexing_Guide
{
    public partial class AuthorizationForm : Form
    {
        public static Search searchForm;
        public static SearchInInternet SearchInInternet;
        public static Republics republics;
        public static Regions regions;
        public static Districts districts;
        public static Villages villages;
        public static Postcodes postcodes;
        public static MainMenuForm mainMenuForm;
        public static AuthorizationForm authorizationForm;
        public static GuestMainMenuForm guestMainMenuForm;

        public static bool b;
        string[] logins = { "karzhaubay.ayan", "kaulibek.albina", "muhammetalieva.aida", "nurgali.zhasulan", "tolebek.dinara", "shorbasov.erkhan", "admin" };
        string[] passwords = { "snowfall", "AlbiBeautyGirl", "AidaBeautyGirl", "Zhasik", "DinkaBeautyGirl", "Erkhan3000", "admin" };
        public AuthorizationForm()
        {
            InitializeComponent();
            authorizationForm = this;
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            int z = -1;
            bool authSuccess = false;
            for (int i = 0; i < logins.Length; i++)
            {
                try
                {
                    if (loginTextBox.Text == logins[i])
                    {
                        z = i;
                    }
                    if (passwordTextBox.Text == passwords[z])
                    {
                        authSuccess = true;
                    }
                }
                catch { }
            }
            if (authSuccess)
            {
                authorizationForm.Hide();
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Login or password is not correct.");
            }
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            Program.isGuest = !Program.isGuest;
            Hide();
            guestMainMenuForm.Show();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            searchForm = new Search();
            SearchInInternet = new SearchInInternet();  
            republics = new Republics();
            regions = new Regions();
            districts = new Districts();
            villages = new Villages();
            postcodes = new Postcodes();
            mainMenuForm = new MainMenuForm();
            guestMainMenuForm = new GuestMainMenuForm();
        }
        private void CloseApplicationButton_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
