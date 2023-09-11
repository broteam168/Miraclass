using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Controllers
{
    internal class AddPresentController
    {
        private MiraclassDataContext db;
        public AddPresentController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string

        }

        public List<P_Room> liRoom(int userId)
        {
            return db.P_Rooms.Where(x=>x.hostId == userId ).ToList();
        
        }
        public List<P_Present> liPresent(int roomId)
        {
            return db.P_Presents.Where(x=>x.P_linkPresents.Where(p=>p.roomId == roomId).ToList().Count>0 ).ToList();
        }
        public List<P_Present> liRemainPresent(int roomId,int userId) {

            return db.P_Presents.Where(x => x.P_linkPresents.Where(p => p.roomId == roomId).ToList().Count == 0 && x.ownerId == userId).ToList();
        }
        public void addLink(P_linkPresent present)
        {
            db.P_linkPresents.InsertOnSubmit(present);
            db.SubmitChanges();
            
        }
        public void deleteLink(int linkId,int roomId) {
            P_linkPresent present = db.P_linkPresents.Where(x=>x.presentId == linkId).FirstOrDefault();
            if(present != null ) {
                MessageBox.Show("test");
                db.P_linkPresents.DeleteOnSubmit(present);
            db.SubmitChanges(); }
           
        }
    }   
}
