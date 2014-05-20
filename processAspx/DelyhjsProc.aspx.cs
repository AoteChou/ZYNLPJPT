using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class DelyhjsProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh = Request["yhbh"] == null ? null : Request["yhbh"].ToString();
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            if (yhbh== null || jsbh_str == null || yhbh == "" || jsbh_str == "")
                Response.Write(false);
            else
            {
                
                int jsbh = int.Parse(jsbh_str);
               bool del= new YHJSB_DAL().Delete(yhbh, jsbh);
               if (del == false)
                   Response.Write("<script language=javascript>alert('删除失败！')</script>");
               else
               {

                 //级联删除相应角色的用户功能
                   int length = new JSGN_BLL().getCountByJs(jsbh);
                   JSGNB[] jsgn_list = new JSGNB[length];
                   GND[] new_GN = new GND[length];
                   YHGNB[] yhgn_list = new YHGNB[length];
                   
                   for (int i = 0; i < length; i++)
                   {
                       jsgn_list[i] = new JSGNB();
                       new_GN[i] = new GND();
                       yhgn_list[i] = new YHGNB();
                   }

                   jsgn_list = new JSGN_BLL().get_GNListByJS(jsbh);
                   for (int i = 0; i < length; i++)
                   {
                       new_GN[i] = new GND_DAL().GetModel(jsgn_list[i].GNBH);
                       yhgn_list[i].YHBH = yhbh;
                       yhgn_list[i].GNBH = new_GN[i].GNBH;
                   }
                   
                   for (int i = 0; i < length; i++)
                   {
                       new YHGNB_DAL().Delete(yhgn_list[i].GNBH,yhgn_list[i].YHBH);
                   }

                   Response.End();
               }
            }
        }
    }
}