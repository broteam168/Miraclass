using DevExpress.Pdf;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraSpellChecker.Parser;
using Miraclass.Controllers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Views
{
    public partial class OfflineFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        private int _roomId;


        MainRoomController cls;
        public OfflineFrm(int roomId, S_User currentUser)
        {
            InitializeComponent();

            cls = new MainRoomController();

            
            _roomId = roomId;
            this._currentUser = currentUser;
            gridParticipations.DataSource = cls.listParticipants(_roomId);
            if (EnoughPermission()) autoData();

            cls.startRoom(_roomId);


        }

        private void mainPdf_Click(object sender, EventArgs e)
        {
            dockPanel3.HideImmediately();
            dockPanel2.HideImmediately();
          }
        private int currentPage = 1;
        private void mainPdf_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Point position = mainPdf.PointToClient(e.Location);
                mainPdf.GetDocumentPosition(position);

                if (currentPage != mainPdf.CurrentPageNumber)
                {
                    currentPage = mainPdf.CurrentPageNumber;
                    cls.updatePresent(currentPresent, _roomId, currentPage);
                }
            }catch (Exception ex) { }
        }

        private int currentPresent = 0;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet myDataSet;

       
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
        public void autoData()
        {
            string ssql;
            command = null;
            string connstr = Miraclass.Properties.Settings.Default.connect;
           
            ssql = "select userId from dbo.P_Attendance where roomId="+_roomId+";";
            
            SqlDependency.Stop(connstr);
            SqlDependency.Start(connstr);
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
                UIDelegate uidel = new UIDelegate(refresh);
                this.Invoke(uidel, null);
                SqlDependency dependency = (SqlDependency)sender;
                dependency.OnChange -= dependency_OnChange;
            }
            catch (Exception)
            {
                Console.WriteLine("zzz");
            }
        }
        public void refresh()
        {
            gridParticipations.DataSource = cls.listParticipants(_roomId);

            GetAdvtData();
        }
        private SqlConnection connection2;
        private SqlCommand command2;
        private DataSet myDataSet2;
        public void autoData2()
        {
            string ssql;
            command2 = null;
            string connstr = Miraclass.Properties.Settings.Default.connect;

            ssql = "select id from dbo.Q_question  where roomId=" + _roomId + ";";

           // SqlDependency.Stop(connstr);
           // SqlDependency.Start(connstr);
            if (connection2 == null)
                connection2 = new SqlConnection(connstr);
            if (command2 == null)
                command2 = new SqlCommand(ssql, connection2);
            if (myDataSet2 == null)
                myDataSet2 = new DataSet();
            GetAdvtData2();
        }
        private void GetAdvtData2()
        {
            myDataSet2.Clear();
            command2.Notification = null;
            SqlDependency dependency = new SqlDependency(command2);
            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange2);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command2))
            {
                adapter.Fill(myDataSet2, "Advt");
            }
        }
        delegate void UIDelegate2();
        private void dependency_OnChange2(object sender, SqlNotificationEventArgs e)
        {
            try
            {
                UIDelegate uidel = new UIDelegate(refresh2);
                this.Invoke(uidel, null);
                SqlDependency dependency = (SqlDependency)sender;
                dependency.OnChange -= dependency_OnChange2;
            }
            catch (Exception)
            {
                Console.WriteLine("zzz");
            }
        }
        public void refresh2()
        {
            gridQA.DataSource = cls.listQuestion(_roomId, currentPresent);
            autoData2();
        }
        private void MainRoomFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cls.closeRoom(_roomId);

            string connstr = Miraclass.Properties.Settings.Default.connect;

            SqlDependency.Stop(connstr);
        }

        private void mainPdf_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void gridQA_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
try
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                if (info.InRow || info.InRowCell)
                {
                    try
                    {
                        answerFrmcs frm = new answerFrmcs(int.Parse(gridView1.GetRowCellValue(info.RowHandle,"id").ToString()),_currentUser.userId);
                        frm.Show();
                    }
                    catch (Exception) {
                        Console.WriteLine("test");
                    }
                }
            }
            catch(Exception ex) { }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (currentPresent != 0)
            {
                inputContentFrm frm = new inputContentFrm();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                String content = frm.getContent();
                Q_question tmp = new Q_question();
                tmp.presentId = currentPresent;
                tmp.roomId = _roomId;
                tmp.content = content;
                tmp.currentPage = currentPage;
                tmp.userId = _currentUser.userId;
                cls.addQuestion(tmp);
                MessageBox.Show("Add successfully");
            }
        }

      
    }
}