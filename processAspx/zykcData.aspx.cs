using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class zykcData : System.Web.UI.Page
    {

        protected string[] kcbh;
        protected string[] kcmc;
        protected string[] ssxk;
        protected string kcxzDataStirng;
        protected string zybh;
        protected void Page_Load(object sender, EventArgs e)
        {

            //string kcbh = Request["kcbh"];
            // DataSet ds1 = new ZYKC_DAL().GetList("kcbh=" + kcbh); 

            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                zybh = Request["zybh"];
                DataSet ds = new KC_DAL().GetList("kcbh NOT IN (SELECT KCBH FROM ZYKC WHERE zybh=" + zybh + " )");
                int alength = ds.Tables[0].Rows.Count;
                kcbh = new string[alength];
                kcmc = new string[alength];
                ssxk = new string[alength];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    kcbh[i] = ds.Tables[0].Rows[i]["KCBH"].ToString();
                    kcmc[i] = ds.Tables[0].Rows[i]["KCMC"].ToString();
                    string kkxk = ds.Tables[0].Rows[i]["KKXK"].ToString();
                    XK xk = new XK_DAL().GetModel(int.Parse(kkxk));
                    ssxk[i] = xk.XKMC;



                }
            }
        }
    }
}