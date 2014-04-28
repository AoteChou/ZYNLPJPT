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
    public partial class DelSingleZyZjzb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sZybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string sEjzbbh = Request["ejzbbh"] == null ? "" : Request["ejzbbh"].ToString();
            if (sZybh == null || sZybh == "" || sXkbh == null || sXkbh == ""||sEjzbbh==null||sEjzbbh=="")
            {
                result = false;
            }
            else
            {
                int zybh = int.Parse(sZybh);
                int xkbh = int.Parse(sXkbh);
                int ejzbbh=int.Parse(sEjzbbh);
                if (new ZYEJZB_DAL().Delete(ejzbbh,zybh))
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