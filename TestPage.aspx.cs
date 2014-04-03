using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using Brettle.Web.NeatUpload;
using System.IO;
using System.Threading;

namespace ZYNLPJPT
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected STZSDView[] stzsdviews;
        protected int stbh;
        protected int teststate;
        protected ProgressBar progressBarId;
        private int pcjlbh;
        public bool sfzdyj;
        protected void Page_Load(object sender, EventArgs e)
        {
            stbh=int.Parse( Request["stbh"]);
            STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
            stzsdviews = stzsdview_dal.getbySTBH(stbh);

            if (stzsdviews.Length == 0)
            {
                Response.Redirect("./ErrorPage.aspx?msg='获取试题的过程中出错啦，请关闭窗口重新获取吧~~'");
            }

            teststate=int.Parse(Request["teststate"]);
            pcjlbh = int.Parse(Request["pcjlbh"]);
            sfzdyj = stzsdviews[0].SFZDYJ;
            submitButtonId.Click += new System.EventHandler(this.Button_Clicked);
                
            
                        
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            if (IsValid && inputFileId.HasFile)
            {
                string fileName=inputFileId.FileName;
                string path = Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/"+DateTime.Now + fileName);
                inputFileId.MoveTo(path,MoveToOptions.Overwrite);
                PCJL_DAL pcjl_dal = new PCJL_DAL();

                FileStream filestream=new FileStream(path,FileMode.Open);
                byte[] tempbyte=new byte[filestream.Length];
                filestream.Write(tempbyte, 0,tempbyte.Length);
                string hzm = fileName.Substring(fileName.LastIndexOf(".")-1);
                pcjl_dal.Update(DateTime.Now,tempbyte,pcjlbh,hzm);
            }
        }

        protected void download_Click(object sender, EventArgs e)
        {
            ST_DAL st_dal = new ST_DAL();
            ST st=st_dal.GetModel(stbh);
            byte[] temp=st.TMNR;
            string fileName=new Random().Next().ToString()+DateTime.Now.ToShortTimeString()+st.HZM;
            
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.AddHeader("Content-Disposition", "attachment;filename="+fileName);
            Response.AddHeader("Content-Length",temp.Length.ToString());
            Response.AddHeader("Content-Transfer-Encoding", "binary");
            Response.ContentType = "application/msword";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            Response.BinaryWrite(temp);
            //Response.WriteFile(Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/"+fileName));
               
        }
    }
}