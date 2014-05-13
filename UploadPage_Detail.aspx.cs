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

namespace ZYNLPJPT
{
    public partial class UploadPage_Detail : System.Web.UI.Page
    {
        protected STZSDView[] stzsdviews;
        protected int stbh;
        protected ProgressBar progressBarId;
        private int pcjlbh;
        public bool sfzdyj;
        private string hzm;
        protected void Page_Load(object sender, EventArgs e)
        {
            stbh = int.Parse(Request["stbh"]);
            //获取知识点
            STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
            stzsdviews = stzsdview_dal.getbySTBH(stbh);
            //检查是否获取失败
            if (stzsdviews.Length == 0)
            {
                Response.Redirect("./ErrorPage.aspx?msg=获取试题的过程中出错啦，请关闭窗口重新获取吧~~&fh=true");
            }
            
            pcjlbh = int.Parse(Request["pcjlbh"]);
            sfzdyj = stzsdviews[0].SFZDYJ;
            submitButtonId.Click += new System.EventHandler(this.Button_Clicked);



        }
        private void Button_Clicked(object sender, EventArgs e)
        {


            //上传文件到数据库
            if (IsValid && inputFileId.HasFile)
            {

                //string fileName = inputFileId.FileName;
                //hzm = fileName.Substring(fileName.LastIndexOf("."));

                //string path = Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/" + new Random().Next().ToString() + fileName);
                //inputFileId.MoveTo(path, MoveToOptions.Overwrite);
                //PCJL_DAL pcjl_dal = new PCJL_DAL();

                //FileStream filestream = new FileStream(path, FileMode.Open);
                //byte[] tempbyte = new byte[filestream.Length];
                //filestream.Write(tempbyte, 0, tempbyte.Length);
                //bool opResult = pcjl_dal.Update(DateTime.Now, tempbyte, pcjlbh, hzm);
                /* 如果马上删除 会显示被占用 待解决
                if (opResult) {
                    File.Delete(path);
                }*/
                string fileName = inputFileId.FileName;
                hzm = fileName.Substring(fileName.LastIndexOf("."));

                long fileLength = inputFileId.FileContent.Length;
                byte[] tempbyte = new byte[fileLength];
                inputFileId.FileContent.Read(tempbyte, 0, tempbyte.Length);
                inputFileId.FileContent.Dispose();
                inputFileId.FileContent.Close();
                PCJL_DAL pcjl_dal = new PCJL_DAL();

                bool opResult = pcjl_dal.Update(DateTime.Now, tempbyte, pcjlbh, hzm);
            }
            else
            {
                Response.Write("<script>alert('文件过大或者文件无效')</script>");
            }
        }

    }
}