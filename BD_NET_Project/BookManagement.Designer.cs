namespace BD_NET_Project
{
    partial class BookManagement
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
            System.Windows.Forms.Label tITLELabel;
            System.Windows.Forms.Label iD_AUTHORLabel;
            System.Windows.Forms.Label iD_PUBLISHING_HOUSELabel;
            System.Windows.Forms.Label pUBLICATION_YEARLabel;
            System.Windows.Forms.Label iD_SECTIONLabel;
            System.Windows.Forms.Label bOOK_DESCRIPTIONLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagement));
            this.dataSet = new BD_NET_Project.DataSet();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new BD_NET_Project.DataSetTableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new BD_NET_Project.DataSetTableAdapters.TableAdapterManager();
            this.bOOKSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bOOKSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tITLETextBox = new System.Windows.Forms.TextBox();
            this.iD_AUTHORTextBox = new System.Windows.Forms.TextBox();
            this.iD_PUBLISHING_HOUSETextBox = new System.Windows.Forms.TextBox();
            this.pUBLICATION_YEARTextBox = new System.Windows.Forms.TextBox();
            this.iD_SECTIONTextBox = new System.Windows.Forms.TextBox();
            this.bOOK_DESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.cOVERPictureBox = new System.Windows.Forms.PictureBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            tITLELabel = new System.Windows.Forms.Label();
            iD_AUTHORLabel = new System.Windows.Forms.Label();
            iD_PUBLISHING_HOUSELabel = new System.Windows.Forms.Label();
            pUBLICATION_YEARLabel = new System.Windows.Forms.Label();
            iD_SECTIONLabel = new System.Windows.Forms.Label();
            bOOK_DESCRIPTIONLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingNavigator)).BeginInit();
            this.bOOKSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOVERPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tITLELabel
            // 
            tITLELabel.AutoSize = true;
            tITLELabel.Location = new System.Drawing.Point(19, 107);
            tITLELabel.Name = "tITLELabel";
            tITLELabel.Size = new System.Drawing.Size(40, 13);
            tITLELabel.TabIndex = 3;
            tITLELabel.Text = "TITLE:";
            // 
            // iD_AUTHORLabel
            // 
            iD_AUTHORLabel.AutoSize = true;
            iD_AUTHORLabel.Location = new System.Drawing.Point(19, 133);
            iD_AUTHORLabel.Name = "iD_AUTHORLabel";
            iD_AUTHORLabel.Size = new System.Drawing.Size(70, 13);
            iD_AUTHORLabel.TabIndex = 5;
            iD_AUTHORLabel.Text = "ID AUTHOR:";
            // 
            // iD_PUBLISHING_HOUSELabel
            // 
            iD_PUBLISHING_HOUSELabel.AutoSize = true;
            iD_PUBLISHING_HOUSELabel.Location = new System.Drawing.Point(19, 159);
            iD_PUBLISHING_HOUSELabel.Name = "iD_PUBLISHING_HOUSELabel";
            iD_PUBLISHING_HOUSELabel.Size = new System.Drawing.Size(130, 13);
            iD_PUBLISHING_HOUSELabel.TabIndex = 7;
            iD_PUBLISHING_HOUSELabel.Text = "ID PUBLISHING HOUSE:";
            // 
            // pUBLICATION_YEARLabel
            // 
            pUBLICATION_YEARLabel.AutoSize = true;
            pUBLICATION_YEARLabel.Location = new System.Drawing.Point(19, 185);
            pUBLICATION_YEARLabel.Name = "pUBLICATION_YEARLabel";
            pUBLICATION_YEARLabel.Size = new System.Drawing.Size(113, 13);
            pUBLICATION_YEARLabel.TabIndex = 9;
            pUBLICATION_YEARLabel.Text = "PUBLICATION YEAR:";
            // 
            // iD_SECTIONLabel
            // 
            iD_SECTIONLabel.AutoSize = true;
            iD_SECTIONLabel.Location = new System.Drawing.Point(19, 211);
            iD_SECTIONLabel.Name = "iD_SECTIONLabel";
            iD_SECTIONLabel.Size = new System.Drawing.Size(71, 13);
            iD_SECTIONLabel.TabIndex = 11;
            iD_SECTIONLabel.Text = "ID SECTION:";
            // 
            // bOOK_DESCRIPTIONLabel
            // 
            bOOK_DESCRIPTIONLabel.AutoSize = true;
            bOOK_DESCRIPTIONLabel.Location = new System.Drawing.Point(19, 237);
            bOOK_DESCRIPTIONLabel.Name = "bOOK_DESCRIPTIONLabel";
            bOOK_DESCRIPTIONLabel.Size = new System.Drawing.Size(116, 13);
            bOOK_DESCRIPTIONLabel.TabIndex = 13;
            bOOK_DESCRIPTIONLabel.Text = "BOOK DESCRIPTION:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(19, 263);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 17;
            iSBNLabel.Text = "ISBN:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.LIB_TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.PUBLISHING_HOUSESTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_NET_Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // bOOKSBindingNavigator
            // 
            this.bOOKSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bOOKSBindingNavigator.BindingSource = this.bOOKSBindingSource;
            this.bOOKSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bOOKSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bOOKSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bOOKSBindingNavigatorSaveItem});
            this.bOOKSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bOOKSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bOOKSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bOOKSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bOOKSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bOOKSBindingNavigator.Name = "bOOKSBindingNavigator";
            this.bOOKSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bOOKSBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.bOOKSBindingNavigator.TabIndex = 0;
            this.bOOKSBindingNavigator.Text = "bindingNavigator1";
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
            // bOOKSBindingNavigatorSaveItem
            // 
            this.bOOKSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOOKSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKSBindingNavigatorSaveItem.Image")));
            this.bOOKSBindingNavigatorSaveItem.Name = "bOOKSBindingNavigatorSaveItem";
            this.bOOKSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bOOKSBindingNavigatorSaveItem.Text = "Save Data";
            this.bOOKSBindingNavigatorSaveItem.Click += new System.EventHandler(this.bOOKSBindingNavigatorSaveItem_Click);
            // 
            // tITLETextBox
            // 
            this.tITLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "TITLE", true));
            this.tITLETextBox.Location = new System.Drawing.Point(155, 104);
            this.tITLETextBox.Name = "tITLETextBox";
            this.tITLETextBox.Size = new System.Drawing.Size(100, 20);
            this.tITLETextBox.TabIndex = 4;
            // 
            // iD_AUTHORTextBox
            // 
            this.iD_AUTHORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ID_AUTHOR", true));
            this.iD_AUTHORTextBox.Location = new System.Drawing.Point(155, 130);
            this.iD_AUTHORTextBox.Name = "iD_AUTHORTextBox";
            this.iD_AUTHORTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_AUTHORTextBox.TabIndex = 6;
            // 
            // iD_PUBLISHING_HOUSETextBox
            // 
            this.iD_PUBLISHING_HOUSETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ID_PUBLISHING_HOUSE", true));
            this.iD_PUBLISHING_HOUSETextBox.Location = new System.Drawing.Point(155, 156);
            this.iD_PUBLISHING_HOUSETextBox.Name = "iD_PUBLISHING_HOUSETextBox";
            this.iD_PUBLISHING_HOUSETextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PUBLISHING_HOUSETextBox.TabIndex = 8;
            // 
            // pUBLICATION_YEARTextBox
            // 
            this.pUBLICATION_YEARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PUBLICATION_YEAR", true));
            this.pUBLICATION_YEARTextBox.Location = new System.Drawing.Point(155, 182);
            this.pUBLICATION_YEARTextBox.Name = "pUBLICATION_YEARTextBox";
            this.pUBLICATION_YEARTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUBLICATION_YEARTextBox.TabIndex = 10;
            // 
            // iD_SECTIONTextBox
            // 
            this.iD_SECTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ID_SECTION", true));
            this.iD_SECTIONTextBox.Location = new System.Drawing.Point(155, 208);
            this.iD_SECTIONTextBox.Name = "iD_SECTIONTextBox";
            this.iD_SECTIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_SECTIONTextBox.TabIndex = 12;
            // 
            // bOOK_DESCRIPTIONTextBox
            // 
            this.bOOK_DESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "BOOK_DESCRIPTION", true));
            this.bOOK_DESCRIPTIONTextBox.Location = new System.Drawing.Point(155, 234);
            this.bOOK_DESCRIPTIONTextBox.Name = "bOOK_DESCRIPTIONTextBox";
            this.bOOK_DESCRIPTIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.bOOK_DESCRIPTIONTextBox.TabIndex = 14;
            // 
            // cOVERPictureBox
            // 
            this.cOVERPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bOOKSBindingSource, "COVER", true));
            this.cOVERPictureBox.Location = new System.Drawing.Point(270, 59);
            this.cOVERPictureBox.Name = "cOVERPictureBox";
            this.cOVERPictureBox.Size = new System.Drawing.Size(235, 297);
            this.cOVERPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cOVERPictureBox.TabIndex = 16;
            this.cOVERPictureBox.TabStop = false;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(155, 260);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 18;
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(tITLELabel);
            this.Controls.Add(this.tITLETextBox);
            this.Controls.Add(iD_AUTHORLabel);
            this.Controls.Add(this.iD_AUTHORTextBox);
            this.Controls.Add(iD_PUBLISHING_HOUSELabel);
            this.Controls.Add(this.iD_PUBLISHING_HOUSETextBox);
            this.Controls.Add(pUBLICATION_YEARLabel);
            this.Controls.Add(this.pUBLICATION_YEARTextBox);
            this.Controls.Add(iD_SECTIONLabel);
            this.Controls.Add(this.iD_SECTIONTextBox);
            this.Controls.Add(bOOK_DESCRIPTIONLabel);
            this.Controls.Add(this.bOOK_DESCRIPTIONTextBox);
            this.Controls.Add(this.cOVERPictureBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(this.bOOKSBindingNavigator);
            this.Name = "BookManagement";
            this.Text = "BookManagement";
            this.Load += new System.EventHandler(this.BookManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingNavigator)).EndInit();
            this.bOOKSBindingNavigator.ResumeLayout(false);
            this.bOOKSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOVERPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bOOKSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bOOKSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tITLETextBox;
        private System.Windows.Forms.TextBox iD_AUTHORTextBox;
        private System.Windows.Forms.TextBox iD_PUBLISHING_HOUSETextBox;
        private System.Windows.Forms.TextBox pUBLICATION_YEARTextBox;
        private System.Windows.Forms.TextBox iD_SECTIONTextBox;
        private System.Windows.Forms.TextBox bOOK_DESCRIPTIONTextBox;
        private System.Windows.Forms.PictureBox cOVERPictureBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
    }
}