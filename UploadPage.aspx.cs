using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using Brettle.Web.NeatUpload;
using System.IO;

namespace ZYNLPJPT
{
    public partial class UploadPage : System.Web.UI.Page
    {
        protected PCJL[] pcjls;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
               this.Response.Redirect("Default.htm");

            }
            else
            {
                YH yh=(YH)Session["yh"];
                int kcbh=int.Parse(Request["kcbh"]);
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                pcjls=pcjl_dal.getPCJL_Undone_ALL(yh.YHBH, kcbh);
                //检查是否已经全部完成
                if (pcjls.Length == 0)
                {
                    Response.Redirect("./ErrorPage.aspx?msg=本课程所有的题目都已经上传完毕,请返回&fh=true");
                }

             }
          
        }

        
        
    }
}