using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.BLL
{
    public class ST_BLL
    {
    

        //由出题人编号和课程编号获得试题列表
        public List<ST> get_ST_ByCTR(string ctrbh,int kcbh)
        {

            string sql = " ctr=" + ctrbh+" and kcbh="+kcbh.ToString();
           List<ST> st_list=new List<ST>();
           DataSet ds = new ST_DAL().GetList(sql);
           for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           {
               ST st = new ST();
               st.STBH=int.Parse(ds.Tables[0].Rows[i]["STBH"].ToString());
               st.KCBH = int.Parse(ds.Tables[0].Rows[i]["KCBH"].ToString());
               st.HZM = ds.Tables[0].Rows[i]["HZM"].ToString();
               st.SFSC = bool.Parse(ds.Tables[0].Rows[i]["SFSC"].ToString());
               st.SFZDYJ=bool.Parse(ds.Tables[0].Rows[i]["SFZDYJ"].ToString());
               st.TMDA = System.Text.Encoding.Default.GetBytes(ds.Tables[0].Rows[i]["TMDA"].ToString());
               st.TMNR = System.Text.Encoding.Default.GetBytes(ds.Tables[0].Rows[i]["TMNR"].ToString());
               st_list.Add(st);
           }

           return st_list;
        }

        //获取试题列表长度
        public int get_Length(string ctrbh,int kcbh)
        {
            string sql = " ctr=" + ctrbh+" and kcbh="+kcbh;
            List<ST> st_list = new List<ST>();
            DataSet ds = new ST_DAL().GetList(sql);
            return ds.Tables[0].Rows.Count;
        
        }
 
        //获取试题所在的课程名称
        public string get_kcmc_Bystbh(int stbh)
        {
            ST st = new ST_DAL().GetModel(stbh);
            return new KC_DAL().GetModel(st.KCBH).KCMC.ToString();
        }
 
    }

} 