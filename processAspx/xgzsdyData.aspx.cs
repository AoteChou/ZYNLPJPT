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
    public partial class xgzsdyData : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] zslyNames;

        protected int zsdybh;

        protected string zslymc;

        protected string zsdymc;

        protected string bz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString();
                zslymc = Request["zslymc"] == null ? "" : Request["zslymc"].ToString();
                zsdymc = Request["zsdymc"] == null ? "" : Request["zsdymc"].ToString();
                bz = Request["bz"] == null ? "" : (Request["bz"].ToString() == "暂无" ? "" : Request["bz"].ToString());
                zsdybh = int.Parse(szsdybh);
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zslyNames = new ZSLY_DAL().getArrayByXkbh(xkbh);
            }
        }
    }
}