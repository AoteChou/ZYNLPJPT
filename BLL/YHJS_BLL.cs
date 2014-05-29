using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.BLL
{
    public class YHJS_BLL
    {
        //由用户编号获取角色列表
        public JS2[] getJS_byYH(string yhbh)
        {
            string sql = "yhbh="+yhbh.ToString();
            DataSet ds = new YHJSB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            JS2[] jsRole_list = new JS2[length];
            for (int i = 0; i < length; i++)
            {
                jsRole_list[i]=new JS2();
                jsRole_list[i].JSBH = int.Parse(ds.Tables[0].Rows[i]["JSBH"].ToString());
                jsRole_list[i] = new JSRole_DAL().GetModel(jsRole_list[i].JSBH);
            }
            return jsRole_list;
        }

        //获取用户的角色数
        public int getJSCount_byYH(string yhbh)
        {
            string sql = "yhbh=" + yhbh.ToString();
            DataSet ds = new YHJSB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            return length;
        
        }

    }
}