using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class addYHJsProc : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh = Request["yhbh"] == null ? null : Request["yhbh"].ToString();
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            if (jsbh_str == null || jsbh_str == "" || yhbh == null || yhbh == "")
                Response.Write(false);

            
            else
            {
                //配置用户新角色
                int jsbh=int.Parse(jsbh_str);
                YHJSB yhjs = new YHJSB();
                yhjs.JSBH = jsbh;
                yhjs.YHBH = yhbh;
                new YHJSB_DAL().Add(yhjs);

                //配置相应角色的用户功能
                int length = new JSGN_BLL().get_GNcount(jsbh);
                JSGNB[] jsgn_list = new JSGNB[length];
                jsgn_list = new JSGN_BLL().get_GNListByJS(jsbh);
                for (int i = 0; i < length; i++)
                {
                    new JSGNB_DAL().Add(jsgn_list[i]);
                }

            }
            Response.End();
        }

    }

}