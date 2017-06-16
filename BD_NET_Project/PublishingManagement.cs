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
    public partial class PublishingManagement : Form
    {
        public PublishingManagement()
        {
            InitializeComponent();
        }

        private void pUBLISHING_HOUSESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pUBLISHING_HOUSESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void PublishingManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.PUBLISHING_HOUSES' table. You can move, or remove it, as needed.
            this.pUBLISHING_HOUSESTableAdapter.Fill(this.dataSet.PUBLISHING_HOUSES);

        }
    }
}
