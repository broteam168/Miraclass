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
using EMS.Controlers;

namespace Miraclass.Views
{
    public partial class userGroupFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;

        GroupControler cls;
        public userGroupFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
           


        }

        private void userGroupFrm_Load(object sender, EventArgs e)
        {
            cls = new GroupControler();

            gridGroup.DataSource = cls.list();
        }
    }
}