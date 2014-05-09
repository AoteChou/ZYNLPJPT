using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class addbj : System.Web.UI.Page
    {
        protected string[] njNames;

        protected string[] xyNames;

        protected string[] xkNames;

        protected string[] zyNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                YH yh = (YH)Session["yh"];
                njNames = new NJ_DAL().getRecentyArray();
                xyNames = new XY_DAL().getAllArrayByStr();
                if (xyNames.Length > 0)
                {
                    xkNames = new XKDetailView_DAL().getStrArray(xyNames[0].Trim());
                    if (xkNames.Length > 0)
                    {
                        zyNames = new XYXKZYDetailView_DAL().getStrArray(xyNames[0],xkNames[0]);
                    }
                    else {
                        zyNames = new string[0];
                    }
                }
                else
                {
                    xkNames = new string[0];
                    zyNames = new string[0];
                }

            }            
        }
    }
}