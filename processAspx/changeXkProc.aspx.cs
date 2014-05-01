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
    public partial class changeXkProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xymc = Request["xyName"] == null ? "" : Request["xyName"].ToString().Trim();
            if (xymc == null || xymc == "")
            {
                Response.Write(false);
            }
            else
            {
                string[] results = new XKDetailView_DAL().getStrArray(xymc);

                for (int i = 0; i < results.Length; i++)
                {
                    Response.Write("<option>" + results[i] + "</option>");
                }
            }
            Response.End();
        }
    }
}