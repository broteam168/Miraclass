﻿using DevExpress.XtraEditors;
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
using DevExpress.XtraExport;

namespace Miraclass.Views
{
    public partial class NoteFrm : DevExpress.XtraEditors.XtraForm
    {
        class temp
        {
            public int id { get; set; }
           
            public string content { get; set; } 
            public int presentId {  get; set; }
            
            public string nameP { get; set; }

            public temp(int id, string content, int presentId, string nameP)
            {
                this.id = id;
                this.content = content;
                this.presentId = presentId;
                this.nameP = nameP;
            }
        }
        private S_User _currentUser;

        NoteController cls;
        public NoteFrm(S_User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
            cls = new NoteController();

            gridRoom.DataSource = cls.listNote(_currentUser.userId).Select(x=>new temp(x.Item1,x.Item2,x.Item3,x.Item4)).ToList();
            gridLookUpEdit1.Properties.DataSource = cls.listSavedPresent(_currentUser.userId);
            setStatus(true);
        }
        private void setStatus(bool enable)
        {
            cmdAdd.Enabled = enable;
            cmdEdit.Enabled = enable;
            cmdDelete.Enabled = enable;

            cmdSave.Enabled = !enable;
            //txtName.Enabled = !enable;
            //txtPass.Enabled = !enable;
            txtDesc.Enabled = !enable;
            gridLookUpEdit1.Enabled = !enable;
         
            
        }
        private void gridRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
          
            gridRoom.DataSource = cls.listNote(_currentUser.userId);
            gridLookUpEdit1.Properties.DataSource = cls.listSavedPresent(_currentUser.userId);

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
            /*
            if (cmd == "add")
            {
                if (txtName.Text.Equals("") || txtDesc.Text.Equals(""))
                {
                    MessageBox.Show("Please enter all information", "Notification");
                    return;
                }
                try
                {
                    P_Room newRoom = new P_Room();
                    newRoom.RoomName = txtName.Text;
                    newRoom.status = false;
                    newRoom.CreatedAt = DateTime.Now;
                    newRoom.RoomDesc = txtDesc.Text;
                    newRoom.hostId = _currentUser.userId;

                    newRoom.password = txtPass.Text;
                    cls.AddRoom(newRoom);
                    MessageBox.Show("Add successfully");

                    cls = new RoomController();

                    gridRoom.DataSource = cls.liRoom(_currentUser.userId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed");

                }
            }
            else if(cmd == "edit")
            {
                if (txtName.Text.Equals("") || txtDesc.Text.Equals(""))
                {
                    MessageBox.Show("Please enter all information", "Notification");
                    return;
                }
                try
                {
                    P_Room newRoom = new P_Room();
                    newRoom.id = currentId;
                    newRoom.RoomName = txtName.Text;
                    newRoom.status = false;
                    newRoom.RoomDesc = txtDesc.Text;
                    if (!txtPass.Text.Equals("")) newRoom.password = txtPass.Text;
                    else newRoom.password += txtPass.Text;
                    cls.UpdateRoom(newRoom);
                    MessageBox.Show("Edit successfully");

                    cls = new RoomController();

                    gridRoom.DataSource = cls.liRoom(_currentUser.userId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed" +ex.Message);

                }
            }*/    
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

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            currentId = int.Parse((gridView1.GetFocusedRowCellValue("id").ToString()));
            txtDesc.Text = (gridView1.GetFocusedRowCellValue("content").ToString());

            MessageBox.Show("" + gridView1.GetFocusedRowCellValue("presentId").ToString());
            //       checkActive.Checked =  gridView1.GetFocusedRowCellValue("status").ToString() == "True" ? true : false;*/
        }
    }
}