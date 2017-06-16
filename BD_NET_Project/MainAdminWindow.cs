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
            if (openNextWindow("SectionManagement"))
            {
                SectionManagement b = new SectionManagement();
                b.Show();
            }
        }

        private void buttonPublishing_Click(object sender, EventArgs e)
        {
            if (openNextWindow("PublishingManagement"))
            {
                PublishingManagement b = new PublishingManagement();
                b.Show();
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            if (openNextWindow("UserManagement"))
            {
                UserManagement b = new UserManagement();
                b.Show();
            }
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            if (openNextWindow("TransactionManagement"))
            {
                TransactionManagement b = new TransactionManagement();
                b.Show();
            }  
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            if (openNextWindow("Statistic"))
            {
                Statistic b = new Statistic();
                b.Show();
            }
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
