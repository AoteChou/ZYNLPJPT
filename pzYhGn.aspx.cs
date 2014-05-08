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
using System.Data;

namespace ZYNLPJPT
{
    public partial class pzYhGn : System.Web.UI.Page
    {
       
        protected  YH[] yh_list;
        protected  int length;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql=" yhbh!=''";
            length = new YH_DAL().GetRecordCount(sql);     
            yh_list=new YH[length];
            DataSet ds=new YH_DAL().GetList(sql);
            for (int i = 0; i < length; i++)
            {
                yh_list[i] = new YH();
                yh_list[i].YHBH=ds.Tables[0].Rows[i]["YHBH"].ToString();
                yh_list[i].XM=ds.Tables[0].Rows[i]["XM"].ToString();
                yh_list[i].MM=ds.Tables[0].Rows[i]["MM"].ToString();
               yh_list[i].XB=bool.Parse(ds.Tables[0].Rows[i]["XB"].ToString());

            }

        }
    
    }
}
 