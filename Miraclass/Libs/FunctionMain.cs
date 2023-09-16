using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclass.Libs
{
    internal class FunctionMain
    {
        public List<string> getMenuByUser(int userGroup,string _type = "mn", int _parent = -1)
        {
            MiraclassDataContext DB = new MiraclassDataContext(Miraclass.Properties.Settings.Default.connect);
            S_Group g = DB.S_Groups.Where(p => p.GroupId.Equals(userGroup)).SingleOrDefault();
            string[] ids = g.Permission.Split(',');
            List<string> buttons = new List<string>();
            IList<S_Menu> menus;
            if (_parent == -1)
            {
                menus = DB.S_Menus.Where(p => p.MenuButton.Contains(_type)).ToList();
            }

            else
            {
                menus = DB.S_Menus.Where(p => p.MenuButton.Contains(_type) && p.ParentId.Equals(_parent)).ToList();
            }

            foreach (S_Menu item in menus)
            {
                if (ids.Contains(item.MenuId.ToString()))
                {
                    buttons.Add(item.MenuButton);
                }
            }
            return buttons;
        }
    }
}
