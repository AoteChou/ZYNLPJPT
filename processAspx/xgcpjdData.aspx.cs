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
    public partial class xgcpjdData : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] zyms;

        protected string[] njNames;

        protected int njbh;

        protected int zybh;

        protected int jdbh;

        protected string jdmc;

        protected string njmc;

        protected string zymc;

        protected string qsxq;

        protected string jzxq;

        protected string bz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
                string szybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
                string sjdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
                jdmc = Request["jdmc"] == null ? "" : Request["jdmc"].ToString();
                njmc = Request["njmc"] == null ? "" : Request["njmc"].ToString();
                zymc = Request["zymc"] == null ? "" : Request["zymc"].ToString();
                qsxq = Request["qsxq"] == null ? "" : Request["qsxq"].ToString();
                jzxq = Request["jzxq"] == null ? "" : Request["jzxq"].ToString();
                bz = Request["bz"] == null ? "" : (Request["bz"].ToString() == "暂无" ? "" : Request["bz"].ToString());
                njbh = int.Parse(snjbh);
                zybh = int.Parse(szybh);
                jdbh = int.Parse(sjdbh);
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zyms = new ZY_DAL().getArrayByXkbh(xkbh);
                njNames = new NJ_DAL().getArray();

            }
        }
    }
}