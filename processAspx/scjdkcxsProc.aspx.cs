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
    public partial class scjdkcxsProc : System.Web.UI.Page
    {
        protected int xkbh;

        protected int njbh;

        protected int kcbh;

        protected int jdbh;

        protected int zybh;

        protected JDKCXSNewView[] jdkcxsNewViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }else
            {
                xkbh = int.Parse(Request["xkbh"].ToString());
                njbh = int.Parse(Request["njbh"].ToString());
                kcbh = int.Parse(Request["kcbh"].ToString());
                jdbh = int.Parse(Request["jdbh"].ToString());
                zybh = int.Parse(Request["zybh"].ToString());
                jdkcxsNewViews = new JDKCXSNewView_DAL().getArray(xkbh,njbh,kcbh,jdbh,zybh);
            }
        }
    }
}