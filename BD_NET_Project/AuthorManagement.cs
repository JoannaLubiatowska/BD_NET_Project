﻿using System;
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
    public partial class AuthorManagement : Form
    {
        public AuthorManagement()
        {
            InitializeComponent();
        }

        private void aUTHORSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aUTHORSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
            MessageBox.Show("Zapisano");
        }

        private void AuthorManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.AUTHORS' table. You can move, or remove it, as needed.
            this.aUTHORSTableAdapter.Fill(this.dataSet.AUTHORS);

        }
    }
}
