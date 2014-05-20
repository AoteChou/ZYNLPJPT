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
    public partial class DelSingleCtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string skcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString();
            string szybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string syhbh = Request["yhbh"] == null ? "" : Request["yhbh"].ToString();
            if (skcbh == null || skcbh == "" || szybh == null || szybh == "" || syhbh == null || syhbh == "" )
            {
                result = false;
            }
            else
            {
                int kcbh = int.Parse(skcbh);
                int zybh = int.Parse(szybh);
                if (new CT_DAL().Delete(kcbh,zybh,syhbh))
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