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
    public partial class xgyjzb : System.Web.UI.Page
    {
        protected YjzbWrapper[] yjzbWrappers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                YHJSView yhjsView = new YHJSView_DAL().GetModel(yh.YHBH.Trim());
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;

                YJZB[] yjzbs = new YJZB_DAL().getObjArrayByXkbh(xkbh);
                XK xk = new XK_DAL().GetModel(xkbh);
                int length = yjzbs.Length;
                yjzbWrappers = new YjzbWrapper[length];
                for (int i = 0; i < length; i++)
                {
                    yjzbWrappers[i] = new YjzbWrapper(yjzbs[i], xk.XKMC);
                }
            }
        }
    }
}