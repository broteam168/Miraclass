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
    public partial class ChooseRoom : DevExpress.XtraEditors.XtraForm
    {
        RoomController cls;
        public ChooseRoom(S_User currentUser)
        {
            InitializeComponent();

            cls = new RoomController();

            gridLookUpEdit1.Properties.DataSource = cls.liRoom(currentUser.userId);
        }
        public P_Room GetRoom()
        {
            if (gridLookUpEdit1.GetSelectedDataRow() != null) return ((P_Room)gridLookUpEdit1.GetSelectedDataRow()); else return null;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseRoom_Load(object sender, EventArgs e)
        {

        }
    }
}