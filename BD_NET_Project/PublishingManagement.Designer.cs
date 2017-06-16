namespace BD_NET_Project
{
    partial class PublishingManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishingManagement));
            this.dataSet = new BD_NET_Project.DataSet();
            this.pUBLISHING_HOUSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHING_HOUSESTableAdapter = new BD_NET_Project.DataSetTableAdapters.PUBLISHING_HOUSESTableAdapter();
            this.tableAdapterManager = new BD_NET_Project.DataSetTableAdapters.TableAdapterManager();
            this.pUBLISHING_HOUSESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pUBLISHING_HOUSESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESBindingNavigator)).BeginInit();
            this.pUBLISHING_HOUSESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLISHING_HOUSESBindingSource
            // 
            this.pUBLISHING_HOUSESBindingSource.DataMember = "PUBLISHING_HOUSES";
            this.pUBLISHING_HOUSESBindingSource.DataSource = this.dataSet;
            // 
            // pUBLISHING_HOUSESTableAdapter
            // 
            this.pUBLISHING_HOUSESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.LIB_TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.PUBLISHING_HOUSESTableAdapter = this.pUBLISHING_HOUSESTableAdapter;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_NET_Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // pUBLISHING_HOUSESBindingNavigator
            // 
            this.pUBLISHING_HOUSESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pUBLISHING_HOUSESBindingNavigator.BindingSource = this.pUBLISHING_HOUSESBindingSource;
            this.pUBLISHING_HOUSESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pUBLISHING_HOUSESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pUBLISHING_HOUSESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem});
            this.pUBLISHING_HOUSESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pUBLISHING_HOUSESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pUBLISHING_HOUSESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pUBLISHING_HOUSESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pUBLISHING_HOUSESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pUBLISHING_HOUSESBindingNavigator.Name = "pUBLISHING_HOUSESBindingNavigator";
            this.pUBLISHING_HOUSESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pUBLISHING_HOUSESBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.pUBLISHING_HOUSESBindingNavigator.TabIndex = 0;
            this.pUBLISHING_HOUSESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pUBLISHING_HOUSESBindingNavigatorSaveItem
            // 
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pUBLISHING_HOUSESBindingNavigatorSaveItem.Image")));
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.Name = "pUBLISHING_HOUSESBindingNavigatorSaveItem";
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.Text = "Save Data";
            this.pUBLISHING_HOUSESBindingNavigatorSaveItem.Click += new System.EventHandler(this.pUBLISHING_HOUSESBindingNavigatorSaveItem_Click);
            // 
            // pUBLISHING_HOUSESDataGridView
            // 
            this.pUBLISHING_HOUSESDataGridView.AutoGenerateColumns = false;
            this.pUBLISHING_HOUSESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pUBLISHING_HOUSESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pUBLISHING_HOUSESDataGridView.DataSource = this.pUBLISHING_HOUSESBindingSource;
            this.pUBLISHING_HOUSESDataGridView.Location = new System.Drawing.Point(12, 37);
            this.pUBLISHING_HOUSESDataGridView.Name = "pUBLISHING_HOUSESDataGridView";
            this.pUBLISHING_HOUSESDataGridView.Size = new System.Drawing.Size(293, 362);
            this.pUBLISHING_HOUSESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PUBLISHING_HOUSE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PUBLISHING_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Wydawnictwo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // PublishingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 411);
            this.Controls.Add(this.pUBLISHING_HOUSESDataGridView);
            this.Controls.Add(this.pUBLISHING_HOUSESBindingNavigator);
            this.Name = "PublishingManagement";
            this.Text = "Wydawnictwa";
            this.Load += new System.EventHandler(this.PublishingManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESBindingNavigator)).EndInit();
            this.pUBLISHING_HOUSESBindingNavigator.ResumeLayout(false);
            this.pUBLISHING_HOUSESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHING_HOUSESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource pUBLISHING_HOUSESBindingSource;
        private DataSetTableAdapters.PUBLISHING_HOUSESTableAdapter pUBLISHING_HOUSESTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pUBLISHING_HOUSESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pUBLISHING_HOUSESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pUBLISHING_HOUSESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}