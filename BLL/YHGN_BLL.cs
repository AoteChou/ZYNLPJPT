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
    public class YHGN_BLL
    {
        //获取某一用户现有功能外的其他功能
        public GND[] get_addGN(string yhbh)
        {
            string sql = "  gnbh not in(select gnbh from YHGNB where yhbh=" + yhbh.ToString() + ")";
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

        //获取某一用户现有功能外的其他功能数
        public int get_GNcount(string yhbh)
        {
            string sql = "  gnbh not in(select gnbh from YHGNB where yhbh=" + yhbh.ToString()+")";
            DataSet ds = new GND_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            return length;
        }

        //获取某一用户对应的用户功能点
        public YHGNB[] get_GNListByYH(string yhbh)
        {
            string sql = "yhbh=" + yhbh.ToString();
            DataSet ds = new YHGNB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            YHGNB[] yhgn_list = new YHGNB[length];
            //GND[]gnd_list=new GND[length];
            for (int i = 0; i < length; i++)
            {
                yhgn_list[i] = new YHGNB();
                yhgn_list[i].YHBH = yhbh;
                yhgn_list[i].GNBH = int.Parse(ds.Tables[0].Rows[i]["GNBH"].ToString());

                //   gnd_list[i] = new GND();
                //  gnd_list[i] = new GND_DAL().GetModel(jsgn_list[i].GNBH);
            }

            return yhgn_list;
        }

        //获取某一用户对应的用户功能点数
        public int getCountByYH(string yhbh)
        {
            string sql = "yhbh=" + yhbh.ToString();
            DataSet ds = new YHGNB_DAL().GetList(sql);
            int length = ds.Tables[0].Rows.Count;
            return length;
        }
    }
}