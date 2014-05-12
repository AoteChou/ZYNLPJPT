using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class XiuGaiKC : System.Web.UI.Page
    {
        
        protected string[] kcmc;
        protected string[] kkxk;
        protected string[] kcfzr;
        protected string[] kcjj;
        protected string[] kcbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new KC_DAL().GetList("");
            int alength = ds.Tables[0].Rows.Count;
            kcbh = new string[alength];
            kcmc = new string[alength];
            kkxk = new string[alength];
            kcfzr = new string[alength];
            kcjj = new string[alength];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                kcbh[i] = ds.Tables[0].Rows[i]["KCBH"].ToString();
                kcmc[i] = ds.Tables[0].Rows[i]["KCMC"].ToString();
                kkxk[i] = ds.Tables[0].Rows[i]["KKXK"].ToString();
                kcfzr[i] = ds.Tables[0].Rows[i]["KCFZR"].ToString();
                kcjj[i] = ds.Tables[0].Rows[i]["KCJJ"].ToString();
                


            }
        }
    }
}