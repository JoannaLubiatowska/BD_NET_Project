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
    public partial class TransactionManagement : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public TransactionManagement()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=LIBRARY;Persist Security Info=True;User ID=AdminNET;Password=12345");
            adapter = new SqlDataAdapter();
            Update_combobox(new DataTable("Books"), comboBoxBook, "select * from BOOKS", "TITLE", "PUBLICATION_YEAR");
            Update_combobox(new DataTable("Users"), comboBoxUser, "select * from USERS", "FIRST_NAME", "LAST_NAME");
        }

        private void lIB_TRANSACTIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIB_TRANSACTIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
            MessageBox.Show("Zapisano");
        }

        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.View_Tran' table. You can move, or remove it, as needed.
            this.view_TranTableAdapter.Fill(this.dataSet.View_Tran);
            // TODO: This line of code loads data into the 'dataSet.LIB_TRANSACTION' table. You can move, or remove it, as needed.
            this.lIB_TRANSACTIONTableAdapter.Fill(this.dataSet.LIB_TRANSACTION);

        }

        public void Update_combobox(DataTable transaction, ComboBox combo, String select, String field, String field2)
        {
            try
            {
                if (transaction.Rows.Count == 0)
                {
                    adapter.SelectCommand = new SqlCommand(select, connection);
                    adapter.Fill(transaction);
                }
                combo.Items.Clear();
                for (int i = 0; i < transaction.Rows.Count; ++i)
                {
                    ComboBoxItem item = new ComboBoxItem()
                    {
                        Text = transaction.Rows[i][field].ToString() + " " + transaction.Rows[i][field2].ToString(),
                        Hidden = transaction.Rows[i]
                    };
                    combo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.SelectCommand = new SqlCommand("SELECT * FROM LIB_TRANSACTION", connection);
                adapter.Fill(dataSet, "LIB_TRANSACTION");
                DataRow book = ((ComboBoxItem)comboBoxBook.SelectedItem).Hidden;
                DataRow user = ((ComboBoxItem)comboBoxUser.SelectedItem).Hidden;
                SqlCommand command = new SqlCommand("INSERT INTO LIB_TRANSACTION(ID_BOOK, ID_USER) VALUES(" + book["ID_BOOK"].ToString() + ", " + user["ID_USER"].ToString() + ");", connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "LIB_TRANSACTION");
                adapter.Update(dataSet, "LIB_TRANSACTION");
                MessageBox.Show("Zapisano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
