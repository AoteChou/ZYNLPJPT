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
    public partial class addZyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zyMc = Request["zyMc"] == null ? "" : Request["zyMc"].ToString().Trim();
            string xyName = Request["xyName"] == null ? "" : Request["xyName"].ToString().Trim();
            string xkName = Request["xkName"] == null ? "" : Request["xkName"].ToString().Trim();
            if (zyMc == null || zyMc == "" || xyName == null || xyName == "" || xkName == null || xkName == "")
            {
                result = false;
            }
            else
            {
                ZY_DAL zyDal=new ZY_DAL ();
                if(zyDal.Exists(zyMc)){
                    result=false;
                }else{
                    XKDetailView xkDetailView = new XKDetailView_DAL().GetModel(xyName,xkName);
                    ZY zy = new ZY();
                    zy.XKBH = xkDetailView.XKBH;
                    zy.ZYM = zyMc;
                    zy.ZYFZR = null;
                    int i=zyDal.Add(zy);
                    if (i == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}