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
    public partial class DelAllGtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sKcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString();
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string sJdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
            if (sKcbh == null || sKcbh == "" || snjbh == null || snjbh == "" || sZybh == null || sZybh == ""||sJdbh==null||sJdbh=="")
            {
                result = false;
            }
            else
            {
                int kcbh = int.Parse(sKcbh);
                int njbh = int.Parse(snjbh);
                int zybh = int.Parse(sZybh);
                int jdbh = int.Parse(sJdbh);
                if (new JDKCXS_DAL().Delete(kcbh,zybh,njbh,jdbh))
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