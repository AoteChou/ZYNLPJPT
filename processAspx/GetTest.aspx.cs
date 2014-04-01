using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;

namespace ZYNLPJXT.processAspx
{
    public partial class GetTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)(Session["yh"]);
                int kcbh = int.Parse(Request["kcbh"]);
                GetTest_BLL gettest_bll = new GetTest_BLL();
                int teststate = -1;
                int stbh = gettest_bll.getSTBH(yh.YHBH, kcbh, ref teststate);
                Response.Redirect("../TestPage.aspx?stbh=" + stbh + "&teststate=" + teststate);
            }
        }
    }
}