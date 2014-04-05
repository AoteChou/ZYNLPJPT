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
    public partial class DownloadMyAnswer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int pcjlbh = int.Parse(Request["pcjlbh"]);
            PCJL_DAL pcjl_dal = new PCJL_DAL();
            PCJL pcjl = pcjl_dal.GetModel(pcjlbh);
            byte[] temp = pcjl.XSSTDA;
            string fileName = new Random().Next().ToString() + DateTime.Now.ToShortTimeString() + pcjl.HZM;

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