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


    public partial class addZyEjzb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string ejzbbh = Request["ejzbbh[]"] == null ? null : Request["ejzbbh[]"].ToString().Trim();
            string nlzbz = Request["nlzbz[]"] == null ? null : Request["nlzbz[]"].ToString().Trim();
            string zybh = Request["zybh"] == null ? null : Request["zybh"].ToString().Trim();
            if (ejzbbh == null || ejzbbh == "" || nlzbz == null || nlzbz == ""||zybh==null||zybh=="")
            {
                result = false;
            }
            else {
                string[] ejzbbhs = ejzbbh.Split(',');
                string[] nlzbzs = nlzbz.Split(',');
                int[] values=new int[nlzbzs.Length];
                int[] iEjzbbhs=new int[ejzbbhs.Length];
                if (convertStrToInt(nlzbzs, values)||convertStrToInt(ejzbbhs,iEjzbbhs))
                {
                    result = false;
                }
                else { 
                    int iZybh=int.Parse(zybh);
                    ZYEJZB[] zyejzbs=new ZYEJZB[iEjzbbhs.Length];
                    for (int i = 0; i < zyejzbs.Length; i++) {
                        zyejzbs[i] = new ZYEJZB();
                        zyejzbs[i].EJZBBH = iEjzbbhs[i];
                        zyejzbs[i].NLYQ = values[i];
                        zyejzbs[i].ZYBH = iZybh;
                    }
                       // new ZYEJZB_DAL().Delete(iZybh);
                        if (new ZYEJZB_DAL().AddList(zyejzbs))
                        {
                           
                            result = true;
                        }
                        else {
                            result = false;
                        }
                }
            }
            Response.Write(result);
            Response.End();
        }

        //返回值表示是否存在小于零元素,true表示存在，false表示不存在
        public bool convertStrToInt(string[] strs,int[] values) {
            bool flag = false;
            for (int i = 0; i < strs.Length; i++) {
                values[i] = int.Parse(strs[i]);
                if (values[i] < 0) {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}