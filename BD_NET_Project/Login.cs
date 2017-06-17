using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
                string password = "AdminNET";
                string plaintext = "12345";

                string encryptedstring = StringCipher.Encrypt(plaintext, password);
                string decryptedstring = StringCipher.Decrypt(encryptedstring, password);

                if (textBoxLogin.Text == "AdminNET" && textBoxPassword.Text == decryptedstring)
                {
                    MainAdminWindow w = new MainAdminWindow();
                    w.Show();
                }
                else
                {
                    MessageBox.Show("Login lub hasło nieprawidłowe. Spróbuj ponownie.");
                }
            }
        }
    }
}
