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
    class RoomController
    {
        private MiraclassDataContext db;
        public RoomController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string
            
        }
        public List<P_Room> liRoom(int id)
        {
            return db.P_Rooms.ToList();
        }
        public void AddRoom(P_Room _obj)
        {
            db.P_Rooms.InsertOnSubmit(_obj);
            db.SubmitChanges();
        }
        public void UpdateRoom(P_Room _obj)
        {
            //MessageBox.Show(_obj.id.ToString());
            P_Room tmp = db.P_Rooms.Where(p=>p.id == _obj.id).FirstOrDefault();
            if (tmp != null)
            {
                tmp.RoomName = _obj.RoomName; 
                tmp.RoomDesc = _obj.RoomDesc;
                tmp.status = _obj.status;
                tmp.password = _obj.password;
                db.SubmitChanges();
            }
        }
        public void deleteRoom(int id)
        {
            P_Room current = db.P_Rooms.Where(x => x.id == id).FirstOrDefault();
            if (current != null)
            {

                List<P_Attendance> temp = current.P_Attendances.ToList();

                if (temp.Count > 0)
                {
                    MessageBox.Show("You cannot delete this !!! Becasue some data linked to this exists");
                    throw new Exception();
                }
                else
                {
                    db.P_Rooms.DeleteOnSubmit(current);
                    db.SubmitChanges();
                }
            }
            
        }
        public List<P_Room> listRoomStudent(int id)
        {
            return db.P_Rooms.Where(x=>x.status == true && x.P_Attendances.Where(y=>y.userId == id).ToList().Count>0).ToList();
        }    
        public void addAttendance(P_Attendance attendance)
        {
            List<P_Attendance> tmp = db.P_Attendances.Where(x => x.roomId == attendance.roomId && x.userId == attendance.userId).ToList();
            foreach (var item in tmp)
            {
                db.P_Attendances.DeleteOnSubmit(item);
                db.SubmitChanges();
            }

            db.P_Attendances.InsertOnSubmit(attendance);
            db.SubmitChanges();
        }
    }
}
