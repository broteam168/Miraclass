using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Miraclass.Models;

namespace EMS.Controlers
{
    class GroupControler
    {
        //private S_GROUP obj;
        private MiraclassDataContext db;

        public GroupControler()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
        }

        public void add(S_Group _obj)
        {
            db.S_Groups.InsertOnSubmit(_obj);
            db.SubmitChanges();
        }

        public void update(S_Group _obj)
        {
            S_Group tmp = db.S_Groups.Where(p => p.GroupId.Equals(_obj.GroupId)).SingleOrDefault();
            if (tmp != null)
            {
                tmp.GroupName = _obj.GroupName;
                tmp.GroupDesc = _obj.GroupDesc;
                tmp.Permission = _obj.Permission;
                db.SubmitChanges();
            }
        }
        public List<S_Group> list()
        {
            return db.S_Groups.ToList();
        }
        public void delete(int _Id)
        {
            S_Group tmp = db.S_Groups.Where(p => p.GroupId.Equals(_Id)).SingleOrDefault();
            if (tmp != null)
            {
                db.S_Groups.DeleteOnSubmit(tmp);
                db.SubmitChanges();
            }
        }

        public List<S_Menu> listMenu(int _parent)
        {
            return db.S_Menus.Where(p => p.ParentId.Equals(_parent)).ToList();
        }
    }
}
