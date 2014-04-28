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
    public partial class pzEjzbProc : System.Web.UI.Page
    {
        protected int zybh;

        protected int xkbh;

        protected NLZBView[] nlzbViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else {
                zybh = int.Parse(Request["zybh"].ToString());
                xkbh = int.Parse(Request["xkbh"].ToString());
                nlzbViews = new NLZBView_DAL().getArrayByXkbhAndZybh(xkbh,zybh);
            }
        }
    }
}