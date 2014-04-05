using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class DownloadTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int stbh = int.Parse(Request["stbh"]);
            ST_DAL st_dal = new ST_DAL();
            ST st = st_dal.GetModel(stbh);
            byte[] temp = st.TMNR;
            string fileName = new Random().Next().ToString() + DateTime.Now.ToShortTimeString() + st.HZM;

            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
            Response.AddHeader("Content-Length", temp.Length.ToString());
            Response.AddHeader("Content-Transfer-Encoding", "binary");
            Response.ContentType = "application/msword";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.BinaryWrite(temp);
            Response.Flush();
            Response.End();
        }
    }
}