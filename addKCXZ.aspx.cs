using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class addKCXZ : System.Web.UI.Page
    {
        //protected int kcxzbh;
        protected string[] kcxzmc;
        protected string[] kcxzbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                KCXZ_DAL kcxz_dal = new KCXZ_DAL();
                DataSet ds = kcxz_dal.GetList("");
                kcxzmc = new string[ds.Tables[0].Rows.Count];
                kcxzbh = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    kcxzbh[i] = ds.Tables[0].Rows[i]["kcxzbh"].ToString();
                    kcxzmc[i] = ds.Tables[0].Rows[i]["kcxzmc"].ToString();
                }


            }
        }
    }
}