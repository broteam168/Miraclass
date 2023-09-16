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
using EMS.Controlers;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

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
            createMenu(treePermission);
            setStatus(true);
        }
        private void setStatus(bool enable)
        {
            cmdAdd.Enabled = enable;
            cmdEdit.Enabled = enable;
            cmdDelete.Enabled = enable;

            cmdSave.Enabled = !enable;
            cmdCancel.Enabled = !enable;
            txtName.Enabled = !enable;
            txtDesc.Enabled = !enable;
            treePermission.Enabled = !enable;

            gridGroup.Enabled = enable;
        }    
        private void createMenu(TreeList tr)
        {
            tr.BeginUnboundLoad();
            TreeListNode root = null;
            createNode(tr, root);
            tr.EndUnboundLoad();
        }
        private void createNode(TreeList tr,TreeListNode node, int _Parent = 0)
        {
            List<S_Menu> lst = cls.listMenu(_Parent);
            foreach (S_Menu item in lst)
            {
                TreeListNode tmp = tr.AppendNode(new object[] { item.MenuId, item.MenuName }, node);
                createNode(tr, tmp, item.MenuId);
            }
        }

        private void treePermission_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            try
            {
                e.Node.Checked = !e.Node.Checked;
            }
            catch (Exception)
            {

                
            }
        }
        private int _id;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _id = int.Parse(gridView1.GetFocusedRowCellValue("GroupId").ToString());
                txtName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
                txtDesc.Text = gridView1.GetFocusedRowCellValue("GroupDesc").ToString();
                mnItems = gridView1.GetFocusedRowCellValue("Permission").ToString().Split(',');
                setCheckedMenu(treePermission.Nodes);
            }
            catch (Exception)
            {
            }
        }
        private string[] mnItems;
        private void setCheckedMenu(TreeListNodes nodes)
        {
            foreach (TreeListNode node in nodes)
            {
                if (mnItems.Contains(node.GetValue("MenuId").ToString())) node.CheckState = CheckState.Checked;
                else node.CheckState = CheckState.Unchecked;
                setCheckedMenu(node.Nodes);
            }
        }
        private void changeState(TreeListNodes nodes)
        {
            foreach (TreeListNode node in nodes)
            {
                node.CheckState = checkEdit1.CheckState;
                changeState(node.Nodes);
            }
        }
        private void reverseState(TreeListNodes nodes)
        {
            foreach (TreeListNode node in nodes)
            {
                node.CheckState = (node.CheckState == CheckState.Checked) ? CheckState.Unchecked : CheckState.Checked;
                reverseState(node.Nodes);
            }    
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                changeState(treePermission.Nodes);
            }
            catch (Exception)
            {

            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                reverseState(treePermission.Nodes);
            }
            catch (Exception)
            {

              
            }
        }

        private void treePermission_AfterCheckNode(object sender, NodeEventArgs e)
        {
            try
            {
                if(e.Node.CheckState == CheckState.Checked)
                {
                    e.Node.CheckAll();
                }
                else
                {
                    e.Node.UncheckAll();
                }
            }
            catch (Exception)
            {

            }
        }

        private void linkExpand_Click(object sender, EventArgs e)
        {
            try
            {
                treePermission.ExpandAll();
            }
            catch (Exception)
            {

            }
        }

        private void linkCollapse_Click(object sender, EventArgs e)
        {
            try
            {
                treePermission.CollapseAll();
            }
            catch (Exception)
            {

            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            setStatus(true);
        }
        private string _Action = "";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            _Action = "ADD";
            setStatus(false);
            txtName.Text = "";
            txtDesc.Text = "";
            checkEdit1.Checked = false; checkEdit2.Checked = false;
            treePermission.UncheckAll();
            treePermission.ExpandAll();
        }
        private string getCheckedMenu(TreeListNodes nodes)
        {
            string str = "";
            foreach (TreeListNode node in nodes)
            {
                if (node.CheckState == CheckState.Checked) str = str + String.Format("{0},", node.GetValue("MenuId"));
                str += getCheckedMenu(node.Nodes);
            }
            return str;
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter enough information");
                return;
            }
            S_Group obj = new S_Group();
            obj.GroupName = txtName.Text;
            obj.GroupDesc = txtDesc.Text;
            obj.Permission = getCheckedMenu(treePermission.Nodes);
            if(_Action == "ADD")
            {
                cls.add(obj);
            }
            else
            {
                obj.GroupId = _id;
                cls.update(obj);
            }    
            MessageBox.Show("Successfully!!!");
            gridGroup.DataSource = cls.list();
            setStatus(true);
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            _Action = "EDIT";
            setStatus(false);
        }
    }
}