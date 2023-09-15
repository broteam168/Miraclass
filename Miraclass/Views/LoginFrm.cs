using DevExpress.XtraEditors;
using Miraclass.Controllers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Views
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        LoginController cls; 
        public LoginFrm()
        {
            InitializeComponent();
            cls = new LoginController();
            if (!Miraclass.Properties.Settings.Default.userRemember.Equals(""))
            {
                String[] remember = Miraclass.Properties.Settings.Default.userRemember.Split('|');
                txtUser.Text = remember[0];
                txtPass.Text = remember[1];
                checkEdit1.Checked = true;
            }
        }

        private void cmdConfig_Click(object sender, EventArgs e)
        {
            ConfigFrm frm = new ConfigFrm();
            frm.ShowDialog();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Please enter all fields!", "Notification");
                return;
            }    
            S_User currentUser = cls.getUser(txtUser.Text,txtPass.Text);
            if (currentUser == null)
            {
                MessageBox.Show("Login failed please check again!");
            }
            else
            {
                //MessageBox.Show("Login Success!");

                if (isRemember)
                {
                    Miraclass.Properties.Settings.Default.userRemember = txtUser.Text + "|" + txtPass.Text;
                    Miraclass.Properties.Settings.Default.Save();
                }
                else
                {
                    Miraclass.Properties.Settings.Default.userRemember = "";
                    Miraclass.Properties.Settings.Default.Save();
                }
                if (currentUser.isTeacher)
                {
                    this.Hide();
                    TeacherDashboard frm = new TeacherDashboard(currentUser);
                    frm.ShowDialog();
                    this.Show();

                }
                else
                {
                    this.Hide();
                    StudentDashboard frm = new StudentDashboard(currentUser);
                    frm.ShowDialog();
                    this.Show();
                } 
                if(!isRemember)
                {
                    txtUser.Text = "";
                    txtPass.Text = "";
                }    
            
            }
        }
        bool isRemember = false;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            isRemember = checkEdit1.Checked;
        }
    }
}