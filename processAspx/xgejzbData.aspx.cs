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
    public partial class xgejzbData : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] yjzbNames;

        protected int ejzbbh;

        protected string ejzbmc;

        protected string yjzbmc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                ejzbmc = Request["ejzbmc"] == null ? "" : Request["ejzbmc"].ToString();
                yjzbmc = Request["yjzbmc"] == null ? "" : Request["yjzbmc"].ToString();
                string sejzbbh = Request["ejzbbh"] == null ? "" : Request["ejzbbh"].ToString();
                ejzbbh = int.Parse(sejzbbh);
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                yjzbNames = new YJZB_DAL().getArrayByXkbh(xkbh);
            }
        }
    }
}