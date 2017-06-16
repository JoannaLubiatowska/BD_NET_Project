namespace BD_NET_Project
{
    partial class TransactionManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionManagement));
            System.Windows.Forms.Label iD_LIB_TRANSACTIONLabel;
            System.Windows.Forms.Label iD_BOOKLabel;
            System.Windows.Forms.Label iD_USERLabel;
            System.Windows.Forms.Label tRANSACTION_DATELabel;
            System.Windows.Forms.Label rETURN_DATELabel;
            this.dataSet = new BD_NET_Project.DataSet();
            this.lIB_TRANSACTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIB_TRANSACTIONTableAdapter = new BD_NET_Project.DataSetTableAdapters.LIB_TRANSACTIONTableAdapter();
            this.tableAdapterManager = new BD_NET_Project.DataSetTableAdapters.TableAdapterManager();
            this.lIB_TRANSACTIONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lIB_TRANSACTIONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_LIB_TRANSACTIONTextBox = new System.Windows.Forms.TextBox();
            this.iD_BOOKTextBox = new System.Windows.Forms.TextBox();
            this.iD_USERTextBox = new System.Windows.Forms.TextBox();
            this.tRANSACTION_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rETURN_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.view_TranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TranTableAdapter = new BD_NET_Project.DataSetTableAdapters.View_TranTableAdapter();
            this.view_TranDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_LIB_TRANSACTIONLabel = new System.Windows.Forms.Label();
            iD_BOOKLabel = new System.Windows.Forms.Label();
            iD_USERLabel = new System.Windows.Forms.Label();
            tRANSACTION_DATELabel = new System.Windows.Forms.Label();
            rETURN_DATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_TRANSACTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_TRANSACTIONBindingNavigator)).BeginInit();
            this.lIB_TRANSACTIONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_TranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TranDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIB_TRANSACTIONBindingSource
            // 
            this.lIB_TRANSACTIONBindingSource.DataMember = "LIB_TRANSACTION";
            this.lIB_TRANSACTIONBindingSource.DataSource = this.dataSet;
            // 
            // lIB_TRANSACTIONTableAdapter
            // 
            this.lIB_TRANSACTIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.LIB_TRANSACTIONTableAdapter = this.lIB_TRANSACTIONTableAdapter;
            this.tableAdapterManager.PUBLISHING_HOUSESTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_NET_Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // lIB_TRANSACTIONBindingNavigator
            // 
            this.lIB_TRANSACTIONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lIB_TRANSACTIONBindingNavigator.BindingSource = this.lIB_TRANSACTIONBindingSource;
            this.lIB_TRANSACTIONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lIB_TRANSACTIONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lIB_TRANSACTIONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lIB_TRANSACTIONBindingNavigatorSaveItem});
            this.lIB_TRANSACTIONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lIB_TRANSACTIONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lIB_TRANSACTIONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lIB_TRANSACTIONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lIB_TRANSACTIONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lIB_TRANSACTIONBindingNavigator.Name = "lIB_TRANSACTIONBindingNavigator";
            this.lIB_TRANSACTIONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lIB_TRANSACTIONBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.lIB_TRANSACTIONBindingNavigator.TabIndex = 0;
            this.lIB_TRANSACTIONBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lIB_TRANSACTIONBindingNavigatorSaveItem
            // 
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lIB_TRANSACTIONBindingNavigatorSaveItem.Image")));
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.Name = "lIB_TRANSACTIONBindingNavigatorSaveItem";
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.Text = "Save Data";
            this.lIB_TRANSACTIONBindingNavigatorSaveItem.Click += new System.EventHandler(this.lIB_TRANSACTIONBindingNavigatorSaveItem_Click);
            // 
            // iD_LIB_TRANSACTIONLabel
            // 
            iD_LIB_TRANSACTIONLabel.AutoSize = true;
            iD_LIB_TRANSACTIONLabel.Location = new System.Drawing.Point(9, 41);
            iD_LIB_TRANSACTIONLabel.Name = "iD_LIB_TRANSACTIONLabel";
            iD_LIB_TRANSACTIONLabel.Size = new System.Drawing.Size(120, 13);
            iD_LIB_TRANSACTIONLabel.TabIndex = 1;
            iD_LIB_TRANSACTIONLabel.Text = "ID LIB TRANSACTION:";
            // 
            // iD_LIB_TRANSACTIONTextBox
            // 
            this.iD_LIB_TRANSACTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIB_TRANSACTIONBindingSource, "ID_LIB_TRANSACTION", true));
            this.iD_LIB_TRANSACTIONTextBox.Location = new System.Drawing.Point(135, 38);
            this.iD_LIB_TRANSACTIONTextBox.Name = "iD_LIB_TRANSACTIONTextBox";
            this.iD_LIB_TRANSACTIONTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_LIB_TRANSACTIONTextBox.TabIndex = 2;
            // 
            // iD_BOOKLabel
            // 
            iD_BOOKLabel.AutoSize = true;
            iD_BOOKLabel.Location = new System.Drawing.Point(9, 67);
            iD_BOOKLabel.Name = "iD_BOOKLabel";
            iD_BOOKLabel.Size = new System.Drawing.Size(54, 13);
            iD_BOOKLabel.TabIndex = 3;
            iD_BOOKLabel.Text = "ID BOOK:";
            // 
            // iD_BOOKTextBox
            // 
            this.iD_BOOKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIB_TRANSACTIONBindingSource, "ID_BOOK", true));
            this.iD_BOOKTextBox.Location = new System.Drawing.Point(135, 64);
            this.iD_BOOKTextBox.Name = "iD_BOOKTextBox";
            this.iD_BOOKTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_BOOKTextBox.TabIndex = 4;
            // 
            // iD_USERLabel
            // 
            iD_USERLabel.AutoSize = true;
            iD_USERLabel.Location = new System.Drawing.Point(9, 93);
            iD_USERLabel.Name = "iD_USERLabel";
            iD_USERLabel.Size = new System.Drawing.Size(54, 13);
            iD_USERLabel.TabIndex = 5;
            iD_USERLabel.Text = "ID USER:";
            // 
            // iD_USERTextBox
            // 
            this.iD_USERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIB_TRANSACTIONBindingSource, "ID_USER", true));
            this.iD_USERTextBox.Location = new System.Drawing.Point(135, 90);
            this.iD_USERTextBox.Name = "iD_USERTextBox";
            this.iD_USERTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_USERTextBox.TabIndex = 6;
            // 
            // tRANSACTION_DATELabel
            // 
            tRANSACTION_DATELabel.AutoSize = true;
            tRANSACTION_DATELabel.Location = new System.Drawing.Point(9, 120);
            tRANSACTION_DATELabel.Name = "tRANSACTION_DATELabel";
            tRANSACTION_DATELabel.Size = new System.Drawing.Size(119, 13);
            tRANSACTION_DATELabel.TabIndex = 7;
            tRANSACTION_DATELabel.Text = "TRANSACTION DATE:";
            // 
            // tRANSACTION_DATEDateTimePicker
            // 
            this.tRANSACTION_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lIB_TRANSACTIONBindingSource, "TRANSACTION_DATE", true));
            this.tRANSACTION_DATEDateTimePicker.Location = new System.Drawing.Point(135, 116);
            this.tRANSACTION_DATEDateTimePicker.Name = "tRANSACTION_DATEDateTimePicker";
            this.tRANSACTION_DATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tRANSACTION_DATEDateTimePicker.TabIndex = 8;
            // 
            // rETURN_DATELabel
            // 
            rETURN_DATELabel.AutoSize = true;
            rETURN_DATELabel.Location = new System.Drawing.Point(9, 146);
            rETURN_DATELabel.Name = "rETURN_DATELabel";
            rETURN_DATELabel.Size = new System.Drawing.Size(88, 13);
            rETURN_DATELabel.TabIndex = 9;
            rETURN_DATELabel.Text = "RETURN DATE:";
            // 
            // rETURN_DATEDateTimePicker
            // 
            this.rETURN_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lIB_TRANSACTIONBindingSource, "RETURN_DATE", true));
            this.rETURN_DATEDateTimePicker.Location = new System.Drawing.Point(135, 142);
            this.rETURN_DATEDateTimePicker.Name = "rETURN_DATEDateTimePicker";
            this.rETURN_DATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rETURN_DATEDateTimePicker.TabIndex = 10;
            // 
            // view_TranBindingSource
            // 
            this.view_TranBindingSource.DataMember = "View_Tran";
            this.view_TranBindingSource.DataSource = this.dataSet;
            // 
            // view_TranTableAdapter
            // 
            this.view_TranTableAdapter.ClearBeforeFill = true;
            // 
            // view_TranDataGridView
            // 
            this.view_TranDataGridView.AutoGenerateColumns = false;
            this.view_TranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_TranDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.view_TranDataGridView.DataSource = this.view_TranBindingSource;
            this.view_TranDataGridView.Location = new System.Drawing.Point(12, 196);
            this.view_TranDataGridView.Name = "view_TranDataGridView";
            this.view_TranDataGridView.Size = new System.Drawing.Size(644, 220);
            this.view_TranDataGridView.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(350, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Książka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Użytkownik:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(112, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TITLE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tytuł";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_LIB_TRANSACTION";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numer wypożyczenia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TRANSACTION_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data wypożyczenia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RETURN_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data zwrotu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FIRST_NAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "Imię czytelnika";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LAST_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nazwisko czytelnika";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.view_TranDataGridView);
            this.Controls.Add(iD_LIB_TRANSACTIONLabel);
            this.Controls.Add(this.iD_LIB_TRANSACTIONTextBox);
            this.Controls.Add(iD_BOOKLabel);
            this.Controls.Add(this.iD_BOOKTextBox);
            this.Controls.Add(iD_USERLabel);
            this.Controls.Add(this.iD_USERTextBox);
            this.Controls.Add(tRANSACTION_DATELabel);
            this.Controls.Add(this.tRANSACTION_DATEDateTimePicker);
            this.Controls.Add(rETURN_DATELabel);
            this.Controls.Add(this.rETURN_DATEDateTimePicker);
            this.Controls.Add(this.lIB_TRANSACTIONBindingNavigator);
            this.Name = "TransactionManagement";
            this.Text = "TransactionManagement";
            this.Load += new System.EventHandler(this.TransactionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_TRANSACTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_TRANSACTIONBindingNavigator)).EndInit();
            this.lIB_TRANSACTIONBindingNavigator.ResumeLayout(false);
            this.lIB_TRANSACTIONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_TranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TranDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource lIB_TRANSACTIONBindingSource;
        private DataSetTableAdapters.LIB_TRANSACTIONTableAdapter lIB_TRANSACTIONTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lIB_TRANSACTIONBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lIB_TRANSACTIONBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_LIB_TRANSACTIONTextBox;
        private System.Windows.Forms.TextBox iD_BOOKTextBox;
        private System.Windows.Forms.TextBox iD_USERTextBox;
        private System.Windows.Forms.DateTimePicker tRANSACTION_DATEDateTimePicker;
        private System.Windows.Forms.DateTimePicker rETURN_DATEDateTimePicker;
        private System.Windows.Forms.BindingSource view_TranBindingSource;
        private DataSetTableAdapters.View_TranTableAdapter view_TranTableAdapter;
        private System.Windows.Forms.DataGridView view_TranDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}