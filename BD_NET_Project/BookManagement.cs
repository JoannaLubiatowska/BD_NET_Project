using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_NET_Project
{
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.View_Book' table. You can move, or remove it, as needed.
            this.view_BookTableAdapter.Fill(this.dataSet.View_Book);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BookEditWindow")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                BookEditWindow w = new BookEditWindow();
                w.Show();
            }
        }
    }
}
