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
    public partial class DelAllJdkc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
            string sjdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            if (snjbh == null || snjbh == "" || sjdbh == null || sjdbh == "" || sZybh == null || sZybh == "")
            {
                result = false;
            }
            else
            {
                int njbh = int.Parse(snjbh);
                int jdbh = int.Parse(sjdbh);
                int zybh = int.Parse(sZybh);
                //检测是否已经给该阶段课程分配改题人。已分配则不能删除，反之则成功!
                if (new JDKCXS_DAL().Exists(zybh, njbh, jdbh))
                {
                    //该阶段存在课程已分配改题人
                    result = false;
                }
                else
                {
                    if (new JDKC_DAL().Delete(zybh,njbh,jdbh))
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