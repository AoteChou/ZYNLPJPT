using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.BLL;
namespace ZYNLPJPT.processAspx
{
    public partial class ifPzJSProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh = Request["yhbh"] == null ? "" : Request["yhbh"].ToString().Trim();
            if (new YHJS_BLL().getJSCount_byYH(yhbh) == 0)
                Response.Write(false);
            else
                Response.Write(true);
            Response.End();
        }
    }
}