using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class StudentDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private S_User _currentUser; 
        public StudentDashboard(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
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
            int result =  frm.GetRoom();
            if(result == -1)
            {
               
            }
            else
            {
                MainRoomFrm frmL = new MainRoomFrm(result,this._currentUser);
                loadForm(frmL);
            } 
                
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            enterRoomFrm frm = new enterRoomFrm(_currentUser);
            frm.ShowDialog();
            int id = frm.getRoomId();
            if (id != 0)
            {
                MiraclassDataContext db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
                if (db.P_Rooms.Where(x => x.id == id).FirstOrDefault().status == true)
                {
                    clientRoomFrm roomFrm = new clientRoomFrm(id, _currentUser);
                    loadForm(roomFrm);
                }
                else MessageBox.Show("Cannot access to a deactived room");
                db.Dispose();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            NoteFrm frm = new NoteFrm(_currentUser);
            loadForm(frm);
        }
    }
}