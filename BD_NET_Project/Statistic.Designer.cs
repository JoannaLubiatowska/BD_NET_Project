namespace BD_NET_Project
{
    partial class Statistic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTransaciotnMonth = new System.Windows.Forms.TextBox();
            this.textBoxTransaciotnWeek = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba wypożyczeń w ostatnim miesiącu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba wypożyczeń w ostatnim tygodniu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Liczba użytkowników";
            // 
            // textBoxTransaciotnMonth
            // 
            this.textBoxTransaciotnMonth.Enabled = false;
            this.textBoxTransaciotnMonth.Location = new System.Drawing.Point(308, 31);
            this.textBoxTransaciotnMonth.Name = "textBoxTransaciotnMonth";
            this.textBoxTransaciotnMonth.Size = new System.Drawing.Size(180, 20);
            this.textBoxTransaciotnMonth.TabIndex = 4;
            // 
            // textBoxTransaciotnWeek
            // 
            this.textBoxTransaciotnWeek.Enabled = false;
            this.textBoxTransaciotnWeek.Location = new System.Drawing.Point(308, 72);
            this.textBoxTransaciotnWeek.Name = "textBoxTransaciotnWeek";
            this.textBoxTransaciotnWeek.Size = new System.Drawing.Size(180, 20);
            this.textBoxTransaciotnWeek.TabIndex = 5;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(308, 111);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(180, 20);
            this.textBoxUser.TabIndex = 6;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 165);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxTransaciotnWeek);
            this.Controls.Add(this.textBoxTransaciotnMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistic";
            this.Text = "Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTransaciotnMonth;
        private System.Windows.Forms.TextBox textBoxTransaciotnWeek;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}