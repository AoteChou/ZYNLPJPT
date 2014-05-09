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
    public partial class Guanlijsyh : System.Web.UI.Page
    {
        protected string[] xkbh;
        protected string[] xkmc;
        protected string[] xymc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                DataSet ds = new XK_DAL().GetList("");
                xkbh = new string[ds.Tables[0].Rows.Count];
                xkmc = new string[ds.Tables[0].Rows.Count];
                xymc = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    xkbh[i] = ds.Tables[0].Rows[i]["XKBH"].ToString();
                    xkmc[i] = ds.Tables[0].Rows[i]["XKMC"].ToString();
                    string xybh = ds.Tables[0].Rows[i]["XYBH"].ToString();
                    XY xy = new XY_DAL().GetModel(int.Parse(xybh));
                    xymc[i] = xy.XYMC;
                }
            }
        }
    }
}