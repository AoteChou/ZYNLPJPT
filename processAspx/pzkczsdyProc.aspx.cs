using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class pzkczsdyProc : System.Web.UI.Page
    {
        protected int kcbh;

        protected ZSNLView[] zsnlViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else {
                int xkbh = int.Parse(Request["xkbh"]);
                kcbh = int.Parse(Request["kcbh"]);
                zsnlViews = new ZSNLView_DAL().getArrayNotInKCZsdyByXkbh(xkbh,kcbh);
            }
        }
    }
}