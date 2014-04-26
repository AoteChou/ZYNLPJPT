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
    public partial class addJdkcxsProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string jsbh = Request["jsbh"] == null ? null : Request["jsbh"].ToString().Trim();
            string xsbhs = Request["xsbh[]"] == null ? null : Request["xsbh[]"].ToString().Trim();
            string kcbh = Request["kcbh"] == null ? null : Request["kcbh"].ToString().Trim();
            string zybh = Request["zybh"] == null ? null : Request["zybh"].ToString().Trim();
            string njbh = Request["njbh"] == null ? null : Request["njbh"].ToString().Trim();
            string jdbh = Request["jdbh"] == null ? null : Request["jdbh"].ToString().Trim();

            if (jsbh == null || jsbh == "" || xsbhs == null || xsbhs == "" || kcbh == null || kcbh == ""||zybh==null||zybh==""||njbh==null||njbh==""||jdbh==null||jdbh=="")
            {
                Response.Write(false);
            }
            else
            {
                string[] xsbhArray = xsbhs.Split(',');
                int iKcbh = int.Parse(kcbh);
                int iZybh = int.Parse(zybh);
                int iNjbh = int.Parse(njbh);
                int iJdbh = int.Parse(jdbh);
                int length = xsbhArray.Length;
                JDKCXS[] jskcxs=new JDKCXS[length];
                for (int i = 0; i < length; i++) {
                    jskcxs[i] = new JDKCXS();
                    jskcxs[i].KCBH = iKcbh;
                    jskcxs[i].ZYBH = iZybh;
                    jskcxs[i].NJBH = iNjbh;
                    jskcxs[i].JDBH = iJdbh;
                    jskcxs[i].JSBH = jsbh;
                    jskcxs[i].XSBH = xsbhArray[i];
                }
                if (new JDKCXS_DAL().AddArray(jskcxs))
                {
                    result = true;
                }
                else {
                    result = false;
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}