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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.IO;
using Miraclass.Libs;

namespace Miraclass.Views
{
    public partial class PresentManagerFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;

        PresentManagerController cls;
        public PresentManagerFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
            initData();
        }
        private void initData()
        {
            cls = new PresentManagerController();

            gridRoom.DataSource = cls.listPresent(_currentUser.userId);
            FunctionMain funnction = new FunctionMain();
            List<string> menus = funnction.getMenuByUser(_currentUser.userGroup, "cmd", 13);
            foreach (string item in menus)
            {

                SimpleButton ctl = this.Controls.Find(item, true).FirstOrDefault() as SimpleButton;
                ctl.Enabled = true;
            }

            t = cmdAdd.Enabled;
            s = cmdEdit.Enabled;
            x = cmdDelete.Enabled;

            setStatus(true);
        }
        private bool t, s, x;
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

            }
            else
            {
                cmdAdd.Enabled = enable;
                cmdEdit.Enabled = enable;
                cmdDelete.Enabled = enable;
            }

            cmdSave.Enabled = !enable;
            txtName.Enabled = !enable;
            txtDesc.Enabled = !enable;
            checkActive.Enabled = !enable;
            simpleButton1.Enabled = !enable;

        }
        private void gridRoom_Load(object sender, EventArgs e)
        {

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            initData();
        }

        private string cmd = "";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            setStatus(false);
            cmd = "add";

        }
       
        private void cmdSave_Click(object sender, EventArgs e)
        {
            setStatus(true);

            if (cmd == "add")
            {
                if (txtName.Text.Equals("") || txtDesc.Text.Equals("") || txtPath.Text.Equals(""))
                {
                    MessageBox.Show("Please enter all information", "Notification");
                    return;
                }
                try
                {
                   P_Present _obj = new P_Present();
                    _obj.name = txtName.Text;
                    _obj.description = txtDesc.Text;
                    _obj.ownerId = _currentUser.userId;
                    _obj.status = checkActive.Checked;
                    byte[] file;
                    using (var stream = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            file = reader.ReadBytes((int)stream.Length);
                        }
                    }
                    _obj.description = txtPath.Text.Split('.')[1];
                    P_data _obj2 = new P_data();
                    _obj2.data = file;
                    cls.AddPresent(_obj,_obj2);
                    MessageBox.Show("Add successfully");

                
                    initData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed" +ex.Message);

                }
            }
            else if (cmd == "edit")
            {
                if (txtName.Text.Equals("") || txtDesc.Text.Equals("") )
                {
                    MessageBox.Show("Please enter all information", "Notification");
                    return;
                }
                try
                {
                    P_Present _obj = new P_Present();
                    _obj.name = txtName.Text;
                    _obj.description = txtDesc.Text;
                    _obj.ownerId = _currentUser.userId;
                    _obj.status = checkActive.Checked;
                    _obj.id = currentId;
                    P_data _obj2=null;
                    if (!txtPath.Text.Equals(""))
                    {
                        byte[] file;
                        using (var stream = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = new BinaryReader(stream))
                            {
                                file = reader.ReadBytes((int)stream.Length);
                            }
                        }
                         _obj2 = new P_data();
                        _obj2.data = file;
                    } 
                    cls.UpdatePresent(_obj,_obj2, !txtPath.Text.Equals(""));
                    MessageBox.Show("Edit successfully");

                    gridRoom.DataSource = cls.listPresent(_currentUser.userId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed" + ex.Message);

                }
            }
        }
    
        

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            
        }
        private int currentId = 0;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
                }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            setStatus(false);
            cmd = "edit";
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
           /* try
            {
                cls.deleteRoom(currentId);
                MessageBox.Show("Delete successfully", "Notifications");   cls = new RoomController();

                gridRoom.DataSource = cls.liRoom(_currentUser.userId);

            }catch(Exception ex)
            {
             
            }*/
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cmd == "add")
            {
                openFileDialog1.Title = "Choose file";
                openFileDialog1.Filter = "PDF (*.pdf)|*.pdf|DOC file (*.doc)|*.doc|PPT file (*.ppt)|*.ppt";
                openFileDialog1.ShowDialog();
                txtPath.Text = openFileDialog1.FileName;
            }
            else if(cmd =="edit")
            {
                DialogResult result = MessageBox.Show("Do you want to continue and lost data", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    openFileDialog1.Title = "Choose file";
                    openFileDialog1.Filter = "PDF (*.pdf)|*.pdf|DOC file (*.doc)|*.doc|PPT file (*.ppt)|*.ppt";
                    openFileDialog1.ShowDialog();
                    txtPath.Text = openFileDialog1.FileName;
                }    
            }    
        }

        private void cmdEdit_Click_1(object sender, EventArgs e)
        {
            setStatus(false);
            cmd = "edit";
            txtPath.Text = "";
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            currentId = int.Parse((gridView1.GetFocusedRowCellValue("id").ToString()));
            txtName.Text = (gridView1.GetFocusedRowCellValue("name").ToString());
            if ((gridView1.GetFocusedRowCellValue("description") != null)) txtDesc.Text = (gridView1.GetFocusedRowCellValue("description").ToString());
            checkActive.Checked = gridView1.GetFocusedRowCellValue("status").ToString() == "True" ? true : false;

        }

        private void cmdDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                cls.deletePresent(currentId);
                initData();
                MessageBox.Show("Delete successfully");
            }catch(Exception)
            {

                MessageBox.Show("Delete failed");
            }
        }
    }
}