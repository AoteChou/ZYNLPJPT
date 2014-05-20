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
    public partial class xgXkProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string xkMc = Request["xkMc"] == null ? "" : Request["xkMc"].ToString().Trim();
            string sxybh = Request["xybh"] == null ? "" : Request["xybh"].ToString().Trim();
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            if (xkMc == null || xkMc == "" || sxybh == "" || sxybh == null||sxkbh==null||sxkbh=="")
            {
                result = false;
            }
            else
            {
                int xybh = int.Parse(sxybh);
                int xkbh = int.Parse(sxkbh);
                XK_DAL xkDal = new XK_DAL();
                if (xkDal.Exists(xkbh,xkMc,xybh))
                {
                    result = false;
                }
                else
                {
                    XK xk = new XK();
                    xk.XKBH = xkbh;
                    xk.XYBH = xybh;
                    xk.XKMC = xkMc;
                    if (xkDal.UpdateForXG(xk))
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