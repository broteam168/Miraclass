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
    public partial class TeacherDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private S_User _currentUser; 
        public TeacherDashboard(S_User currentUser)
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
            catch (Exception)
            {

                
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddRoom frm = new AddRoom();
            loadForm(frm);
        }
    }
}