using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.Utility
{
    public class XS_Utility
    {
        //获取当前学期
        public static int getSemNum(string yhbh)
        {

            int semNum = 0;

            //获取学生班级编号
            XS_DAL xs_dal = new XS_DAL();
            XS xs = xs_dal.GetModel(yhbh);
            int bjbh = xs.BJBH;

            //获取班级的入学年份
            BJ_DAL bj_dal = new BJ_DAL();
            BJ bj = bj_dal.GetModel(bjbh);
            int bjrxnf = bj.RXNF.Year;

            int nownf = DateTime.Now.Year;

            if (DateTime.Now.Month >= 9)
            {
                semNum = (nownf - bjrxnf) * 2 + 1;
            }
            else
            {
                semNum = (nownf - bjrxnf) * 2 + 0;
            }

            return semNum;
        }
    }
}