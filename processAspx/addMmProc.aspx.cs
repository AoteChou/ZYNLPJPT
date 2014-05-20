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
    public partial class addMmProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string yhbh = Request["yhbh"] == null ? "" : Request["yhbh"].ToString().Trim();
            string oldPassword = Request["oldPassword"] == null ? "" : Request["oldPassword"].ToString().Trim();
            string newPassword = Request["newPassword"] == null ? "" : Request["newPassword"].ToString().Trim();
            if (yhbh == null || yhbh == "" ||oldPassword==null||oldPassword==""||newPassword==null||newPassword=="")
            {
                result = false;
            }
            else
            {
                YH yh=(YH)Session["yh"];
                if (yhbh==yh.YHBH&&yh.MM==oldPassword)
                {
                    yh.MM = newPassword;
                    YH_DAL yhDal = new YH_DAL();
                    if (yhDal.UpdatePassword(yh))
                    {
                        result = true;
                    }
                    else {
                        result = false;
                    }
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