using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    public class LoginController
    {
        private MiraclassDataContext db;
        public LoginController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string
        }
        public S_User getUser(string username, string password)
        {
            return db.S_Users.Where(p => p.userName.Equals(username) && p.userPassword.Equals(password)).SingleOrDefault();
        }
    }
}
