using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    class AccountController
    {
        private MiraclassDataContext db;
        public AccountController() { 
            db  = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
        }
        public List<S_User> listUser()
        {
            return db.S_Users.ToList();
        }
    }
}
