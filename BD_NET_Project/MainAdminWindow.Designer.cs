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
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonPublishing = new System.Windows.Forms.Button();
            this.buttonSection = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonBD = new System.Windows.Forms.Button();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBD);
            this.groupBox2.Controls.Add(this.buttonStatistic);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inne";
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Location = new System.Drawing.Point(21, 34);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(98, 23);
            this.buttonStatistic.TabIndex = 4;
            this.buttonStatistic.Text = "Statystyki";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonBD
            // 
            this.buttonBD.Location = new System.Drawing.Point(21, 121);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(98, 81);
            this.buttonBD.TabIndex = 5;
            this.buttonBD.Text = "Skasuj starą \r\nbazę danych\r\ni inicjalizuj\r\nnową";
            this.buttonBD.UseVisualStyleBackColor = true;
            this.buttonBD.Click += new System.EventHandler(this.buttonBD_Click);
            // 
            // MainAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainAdminWindow";
            this.Text = "Okno główne administratora";
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
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonBD;
    }
}