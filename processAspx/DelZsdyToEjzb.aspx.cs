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
    public partial class DelZsdyToEjzb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
            string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString();
            if (szslybh == null || szslybh == "" ||  szsdybh == null || szsdybh == "")
            {
                result = false;
            }
            else
            {
                int zslybh = int.Parse(szslybh);
                int zsdybh = int.Parse(szsdybh);
                ZSDY zsdy = new ZSDY();
                zsdy.ZSLYBH = zslybh;
                zsdy.ZSDYBH = zsdybh;
                zsdy.EJZBBH = null;
                if (new ZSDY_DAL().UpdateEJZBBH(zsdy))
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