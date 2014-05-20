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
    public partial class DelAllCtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sKcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            if (sKcbh == null || sKcbh == "" || sXkbh == null || sXkbh == ""||sZybh==null||sZybh=="")
            {
                result = false;
            }
            else
            {
                int kcbh = int.Parse(sKcbh);
                int xkbh = int.Parse(sXkbh);
                int zybh = int.Parse(sZybh);
                if (new CT_DAL().Delete(kcbh,zybh))
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