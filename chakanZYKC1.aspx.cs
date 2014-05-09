using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class chakanZYKC1 : System.Web.UI.Page
    {
        protected ZYKCView[] zykcViews;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                DataSet ds = new ZY_DAL().GetList("");
                zykcViews = new ZYKCView[ds.Tables[0].Rows.Count];
                for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
                {
                    string zybh = ds.Tables[0].Rows[n]["ZYBH"].ToString();
                    string xkbh = ds.Tables[0].Rows[n]["XKBH"].ToString();
                    XK xk = new XK_DAL().GetModel(int.Parse(xkbh));

                    string zym = ds.Tables[0].Rows[n]["ZYM"].ToString();
                    ZYKCView zykcviewTemp = new ZYKCView();


                    zykcviewTemp.ZYBH = int.Parse(zybh);
                    zykcviewTemp.XKMC = xk.XKMC;
                    zykcviewTemp.ZYM = zym;

                    zykcViews[n] = zykcviewTemp;
                }
            }
        }
    }
}