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
    public partial class TestPage : System.Web.UI.Page
    {
        protected STZSDView[] stzsdviews;
        protected int stbh;
        protected int teststate;
        protected ProgressBar progressBarId;
        private int pcjlbh;
        public bool sfzdyj;
        private string hzm;
        protected float finishratio;
        protected string zsdstring;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {
                stbh = int.Parse(Request["stbh"]);
                YH yh = (YH)Session["yh"];
                string xsbh = yh.YHBH;
                int kcbh = int.Parse(Request["kcbh"]);
                //获取知识点
                STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
                stzsdviews = stzsdview_dal.getbySTBH(stbh);
                //检查是否获取失败
                if (stzsdviews.Length == 0)
                {
                    Response.Redirect("./ErrorPage.aspx?msg=获取试题的过程中出错啦，请关闭窗口重新获取吧~~&fh=true");
                }

                teststate = int.Parse(Request["teststate"]);
                pcjlbh = int.Parse(Request["pcjlbh"]);
                sfzdyj = stzsdviews[0].SFZDYJ;

                int[] zsd_unfinished= stzsdview_dal.getZSD_Unfinished(kcbh, xsbh);//未完成的知识点数目
                int zsdcount = stzsdview_dal.getZSDCountbyKCBH(kcbh);//该门课程下的知识点数目总数
                finishratio = 1-((float)zsd_unfinished.Length / (float)zsdcount);//完成比率

                submitButtonId.Click += new System.EventHandler(this.Button_Clicked);
                for (int i = 0; i < stzsdviews.Length; i++)
                {
                    if (i == 0)
                    {
                        zsdstring += "['" + stzsdviews[i].ZSDMC + "'," + float.Parse(stzsdviews[i].ZSDBZ.ToString()) + "]";
                    }
                    else {
                        zsdstring += ",['" + stzsdviews[i].ZSDMC + "'," + float.Parse(stzsdviews[i].ZSDBZ.ToString()) + "]";
                    }
    		     
                } 
            
            }
            
            
                        
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            //上传文件到数据库
            if (IsValid && inputFileId.HasFile)
            {

                /*string fileName = inputFileId.FileName;
                hzm = fileName.Substring(fileName.LastIndexOf(".") );

                string path = Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/" + new Random().Next().ToString() + fileName);
                inputFileId.MoveTo(path, MoveToOptions.Overwrite);
                PCJL_DAL pcjl_dal = new PCJL_DAL();

                FileStream filestream = new FileStream(path, FileMode.Open);
                byte[] tempbyte = new byte[filestream.Length];
                filestream.Write(tempbyte, 0, tempbyte.Length);
                bool opResult = pcjl_dal.Update(DateTime.Now, tempbyte, pcjlbh, hzm);*/
                /* 如果马上删除 会显示被占用 待解决
               if (opResult) {
                   File.Delete(path);
               }*/
                string fileName = inputFileId.FileName;
                hzm = fileName.Substring(fileName.LastIndexOf("."));
                if (hzm != ".doc" || hzm != ".docx")
                {
                    Response.Write("<script type=text/javascript>alert('请上传后缀名为.doc或.docx的文件！')</script>");

                }
                else
                {
                    long fileLength = inputFileId.FileContent.Length;
                    byte[] tempbyte = new byte[fileLength];
                    inputFileId.FileContent.Read(tempbyte, 0, tempbyte.Length);
                    inputFileId.FileContent.Dispose();
                    inputFileId.FileContent.Close();
                    PCJL_DAL pcjl_dal = new PCJL_DAL();

                    bool opResult = pcjl_dal.Update(DateTime.Now, tempbyte, pcjlbh, hzm);
                }
                

                
               
            }
            else {
                Response.Write("<script>alert('文件过大或者文件无效')</script>");
            }
        }

       
    }
}