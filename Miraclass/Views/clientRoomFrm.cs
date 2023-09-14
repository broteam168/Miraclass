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
using DevExpress.XtraExport.Xls;
using DevExpress.XtraBars;
using System.Data.Linq;

namespace Miraclass.Views
{
    public partial class clientRoomFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        private int _roomId;


        MainRoomController cls;
        public clientRoomFrm(int roomId, S_User currentUser)
        {
            InitializeComponent();

            cls = new MainRoomController();

            cbPresent.Properties.DataSource = cls.listPresent(roomId);
            
            _roomId = roomId;
            this._currentUser = currentUser;
            gridParticipations.DataSource = cls.listParticipants(_roomId);
            if (EnoughPermission()) autoData();

            if (EnoughPermission()) autoData3();

            if (EnoughPermission()) autoData2();


        }

        private void mainPdf_Click(object sender, EventArgs e)
        {
            dockPanel3.HideImmediately();
            dockPanel2.HideImmediately();
          }
        private int currentPage = 1;
        private void mainPdf_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private int currentPresent = 0;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet myDataSet;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
                
        }

       
        private void endRoom()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
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
             string connstr = Miraclass.Properties.Settings.Default.connect;

            SqlDependency.Stop(connstr);
        }

        private void mainPdf_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (cbPresent.GetSelectedDataRow() != null)
            {
                try
                {
                    P_data tmp = cls.getData(((P_Present)cbPresent.GetSelectedDataRow()).id);
                    mainPdf.LoadDocument(new MemoryStream(tmp.data.ToArray()));
                    tmp = null;
                    P_StatePresent temp = new P_StatePresent();
                    temp.presentId = ((P_Present)cbPresent.GetSelectedDataRow()).id;
                    temp.roomId = _roomId;
                    temp.currentPage = 1;
                      mainPdf.CurrentPageNumber = 1;
                   
                    currentPresent = ((P_Present)cbPresent.GetSelectedDataRow()).id;
                    gridQA.DataSource = cls.listQuestion(_roomId, currentPresent);
                    refreshNote();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose present to present");
            }
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

        private void dockPanel6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (simpleButton6.Text == "Continue live")
            {
                P_Present currentPresento = cls.getCurrentPresennt(_roomId);
                if (currentPresento != null)
                {
                    if (currentPresento.id != currentPresent)
                    {
                        P_data tmp = cls.getData(currentPresento.id);
                        mainPdf.LoadDocument(new MemoryStream(tmp.data.ToArray()));
                        tmp = null;

                       currentPresent = currentPresento.id;
                       }
                      P_StatePresent temp = cls.getCurrentPage(currentPresento.id, _roomId);
                    currentPage = temp.currentPage;
                    mainPdf.CurrentPageNumber = currentPage;
                    //  MessageBox.Show(currentPresent.ToString());
                    gridQA.DataSource = cls.listQuestion(_roomId, currentPresent);

                    refreshNote();
                    simpleButton6.Text = "Stop live";
                }
                else
                {
                    MessageBox.Show("No presentation is presenting");
                }
            }
            else
            {
                simpleButton6.Text = "Continue live";
            }
        }
        private SqlConnection connection3;
        private SqlCommand command3;
        private DataSet myDataSet3;
        public void autoData3()
        {
            string ssql;
            command3 = null;
            string connstr = Miraclass.Properties.Settings.Default.connect;

            ssql = "select id,currentPage from dbo.P_StatePresent  where roomId=" + _roomId + ";";

            // SqlDependency.Stop(connstr);
            // SqlDependency.Start(connstr);
            if (connection3 == null)
                connection3 = new SqlConnection(connstr);
            if (command3 == null)
                command3 = new SqlCommand(ssql, connection3);
            if (myDataSet3 == null)
                myDataSet3 = new DataSet();
            GetAdvtData3();
        }
        private void GetAdvtData3()
        {
            myDataSet3.Clear();
            command3.Notification = null;
            SqlDependency dependency = new SqlDependency(command3);
            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange3);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command3))
            {
                adapter.Fill(myDataSet3, "Advt");
            }
        }
        delegate void UIDelegate3();
        private void dependency_OnChange3(object sender, SqlNotificationEventArgs e)
        {
            try
            {
                UIDelegate uidel = new UIDelegate(refresh3);
                this.Invoke(uidel, null);
                SqlDependency dependency = (SqlDependency)sender;
                dependency.OnChange -= dependency_OnChange3;
            }
            catch (Exception)
            {
                Console.WriteLine("zzz");
            }
        }
        public void refresh3()
        {
           if (!simpleButton6.Text .Equals( "Continue live"))
            {
                //MessageBox.Show("tesst");
         
                P_Present currentPresento = cls.getCurrentPresennt(_roomId);
                if (currentPresento != null)
                {
                   /// MessageBox.Show(cls.getCurrentPage(currentPresento.id, _roomId).currentPage.ToString());

                    if (currentPresento.id != currentPresent)
                    {
                        P_data tmp = cls.getData(currentPresento.id);
                        mainPdf.LoadDocument(new MemoryStream(tmp.data.ToArray()));
                        tmp = null;

                        currentPresent = currentPresento.id;
                        gridQA.DataSource = cls.listQuestion(_roomId, currentPresent);

                    }
                    mainPdf.CurrentPageNumber = cls.getCurrentPage(currentPresento.id, _roomId).currentPage;
                    refreshNote();
                }
                else
                {

                }
                
            }else
            {
               
            }
            autoData3();
        }
        private void refreshNote()
        {
            gridControl1.DataSource = cls.listNote(_currentUser.userId, currentPresent);
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if(currentPresent == 0)
            {
                MessageBox.Show("No file is here?");

            }
            else
            {
                try
                {
                    folderBrowserDialog1.ShowDialog();
                    P_data tmp = cls.getData(currentPresent);
                    //MemoryStream temp =  new MemoryStream(tmp.data.ToArray()));
                    using (FileStream file = new FileStream(folderBrowserDialog1.SelectedPath + "\\Save" + currentPresent + ".pdf", FileMode.Create, System.IO.FileAccess.Write))
                    {
                        file.Write(tmp.data.ToArray(), 0, tmp.data.ToArray().Length);

                    }
                    MessageBox.Show("Save successfully");
                }catch(Exception)
                {
                    MessageBox.Show("Save failed");
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            cls.removeParticipant(_currentUser.userId, _roomId);
            this.Close();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (currentPresent != 0)
            {
                N_savePresent tmp = new N_savePresent();
                tmp.userId = _currentUser.userId;
                tmp.presentId = currentPresent; 
                cls.addSavePresent(tmp);
                MessageBox.Show("Save document");
            }
            else MessageBox.Show("No present is here");
        }

        private void mainPdf_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e)
        {
            BarButtonItem browseBarButton = new BarButtonItem();
            browseBarButton.Caption = "Add note";
            BarButtonItem viewBarButton = new BarButtonItem();
            viewBarButton.Caption = "View note on this page";

            e.ItemLinks.Clear();
            
            e.ItemLinks.Add(browseBarButton, true);
            e.ItemLinks.Add(viewBarButton, true);

            browseBarButton.ItemClick += BrowseBarButton_ItemClick;
            viewBarButton.ItemClick += viewBarButton_ItemClick;
        }
        private void viewBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewNoteStudent frm = new ViewNoteStudent(currentPresent, _currentUser.userId, currentPage);
            frm.ShowDialog();
        }
            private void BrowseBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(currentPresent!=0 && cls.checkSavePresent(_currentUser.userId,currentPresent))
            {
                addNote frm = new addNote();
                frm.ShowDialog();
                N_Note tmp = new N_Note();
                tmp.userId = _currentUser.userId;
                tmp.presentId=currentPresent;
                tmp.content = frm.getContent();
                tmp.page = currentPage;
                cls.addNote(tmp);
                MessageBox.Show("Add successfully");
            }
            else
            {
                MessageBox.Show("Please save document before adding a note");
            }
        }
    }
}