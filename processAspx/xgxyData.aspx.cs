using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZYNLPJPT.processAspx
{
    public partial class xgxyData : System.Web.UI.Page
    {
        protected int xybh;

        protected string xymc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                xymc = Request["xymc"] == null ? "" : Request["xymc"].ToString();
                xybh = int.Parse(Request["xybh"]);
            }
        }
    }
}