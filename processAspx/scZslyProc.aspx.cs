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
    public partial class scZslyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
            if (sxkbh == null || sxkbh == "" || szslybh == null || szslybh == "")
            {
                result = false;
            }
            else
            {
                int xkbh = int.Parse(sxkbh);
                int zslybh = int.Parse(szslybh);
                if (new ZSDY_DAL().ExistsZslyBh(zslybh))
                {
                    //该阶段已被配置，不能删除
                    result = false;
                }
                else
                {
                    if (new ZSLY_DAL().Delete(zslybh))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}