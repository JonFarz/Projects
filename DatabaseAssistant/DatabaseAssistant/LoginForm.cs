using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Functions;
using System.Security;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        private Login NL = new Login();
        private SecureString d = new SecureString();

        public LoginForm()
        {
              InitializeComponent();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            if (UserNameTxtBox.TextLength == 0 || PasswordTxtBox.TextLength == 0)
            {
                MessageBox.Show("Please Fill out both the User Name and Password Fields Before continuing", "Invalid Attempt");
            }
            else
            {
               // MainScreen MS = new MainScreen();
               // MS.Show();
                d.MakeReadOnly();

                if (NL.ValidateLogin(UserNameTxtBox.Text, d) == true)
                {
                    ActiveForm.Hide();
                    MainScreen MS = new MainScreen();
                    //MS.SetLogin(NL);
                    MS.Show();
                    d.Dispose();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials Please Try Again", "Failure Login In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTxtBox.Clear();
                    UserNameTxtBox.Clear();
                    d.Clear();
                }
            }
        }

        private void PWordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                d.RemoveAt(PasswordTxtBox.TextLength);
            }
            else
            {
                d.AppendChar(e.KeyChar);
            }
        }
    }
}
