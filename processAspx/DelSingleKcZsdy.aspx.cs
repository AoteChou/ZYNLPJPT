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
    public partial class DelSingleKcZsdy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string skcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
            string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString();
            if (skcbh == null || skcbh == "" || sXkbh == null || sXkbh == "" || szslybh == null || szslybh == "" || szsdybh == null || szsdybh=="")
            {
                result = false;
            }
            else
            {
                int kcbh = int.Parse(skcbh);
                int xkbh = int.Parse(sXkbh);
                int zslybh = int.Parse(szslybh);
                int zsdybh = int.Parse(szsdybh);
                if (new KCZSDY_DAL().Delete(kcbh,zslybh,zsdybh))
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