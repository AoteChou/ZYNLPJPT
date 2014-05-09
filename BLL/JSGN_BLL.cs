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
    public class JSGN_BLL
    {
        //获取某一角色现有功能外的其他功能
        public  GND[]  get_addGN(int jsbh)
        {
            string sql = "  gnbh not in(select gnbh from JSGNB where jsbh=" + jsbh.ToString() + ")";
            DataSet ds = new GND_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            GND[] gn_list;
            gn_list = new GND[length];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                gn_list[i] = new GND();
                gn_list[i] = new GND_DAL().GetModel(int.Parse(ds.Tables[0].Rows[i]["gnbh"].ToString()));
            }

            return gn_list;
        }

        //获取某一角色现有功能外的其他功能数
        public int get_GNcount(int jsbh)
        {
            string sql = "  gnbh not in(select gnbh from JSGNB where jsbh=" + jsbh.ToString() + ")";
            DataSet ds = new GND_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            return length;
        }

        //获取某一角色对应的角色功能点
        public JSGNB[] get_GNListByJS(int jsbh)
        {
            string sql = "jsbh="+jsbh.ToString();
            DataSet ds = new JSGNB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            JSGNB[] jsgn_list = new JSGNB[length];
          //GND[]gnd_list=new GND[length];
            for (int i = 0; i < length; i++)
            {
                jsgn_list[i] = new JSGNB();
                jsgn_list[i].JSBH = jsbh;
                jsgn_list[i].GNBH = int.Parse(ds.Tables[0].Rows[i]["GNBH"].ToString());

             //   gnd_list[i] = new GND();
             //  gnd_list[i] = new GND_DAL().GetModel(jsgn_list[i].GNBH);
            }

            return jsgn_list;
        }

        //获取某一角色对应的角色功能点数
        public int getCountByJs(int jsbh)
        {
            string sql = "jsbh=" + jsbh.ToString();
            DataSet ds = new JSGNB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            return length;
        }

    }
}