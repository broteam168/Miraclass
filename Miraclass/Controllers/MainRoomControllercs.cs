using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Picker;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    internal class MainRoomControllercs
    {
        private MiraclassDataContext db;

         public MainRoomControllercs()
        {

            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string

        }
        public List<P_Present> listPresent(int roomId)
        {
            return db.P_Presents.Where(x=>x.P_linkPresents.Where(y=>y.roomId == roomId).ToList().Count>0).ToList();
        }
        public P_data getData(int presentId)
        {
            return db.P_datas.Where(p=>p.P_Presents.id == presentId).FirstOrDefault();  
        }
        public void startPresent(int presentId,int roomId,P_StatePresent state)
        {
            List<P_StatePresent> tmp = db.P_StatePresents.Where(x =>  x.roomId == roomId).ToList();
            if (tmp != null)
            {
                foreach (var p in tmp)
                {
                    db.P_StatePresents.DeleteOnSubmit(p);
                }
                db.SubmitChanges();
            }
            db.P_StatePresents.InsertOnSubmit(state);
            db.SubmitChanges();
             
        }
        public void startRoom(int roomId)
        {
            P_Room tmp = db.P_Rooms.Where(x => x.id == roomId).FirstOrDefault();
            if (tmp != null)
            {
                tmp.status = true;
                db.SubmitChanges();
            }
        }
        public void updatePresent(int presentId,int roomId,int number )
        {
            P_StatePresent tmp = db.P_StatePresents.Where(x => x.roomId == roomId && x.presentId == presentId).FirstOrDefault();
            if (tmp != null)
            {
                tmp.currentPage = number;
                db.SubmitChanges();
            }
        }
        public List<S_User> listParticipants(int roomId)
        {
            return db.S_Users.Where(x => x.P_Attendances.Where(y => y.roomId == roomId).ToList().Count>0).ToList();

        }
        public List<Q_question> listQuestion(int roomId,int presentId) {
            return db.Q_questions.Where(x => x.roomId == roomId && x.presentId == presentId).ToList();
        }
    }
}
