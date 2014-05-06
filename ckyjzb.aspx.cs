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
    public partial class ckyjzb : System.Web.UI.Page
    {
        protected YjzbWrapper[] yjzbWrappers;

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

    public class YjzbWrapper
    {

        private YJZB yjzb;

        public YJZB Yjzb
        {
            get { return yjzb; }
            set { yjzb = value; }
        }

        private string xkName;

        public string XkName
        {
            get { return xkName; }
            set { xkName = value; }
        }

        public YjzbWrapper(YJZB _yjzb, string _xkName)
        {
            yjzb = _yjzb;
            xkName = _xkName;
        }
    }

}