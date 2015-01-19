using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Functions;

namespace WindowsFormsApplication1
{
    public partial class MainScreen : Form
    {
        //private Login L = new Login();
        private DifferentUserApplicationLaunch DUA = new DifferentUserApplicationLaunch();

        /*public void SetLogin(Login T)
        {
            this.L = T;
            DUA.setLogin(this.L);
        }*/
        
        public MainScreen()
        {
            InitializeComponent();
            this.Text = "Welcome to Database Assistant: " + Login.UserName;
        }

        private void BackUpRestoreDropDownSVC(object sender, EventArgs e)
        {

            if (BackupRestoreDropDown.SelectedItem.ToString() == "Backup")
            {
                BackupPanel.Show();
                //RestorePanel.Hide();
            }
            else if (BackupRestoreDropDown.SelectedItem.ToString() == "Backup and Restore")
            {
                BackupPanel.Show();
                RestorePanel.Show();
            }
            else if (BackupRestoreDropDown.SelectedItem.ToString() == "Restore")
            {
                BackupPanel.Hide();
                RestorePanel.Show();
            }
            else 
            {

            }
        }

        private void ServerCombBoxSVC(object sender, EventArgs e)
        {

        }

    }
}
