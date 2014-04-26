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
    public partial class addJdKc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kcbhs = Request["kcbhs[]"] == null ? null : Request["kcbhs[]"].ToString().Trim();
            string jdbh = Request["jdbh"] == null ? null : Request["jdbh"].ToString().Trim();
            string zybh = Request["zybh"] == null ? null : Request["zybh"].ToString().Trim();
            string njbh = Request["njbh"] == null ? null : Request["njbh"].ToString().Trim();
            if (kcbhs == null || kcbhs == "" || jdbh == null || jdbh == "" || zybh == null || zybh == "" || njbh == null || njbh == "")
            {
                result = false;
            }
            else {
                string[] kcbhArray = kcbhs.Split(',');
                int iJdbh = int.Parse(jdbh);
                int iZybh = int.Parse(zybh);
                int iNjbh = int.Parse(njbh);
                int[] iKcbhArray=new int[kcbhArray.Length];
                convertStrToInt(kcbhArray,iKcbhArray);
                new JDKC_DAL().Delete(iZybh, iNjbh, iJdbh);
                JDKC[] jdkcs=new JDKC[kcbhArray.Length];
                for (int i = 0; i < jdkcs.Length; i++) {
                    jdkcs[i] = new JDKC();
                    jdkcs[i].JDBH = iJdbh;
                    jdkcs[i].ZYBH = iZybh;
                    jdkcs[i].NJBH = iNjbh;
                    jdkcs[i].KCBH = iKcbhArray[i];
                }

                if (new JDKC_DAL().addArray(jdkcs))
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