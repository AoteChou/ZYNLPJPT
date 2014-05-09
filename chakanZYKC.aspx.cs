using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using System.Data;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class chakanZYKC : System.Web.UI.Page
    {
        protected string[] kcbh;
        protected string[] kcmc;
        protected string[] ssxk;
        protected string[] kkxq;
        protected string[] kcxzmc;
        protected string[] llxf;
        protected string[] sjxf;
        protected string zybh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                zybh = Request["zybh"];
                DataSet ds = new ZYKC_DAL().GetList("zybh=" + zybh);
                int alength = ds.Tables[0].Rows.Count;
                kcbh = new string[alength];
                kcmc = new string[alength];
                ssxk = new string[alength];
                kkxq = new string[alength];
                kcxzmc = new string[alength];
                llxf = new string[alength];
                sjxf = new string[alength];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    kcbh[i] = ds.Tables[0].Rows[i]["KCBH"].ToString();
                    KC kc = new KC_DAL().GetModel(int.Parse(kcbh[i]));
                    kcmc[i] = kc.KCMC;
                    int kkxk = kc.KKXK;
                    XK xk = new XK_DAL().GetModel(kkxk);
                    ssxk[i] = xk.XKMC;
                    kkxq[i] = ds.Tables[0].Rows[i]["KKXQ"].ToString();
                    string kcxzbh = ds.Tables[0].Rows[i]["KCXZBH"].ToString();
                    KCXZ kcxz = new KCXZ_DAL().GetModel(int.Parse(kcxzbh));
                    kcxzmc[i] = kcxz.KCXZMC;
                    llxf[i] = ds.Tables[0].Rows[i]["LLXF"].ToString();
                    sjxf[i] = ds.Tables[0].Rows[i]["SJXF"].ToString();
                }
            }
        }
    }
}