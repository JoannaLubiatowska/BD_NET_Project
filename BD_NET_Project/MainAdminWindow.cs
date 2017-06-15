using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_NET_Project
{
    public partial class MainAdminWindow : Form
    {
        private SqlConnection connection;
        public MainAdminWindow()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=LIBRARY;Persist Security Info=True;User ID=AdminNET;Password=12345");

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (openNextWindow("BookManagement"))
            {
                BookManagement b = new BookManagement();
                b.Show();
            }
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            if (openNextWindow("AuthorManagemen"))
            {
                AuthorManagement b = new AuthorManagement();
                b.Show();
            }
        }

        private void buttonSection_Click(object sender, EventArgs e)
        {

        }

        private void buttonPublishing_Click(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {

        }

        private void buttonBookStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonAuthorStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonSectionStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonPublishingStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransactionStatistic_Click(object sender, EventArgs e)
        {

        }

        private Boolean openNextWindow(string windowName)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == windowName)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
