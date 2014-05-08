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
    public partial class sgjsData : System.Web.UI.Page
    { 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            string jsmc = Request["jsmc"] == null ? null : Request["jsmc"].ToString();
            if (jsbh_str == null || jsmc == null || jsbh_str == "" || jsmc == "")
                Response.Write(false);
            else
            {
                int jsbh = int.Parse(jsbh_str);
                JS2 js = new JS2();
                js.JSBH = jsbh;
                js.JSM = jsmc;
               bool ud= new JSRole_DAL().Update(js);
               if (ud == false)
                   Response.Write("<scirpt language=javascript>alert('更新失败！')</sciprt>");
            }
        }
    }
}