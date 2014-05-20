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
    public partial class scCtrProc : System.Web.UI.Page
    {
        protected JSRoleYHView[] jsRoleYhView;

        protected int kcbh;

        protected int zybh;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                kcbh = int.Parse(Request["kcbh"].ToString());
                zybh = int.Parse(Request["zybh"].ToString());
                int xkbh = int.Parse(Request["xkbh"].ToString());
                jsRoleYhView = new JSRoleYHView_DAL().getArrayInCtr(xkbh, zybh, kcbh);
            }
        }
    }
}