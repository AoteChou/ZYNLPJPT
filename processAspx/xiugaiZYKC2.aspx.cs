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
    public partial class xiugaiZYKC2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kkxqbh = Request["kkxqbh[]"] == null ? null : Request["kkxqbh[]"].ToString().Trim();
            string kcxzbh = Request["kcxzbh[]"] == null ? null : Request["kcxzbh[]"].ToString().Trim();
            string llxf = Request["llxf[]"] == null ? null : Request["llxf[]"].ToString().Trim();
            string sjxf = Request["sjxf[]"] == null ? null : Request["sjxf[]"].ToString().Trim();
            string kcbh = Request["kcbh[]"] == null ? null : Request["kcbh[]"].ToString().Trim();
            string zybh = Request["zybh"] == null ? null : Request["zybh"].ToString().Trim();
            if (kkxqbh == null || kkxqbh == "" || kcxzbh == null || kcxzbh == "" || llxf == null || llxf == "" || sjxf == null || sjxf == "")
            {
                result = false;
            }
            else
            {

                string[] kkxqbhs = kkxqbh.Split(',');
                string[] kcxzbhs = kcxzbh.Split(',');
                string[] llxfs = llxf.Split(',');
                string[] sjxfs = sjxf.Split(',');
                string[] kcbhs = kcbh.Split(',');
                decimal[] values1 = new decimal[llxfs.Length];
                decimal[] values = new decimal[sjxfs.Length];
                int[] ikkxqbhs = new int[kkxqbhs.Length];
                int[] ikcxzbhs = new int[kcxzbhs.Length];
                int[] ikcbhs = new int[kcbhs.Length];
                if (convertStrToDecimal(llxfs, values1) || convertStrToDecimal(sjxfs, values) || convertStrToInt(kkxqbhs, ikkxqbhs) || convertStrToInt(kcxzbhs, ikcxzbhs)||convertStrToInt(kcbhs,ikcbhs))
                {
                    result = false;
                }
                else
                {
                    //int iZybh = int.Parse(zybh);
                    //ZYKC[] zykcs = new ZYKC[ikcxzbhs.Length];
                    for (int i = 0; i < ikcbhs.Length; i++)
                    {
                        ZYKC zykc = new ZYKC();
                        zykc.KCXZBH = ikcxzbhs[i];
                        zykc.LLXF = values1[i];
                        zykc.SJXF = values[i];
                        zykc.KCBH = ikcbhs[i];
                        zykc.KKXQ = ikkxqbhs[i];
                        zykc.ZYBH = int.Parse(zybh);

                        try
                        {
                            result = new ZYKC_DAL().Update(zykc);

                        }
                        catch (Exception)
                        {

                            result = false;
                        }
                    }
                   

                }
                Response.Write(result);
                Response.End();
            }
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
        //返回值表示是否存在小于零元素,true表示存在，false表示不存在
        public bool convertStrToDecimal(string[] strs, decimal[] values)
        {
            bool flag = false;
            for (int i = 0; i < strs.Length; i++)
            {
                values[i] = decimal.Parse(strs[i]);
                if (values[i] < 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        }
    }
