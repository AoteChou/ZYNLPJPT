using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;


namespace ZYNLPJPT.BLL
{
    public class gt_BLL
    {
        protected int pcjlbh;        //评测记录编号
 
        //获取数据库中的评测记录数
        public int get_numOfpcjl()
        {
          return  new PCJL_DAL().GetMaxId();
        }

        //由课程编号得到课程名称
        public string get_kcmc_Bykcbh(int kcbh)
        {
            KC kc = new KC();
            kc = new KC_DAL().GetModel(kcbh);
            return kc.KCMC.ToString();
        }
        
        //由出题人编号获取出题人姓名
        public string get_ctrxm_Byctrbh(string ctrbh)
        {
            YH yh = new YH();
            yh = new YH_DAL().GetModel(ctrbh);
            return yh.XM.ToString().Trim();
        }
    }
}