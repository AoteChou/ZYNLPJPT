using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class ResultPage : System.Web.UI.Page
    {
        protected PCJL[] pcjls;
        protected string[] yhxm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");

            }
            else
            {
                YH yh = (YH)Session["yh"];
                int kcbh = int.Parse(Request["kcbh"]);
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                pcjls = pcjl_dal.getPCJLWithMark_ALL(yh.YHBH, kcbh);
                //检查是否已经全部完成
                if (pcjls.Length == 0)
                {
                    Response.Redirect("./ErrorPage.aspx?msg=亲...该门课程下还没有成绩,请返回&fh=true");
                }
                string[] gtrbh=new string[pcjls.Length];
                for (int i = 0; i < pcjls.Length; i++)
                {
                    gtrbh[i] = pcjls[i].GTR;
                }
              
                YH_DAL yh_dal=new YH_DAL();
                yhxm = yh_dal.getYHXMbyYHBH(gtrbh);
               
                
            }
        }
    }
}