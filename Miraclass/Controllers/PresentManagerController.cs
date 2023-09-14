using DevExpress.Data.Helpers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Controllers
{
    class PresentManagerController
    {
        MiraclassDataContext db;
        public PresentManagerController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string
        }
        public List<P_Present> listPresent(int userId)
        {
            return db.P_Presents.Where(x=>x.ownerId == userId).ToList();
        }
        public void AddPresent(P_Present _obj , P_data _obj2)
        {
            P_Present temp = _obj;
            db.P_Presents.InsertOnSubmit(temp);
            db.SubmitChanges();
            
            
            P_data temp2 = _obj2;
            temp2.id = temp.id;
            db.P_datas.InsertOnSubmit(temp2);
            db.SubmitChanges();


        }
        public void UpdatePresent(P_Present _obj, P_data _obj2, bool check)
        {
            MessageBox.Show("" + _obj.id);
            P_Present temp = db.P_Presents.Where(x => x.id == _obj.id).FirstOrDefault();
            if (temp != null)
            {
                temp.name = _obj.name;
                temp.description = _obj.description;
                temp.status = _obj.status;
                db.SubmitChanges();


            }
            if (check == true)
            {
                P_data tmp = db.P_datas.Where(x => x.id == _obj.id).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.data = _obj2.data;
                    db.SubmitChanges();


                }
            }
        }
        public void deletePresent(int id)
        {
            try
            {
                P_linkPresent tt = db.P_linkPresents.Where(x=>x.presentId == id).FirstOrDefault();
                if (tt != null)
                {
                    P_Present temp = db.P_Presents.Where(x => x.id == id).FirstOrDefault();
                    db.P_Presents.DeleteOnSubmit(temp);
                    P_data temp2 = db.P_datas.Where(x => x.id == id).FirstOrDefault();
                    db.P_datas.DeleteOnSubmit(temp2);
                    db.SubmitChanges();
                }
                else MessageBox.Show("Delete not success");
            }catch (Exception ex) { }
        }


    }
}
