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
    public partial class xgZsdyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zsdyMc = Request["zsdyMc"] == null ? "" : Request["zsdyMc"].ToString().Trim();
            string zslyName = Request["zslyName"] == null ? "" : Request["zslyName"].ToString().Trim();
            string sZsdyQz = Request["sZsdyQz"] == null ? "" : Request["sZsdyQz"].ToString().Trim();
            string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString().Trim();
            if (zsdyMc == null || zsdyMc == "" || zslyName == null || zslyName == "" || sZsdyQz == null || sZsdyQz == ""||szsdybh==null||szsdybh=="")
            {
                result = false;
            }
            else
            {
                int zsdybh = int.Parse(szsdybh);
                int iZsdyQz = int.Parse(sZsdyQz);
                string zsdyBz = Request["zsdyBz"] == null ? "" : Request["zsdyBz"].ToString().Trim();
                ZSLY zsly = new ZSLY_DAL().GetModel(zslyName);
                ZSDY zsdy = new ZSDY();
                zsdy.ZSDYMC = zsdyMc;
                zsdy.ZSLYBH = zsly.ZSLYBH;
                zsdy.EJZBBH = null;
                zsdy.ZSDYQZ = iZsdyQz;
                zsdy.BZ = zsdyBz;
                zsdy.ZSDYBH = zsdybh;
                if (new ZSDY_DAL().UpdateForXG(zsdy))
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