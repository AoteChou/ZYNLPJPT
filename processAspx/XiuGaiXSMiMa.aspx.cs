using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class XiuGaiXSMiMa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XSYHView_DAL xs = new XSYHView_DAL();
            if (Request["option"] != null && Request["option"] == "xiuMIMA")
            {
                string id = Request["XsID"];
                string mima = Request["password"];
                if (id != null && mima != null)
                {
                    if (xs.UpdateMiMa(id, mima) > 0)
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
                        if (xs.DeleteUser(IDList[i]) == 1)
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