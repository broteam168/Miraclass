using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    internal class ChangePasswordController
    {
        private MiraclassDataContext db;
        public ChangePasswordController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
        }
        public void updatePassword(int id, string password)
        {
            S_User tmp = db.S_Users.Where(x => x.userId == id).FirstOrDefault();
            tmp.userPassword = EncodeMD5(password);
            db.SubmitChanges();
        }
        public string EncodeMD5(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

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
