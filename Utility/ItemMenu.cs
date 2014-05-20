using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class ItemMenu
    {
        public ItemMenu() { 
        }

        public ItemMenu(string _menuName, string _menuContent, int _gnbh) {
            this.MenuName = _menuName;
            this.MenuContent = _menuContent;
            this.gnbh = _gnbh;
        }

        private string menuName;

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        private string menuContent;

        public string MenuContent
        {
            get { return menuContent; }
            set { menuContent = value; }
        }

        private int gnbh;

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }
    }
}