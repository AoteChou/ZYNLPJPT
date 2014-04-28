using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class ZBMCAndFS
    {
        public ZBMCAndFS(bool haveChildOrNot)
        {
            if (haveChildOrNot)
            {
                mCandFS_child = new List<ZBMCAndFS>();
            }
            else {
                mCandFS_child = null;
            }

            
        }
        private string zbmc;//指标名称

        public string Zbmc
        {
          get { return zbmc; }
          set { zbmc = value; }
        }
     
        private int fs;//指标分数

        public int Fs
        {
            get { return fs; }
            set { fs = value; }
        }
        private List<ZBMCAndFS> mCandFS_child;//下属指标

        public List<ZBMCAndFS> MCandFS_child
        {
            get { return mCandFS_child; }
            set { mCandFS_child = value; }
        }
    }
}