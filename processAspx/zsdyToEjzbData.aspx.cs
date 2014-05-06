using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class zsdyToEjzbData : System.Web.UI.Page
    {
        protected int xkbh;

        protected int zslybh;

        protected int zsdybh;

        protected NLZBViewWrapperForCK[] nlzbViewWrappers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                YH yh = (YH)Session["yh"];
                if (Request["xkbh"] == null || Request["xkbh"].ToString() == "" || Request["zslybh"] == null || Request["zslybh"].ToString() == "" || Request["zsdybh"] == null || Request["zsdybh"].ToString() == "")
                {
                    Response.Redirect("../Default.htm");
                }
                else {
                    xkbh = int.Parse(Request["xkbh"].ToString());
                    zslybh = int.Parse(Request["zslybh"].ToString());
                    zsdybh = int.Parse(Request["zsdybh"].ToString());
                }

                NLZBView[] nlzbViews = new NLZBView_DAL().getArrayByXkbh(xkbh);
                XK xk = new XK_DAL().GetModel(xkbh);
                int length = nlzbViews.Length;
                nlzbViewWrappers = new NLZBViewWrapperForCK[length];
                for (int i = 0; i < length; i++)
                {
                    nlzbViewWrappers[i] = new NLZBViewWrapperForCK(nlzbViews[i], xk.XKMC);
                }
            }
        }
    }
}