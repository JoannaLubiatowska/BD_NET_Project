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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.dataSet.USERS);

        }
    }
}
