using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Controllers
{
    internal class NoteController
    {
        private MiraclassDataContext db;
        public NoteController()
        {
            db = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            // get connectiton from saved string

        }
        public List<Tuple<int,string,int,string>> listNote(int userId)
        {
            return db.N_Notes.Where(x=>x.userId == userId).Join(db.P_Presents,
                                    x => x.presentId,
                                    y => y.id,
                                    (x, y) => new
                                    {
                                        x.id,
                                        x.content,
                                        x.presentId,
                                        y.name

                                    }).Select(x => new Tuple<int, string,int, string>(x.id, x.content,x.presentId, x.name)).ToList();
        }
        public List<P_Present> listSavedPresent(int userId)
        {
            return db.P_Presents.Where(x => x.N_savePresents.Where(y => y.userId == userId).ToList().Count > 0).ToList();
        }
    }
}
