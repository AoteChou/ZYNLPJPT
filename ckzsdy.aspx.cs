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
    public partial class ckzsdy : System.Web.UI.Page
    {
        protected ZsnlViewWrapper[] zsnlViewWrappers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                YH yh = (YH)Session["yh"];
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zsnlViewWrappers = new ZSNLView_DAL().getArrayByXkbhForWrapper(xkbh);
            }
        }
    }

    public class ZsnlViewWrapper{
        
        private ZSNLView zsnlView;

        public ZSNLView ZsnlView
        {
          get { return zsnlView; }
          set { zsnlView = value; }
        }

        private string xkmc;

        public string Xkmc
        {
          get { return xkmc; }
          set { xkmc = value; }
        }
    }

}