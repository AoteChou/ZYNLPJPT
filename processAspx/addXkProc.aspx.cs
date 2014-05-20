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
    public partial class addXkProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string xyMc = Request["xyName"] == null ? "" : Request["xyName"].ToString().Trim();
            string xkmc = Request["xkMc"] == null ? "" : Request["xkMc"].ToString().Trim();
            if (xyMc == null || xyMc == ""||xkmc==null||xkmc=="")
            {
                result = false;
            }
            else
            {
                XY xy = new XY_DAL().GetModelByXymc(xyMc);
                XK_DAL xkDal = new XK_DAL();
                if (xkDal.Exists(xkmc))
                {
                    result = false;
                }
                else
                {
                    XK xk = new XK();
                    xk.XKFZR = null;
                    xk.XKMC = xkmc;
                    xk.XYBH = xy.XYBH;
                    if (xkDal.Add(xk))
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