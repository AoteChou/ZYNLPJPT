using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT
{
    public partial class addst : System.Web.UI.Page
    {

        protected CTView[]ctview;  //出题列表
        protected int num;             //出题信息条数

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["yh"] == null)
                this.Response.Redirect("Default.htm");
            else
            {
               YH yh=(YH)Session["yh"];
               String jsbh = yh.YHBH;      //教师编号
               GetTestCourse_BLL gettestcourse_bll = new GetTestCourse_BLL();
               num = gettestcourse_bll.Get_CTinfo(jsbh).Count;
               ctview=new CTView[num];
               for (int i = 0; i <num; i++)
               {
                   ctview[i] = gettestcourse_bll.Get_CTinfo(jsbh).ElementAt(i);
               }
            }
        
        }
    
    }
}