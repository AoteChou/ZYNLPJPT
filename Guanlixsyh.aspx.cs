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
    public partial class Guanlixsyh : System.Web.UI.Page
    {
        protected string[] zymc;
        protected string[] bjbh;
        protected string[] bjmc;
        protected string[] rxnf;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                DataSet ds = new BJ_DAL().GetList("");
                zymc = new string[ds.Tables[0].Rows.Count];
                bjbh = new string[ds.Tables[0].Rows.Count];
                bjmc = new string[ds.Tables[0].Rows.Count];
                rxnf = new string[ds.Tables[0].Rows.Count];
                for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
                {
                    bjbh[n] = ds.Tables[0].Rows[n]["BJBH"].ToString();
                    bjmc[n] = ds.Tables[0].Rows[n]["BJMC"].ToString();


                    string zybh = ds.Tables[0].Rows[n]["ZYBH"].ToString();
                    ZY zy = new ZY_DAL().GetModel(int.Parse(zybh));
                    zymc[n] = zy.ZYM;
                    rxnf[n] = ds.Tables[0].Rows[n]["RXNF"].ToString();
                }
            }
        }
    }
}