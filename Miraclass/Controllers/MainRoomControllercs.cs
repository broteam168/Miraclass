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
            List<P_StatePresent> tmp = db.P_StatePresents.Where(x => x.presentId == presentId && x.roomId == roomId).ToList();
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
    }
}
