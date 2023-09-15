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
    public partial class passwordFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User currentUser;
        ChangePasswordController cls;
        public passwordFrm(S_User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            cls = new ChangePasswordController();
        }
        private bool isChanged = false;
        public bool getStatus()
        {
            return isChanged;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(textEdit1.Text.Equals("")||textEdit2.Text.Equals("")||textEdit3.Text.Equals(""))
            {
                MessageBox.Show("Please enter all field");
                return;
            }    
            if(!textEdit2.Text.Equals(textEdit3.Text))
            {
                MessageBox.Show("New password is not match");
                return;
            }    
            if(!cls.EncodeMD5(textEdit1.Text).Equals(currentUser.userPassword))
            {
                MessageBox.Show("Old password is not match");
                return;
            }
            if(textEdit2.Text.Equals(textEdit1.Text))
            {
                MessageBox.Show("Password is used. Please try again!");
                return;
            }    
            cls.updatePassword(currentUser.userId, textEdit2.Text);
            isChanged = true;
            MessageBox.Show("Update Success");
            this.Close();
        }
    }
}