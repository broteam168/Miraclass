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
    public partial class inputContentFrm : DevExpress.XtraEditors.XtraForm
    {
        public inputContentFrm()
        {
            InitializeComponent();
        }
        private string content = "";
        public string getContent()
        {
            return content;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            content = textBox1.Text;
            this.Close();
        }
    }
}