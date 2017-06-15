namespace BD_NET_Project
{
    partial class MainAdminWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonPublishing = new System.Windows.Forms.Button();
            this.buttonSection = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTransactionStatistic = new System.Windows.Forms.Button();
            this.buttonUserStatistic = new System.Windows.Forms.Button();
            this.buttonPublishingStatistic = new System.Windows.Forms.Button();
            this.buttonSectionStatistic = new System.Windows.Forms.Button();
            this.buttonAuthorStatistic = new System.Windows.Forms.Button();
            this.buttonBookStatistic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTransaction);
            this.groupBox1.Controls.Add(this.buttonUser);
            this.groupBox1.Controls.Add(this.buttonPublishing);
            this.groupBox1.Controls.Add(this.buttonSection);
            this.groupBox1.Controls.Add(this.buttonAuthor);
            this.groupBox1.Controls.Add(this.buttonBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzaj Tabelami";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(21, 34);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(98, 23);
            this.buttonBook.TabIndex = 0;
            this.buttonBook.Text = "Książki";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Location = new System.Drawing.Point(21, 63);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(98, 23);
            this.buttonAuthor.TabIndex = 1;
            this.buttonAuthor.Text = "Autorzy";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // buttonPublishing
            // 
            this.buttonPublishing.Location = new System.Drawing.Point(21, 121);
            this.buttonPublishing.Name = "buttonPublishing";
            this.buttonPublishing.Size = new System.Drawing.Size(98, 23);
            this.buttonPublishing.TabIndex = 3;
            this.buttonPublishing.Text = "Wydawnictwa";
            this.buttonPublishing.UseVisualStyleBackColor = true;
            this.buttonPublishing.Click += new System.EventHandler(this.buttonPublishing_Click);
            // 
            // buttonSection
            // 
            this.buttonSection.Location = new System.Drawing.Point(21, 92);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(98, 23);
            this.buttonSection.TabIndex = 2;
            this.buttonSection.Text = "Działy";
            this.buttonSection.UseVisualStyleBackColor = true;
            this.buttonSection.Click += new System.EventHandler(this.buttonSection_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Location = new System.Drawing.Point(21, 179);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(98, 23);
            this.buttonTransaction.TabIndex = 5;
            this.buttonTransaction.Text = "Wypożyczenia";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(21, 150);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(98, 23);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Czytelnicy";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTransactionStatistic);
            this.groupBox2.Controls.Add(this.buttonUserStatistic);
            this.groupBox2.Controls.Add(this.buttonPublishingStatistic);
            this.groupBox2.Controls.Add(this.buttonSectionStatistic);
            this.groupBox2.Controls.Add(this.buttonAuthorStatistic);
            this.groupBox2.Controls.Add(this.buttonBookStatistic);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statystyki";
            // 
            // buttonTransactionStatistic
            // 
            this.buttonTransactionStatistic.Location = new System.Drawing.Point(21, 179);
            this.buttonTransactionStatistic.Name = "buttonTransactionStatistic";
            this.buttonTransactionStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonTransactionStatistic.TabIndex = 5;
            this.buttonTransactionStatistic.Text = "Wypożyczenia";
            this.buttonTransactionStatistic.UseVisualStyleBackColor = true;
            this.buttonTransactionStatistic.Click += new System.EventHandler(this.buttonTransactionStatistic_Click);
            // 
            // buttonUserStatistic
            // 
            this.buttonUserStatistic.Location = new System.Drawing.Point(21, 150);
            this.buttonUserStatistic.Name = "buttonUserStatistic";
            this.buttonUserStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonUserStatistic.TabIndex = 4;
            this.buttonUserStatistic.Text = "Czytelnicy";
            this.buttonUserStatistic.UseVisualStyleBackColor = true;
            this.buttonUserStatistic.Click += new System.EventHandler(this.buttonUserStatistic_Click);
            // 
            // buttonPublishingStatistic
            // 
            this.buttonPublishingStatistic.Location = new System.Drawing.Point(21, 121);
            this.buttonPublishingStatistic.Name = "buttonPublishingStatistic";
            this.buttonPublishingStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonPublishingStatistic.TabIndex = 3;
            this.buttonPublishingStatistic.Text = "Wydawnictwa";
            this.buttonPublishingStatistic.UseVisualStyleBackColor = true;
            this.buttonPublishingStatistic.Click += new System.EventHandler(this.buttonPublishingStatistic_Click);
            // 
            // buttonSectionStatistic
            // 
            this.buttonSectionStatistic.Location = new System.Drawing.Point(21, 92);
            this.buttonSectionStatistic.Name = "buttonSectionStatistic";
            this.buttonSectionStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonSectionStatistic.TabIndex = 2;
            this.buttonSectionStatistic.Text = "Działy";
            this.buttonSectionStatistic.UseVisualStyleBackColor = true;
            this.buttonSectionStatistic.Click += new System.EventHandler(this.buttonSectionStatistic_Click);
            // 
            // buttonAuthorStatistic
            // 
            this.buttonAuthorStatistic.Location = new System.Drawing.Point(21, 63);
            this.buttonAuthorStatistic.Name = "buttonAuthorStatistic";
            this.buttonAuthorStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonAuthorStatistic.TabIndex = 1;
            this.buttonAuthorStatistic.Text = "Autorzy";
            this.buttonAuthorStatistic.UseVisualStyleBackColor = true;
            this.buttonAuthorStatistic.Click += new System.EventHandler(this.buttonAuthorStatistic_Click);
            // 
            // buttonBookStatistic
            // 
            this.buttonBookStatistic.Location = new System.Drawing.Point(21, 34);
            this.buttonBookStatistic.Name = "buttonBookStatistic";
            this.buttonBookStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonBookStatistic.TabIndex = 0;
            this.buttonBookStatistic.Text = "Książki";
            this.buttonBookStatistic.UseVisualStyleBackColor = true;
            this.buttonBookStatistic.Click += new System.EventHandler(this.buttonBookStatistic_Click);
            // 
            // MainAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainAdminWindow";
            this.Text = "MainAdminWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonPublishing;
        private System.Windows.Forms.Button buttonSection;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTransactionStatistic;
        private System.Windows.Forms.Button buttonUserStatistic;
        private System.Windows.Forms.Button buttonPublishingStatistic;
        private System.Windows.Forms.Button buttonSectionStatistic;
        private System.Windows.Forms.Button buttonAuthorStatistic;
        private System.Windows.Forms.Button buttonBookStatistic;
    }
}