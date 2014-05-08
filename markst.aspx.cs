using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using  ZYNLPJPT.Utility;
using System.Data;
 
namespace ZYNLPJPT
{
    public partial class markst : System.Web.UI.Page
    { 
         
        protected PCJL[] pcjl_list;                                             //评测记录
        protected GTView[] GTView_list;                                   //改题View
        protected string gtrbh;                                                //改题人编号
        protected string gtrxm;                                               //改题人姓名
        protected int pcjl_num;                                               //所有的评测记录数

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }

           else
            {  
                YH yh = (YH)Session["yh"];
                gtrbh = yh.YHBH;
                string sql = " gtr="+gtrbh;
                DataSet ds=new GTView_DAL().GetList(sql);
                int num=ds.Tables[0].Rows.Count;
                GTView_list = new GTView[num];
               
                for (int i = 0; i < GTView_list.Length; i++)
                {
                    GTView_list[i] = new GTView();
                    GTView_list[i].PCJLBH=int.Parse(ds.Tables[0].Rows[i]["PCJLBH"].ToString());
                    GTView_list[i].GTR =ds.Tables[0].Rows[i]["GTR"].ToString();
                    GTView_list[i].KCBH = int.Parse(ds.Tables[0].Rows[i]["KCBH"].ToString());
                    GTView_list[i].STBH = int.Parse(ds.Tables[0].Rows[i]["STBH"].ToString());
                    GTView_list[i].SCRQ = Convert.ToDateTime(ds.Tables[0].Rows[i]["SCRQ"].ToString());
                    GTView_list[i].XZRQ = Convert.ToDateTime(ds.Tables[0].Rows[i]["XZRQ"].ToString());
                    GTView_list[i].XSBH = ds.Tables[0].Rows[i]["XSBH"].ToString();

                   if(ds.Tables[0].Rows[i]["PCFS"].ToString()!="")
                    GTView_list[i].PCFS =int.Parse(ds.Tables[0].Rows[i]["PCFS"].ToString());
                                              
                }


               pcjl_num = new gt_BLL().get_numOfpcjl();     //所有评测记录数

            }


        }

        //获取GTView中改题人的姓名
        public string get_ctrxm(GTView gtview)
        {
          return  new gt_BLL().get_ctrxm_Byctrbh(gtview.GTR);
        }

        //获取GTView中课程名
        public string get_kcmc(GTView gtview)
        {

            return new gt_BLL().get_kcmc_Bykcbh(gtview.KCBH);
        }
        

   }

}