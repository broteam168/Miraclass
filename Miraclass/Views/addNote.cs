using DevExpress.XtraEditors;
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
    public partial class addNote : DevExpress.XtraEditors.XtraForm
    {
        public addNote()
        {
            InitializeComponent();
        }
        private string content = "";
        private void addNote_Load(object sender, EventArgs e)
        {

        }
        public string getContent()
        {
            return content;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(textEdit1.Text.Equals(""))
            {
                MessageBox.Show("Please enter information");
                return;
            }
            content = textEdit1.Text;
            this.Close();
        }
    }
}