using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class addxk : System.Web.UI.Page
    {
        protected string[] xyNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                xyNames = new XY_DAL().getAllArrayByStr();
            }
        }
    }
}