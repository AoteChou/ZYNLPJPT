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
    public partial class addKcZsdy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zslybh = Request["zslybh[]"] == null ? null : Request["zslybh[]"].ToString().Trim();
            string zsdybh = Request["zsdybh[]"] == null ? null : Request["zsdybh[]"].ToString().Trim();
            string kcbh = Request["kcbh"] == null ? null : Request["kcbh"].ToString().Trim();
            if (zsdybh == null || zsdybh == "" || zslybh == null || zslybh == "" || kcbh == null || kcbh == "")
            {
                result = false;
            }
            else {
                int iKcbh = int.Parse(kcbh);
                string[] zslybhs = zslybh.Split(',');
                string[] zsdybhs = zsdybh.Split(',');
                int length = zslybhs.Length;
                int[] iZslys=new int[length];
                int[] iZsdys=new int[length];
                convertStrToInt(zslybhs,iZslys);
                convertStrToInt(zsdybhs,iZsdys);
                new KCZSDY_DAL().Delete(iKcbh);
                
                KCZSDY[] kszsdys=new  KCZSDY[length];
                for (int i = 0; i < length; i++) {
                    kszsdys[i] = new KCZSDY();
                    kszsdys[i].KCBH = iKcbh;
                    kszsdys[i].ZSLYBH = iZslys[i];
                    kszsdys[i].ZSDYBH = iZsdys[i];
                }

                if (new KCZSDY_DAL().addArray(kszsdys))
                {
                    result = true;
                }
                else {
                    result = false;
                }
            }
            Response.Write(result);
            Response.End();
        }

        public void convertStrToInt(string[] strs, int[] values)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                values[i] = int.Parse(strs[i]);
            }
        }

    }
}