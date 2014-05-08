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
    public partial class xgXyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string xyMc = Request["xyMc"] == null ? "" : Request["xyMc"].ToString().Trim();
            string sxybh = Request["xybh"] == null ? "" : Request["xybh"].ToString().Trim();
            if (xyMc == null || xyMc == ""||sxybh==""||sxybh==null)
            {
                result = false;
            }
            else
            {
                XY xy = new XY();
                int xybh = int.Parse(sxybh);
                xy.XYMC = xyMc.Trim();
                xy.XYBH = xybh;
                XY_DAL xyDal = new XY_DAL();
                if (xyDal.Exists(xyMc,xybh))
                {
                    result = false;
                }
                else
                {
                    if (xyDal.Update(xy))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}