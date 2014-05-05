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
    public partial class xgyjzbData : System.Web.UI.Page
    {
        protected int xkbh;

        protected int yjzbbh;

        protected string yjzbmc;

        protected int yjzbqz;

        protected string yjzbbz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                string syjzbbh = Request["yjzbbh"] == null ? "" : Request["yjzbbh"].ToString();
                yjzbmc = Request["yjzbmc"] == null ? "" : Request["yjzbmc"].ToString();
                string syjzbqz = Request["yjzbqz"] == null ? "" : Request["yjzbqz"].ToString();
                yjzbbz = Request["bz"] == null ? "" : Request["bz"].ToString();
                yjzbbh = int.Parse(syjzbbh);
                yjzbqz = int.Parse(syjzbqz);
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
            }
        }
    }
}