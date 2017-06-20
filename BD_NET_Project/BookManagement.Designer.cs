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
            System.Windows.Forms.Label tytułLabel;
            System.Windows.Forms.Label imię_autoraLabel;
            System.Windows.Forms.Label nazwisko_autoraLabel;
            System.Windows.Forms.Label wydawnictwoLabel;
            System.Windows.Forms.Label działLabel;
            System.Windows.Forms.Label data_wydaniaLabel;
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagement));
            this.dataSet = new BD_NET_Project.DataSet();
            this.view_BookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_BookTableAdapter = new BD_NET_Project.DataSetTableAdapters.View_BookTableAdapter();
            this.tableAdapterManager = new BD_NET_Project.DataSetTableAdapters.TableAdapterManager();
            this.view_BookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tytułTextBox = new System.Windows.Forms.TextBox();
            this.imię_autoraTextBox = new System.Windows.Forms.TextBox();
            this.nazwisko_autoraTextBox = new System.Windows.Forms.TextBox();
            this.wydawnictwoTextBox = new System.Windows.Forms.TextBox();
            this.działTextBox = new System.Windows.Forms.TextBox();
            this.data_wydaniaTextBox = new System.Windows.Forms.TextBox();
            this.okładkaPictureBox = new System.Windows.Forms.PictureBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            tytułLabel = new System.Windows.Forms.Label();
            imię_autoraLabel = new System.Windows.Forms.Label();
            nazwisko_autoraLabel = new System.Windows.Forms.Label();
            wydawnictwoLabel = new System.Windows.Forms.Label();
            działLabel = new System.Windows.Forms.Label();
            data_wydaniaLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_BookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_BookBindingNavigator)).BeginInit();
            this.view_BookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okładkaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tytułLabel
            // 
            tytułLabel.AutoSize = true;
            tytułLabel.Location = new System.Drawing.Point(12, 71);
            tytułLabel.Name = "tytułLabel";
            tytułLabel.Size = new System.Drawing.Size(35, 13);
            tytułLabel.TabIndex = 1;
            tytułLabel.Text = "Tytuł:";
            // 
            // imię_autoraLabel
            // 
            imię_autoraLabel.AutoSize = true;
            imię_autoraLabel.Location = new System.Drawing.Point(12, 97);
            imię_autoraLabel.Name = "imię_autoraLabel";
            imię_autoraLabel.Size = new System.Drawing.Size(62, 13);
            imię_autoraLabel.TabIndex = 3;
            imię_autoraLabel.Text = "Imię autora:";
            // 
            // nazwisko_autoraLabel
            // 
            nazwisko_autoraLabel.AutoSize = true;
            nazwisko_autoraLabel.Location = new System.Drawing.Point(12, 123);
            nazwisko_autoraLabel.Name = "nazwisko_autoraLabel";
            nazwisko_autoraLabel.Size = new System.Drawing.Size(89, 13);
            nazwisko_autoraLabel.TabIndex = 5;
            nazwisko_autoraLabel.Text = "Nazwisko autora:";
            // 
            // wydawnictwoLabel
            // 
            wydawnictwoLabel.AutoSize = true;
            wydawnictwoLabel.Location = new System.Drawing.Point(12, 149);
            wydawnictwoLabel.Name = "wydawnictwoLabel";
            wydawnictwoLabel.Size = new System.Drawing.Size(77, 13);
            wydawnictwoLabel.TabIndex = 7;
            wydawnictwoLabel.Text = "Wydawnictwo:";
            // 
            // działLabel
            // 
            działLabel.AutoSize = true;
            działLabel.Location = new System.Drawing.Point(12, 175);
            działLabel.Name = "działLabel";
            działLabel.Size = new System.Drawing.Size(35, 13);
            działLabel.TabIndex = 9;
            działLabel.Text = "Dział:";
            // 
            // data_wydaniaLabel
            // 
            data_wydaniaLabel.AutoSize = true;
            data_wydaniaLabel.Location = new System.Drawing.Point(12, 201);
            data_wydaniaLabel.Name = "data_wydaniaLabel";
            data_wydaniaLabel.Size = new System.Drawing.Size(75, 13);
            data_wydaniaLabel.TabIndex = 13;
            data_wydaniaLabel.Text = "Data wydania:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(12, 253);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(31, 13);
            opisLabel.TabIndex = 17;
            opisLabel.Text = "Opis:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(12, 227);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 19;
            iSBNLabel.Text = "ISBN:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_BookBindingSource
            // 
            this.view_BookBindingSource.DataMember = "View_Book";
            this.view_BookBindingSource.DataSource = this.dataSet;
            // 
            // view_BookTableAdapter
            // 
            this.view_BookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LIB_TRANSACTIONTableAdapter = null;
            this.tableAdapterManager.PUBLISHING_HOUSESTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_NET_Project.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // view_BookBindingNavigator
            // 
            this.view_BookBindingNavigator.AddNewItem = null;
            this.view_BookBindingNavigator.BindingSource = this.view_BookBindingSource;
            this.view_BookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_BookBindingNavigator.DeleteItem = null;
            this.view_BookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.view_BookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_BookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_BookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_BookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_BookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_BookBindingNavigator.Name = "view_BookBindingNavigator";
            this.view_BookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_BookBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.view_BookBindingNavigator.TabIndex = 0;
            this.view_BookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // tytułTextBox
            // 
            this.tytułTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Tytuł", true));
            this.tytułTextBox.Location = new System.Drawing.Point(107, 68);
            this.tytułTextBox.Name = "tytułTextBox";
            this.tytułTextBox.Size = new System.Drawing.Size(199, 20);
            this.tytułTextBox.TabIndex = 2;
            // 
            // imię_autoraTextBox
            // 
            this.imię_autoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Imię autora]", true));
            this.imię_autoraTextBox.Location = new System.Drawing.Point(107, 94);
            this.imię_autoraTextBox.Name = "imię_autoraTextBox";
            this.imię_autoraTextBox.Size = new System.Drawing.Size(199, 20);
            this.imię_autoraTextBox.TabIndex = 4;
            // 
            // nazwisko_autoraTextBox
            // 
            this.nazwisko_autoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Nazwisko autora", true));
            this.nazwisko_autoraTextBox.Location = new System.Drawing.Point(107, 120);
            this.nazwisko_autoraTextBox.Name = "nazwisko_autoraTextBox";
            this.nazwisko_autoraTextBox.Size = new System.Drawing.Size(199, 20);
            this.nazwisko_autoraTextBox.TabIndex = 6;
            // 
            // wydawnictwoTextBox
            // 
            this.wydawnictwoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Wydawnictwo", true));
            this.wydawnictwoTextBox.Location = new System.Drawing.Point(107, 146);
            this.wydawnictwoTextBox.Name = "wydawnictwoTextBox";
            this.wydawnictwoTextBox.Size = new System.Drawing.Size(199, 20);
            this.wydawnictwoTextBox.TabIndex = 8;
            // 
            // działTextBox
            // 
            this.działTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Dział", true));
            this.działTextBox.Location = new System.Drawing.Point(107, 172);
            this.działTextBox.Name = "działTextBox";
            this.działTextBox.Size = new System.Drawing.Size(199, 20);
            this.działTextBox.TabIndex = 10;
            // 
            // data_wydaniaTextBox
            // 
            this.data_wydaniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Data wydania", true));
            this.data_wydaniaTextBox.Location = new System.Drawing.Point(107, 198);
            this.data_wydaniaTextBox.Name = "data_wydaniaTextBox";
            this.data_wydaniaTextBox.Size = new System.Drawing.Size(199, 20);
            this.data_wydaniaTextBox.TabIndex = 14;
            // 
            // okładkaPictureBox
            // 
            this.okładkaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.view_BookBindingSource, "Okładka", true));
            this.okładkaPictureBox.Location = new System.Drawing.Point(324, 28);
            this.okładkaPictureBox.Name = "okładkaPictureBox";
            this.okładkaPictureBox.Size = new System.Drawing.Size(227, 329);
            this.okładkaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.okładkaPictureBox.TabIndex = 16;
            this.okładkaPictureBox.TabStop = false;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "Opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(107, 250);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(199, 52);
            this.opisTextBox.TabIndex = 18;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_BookBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(107, 224);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(199, 20);
            this.iSBNTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Dodaj/Edytuj/Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(tytułLabel);
            this.Controls.Add(this.tytułTextBox);
            this.Controls.Add(imię_autoraLabel);
            this.Controls.Add(this.imię_autoraTextBox);
            this.Controls.Add(nazwisko_autoraLabel);
            this.Controls.Add(this.nazwisko_autoraTextBox);
            this.Controls.Add(wydawnictwoLabel);
            this.Controls.Add(this.wydawnictwoTextBox);
            this.Controls.Add(działLabel);
            this.Controls.Add(this.działTextBox);
            this.Controls.Add(data_wydaniaLabel);
            this.Controls.Add(this.data_wydaniaTextBox);
            this.Controls.Add(this.okładkaPictureBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(this.view_BookBindingNavigator);
            this.Name = "BookManagement";
            this.Text = "Książki";
            this.Load += new System.EventHandler(this.BookManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_BookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_BookBindingNavigator)).EndInit();
            this.view_BookBindingNavigator.ResumeLayout(false);
            this.view_BookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okładkaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource view_BookBindingSource;
        private DataSetTableAdapters.View_BookTableAdapter view_BookTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_BookBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tytułTextBox;
        private System.Windows.Forms.TextBox imię_autoraTextBox;
        private System.Windows.Forms.TextBox nazwisko_autoraTextBox;
        private System.Windows.Forms.TextBox wydawnictwoTextBox;
        private System.Windows.Forms.TextBox działTextBox;
        private System.Windows.Forms.TextBox data_wydaniaTextBox;
        private System.Windows.Forms.PictureBox okładkaPictureBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.Button button1;
    }
}