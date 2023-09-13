using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    internal class answerController
    {
        private MiraclassDataContext db;
        public answerController() {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string
        }
        public string getMessage(int id)
        {
            return db.Q_questions.Where(x => x.id == id).FirstOrDefault().content;
        }
        public List<Tuple<int,string, string>> listAnswer(int messageId)
        {
            return db.Q_Answers.Where(x=>x.questionId == messageId).Join(db.S_Users,
                                    x => x.userId,
                                    y => y.userId,
                                    (x, y) => new
                                    {
                                        x.id,
                                         x.content,
                                         y.userFullName

                                    }).Select(x=>new Tuple<int,string,string>(x.id,x.content,x.userFullName)).ToList() ;
                                        

        }
        public List<Tuple<int, string, string>> listAnswerOnlyMe(int messageId,int userId)
        {
            return db.Q_Answers.Where(x => x.questionId == messageId && x.userId == userId).Join(db.S_Users,
                                    x => x.userId,
                                    y => y.userId,
                                    (x, y) => new
                                    {
                                        x.id,
                                        x.content,
                                        y.userFullName

                                    }).Select(x => new Tuple<int, string, string>(x.id, x.content, x.userFullName)).ToList();


        }
        public void addAnswer(int messageId, string content, int userId)
        {
            try
            {
                Q_Answer tmp = new Q_Answer();
                tmp.content = content;
                tmp.userId = userId;
                tmp.questionId = messageId;
                db.Q_Answers.InsertOnSubmit(tmp);
                db.SubmitChanges();
            }
            catch (Exception e) { }
        }
        public void deleteAnswer(int id)
        {
            try
            {
                Q_Answer tmp = db.Q_Answers.Where(x => x.id == id).FirstOrDefault();
                if (tmp != null)
                {
                    db.Q_Answers.DeleteOnSubmit(tmp);
                    db.SubmitChanges();
                }
            }
            catch (Exception e) { }
        }
        public List<Q_Answer> getAnswer(int id,int userId)
        {
            return db.Q_Answers.Where(x=>x.id == id && x.userId == userId).ToList();
        }
    }
}
