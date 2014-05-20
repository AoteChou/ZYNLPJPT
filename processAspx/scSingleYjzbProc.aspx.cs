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
    public partial class scSingleYjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sejzbbh = Request["ejzbbh"] == null ? "" : Request["ejzbbh"].ToString();
            string syjzbbh = Request["yjzbbh"] == null ? "" : Request["yjzbbh"].ToString();
            if (sejzbbh == null || sejzbbh == "" || syjzbbh == null || syjzbbh == "")
            {
                result = false;
            }
            else
            {
                int ejzbbh = int.Parse(sejzbbh);
                int yjzbbh = int.Parse(syjzbbh);
                if (new ZSDY_DAL().Exists(ejzbbh)||new ZYEJZB_DAL().Exists(ejzbbh))
                {
                    //该阶段已被配置，不能删除
                    result = false;
                }
                else
                {
                    if (new EJZB_DAL().Delete(ejzbbh))
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