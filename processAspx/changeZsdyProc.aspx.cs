using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class changeZsdyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            string zslyMc = Request["zslyName"] == null ? "" : Request["zslyName"].ToString().Trim();
            if (sXkbh == null || sXkbh == "" || zslyMc == null || zslyMc == "")
            {
                Response.Write(false);
            }
            else {
                int xkbh = int.Parse(sXkbh);
                string[] results = new ZSTXView_DAL().getArrayByXkbhAndYjzb(xkbh, zslyMc);
                for (int i = 0; i < results.Length; i++)
                {
                    Response.Write("<option>" + results[i] + "</option>");
                }
            }
            Response.End();
        }
    }
}