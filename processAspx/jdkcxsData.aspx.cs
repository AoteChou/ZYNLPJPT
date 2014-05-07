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
    public partial class jdkcxsData : System.Web.UI.Page
    {
        protected int xkbh;

        protected int njbh;

        protected int jdbh;

        protected int kcbh;

        protected int zybh;

        protected BjXsDetailView[] bjXsDetailViews;

        protected JsTeaDetailView[] jsTeaDetailViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else {
                if (Request["xkbh"] == null || Request["xkbh"].ToString() == "" || Request["njbh"] == null || Request["njbh"].ToString() == "" || Request["jdbh"] == null || Request["jdbh"].ToString() == "" || Request["kcbh"] == null || Request["kcbh"].ToString() == "" || Request["zybh"] == null || Request["zybh"].ToString() == "")
                {
                    this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                    this.Response.End();
                }
                else {
                    xkbh = int.Parse(Request["xkbh"].ToString());
                    njbh = int.Parse(Request["njbh"].ToString());
                    kcbh = int.Parse(Request["kcbh"].ToString());
                    jdbh = int.Parse(Request["jdbh"].ToString());
                    zybh = int.Parse(Request["zybh"].ToString());
                    bjXsDetailViews = new BjXsDetailView_DAL().getArray(kcbh,zybh,njbh,jdbh);
                    jsTeaDetailViews = new JsTeaDetailView_DAL().getArray(kcbh,zybh,njbh,jdbh,xkbh);
                }
            }
        }
    }
}