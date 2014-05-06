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
    public partial class scCpjdProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
            string sjdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            if (snjbh == null || snjbh == "" || sjdbh == null || sjdbh == "" || sZybh == null || sZybh == "" )
            {
                result = false;
            }
            else
            {
                int njbh = int.Parse(snjbh);
                int jdbh = int.Parse(sjdbh);
                int zybh = int.Parse(sZybh);
                if (new JDKC_DAL().Exists(zybh, njbh, jdbh))
                {
                    //该阶段已被配置，不能删除
                    result = false;
                }
                else
                {
                    if (new CPJD_DAL().Delete(njbh,zybh,jdbh))
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