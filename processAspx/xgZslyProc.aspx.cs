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
    public partial class xgZslyProc : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zslyMc = Request["zslyMc"] == null ? "" : Request["zslyMc"].ToString().Trim();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
            if (zslyMc == null || zslyMc == "" || sXkbh == null || sXkbh == ""||szslybh==null||szslybh=="")
            {
                result = false;
            }
            else
            {
                string zslyJj = Request["zslyJj"] == null ? "" : Request["zslyJj"].ToString().Trim();
                int zslybh = int.Parse(szslybh);
                int iXkbh = int.Parse(sXkbh);
                ZSLY zsly = new ZSLY();
                zsly.ZSLYMC = zslyMc;
                zsly.BZ = zslyJj;
                zsly.XKBH = iXkbh;
                zsly.ZSLYBH = zslybh;
                if (new ZSLY_DAL().Update(zsly))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}