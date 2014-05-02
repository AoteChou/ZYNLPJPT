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
    public partial class addZsdyToEjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string ejzbbh = Request["ejzbbh"] == null ? "" : Request["ejzbbh"].ToString().Trim();
            string zslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString().Trim();
            string zsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString().Trim();
            if (ejzbbh == null || ejzbbh == "" || zslybh == null || zslybh == "" || zsdybh == null || zsdybh == "")
            {
                result = false;
            }
            else
            {
                int iEjzbbh = int.Parse(ejzbbh);
                int iZslybh = int.Parse(zslybh);
                int iZsdybh = int.Parse(zsdybh);

                ZSDY zsdy = new ZSDY();
                zsdy.EJZBBH = iEjzbbh;
                zsdy.ZSLYBH = iZslybh;
                zsdy.ZSDYBH = iZsdybh;

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