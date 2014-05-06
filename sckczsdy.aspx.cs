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
    public partial class sckczsdy : System.Web.UI.Page
    {
        protected KCDetailView[] kcDetailViews;

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
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                kcDetailViews = new KCDetailView_DAL().getSCAndCKArray(xkbh);
            }
        }
    }
}