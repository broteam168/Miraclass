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
    public partial class ViewNoteStudent : DevExpress.XtraEditors.XtraForm
    {
        public ViewNoteStudent(int presentId,int userId,int page)
        {
            InitializeComponent();
            MainRoomController cls = new MainRoomController();
            gridControl1.DataSource = cls.listNote(userId, presentId, page);
        }
    }
}