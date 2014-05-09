using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class XiuGaiJiaoShiMiMa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JSTeaYHView_DAL js=new JSTeaYHView_DAL();
            if (Request["option"] != null && Request["option"] == "xiuMIMA")
            {
                string id = Request["JsID"];
                string mima = Request["password"];
                if (id != null && mima != null)
                {
                    if (js.UpdateMiMa(id, mima) > 0)
                    {
                        Response.Write("SaveOK");
                    }
                    else
                    {
                        Response.Write("SaveNo");
                    }

                }
                else
                {
                    Response.Write("No");
                }
            }
            else
                if (Request["option"] != null && Request["option"] == "shanchu")
                {
                    string str = Request["idlist"];
                    string[] IDList = str.Split(',');
                    for (int i = 0; i < IDList.Length - 1; i++)
                    {
                        if (js.DeleteUser(IDList[i]) == 1)
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
}