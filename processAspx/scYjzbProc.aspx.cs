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
    public partial class scYjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string syjzbbh = Request["yjzbbh"] == null ? "" : Request["yjzbbh"].ToString();
            if (sxkbh == null || sxkbh == "" || syjzbbh == null || syjzbbh == "")
            {
                result = false;
            }
            else
            {
                int xkbh = int.Parse(sxkbh);
                int yjzbbh = int.Parse(syjzbbh);
                if (new EJZB_DAL().ExistsForYJZBBH(yjzbbh))
                {
                    //该阶段已被配置，不能删除
                    result = false;
                }
                else
                {
                    if (new YJZB_DAL().Delete(yjzbbh))
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