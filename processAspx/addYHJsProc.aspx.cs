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
                //判断角色是否冲突
                int jsbh = int.Parse(jsbh_str);
                if (jsbh == 1 && new XS_DAL().GetRecordCount(" XSBH=" + yhbh) > 0)
                {
                    
                        Response.Write(1);
                        Response.End();
                   
                }

                else if (jsbh == 2 && new JSTea_DAL().GetRecordCount(" JSBH=" + yhbh) > 0)
                {
                   
                        Response.Write(2);
                        Response.End();
                    
                }

                else
                {
                    //配置用户新角色
                    YHJSB yhjs = new YHJSB();
                    yhjs.JSBH = jsbh;
                    yhjs.YHBH = yhbh;
                    new YHJSB_DAL().Add(yhjs);

                     
                    //配置相应角色的用户功能
                    int length = new JSGN_BLL().getMRCountByJs(jsbh);
                    JSGNB[] jsgn_list = new JSGNB[length];
                    GND[] new_GN = new GND[length];
                    YHGNB[] yhgn_list = new YHGNB[length];
                    //初始化
                    for (int i = 0; i < length; i++)
                    {
                        jsgn_list[i] = new JSGNB();
                        new_GN[i] = new GND();
                        yhgn_list[i] = new YHGNB();
                    }

                    jsgn_list = new JSGN_BLL().get_MRGNListByJS(jsbh);
                    for (int i = 0; i < length; i++)
                    {
                        new_GN[i] = new GND_DAL().GetModel(jsgn_list[i].GNBH);
                        yhgn_list[i].YHBH = yhbh;
                        yhgn_list[i].GNBH = new_GN[i].GNBH;
                    }

                    for (int i = 0; i < length; i++)
                    {
                        //判断，不能插入重复功能
                        if (new JSGN_BLL().IfExit_YHGN(yhgn_list[i]) == false)
                            new YHGNB_DAL().Add(yhgn_list[i]);
                    }
                    Response.Write(true);
                }
                Response.End();
            }
        }

    }

}