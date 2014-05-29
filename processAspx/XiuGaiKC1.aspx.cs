using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class XiuGaiKC1 : System.Web.UI.Page
    {
        protected string kcbh;
        protected string kcjj; 
        protected string kcmc;
        protected string kcfzr;
        protected string kkxk;
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
                kcbh = Request["kcbh"];
                DataSet ds = new KC_DAL().GetList("kcbh=" + kcbh);
                int alength = ds.Tables[0].Rows.Count;

                XK_DAL xk_dal = new XK_DAL();
                DataSet ds1 = xk_dal.GetList("");
                xkbh = new string[ds1.Tables[0].Rows.Count];
                xkmc = new string[ds1.Tables[0].Rows.Count];

                 if(ds.Tables[0].Rows.Count>0)
                {
                    kcmc= ds.Tables[0].Rows[0]["kcmc"].ToString();
                    kkxk = ds.Tables[0].Rows[0]["kkxk"].ToString();
                    kcfzr = ds.Tables[0].Rows[0]["kcfzr"].ToString()==""?"-1":kcfzr;
                    kcjj = ds.Tables[0].Rows[0]["kcjj"].ToString();
                }

                 for (int n = 0; n < ds1.Tables[0].Rows.Count; n++)
                 {
                     xkmc[n] = ds1.Tables[0].Rows[n]["xkmc"].ToString();
                     xkbh[n] = ds1.Tables[0].Rows[n]["xkbh"].ToString();
                 }


            }
        }
    }
}