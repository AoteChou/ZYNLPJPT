using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class DelyhjsProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh = Request["yhbh"] == null ? null : Request["yhbh"].ToString();
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            if (yhbh== null || jsbh_str == null || yhbh == "" || jsbh_str == "")
                Response.Write(false);
            else
            {
                
                int jsbh = int.Parse(jsbh_str);
               bool del= new YHJSB_DAL().Delete(yhbh, jsbh);
               if (del == false)
                   Response.Write("<script language=javascript>alert('删除失败！')</script>");
               else
                   Response.End();
            }
        }
    }
}