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
    public partial class ckejzb : System.Web.UI.Page
    {
        protected NLZBViewWrapperForCK[] nlzbViewWrappers;

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

    public class NLZBViewWrapperForCK {

        public NLZBViewWrapperForCK(NLZBView _nlzbView, string _xkmc)
        {
            nlzbView = _nlzbView;
            xkmc = _xkmc;
        }

        private NLZBView nlzbView;

        public NLZBView NlzbView
        {
            get { return nlzbView; }
            set { nlzbView = value; }
        }

        private string xkmc;

        public string Xkmc
        {
            get { return xkmc; }
            set { xkmc = value; }
        }
    }

}