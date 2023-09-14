using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Controllers
{
    class AddRoomController
    {
        private MiraclassDataContext db;
        public AddRoomController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string
            
        }
        public List<P_Room> liRoom(int id)
        {
            return db.P_Rooms.Where(p=>p.hostId == id).ToList();
        }
       public List<P_Attendance> liAttendance(int id)
        {
            return db.P_Attendances.Where(p=>p.roomId == id).ToList();
        }
        public List<S_User> liUser(int id)
        {
            return db.S_Users.Where(x=>x.P_Attendances.Where(y=>y.roomId == id).ToList().Count == 0 && x.isTeacher==false).ToList();
        }
        public void addUserRoom(P_Attendance _obj)
        {
            db.P_Attendances.InsertOnSubmit(_obj);
            db.SubmitChanges();
        }
        public void deleteUserRoom(int id)
        {
             db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.P_Attendances);
            P_Attendance temp = db.P_Attendances.Where(p => p.id ==id).FirstOrDefault();
            db.P_Attendances.DeleteOnSubmit(temp);
            db.SubmitChanges();
        }
    }
}
