using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class Guanlixsyh1 : System.Web.UI.Page
    {
        protected string[] yhbh;
        protected string[] mm;
        protected string[] xm;
        protected string[] xb;
        protected string[] rxnf;
        protected string bjbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                bjbh = Request["bjbh"];
                DataSet ds = new XSYHView_DAL().GetList("bjbh=" + bjbh);

                int alength = ds.Tables[0].Rows.Count;
                yhbh = new string[alength];
                mm = new string[alength];
                xm = new string[alength];
                xb = new string[alength];
                rxnf = new string[alength];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    yhbh[i] = ds.Tables[0].Rows[i]["YHBH"].ToString();
                    //XSYH xsyh = new XSYHView_DAL().GetModel(int.Parse(yhbh[i]));
                    mm[i] = ds.Tables[0].Rows[i]["MM"].ToString();
                    xm[i] = ds.Tables[0].Rows[i]["XM"].ToString();
                    xb[i] = ds.Tables[0].Rows[i]["XB"].ToString();
                    xb[i] = ds.Tables[0].Rows[i]["XB"].ToString();
                    if ("True".Equals(xb[i]))
                    {
                        xb[i] = "男";
                    }
                    else
                    {
                        xb[i] = "女";
                    }
                    rxnf[i] = ds.Tables[0].Rows[i]["RXNF"].ToString();
                }
            }
        }
    }
}