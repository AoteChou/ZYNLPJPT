using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class ST_Undone
    {
        public ST_Undone() {
            zsdbhList = new List<int>();
        }
        private int stbh;//试题编号

        public int Stbh
        {
            get { return stbh; }
            set { stbh = value; }
        }
        private List<int> zsdbhList;//知识点编号List

        public List<int> ZsdbhList
        {
            get { return zsdbhList; }
            set { zsdbhList = value; }
        }

    }
}