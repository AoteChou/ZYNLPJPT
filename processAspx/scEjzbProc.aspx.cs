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
    public partial class scEjzbProc : System.Web.UI.Page
    {
        protected int zybh;

        protected  int xkbh;

        protected NLZBViewWrapper[] NLZBViewWrappers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else
            {
                zybh = int.Parse(Request["zybh"].ToString());
                xkbh = int.Parse(Request["xkbh"].ToString());
                NLZBViewWrappers = new NLZBView_DAL().getArrayInZyejzbByXkbhAndZybhForSC(xkbh, zybh);
            }
        }
    }

    public class NLZBViewWrapper {

        public NLZBViewWrapper() {
            nlzbView = new NLZBView();
        }

        private NLZBView nlzbView;

        public NLZBView NlzbView
        {
            get { return nlzbView; }
            set { nlzbView = value; }
        }

        private int nlyq;

        public int Nlyq
        {
            get { return nlyq; }
            set { nlyq = value; }
        }

    }

}