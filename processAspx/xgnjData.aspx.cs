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
    public partial class xgnjData : System.Web.UI.Page
    {
        protected int njbh;

        protected string njmc;

        protected string rxnf;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                njmc = Request["njmc"] == null ? "" : Request["njmc"].ToString();
                rxnf = Request["rxnf"] == null ? "" : Request["rxnf"].ToString();
                njbh = int.Parse(Request["njbh"]);
            }
        }
    }
}