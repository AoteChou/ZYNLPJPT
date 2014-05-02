using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class changeZyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xymc = Request["xyName"] == null ? "" : Request["xyName"].ToString().Trim();
            string xkmc = Request["xkName"] == null ? "" : Request["xkName"].ToString().Trim();
            if (xymc == null || xymc == ""||xkmc==null||xkmc=="")
            {
                Response.Write(false);
            }
            else
            {
                string[] results =new XYXKZYDetailView_DAL().getStrArray(xymc,xkmc);

                for (int i = 0; i < results.Length; i++)
                {
                    Response.Write("<option>" + results[i] + "</option>");
                }
            }
            Response.End();
        }
    }
}