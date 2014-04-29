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
    public partial class scKcZsdyProc : System.Web.UI.Page
    {
        protected int kcbh;

        protected int xkbh;

        protected ZSNLView[] zsnlViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else
            {
                kcbh = int.Parse(Request["kcbh"].ToString());
                xkbh = int.Parse(Request["xkbh"].ToString());
                
                zsnlViews = new ZSNLView_DAL().getArrayInKCZsdyByXkbh(xkbh, kcbh);
            }
        }
    }



}