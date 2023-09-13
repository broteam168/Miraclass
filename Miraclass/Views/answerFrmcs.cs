using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using Miraclass.Controllers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Views
{
    public partial class answerFrmcs : DevExpress.XtraEditors.XtraForm
    {
        class temp{
            public int id { get; set; }
            public string content { get; set; }
            public string userFullName { get; set; }
            public temp(int id,string content,string userFullName)
            {
                this.content = content;
                this.userFullName = userFullName;
                this.id = id;
            }
        }
        answerController cls;

        private int _messageId;
        private int _userId;
        public answerFrmcs(int messageId,int userId)
        {
            InitializeComponent();

            this._messageId = messageId;
            this._userId = userId;

            cls = new answerController();
            textEdit1.Text = cls.getMessage(messageId);

            refreshData();

            this.Text ="Question discussion: "+ textEdit1.Text;

         }
        private void refreshData()
        {

            List<temp> tmp= new List<temp>();
            if(checkEdit1.Checked==false) tmp = cls.listAnswer(_messageId).Select(x => new temp(x.Item1, x.Item2,x.Item3)).ToList();
            else tmp = cls.listAnswerOnlyMe(_messageId,_userId).Select(x => new temp(x.Item1, x.Item2, x.Item3)).ToList();
            gridControl1.DataSource = tmp;
            autoData();
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        private bool EnoughPermission()
        {
            SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
            try
            {
                perm.Demand();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet myDataSet;

        public void autoData()
        {
            string ssql;
            command = null;
            string connstr = Miraclass.Properties.Settings.Default.connect;

            ssql = "select id from dbo.Q_Answer where questionId=" + _messageId + ";";

          //  SqlDependency.Stop(connstr);
       ///     SqlDependency.Start(connstr);
            if (connection == null)
                connection = new SqlConnection(connstr);
            if (command == null)
                command = new SqlCommand(ssql, connection);
            if (myDataSet == null)
                myDataSet = new DataSet();
            GetAdvtData();
        }
        private void GetAdvtData()
        {
            myDataSet.Clear();
            command.Notification = null;
            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(myDataSet, "Advt");
            }
        }
        delegate void UIDelegate();
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            try
            {
                UIDelegate uidel = new UIDelegate(refreshData);
                this.Invoke(uidel, null);
                SqlDependency dependency = (SqlDependency)sender;
                dependency.OnChange -= dependency_OnChange;
            }
            catch (Exception)
            {
                Console.WriteLine("zzz");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cls.addAnswer(_messageId, textEdit2.Text, _userId);
            textEdit2.Text = "";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                DXMenuItem item = new DXMenuItem("Delete");
                item.Click += (o, args) => {

                    List<Q_Answer> tmp = cls.getAnswer(int.Parse(gridView1.GetFocusedRowCellValue("id").ToString()) , _userId);
                    if (tmp.Count == 0)
                    {
                        MessageBox.Show("Cannot delete other user comment");
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Are you sure to delete this answer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            cls.deleteAnswer(int.Parse(gridView1.GetFocusedRowCellValue("id").ToString()));
                            MessageBox.Show("Delete successfully");
                        }
                    }    
                };
                e.Menu.Items.Add(item);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}