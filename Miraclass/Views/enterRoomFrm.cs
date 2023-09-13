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
    public partial class enterRoomFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        public enterRoomFrm(S_User currentUser)
        {
            InitializeComponent();

            this._currentUser = currentUser;
        }
        private int roomId = 0;
        public int getRoomId()
        {
            return roomId;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            enterOldRoom frm = new enterOldRoom(_currentUser);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            roomId = frm.getId();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inputRoom frm = new inputRoom();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            roomId = frm.getId();
            if(roomId !=0)
            {
                P_Attendance tmp = new P_Attendance();
                tmp.userId = _currentUser.userId;
                tmp.roomId = roomId;
                RoomController cls = new RoomController();
                cls.addAttendance(tmp);
            }    

            this.Close();
        }
    }
}