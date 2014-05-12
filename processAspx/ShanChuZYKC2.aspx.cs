using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class ShanChuZYKC2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZYKC_DAL zykc= new ZYKC_DAL();
            if (Request["option"] != null && Request["option"] == "shanchu")
            {
                string str = Request["idlist"];
                string[] IDList = str.Split(',');
                bool flag = true;
                for (int i = 0; i < IDList.Length - 1; i++)
                {
                    if (zykc.DeleteUser(IDList[i]) != 1)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Response.Write("DeleteOK");
                }
                else
                {
                    Response.Write("DeleteNo");
                }
            }
        }
    }
}