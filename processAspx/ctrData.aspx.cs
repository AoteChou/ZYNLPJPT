using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class ctrData : System.Web.UI.Page
    {
        protected JSRoleYHView[] jsRoleYhView;

        protected int kcbh;
        protected int zybh;

        protected string tips;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else 
            {
                kcbh = int.Parse(Request["kcbh"].ToString());
                zybh = int.Parse(Request["zybh"].ToString());
                tips = "请选择教师是否为  "+Request["zym"].ToString()+"  专业  "+Request["kcmc"].ToString()+"  课程的出题人。\n 打钩表示为出题人，反之则不是。";
                int xkbh=int.Parse(Request["xkbh"].ToString());
                jsRoleYhView = new JSRoleYHView_DAL().getArrayNotInCtr(xkbh, zybh, kcbh);
                //jsRoleYhView = new JSRoleYHView_DAL().getArray("ssxk="+xkbh);
            }
        }
    }
}