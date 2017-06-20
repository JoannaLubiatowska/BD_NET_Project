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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTransaciotnMonth = new System.Windows.Forms.TextBox();
            this.textBoxTransaciotnWeek = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.dataSet = new BD_NET_Project.DataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new BD_NET_Project.DataSetTableAdapters.USERSTableAdapter();
            this.lIBTRANSACTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIB_TRANSACTIONTableAdapter = new BD_NET_Project.DataSetTableAdapters.LIB_TRANSACTIONTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBTRANSACTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.dataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // lIBTRANSACTIONBindingSource
            // 
            this.lIBTRANSACTIONBindingSource.DataMember = "LIB_TRANSACTION";
            this.lIBTRANSACTIONBindingSource.DataSource = this.dataSet;
            // 
            // lIB_TRANSACTIONTableAdapter
            // 
            this.lIB_TRANSACTIONTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.uSERSBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 160);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Liczba użytkowników";
            series1.YValueMembers = "ID_USER";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(473, 135);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 317);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxTransaciotnWeek);
            this.Controls.Add(this.textBoxTransaciotnMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistic";
            this.Text = "Statystyki";
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBTRANSACTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private DataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.BindingSource lIBTRANSACTIONBindingSource;
        private DataSetTableAdapters.LIB_TRANSACTIONTableAdapter lIB_TRANSACTIONTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}