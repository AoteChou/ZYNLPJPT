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
    public partial class xgzslyData : System.Web.UI.Page
    {
        protected int xkbh;

        protected int zslybh;

        protected string zslymc;

        protected string bz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
                zslymc = Request["zslymc"] == null ? "" : Request["zslymc"].ToString();
                bz = Request["bz"] == null ? "" : (Request["bz"].ToString() == "暂无" ? "" : Request["bz"].ToString());
                zslybh = int.Parse(szslybh);
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
            }
        }
    }
}