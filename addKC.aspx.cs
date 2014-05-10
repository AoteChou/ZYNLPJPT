using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class addKC : System.Web.UI.Page
    {
        protected string[] kcbh;
        protected string[] kcjj;
        protected string[] kcmc;
        protected string[] kcfzr;
        protected string[] kkxk;
        protected string[] xkmc;
        protected string[] xkbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                KC_DAL kc_dal = new KC_DAL();
                DataSet ds = kc_dal.GetList("");
                XK_DAL xk_dal = new XK_DAL();
                DataSet ds1 = xk_dal.GetList("");




                xkbh = new string[ds1.Tables[0].Rows.Count];
                xkmc = new string[ds1.Tables[0].Rows.Count];

                for (int n = 0; n < ds1.Tables[0].Rows.Count; n++)
                {
                    xkmc[n] = ds1.Tables[0].Rows[n]["xkmc"].ToString();
                    xkbh[n] = ds1.Tables[0].Rows[n]["xkbh"].ToString();
                }



            }
        }
    }
}