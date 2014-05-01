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
    public partial class addXyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string xyMc = Request["xyMc"] == null ? "" : Request["xyMc"].ToString().Trim();
            if (xyMc == null || xyMc == "")
            {
                result = false;
            }
            else
            {
                XY xy = new XY();
                xy.XYMC = xyMc.Trim();
                XY_DAL xyDal = new XY_DAL();
                if (xyDal.Exists(xyMc))
                {
                    result = false;
                }
                else {
                    int i = xyDal.Add(xy);
                    if (i == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }    
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}