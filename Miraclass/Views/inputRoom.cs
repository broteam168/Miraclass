using DevExpress.Utils.Serializing;
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

namespace Miraclass.Views
{
    public partial class inputRoom : DevExpress.XtraEditors.XtraForm
    {
        MainRoomController cls = new MainRoomController();
        public inputRoom()
        {
            InitializeComponent();
        }
        private int id;
        public int getId()
        {
            return id;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(textEdit1.Text.Equals(""))
            {
                MessageBox.Show("Please enter room id");
                return;
            }
       
            if(!cls.checkRoom(int.Parse(textEdit1.Text), textEdit2.Text))
            {
                MessageBox.Show("Cannot enter this room");
                return;
            }    
            id = int.Parse(textEdit1.Text);
            Close();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}