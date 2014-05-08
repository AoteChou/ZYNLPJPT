using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using System.IO;
using Brettle.Web.NeatUpload;
using System.Data;


namespace ZYNLPJPT
{
    public partial class ctRecord : System.Web.UI.Page
    { 
         
        protected int kcbh;                                                        //课程编号
        protected ST []st_list;                                                    //试题
        protected int st_list_length;                                           //试题列表长度
        protected void Page_Load(object sender, EventArgs e)
         {
             if (Session["yh"] == null)
             {
                 Response.Redirect("../Default.htm");
             }

             else
             {
               
                 YH yh = (YH)Session["yh"];
                 string ctrbh = yh.YHBH.ToString();                
                 kcbh = int.Parse(Request["kcbh"]);
                 st_list_length=new ST_BLL().get_Length(ctrbh,kcbh);
                 st_list=new ST[st_list_length];
                 for (int i = 0; i < new ST_BLL().get_Length(ctrbh,kcbh); i++)
                 {
                     st_list[i] = new ST_BLL().get_ST_ByCTR(ctrbh,kcbh).ElementAt(i);
                 }
                 
             }

         }

     //由课程编号获取课程名称
     public string get_kcmc(int kcbh)
     {
       return   new gt_BLL().get_kcmc_Bykcbh(kcbh);
     }
  
     //判断某一试题是否设置了知识点比重
     public bool if_Set_ZSDBZ(ST st)
     {
         string sql = " stbh="+st.STBH;
         DataSet ds = new STZSDB_DAL().GetList(sql);
         if (ds == null)
             return false;
         else
             return true;
     }

      
    
   }

  
}