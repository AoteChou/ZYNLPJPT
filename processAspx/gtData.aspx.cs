using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZYNLPJPT.processAspx
{
    public partial class gtData : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            string pcjlbh_str = Request["pcjlbh"] == null ? null : Request["pcjlbh"].ToString();      //评测记录编号
            string stbh_str = Request["stbh"] == null ?null: Request["stbh"].ToString();          //试题编号
            string xsbh = Request["xsbh"] == null ? null : Request["xsbh"].ToString();            //学生编号
            string gtr = Request["gtr"] == null ? null : Request["gtr"].ToString();                    //改题人
            string scrq_str = Request["scrq"] == null ? null: Request["scrq"].ToString();         //上传日期
            string xzrq_str = Request["xzrq"] == null ? null:Request["xzrq"].ToString();          //下载日期

            if (pcjlbh_str==null||stbh_str == null || xsbh == null || gtr == null || scrq_str == null || xzrq_str == null)
            {
                Response.Write(false);
            }

            else
            {
                int pcjlbh = int.Parse(pcjlbh_str);
                int stbh = int.Parse(stbh_str);
                DateTime scrq = DateTime.Parse(scrq_str);
                DateTime xzrq = DateTime.Parse(xzrq_str);
            }
           

        }
    }
}