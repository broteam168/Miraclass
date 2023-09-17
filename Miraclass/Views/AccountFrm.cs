using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
using Miraclass.Libs;

namespace Miraclass.Views
{
    public partial class AccountFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;

        private UserControler cls;
        public AccountFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;

        }
        private bool t, s, x, r;
        private void AccountFrm_Load(object sender, EventArgs e)
        {
            cls = new UserControler();

            gridUser.DataSource = cls.list();

            cbGroup.Properties.DataSource = cls.listGroup();

            FunctionMain funnction = new FunctionMain();
            List<string> menus = funnction.getMenuByUser(_currentUser.userGroup, "cmd", 21);
            foreach (string item in menus)
            {

                SimpleButton ctl = this.Controls.Find(item, true).FirstOrDefault() as SimpleButton;
                ctl.Enabled = true;
            }

            t = cmdAdd.Enabled;
            s = cmdEdit.Enabled;
            x = cmdDelete.Enabled;
            r = cmdRemovePass.Enabled;
            setStatus(true);
        }
        private void setStatus(bool enable)
        {
            if (enable)
            {
                if (t)
                    cmdAdd.Enabled = enable;
                if (s)
                    cmdEdit.Enabled = enable;
                if (x)
                    cmdDelete.Enabled = enable;
                if(r) 
                    cmdRemovePass.Enabled = enable;
            }
            else
            {
                cmdAdd.Enabled = enable;
                cmdEdit.Enabled = enable;
                cmdDelete.Enabled = enable;
                cmdRemovePass.Enabled = enable;
            }
            

            cmdSave.Enabled = !enable;
            cmdCancel.Enabled = !enable;
            txtUser.Enabled = !enable;
            txtPhone.Enabled = !enable;
            txtFullName.Enabled = !enable;

            checkActive.Enabled = !enable;
            checkTeacher.Enabled = !enable;
            cbGroup.Enabled = !enable;
            gridUser.Enabled = enable;
        }
        private string action = "";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            action = "ADD";
            setStatus(false);

            txtFullName.Text = "";
            txtUser.Text = "";
            txtPhone.Text = "";

        }
        private int _id;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _id = int.Parse(gridView1.GetFocusedRowCellValue("userId").ToString());
                txtUser.Text = gridView1.GetFocusedRowCellValue("userName").ToString();
                txtFullName.Text = gridView1.GetFocusedRowCellValue("userFullName").ToString();
                txtPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
               
                checkActive.Checked = gridView1.GetFocusedRowCellValue("isActive").ToString() == "True";
                checkTeacher.Checked = gridView1.GetFocusedRowCellValue("isTeacher").ToString() == "True";

                cbGroup.EditValue = int.Parse(gridView1.GetFocusedRowCellValue("userGroup").ToString());
            }
            catch (Exception)
            {

               
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            setStatus(true);
        }

        private void cmdRemovePass_Click(object sender, EventArgs e)
        {
            try
            {
                cls.clearPass(_id);
                MessageBox.Show("Reset password successfully. Now password is same as name");
            }
            catch (Exception)
            {

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals("") || txtUser.Text.Equals("") || txtPhone.Text.Equals("") || cbGroup.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Please enter all fields","Warning");
                setStatus(true);
                return;
            }

            S_User obj = new S_User();
            obj.userName = txtUser.Text.Trim();
            obj.userFullName = txtFullName.Text;
            obj.Phone = txtPhone.Text;
            obj.isActive = checkActive.Checked;
            obj.isTeacher = checkTeacher.Checked;
            obj.userGroup = int.Parse(cbGroup.EditValue.ToString());
            if(action == "EDIT")
            {
                obj.userId = _id;
                cls.update(obj);
            }    
            else if(!cls.checkExists(obj.userName))
            {
                obj.userPassword = cls.EncodeMD5(obj.userName);
                cls.add(obj);
            }    
            else
            {
                MessageBox.Show("The username existed!!!");
                txtUser.Focus();
                return;
            }
            MessageBox.Show("Update successfully");
            gridUser.DataSource = cls.list();
            setStatus(true);

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            action = "EDIT";
            setStatus(false);
            txtUser.Enabled = false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cls.delete(_id);
                gridUser.DataSource = cls.list();
                MessageBox.Show("Delete success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur");
            }
        }
    }
}