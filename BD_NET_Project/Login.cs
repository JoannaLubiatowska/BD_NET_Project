using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_NET_Project
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string password;
        string plaintext;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=LIBRARY;Persist Security Info=True;User ID=AdminNET;Password=12345");
            adapter = new SqlDataAdapter();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "MainAdminWindow")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                try
                {
                    DataTable temp = new DataTable();
                    SqlCommand command = new SqlCommand("select * from ADMINS", connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(temp);
                    adapter.Update(temp);
                    password = temp.Rows[0]["ADMIN_LOGIN"].ToString();
                    plaintext = temp.Rows[0]["ADMIN_PASSWORD"].ToString();
                    string encryptedstring = StringCipher.Encrypt(plaintext, password);
                    string decryptedstring = StringCipher.Decrypt(encryptedstring, password);

                    if (textBoxLogin.Text == password && textBoxPassword.Text == decryptedstring)
                    {
                        MainAdminWindow w = new MainAdminWindow();
                        w.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login lub hasło nieprawidłowe. Spróbuj ponownie.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
