using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT
{
    public partial class addYHJs : System.Web.UI.Page
    {
       protected  string yhbh;
       protected int length;
       protected YHJSB[] yhjs_list;
       protected JS2[] js_list;
        protected void Page_Load(object sender, EventArgs e)
        {
            yhbh = Request["yhbh"] == null ? null : Request["yhbh"].ToString();
            string sql = " jsbh not in(select jsbh from YHJSB where yhbh="+yhbh+")";
            DataSet ds= new JSRole_DAL().GetList(sql);
            length = ds.Tables[0].Rows.Count;
            yhjs_list = new YHJSB[length];
            js_list = new JS2[length];

            for (int i = 0; i < length; i++)
            {
                js_list[i] = new JS2();
                js_list[i] =new JSRole_DAL().GetModel( int.Parse(ds.Tables[0].Rows[i]["JSBH"].ToString()));         
            }
        }
    }
}