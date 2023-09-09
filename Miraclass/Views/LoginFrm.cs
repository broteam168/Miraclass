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
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void cmdConfig_Click(object sender, EventArgs e)
        {
            ConfigFrm frm = new ConfigFrm();
            frm.ShowDialog();
        }
    }
}