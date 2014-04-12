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
    public partial class changeEjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
             string yjzbMc = Request["yjzbName"] == null ? "" : Request["yjzbName"].ToString().Trim();
             if (sXkbh == null || sXkbh == "" || yjzbMc == null || yjzbMc == "")
             {
                 Response.Write(false);
             }
             else {
                 int xkbh = int.Parse(sXkbh);
                 string[] results = new NLZBView_DAL().getArrayByXkbhAndYjzb(xkbh,yjzbMc);
                 
                 for (int i = 0; i < results.Length; i++) { 
                    Response.Write("<option>"+results[i]+"</option>");
                 }
             }
             Response.End();
        }
    }
}