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

namespace Miraclass.Views
{
    public partial class AddRoomFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;

        AddRoomController cls;
        public AddRoomFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
        }
      
        private void gridRoom_Load(object sender, EventArgs e)
        {
            cls = new AddRoomController();

            gridRoom.DataSource = cls.liRoom(_currentUser.userId);

            gridParticipation.DataSource = cls.liAttendance(currentId);

            
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            cls = new AddRoomController();

            gridRoom.DataSource = cls.liRoom(_currentUser.userId);
        }

        private string cmd = "";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (cbAdd.Text.Equals(""))
                return;
            P_Attendance temp = new P_Attendance();
            temp.userId =int.Parse( cbAdd.Text.Split('|')[0]);
            temp.roomId = currentId;
            cls.addUserRoom(temp);
            MessageBox.Show("Add successfully", "Notification");
            cbAdd.Properties.Items.Clear();

            List<S_User> users = cls.liUser(currentId);
            cbAdd.Properties.Items.Clear();
            cbAdd.Text = "";
            foreach (var item in users)
            {
                 cbAdd.Properties.Items.Add(item.userId + "|" + item.userName + "|" + item.userFullName);

            }
            if (users.Count > 0) cbAdd.SelectedIndex = 0;
            gridParticipation.DataSource = cls.liAttendance(currentId);
            
            
        }

      

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            
        }
        private int currentId = 0;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            currentId = int.Parse((gridView1.GetFocusedRowCellValue("id").ToString()));
            gridParticipation.DataSource = cls.liAttendance(currentId);
            cbAdd.Properties.Items.Clear();
            cbAdd.Text = "";

            List<S_User> users = cls.liUser(currentId);
            cbAdd.Properties.Items.Clear();
             foreach (var item in users)
            {
                 cbAdd.Properties.Items.Add(item.userId+"|"+item.userName+"|"+item.userFullName);
               
            }
            if(users.Count>0) cbAdd.SelectedIndex = 0;
        }

        

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cls.deleteUserRoom(currentUserId);
                MessageBox.Show("Delete success");
                gridRoom.DataSource = cls.liRoom(_currentUser.userId);

                gridParticipation.DataSource = cls.liAttendance(currentId);
                cbAdd.Text = "";

                List<S_User> users = cls.liUser(currentId);
                cbAdd.Properties.Items.Clear();
                foreach (var item in users)
                {
                    cbAdd.Properties.Items.Add(item.userId + "|" + item.userName + "|" + item.userFullName);

                }
                if (users.Count > 0) cbAdd.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }
        private int currentUserId = 0;
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if(gridView2.GetFocusedRowCellValue("id")!=null)
                currentUserId = int.Parse((gridView2.GetFocusedRowCellValue("id").ToString()));      
          
             }
            catch(Exception ex) { }
            }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }
    }
}