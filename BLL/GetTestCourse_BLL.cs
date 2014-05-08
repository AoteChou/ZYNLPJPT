using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using System.Data;


namespace ZYNLPJPT.BLL
{
    public class GetTestCourse_BLL
    {

        //根据教师的用户编号，获取出题信息列表
        public DataSet Get_testcourse(String yhbh)  
        {
            
            String sql = " CTR="+yhbh+"";
            DataSet ds_ct= new CTView_DAL().GetList(sql);
            return ds_ct;
        }

     
        //根据课程编号，获取课程信息
       
        public List<KC> Get_courseinfo(String kcbh)
        {
            String sql = "KCBH="+"'"+kcbh+"'";
           
            List<KC> course_list = new List<KC>();
            DataSet ds = new KC_DAL().GetList(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                KC kc = new KC();
                kc.KCBH =Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                kc.KCJJ = ds.Tables[0].Rows[i][1].ToString();
                kc.KCMC = ds.Tables[0].Rows[i][2].ToString();
                kc.KCFZR = ds.Tables[0].Rows[i][3].ToString();
                kc.KKXK = Convert.ToInt32(ds.Tables[0].Rows[i][4].ToString());
                course_list.Add(kc);
            }

            return course_list;
        }
 
        //由出题人编号获取出题信息
        public List<CTView> Get_CTinfo(String ctr)
        {
            String sql = " CTR="+"'"+ctr+"'";
           
            List<CTView> ctinfo_list = new List<CTView>();
            DataSet ds = new CTView_DAL().GetList(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CTView ctview = new CTView();
                ctview.KCMC = ds.Tables[0].Rows[i]["KCMC"].ToString();
                ctview.KCBH = Convert.ToInt32(ds.Tables[0].Rows[i]["KCBH"].ToString());
                ctview.ZYM = ds.Tables[0].Rows[i]["ZYM"].ToString();
                ctview.KCXZMC = ds.Tables[0].Rows[i]["KCXZMC"].ToString();
                ctview.XM = ds.Tables[0].Rows[i]["XM"].ToString();

                ctinfo_list.Add(ctview);
            }

            return ctinfo_list;
        }

       
    }
         
    }
 