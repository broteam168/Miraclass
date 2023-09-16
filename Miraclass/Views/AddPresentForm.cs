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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Miraclass.Libs;

namespace Miraclass.Views
{
    public partial class AddPresentFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;

        AddPresentController cls;
        public AddPresentFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
        }
      
        private void gridRoom_Load(object sender, EventArgs e)
        {
            cls = new AddPresentController();

            gridRoom.DataSource = cls.liRoom(_currentUser.userId);

            gridControl1.DataSource = cls.liPresent(currentId);

            FunctionMain funnction = new FunctionMain();
            List<string> menus = funnction.getMenuByUser(_currentUser.userGroup, "cmd", 17);
            foreach (string item in menus)
            {

                SimpleButton ctl = this.Controls.Find(item, true).FirstOrDefault() as SimpleButton;
                ctl.Enabled = true;
            }

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = cls.liPresent(currentId);

            gridRoom.DataSource = cls.liRoom(_currentUser.userId);
        }

        private string cmd = "";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridLookUpEdit1.GetSelectedDataRow() != null)
                {
                    P_linkPresent tmp = new P_linkPresent();
                    tmp.presentId = ((P_Present)gridLookUpEdit1.GetSelectedDataRow()).id;
                    tmp.roomId = currentId;
                    cls.addLink(tmp);
                    gridControl1.DataSource = cls.liPresent(currentId);
                    List<P_Present> presents = cls.liRemainPresent(currentId, this._currentUser.userId);
                    gridLookUpEdit1.Properties.DataSource = presents;
                    if (gridView2.GetFocusedRowCellValue("id") != null) currentUserId = int.Parse((gridView2.GetFocusedRowCellValue("id").ToString()));

                    MessageBox.Show("Add success");
                }
            }catch (Exception ex) { }

        }

      

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            
        }
        private int currentId = 0;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            currentId = int.Parse((gridView1.GetFocusedRowCellValue("id").ToString()));

            gridControl1.DataSource = cls.liPresent(currentId);
            
                       List<P_Present> presents = cls.liRemainPresent(currentId,this._currentUser.userId);
                      gridLookUpEdit1.Properties.DataSource = presents;
        }



        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cls.deleteLink(currentUserId,currentId);
           //     MessageBox.Show("Delete success");
                gridRoom.DataSource = cls.liRoom(_currentUser.userId);

                gridControl1.DataSource = cls.liPresent(currentId);
                List<P_Present> presents = cls.liRemainPresent(currentId, this._currentUser.userId);
                gridLookUpEdit1.Properties.DataSource = presents; MessageBox.Show("Delete success");


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
                if (gridView2.GetFocusedRowCellValue("id") != null)
                {
                    currentUserId = int.Parse((gridView2.GetFocusedRowCellValue("id").ToString()));
                    //  MessageBox.Show("" + (gridView2.GetFocusedRowCellValue("id").ToString())); }
                }
                }catch(Exception)
            { }
        }
    }
}