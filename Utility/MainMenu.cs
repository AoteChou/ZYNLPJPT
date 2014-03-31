using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class MainMenu
    {
        public MainMenu(string _menuName, ItemMenu[] _itemMenus) {
            this.MenuName = _menuName;
            this.ItemMenu = _itemMenus;
        }

        private string menuName;

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        private ItemMenu[] itemMenu;

        public ItemMenu[] ItemMenu
        {
            get { return itemMenu; }
            set { itemMenu = value; }
        }


    }
}