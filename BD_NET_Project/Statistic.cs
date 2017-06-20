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
    public partial class Statistic : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public Statistic()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=LIBRARY;Persist Security Info=True;User ID=AdminNET;Password=12345");
            adapter = new SqlDataAdapter();
            getNumberOfTranMounth();
            getNumberOfTranWeek();
            getNumberUser();
        }

        private void getNumberOfTranMounth()
        {
            try
            {
                DataTable temp = new DataTable();
                SqlCommand command = new SqlCommand("select dbo.numberOfTranInMonth() as a", connection);
                adapter.SelectCommand = command;
                adapter.Fill(temp);
                adapter.Update(temp);
                this.textBoxTransaciotnMonth.Text = temp.Rows[0]["a"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getNumberOfTranWeek()
        {
            try
            {
                DataTable temp = new DataTable();
                SqlCommand command = new SqlCommand("select dbo.numberOfTranInWeek() as a", connection);
                adapter.SelectCommand = command;
                adapter.Fill(temp);
                adapter.Update(temp);
                this.textBoxTransaciotnWeek.Text = temp.Rows[0]["a"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getNumberUser()
        {
            try
            {
                DataTable temp = new DataTable();
                SqlCommand command = new SqlCommand("select dbo.numberOfUser() as a", connection);
                adapter.SelectCommand = command;
                adapter.Fill(temp);
                adapter.Update(temp);
                this.textBoxUser.Text = temp.Rows[0]["a"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.LIB_TRANSACTION' table. You can move, or remove it, as needed.
            this.lIB_TRANSACTIONTableAdapter.Fill(this.dataSet.LIB_TRANSACTION);
            // TODO: This line of code loads data into the 'dataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);

        }

        private void Statystyki_Click(object sender, EventArgs e)
        {

        }
    }
}
