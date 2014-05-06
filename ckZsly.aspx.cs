using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class ckZsly : System.Web.UI.Page
    {
        protected ZSLYDetails[] zslyDetails;

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
                ZSLY[] zslys = new ZSLY_DAL().getModelArrayByXkbh(xkbh);
                XK xk = new XK_DAL().GetModel(xkbh);
                int length=zslys.Length;
                zslyDetails=new ZSLYDetails[length];
                for (int i = 0; i <length; i++) {
                    zslyDetails[i] = new ZSLYDetails(zslys[i], xk.XKMC);
                }
            }
        }
    }

    public class ZSLYDetails{

        private ZSLY zsly;

        public ZSLY Zsly
        {
            get { return zsly; }
            set { zsly = value; }
        }

        private string xkName;

        public string XkName
        {
            get { return xkName; }
            set { xkName = value; }
        }

        public ZSLYDetails(ZSLY _zsly,string _xkName){
            zsly=_zsly;
            xkName=_xkName;
        }
    }

}