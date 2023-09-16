using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Controllers
{
    class UserControler
    {
        private S_User obj;
        private MiraclassDataContext db;

        public UserControler()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
        }

        public S_User getByUserName(string _Name)
        {
            try
            {
                return db.S_Users.Where(p => p.userName.Equals(_Name)).SingleOrDefault();
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng kiểm tra lại kết nối tới máy chủ!");
                return null;
            }
        }

        public void add(S_User _obj)
        {
            try
            {
                db.S_Users.InsertOnSubmit(_obj);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm mới, vui lòng kiểm tra lại.");
            }
        }

        public bool checkExists(string _UserName)
        {
            obj = db.S_Users.Where(p => p.userName.Equals(_UserName)).SingleOrDefault();
            if (obj != null) return true;
            return false;
        }

        public void clearPass(int _Id)
        {
            obj = db.S_Users.Where(p => p.userId.Equals(_Id)).SingleOrDefault();
            if (obj != null)
            {
                obj.userPassword =EncodeMD5( obj.userName);
                db.SubmitChanges();
            }
        }

        public void delete(int _Id)
        {
            obj = db.S_Users.Where(p => p.userId.Equals(_Id)).SingleOrDefault();
            
            if (obj != null)
            {
                db.S_Users.DeleteOnSubmit(obj);
                db.SubmitChanges();
            }
        }

        public void update(S_User _obj)
        {
            obj = db.S_Users.Where(p => p.userName.Equals(_obj.userName)).SingleOrDefault();
            if (obj != null)
            {

                obj.isActive = _obj.isActive;
                obj.Phone = _obj.Phone;
                obj.userFullName = _obj.userFullName;
                obj.userGroup = _obj.userGroup;
                obj.Phone = _obj.Phone;
                obj.isTeacher = obj.isTeacher;
                //obj.UserPassword = _obj.UserPassword;
                db.SubmitChanges();
            }
        }
        public List<S_User> list()
        {
            return db.S_Users.ToList();
        }

        public List<S_Group> listGroup()
        {
            return db.S_Groups.ToList();
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
