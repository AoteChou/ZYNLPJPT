using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class addZsdyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zsdyMc = Request["zsdyMc"] == null ? "" : Request["zsdyMc"].ToString().Trim();
            string zslyName = Request["zslyName"] == null ? "" : Request["zslyName"].ToString().Trim();
            if (zsdyMc == null || zsdyMc == "" || zslyName == null || zslyName == "")
            {
                result = false;
            }
            else {
                string zsdyBz = Request["zsdyBz"] == null ? "" : Request["zsdyBz"].ToString().Trim();
                ZSLY zsly = new ZSLY_DAL().GetModel(zslyName);
                ZSDY zsdy = new ZSDY();
                zsdy.ZSDYMC = zsdyMc;
                zsdy.ZSLYBH = zsly.ZSLYBH;
                zsdy.EJZBBH = null;
                zsdy.BZ = zsdyBz;
                int i= new ZSDY_DAL().Add(zsdy);
                if (i == 0)
                {
                    result = false;
                }
                else {
                    result = true;
                }
            }
            Response.Write(result);
            Response.End();

        }
    }
}