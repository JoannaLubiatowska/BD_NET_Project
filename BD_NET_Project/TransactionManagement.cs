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
        }

        private void lIB_TRANSACTIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIB_TRANSACTIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.View_Tran' table. You can move, or remove it, as needed.
            this.view_TranTableAdapter.Fill(this.dataSet.View_Tran);
            // TODO: This line of code loads data into the 'dataSet.LIB_TRANSACTION' table. You can move, or remove it, as needed.
            this.lIB_TRANSACTIONTableAdapter.Fill(this.dataSet.LIB_TRANSACTION);

        }
    }
}
