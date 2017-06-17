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
    public partial class SectionManagement : Form
    {
        public SectionManagement()
        {
            InitializeComponent();
        }

        private void sECTIONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sECTIONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
            MessageBox.Show("Zapisano");
        }

        private void SectionManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.SECTIONS' table. You can move, or remove it, as needed.
            this.sECTIONSTableAdapter.Fill(this.dataSet.SECTIONS);

        }
    }
}
