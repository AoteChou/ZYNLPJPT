using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;


namespace ZYNLPJPT.processAspx
{
    public partial class addJSProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string jsmc = Request["jsmc"] == null?null: Request["jsmc"].ToString().Trim();
            if (jsmc == "" || jsmc == null)
                Response.Write(false);
            else
            {
                JS2 js = new JS2();
                js.JSM = jsmc;
                new JSRole_DAL().Add(js);
            }

        }
    }
}