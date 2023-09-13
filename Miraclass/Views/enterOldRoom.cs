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
    public partial class enterOldRoom : DevExpress.XtraEditors.XtraForm
    {
        RoomController cls;

        private int roomId = 0;
        public enterOldRoom(S_User currentUser)
        {
            InitializeComponent();
           
            cls = new RoomController();
            gridLookUpEdit1.Properties.DataSource =  cls.listRoomStudent(currentUser.userId);
        }
        public int getId()
        {
            return roomId;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(gridLookUpEdit1.GetSelectedDataRow() != null)
            {
                roomId = ((P_Room)gridLookUpEdit1.GetSelectedDataRow()).id;
                this.Close();
            }
            else {
                MessageBox.Show("Please choose one");
            }

           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}