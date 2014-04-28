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
    public partial class DelAllZyZjzb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            if (sZybh == null || sZybh == "" || sXkbh == null || sXkbh == "")
            {
                result = false;
            }
            else {
                int zybh = int.Parse(sZybh);
                int xkbh = int.Parse(sXkbh);
                if (new ZYEJZB_DAL().Delete(zybh))
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