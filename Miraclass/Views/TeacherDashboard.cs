using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Miraclass.Libs;
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
    public partial class TeacherDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private S_User _currentUser; 
        public TeacherDashboard(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
            setPermission("");
        }
        public void setPermission(string MenuStr)
        {
            try
            {
                FunctionMain fn = new FunctionMain();
                List<string> list = fn.getMenuByUser(_currentUser.userGroup,"mn",-1);
                foreach (string item in list)
                {
                    System.Console.WriteLine(item);
                    BarItem ctl = ribbon.Manager.Items[item];
                    ctl.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }
        private void loadForm(XtraForm frm)
        {
            try
            {
                foreach (XtraForm f in MdiChildren)
                {
                    if(f.Name == frm.Name)
                    {
                        f.Activate();
                        return;
                    }    
                }
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("errror"+ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RoomFrm frm = new RoomFrm(this._currentUser);
            loadForm(frm);
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddRoomFrm frm = new AddRoomFrm(this._currentUser);
            loadForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            PresentManagerFrm frm = new PresentManagerFrm(this._currentUser);
            loadForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

            AddPresentFrm frm = new AddPresentFrm(this._currentUser);
            loadForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChooseRoom frm = new ChooseRoom(_currentUser);
            frm.ShowDialog();
            P_Room result =  frm.GetRoom();
            if (result == null || result.status == true)
            {
                MessageBox.Show("Cannot start room");
            }
            else
            {
                MainRoomFrm frmL = new MainRoomFrm(result.id,this._currentUser);
                loadForm(frmL);
            } 
                
        }

        private void TeacherDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (XtraForm f in MdiChildren)
                {
                    f.Close();
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show("errror" + ex.Message);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            passwordFrm frm = new passwordFrm(this._currentUser);
            frm.ShowDialog();
            if(frm.getStatus())
            {
                MessageBox.Show("Please login again before continue using");
                this.Close();
            }    
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            userGroupFrm frm = new userGroupFrm(this._currentUser);
            loadForm(frm);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountFrm frm = new AccountFrm(this._currentUser);
            loadForm(frm);
        }

        private void mnOffline_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChooseRoom frm = new ChooseRoom(_currentUser);
            frm.ShowDialog();
            P_Room result = frm.GetRoom();
            if (result == null || result.status == true)
            {
                MessageBox.Show("Cannot start room");
            }
            else
            {
                OfflineFrm frmL = new OfflineFrm(result.id, this._currentUser);
                loadForm(frmL);
            }
        }
    }
}