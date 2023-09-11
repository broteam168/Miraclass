using DevExpress.Pdf;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraSpellChecker.Parser;
using Miraclass.Controllers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Views
{
    public partial class MainRoomFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        private int _roomId;


        MainRoomControllercs cls;
        public MainRoomFrm(int roomId, S_User currentUser)
        {
            InitializeComponent();

            cls = new MainRoomControllercs();

            cbPresent.Properties.DataSource = cls.listPresent(roomId);
            
            _roomId = roomId;
            this._currentUser = currentUser;
        }

        private void mainPdf_Click(object sender, EventArgs e)
        {
            QaPanel.HideImmediately();
            dockPanel2.HideImmediately();
          }

        private void mainPdf_MouseDown(object sender, MouseEventArgs e)
        {
            Point position = mainPdf.PointToClient(e.Location);
            mainPdf.GetDocumentPosition(position);

          //  MessageBox.Show(string.Format("You clicked on page {0}  {1}", mainPdf.GetDocumentPosition(position).Point.X, mainPdf.GetDocumentPosition(position).Point.Y));

        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cbPresent.GetSelectedDataRow() != null)
            {
                try
                {
                    P_data tmp = cls.getData(((P_Present)cbPresent.GetSelectedDataRow()).id);
                    mainPdf.LoadDocument(new MemoryStream(tmp.data.ToArray()));
                    tmp = null;
                    P_StatePresent temp = new P_StatePresent ();
                    temp.presentId = ((P_Present)cbPresent.GetSelectedDataRow()).id;
                    temp.roomId = _roomId;
                    temp.currentPage = 1;
                    cls.startPresent(((P_Present)cbPresent.GetSelectedDataRow()).id, _roomId, temp);

                    mainPdf.CurrentPageNumber = 1;
                }
                catch(Exception ex) {
                    MessageBox.Show("error: " + ex.Message);
                }
            } 
            else
            {
                MessageBox.Show("Please choose present to present");
            }    
                
        }

       
        private void endRoom()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}