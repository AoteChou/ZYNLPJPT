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
    public partial class xgzsdData : System.Web.UI.Page
    {
        protected int xkbh;

        protected int zsdbh;

        protected string zsdmc;

        protected int zslybh;

        protected string zslymc;

        protected int zsdybh;

        protected string zsdymc;

        protected int zsdqz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zsdmc = Request["zsdmc"] == null ? "" : Request["zsdmc"].ToString().Trim();
                zslymc = Request["zslymc"] == null ? "" : Request["zslymc"].ToString().Trim();
                zsdymc = Request["zsdymc"] == null ? "" : Request["zsdymc"].ToString().Trim();

                string szsdbh = Request["zsdbh"] == null ? "" : Request["zsdbh"].ToString();
                string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
                string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString();
                string szsdqz = Request["zsdqz"] == null ? "" : Request["zsdqz"].ToString();
                zsdqz = int.Parse(szsdqz);
                zsdbh=int.Parse(szsdbh);
                zslybh = int.Parse(szslybh);
                zsdybh = int.Parse(szsdybh);
            }
        }
    }
}