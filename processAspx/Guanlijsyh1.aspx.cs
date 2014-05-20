using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class Guanlijsyh1 : System.Web.UI.Page
    {
        protected string[] yhbh;
        protected string[] mm;
        protected string[] xm;
        protected string[] xb;
        protected string[] sfsxkfzr;
        protected string[] sfskcfzr;
        protected string ssxk;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm'</script>");
                this.Response.End();
            }
            else
            {

                ssxk = Request["xkbh"];
                DataSet ds = new JSTeaYHView_DAL().GetList("ssxk=" + ssxk);
                int alength = ds.Tables[0].Rows.Count;
                yhbh = new string[alength];
                mm = new string[alength];
                xm = new string[alength];
                xb = new string[alength];
                sfsxkfzr = new string[alength];
                sfskcfzr = new string[alength];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    yhbh[i] = ds.Tables[0].Rows[i]["YHBH"].ToString();
                    mm[i] = ds.Tables[0].Rows[i]["MM"].ToString();
                    xm[i] = ds.Tables[0].Rows[i]["XM"].ToString();

                    xb[i] = ds.Tables[0].Rows[i]["XB"].ToString();
                    if ("True".Equals(xb[i]))
                    {
                        xb[i] = "男";
                    }
                    else
                    {
                        xb[i] = "女";
                    }
                    sfsxkfzr[i] = ds.Tables[0].Rows[i]["SFSXKFZR"].ToString();
                    if ("True".Equals(xb[i]))
                    {
                        sfsxkfzr[i] = "是";
                    }
                    else
                    {
                        sfsxkfzr[i] = "否";
                    }
                    sfskcfzr[i] = ds.Tables[0].Rows[i]["SFSKCFZR"].ToString();
                    if ("True".Equals(xb[i]))
                    {
                        sfskcfzr[i] = "是";
                    }
                    else
                    {
                        sfskcfzr[i] = "否";
                    }


                }
            }
        }
    }
}