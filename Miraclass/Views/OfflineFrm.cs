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

using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Miraclass.Views
{
    public partial class OfflineFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        private int _roomId;


        public OfflineFrm()
        {
            InitializeComponent();



        }

        private void mainPdf_Click(object sender, EventArgs e)
        {
            dockPanel3.HideImmediately();
            dockPanel2.HideImmediately();
          }
        private int currentPage = 1;
        private void mainPdf_MouseDown(object sender, MouseEventArgs e)
        {
         /*   try
            {
                Point position = mainPdf.PointToClient(e.Location);
                mainPdf.GetDocumentPosition(position);

                if (currentPage != mainPdf.CurrentPageNumber)
                {
                    currentPage = mainPdf.CurrentPageNumber;
                    cls.updatePresent(currentPresent, _roomId, currentPage);
                }
            }catch (Exception ex) { }*/
        }

        
       
        private void MainRoomFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void mainPdf_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ////handle
            
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
            
                
            
        }

      
    }
}