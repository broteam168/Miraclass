using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using Miraclass.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Miraclass.Views
{
    public partial class ConfigFrm : DevExpress.XtraEditors.XtraForm
    {
        ConfigController cls;

        bool isTest = false;

        String connectionString = "";
        public ConfigFrm()
        {
            InitializeComponent();

            ///Load saved data
            try
            {
                string s = Miraclass.Properties.Settings.Default.connect;
                string[] s1 = s.Split(';');
                for (int i = 0; i < s1.Length; i++)
                {
                    string[] s2 = s1[i].Split('=');
                    if (i == 0)
                    {
                        txtServer.Text = s2[1];
                    }
                    if (i == 1)
                    {
                        txtDB.Text = s2[1];
                    }
                    if (i == 2)
                    {
                        txtUser.Text = s2[1];
                    }
                    if (i == 3)
                    {
                        txtPass.Text = s2[1];
                    }
                }
            }
            catch (Exception)
            {

            }

            cls = new ConfigController();            
        }
        bool currentStatus = true;
        private void setStatus(bool status)
        {
            txtServer.Enabled = status;
            txtDB.Enabled = status;
            txtUser.Enabled = status;
            txtPass.Enabled = status;

            cmdExit.Enabled = status;
            cmdSave.Enabled = status;
            cmdTest.Enabled = status;

            currentStatus = status;
        }
        
        private void cmdTest_Click(object sender, EventArgs e)
        {
            if(txtServer.Text.Equals("") || txtServer.Text.Equals("") ||
                txtServer.Text.Equals("") || txtServer.Text.Equals(""))
            {
                MessageBox.Show("Please enter all information", "Notification");
                return;
            }
            if (currentStatus)
            {
                try
                {
                    setStatus(false);
                    if (cls.checkConnection(txtServer.Text, txtDB.Text, txtUser.Text, txtPass.Text))
                    {
                        isTest = true;
                        connectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDB.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPass.Text + ";";

                        MessageBox.Show("Connect success. Please save it!", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Connect failed. Please try again!", "Notification");

                    }
                }catch(Exception) { }
                finally
                {
                    setStatus(true);
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(isTest)
            {
                Miraclass.Properties.Settings.Default.connect = connectionString;
                Miraclass.Properties.Settings.Default.Save();
                MessageBox.Show("Saved successfully", "Notification");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Please test before save", "Notification");

            }

        }
    }
}