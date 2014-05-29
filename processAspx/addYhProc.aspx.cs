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
    public partial class addYhProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string yhmc = Request["YhMc"] == null ? "" : Request["YhMc"].ToString().Trim();
            string xm = Request["YhName"] == null ? "" : Request["YhName"].ToString().Trim();
            string xb = Request["XB"] == null ? "" : Request["XB"].ToString().Trim();
            if (yhmc == null || yhmc == "" || xm == null || xm == "")
            {
                result = false;
            }
            else
            {
                YH_DAL yh_dal = new YH_DAL();
                if (yh_dal.Exists(yhmc))
                    result = false;
                else
                {
                    YH yh = new YH();
                    yh.YHBH = yhmc;
                    yh.XM = xm;
                    if (xb == "true")
                        yh.XB = true;
                    else
                        yh.XB = false;
                    yh.MM = yhmc;

                    if (yh_dal.Add(yh))
                        result = true;
                    else
                        result = false;
                
                }
            }
            Response.Write(result);
            Response.End();
        
        }
    }
}