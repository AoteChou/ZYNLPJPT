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
    public partial class xgzsd : System.Web.UI.Page
    {
        protected ZSALLView[] zsAllView;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zsAllView = new ZSALLView_DAL().getArrayByXkbh(xkbh);
            }
        }
    }
}