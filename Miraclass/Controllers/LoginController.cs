using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.S_Users);
            return db.S_Users.Where(p => p.userName.Trim().Equals(username.Trim()) &&p.userPassword.Trim().Equals(EncodeMD5(password).Trim())).SingleOrDefault();
        }
        private string EncodeMD5(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bs=   System.Text.Encoding.UTF8.GetBytes(pass);

            bs = md5.ComputeHash(bs);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x1").ToLower());

            }

            pass = sb.ToString();

            return pass;

        }
    }
}
