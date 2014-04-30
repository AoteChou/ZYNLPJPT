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
    public partial class scJdkcProc : System.Web.UI.Page
    {
        protected int jdbh;

        protected int njbh;

        protected int zybh;

        protected ZYKCView[] zykcViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else
            {
                zybh = int.Parse(Request["zybh"].ToString());
                jdbh = int.Parse(Request["jdbh"].ToString());
                njbh = int.Parse(Request["njbh"].ToString());
                string queryZym = Request["zym"].ToString();
                int xkbh = int.Parse(Request["xkbh"].ToString());
                zykcViews = new ZYKCView_DAL().GetArrayInJDKC(xkbh, queryZym, jdbh, njbh, zybh);
            }
        }
    }
}