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
    public partial class getResult_ZSDY : System.Web.UI.Page
    {
        protected int xkbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");

            }
            else
            {
                YH yh = (YH)Session["yh"];

                //获取用户所属的学科编号
                XSBJZYView_DAL xsbjzyview_dal = new XSBJZYView_DAL();
                DataSet ds = xsbjzyview_dal.GetList("xsbh=" + yh.YHBH);
                if (ds.Tables[0].Rows.Count >= 0)
                {
                    xkbh = int.Parse(ds.Tables[0].Rows[0]["xkbh"].ToString());
                }
                else
                {
                    Response.Redirect("./ErrorPage.aspx?msg=出错啦&fh=false");
                }


            }
        }
    }
}