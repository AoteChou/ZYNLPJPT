using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Utility;
using System.Data;
using System.IO;
using System.Text;

namespace ZYNLPJPT.processAspx
{
    public partial class export_ZSD : System.Web.UI.Page
    {
        public string xsbh;
        public int zybh;
        public int xkbh;
        private bool flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {
                flag = false;
                YH yh = (YH)Session["yh"];
                xsbh = yh.YHBH;
                //获取用户所属的学科编号
                XSBJZYView_DAL xsbjzyview_dal = new XSBJZYView_DAL();
                DataSet ds1 = xsbjzyview_dal.GetList("xsbh=" + xsbh);
                xkbh = -1;
                if (ds1.Tables[0].Rows.Count >= 0)
                {
                    xkbh = int.Parse(ds1.Tables[0].Rows[0]["xkbh"].ToString());
                    zybh = int.Parse(ds1.Tables[0].Rows[0]["zybh"].ToString());
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('获取用户信息出错，请重试');</script>");
                    Response.End();
                    return;
                }
                //int count = Request.Form.Count;
                List<ExcelSheet> exportList = new List<ExcelSheet>();
                
                for (int i = 1; i <=5; i++)
                {
                    string itemName = "item" + i;
                    switch (Request.Form.Get(itemName))
                    {
                        case "1": exportList.Add(getResult_ZSLY());
                            flag = true;
                            break;
                        case "2": exportList.Add(getResult_ZSDY());
                            flag = true;
                            break;
                        case "3": exportList.Add(getResult_ZSD());
                            flag = true;
                            break;
                        case "4": exportList.Add(getResult_YJZB());
                            flag = true;
                            break;
                        case "5": exportList.Add(getResult_EJZB());
                            flag = true;
                            break;
                    }
                }
                if (!flag)
                {
                    Response.Write("<script type='text/javascript'>alert('导出出错，请重试');window.history.back();</script>");
                    Response.End();
                }
                MemoryStream ms = ZYNLPJPT.Utility.ExcelOutputHelper.RenderToExcel(exportList);
                string fileName = new Random().Next().ToString() + DateTime.Now.ToShortTimeString() + ".xls";

                byte[] temp = ms.GetBuffer();
                
                Response.Clear();
                Response.ClearContent();
                Response.ClearHeaders();
                Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
                Response.AddHeader("Content-Length", temp.Length.ToString());
                Response.AddHeader("Content-Transfer-Encoding", "binary");
                Response.ContentType = "application/vnd.ms-excel";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
                Response.BinaryWrite(temp);
                Response.Flush();
                //Response.Clear();
                //Response.ClearContent();
                ////Response.ClearHeaders();
                //Response.Write("<script type='text/javascript'>alert('获取用户信息出错，请重试');</script>");
                //RedirectUrl(this,"../Export_Result_Excel.aspx");
                Session["ExportState"] = true;
                Response.End();
            }
            
            
        }
        public static void RedirectUrl(System.Web.UI.Page page, string url)
        {
            StringBuilder Builder = new StringBuilder();

            Builder.Append("<script language=’javascript’  >");
            Builder.AppendFormat("alert(‘{0}’);", "操作成功！");
            Builder.AppendFormat("top.location.href=’{0}’ ", url);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString());
        }
        public void RedirectUrl(string url)
        {
            this.Response.Clear();//这里是关键，清除在返回前已经设置好的标头信息，这样后面的跳转才不会报错
            this.Response.BufferOutput = true;//设置输出缓冲
            if (!this.Response.IsRequestBeingRedirected)//在跳转之前做判断,防止重复
            {
                this.Response.Redirect(url, true);
            }
        }
        public ExcelSheet getResult_ZSD() {
            

            //获取学科下面的知识单元
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();

            int size = xkzstxview_dal.GetRecordCount("xkbh=" + xkbh);

            XKZSTXView[] xkzstxviews = xkzstxview_dal.getByXkbh(xkbh, 0, size - 1);

            ZYNLPJPT.Utility.ExcelSheet excelSheet = new Utility.ExcelSheet();
            excelSheet.Name = "知识点分数";
            excelSheet.Header.Add("知识领域名称");
            excelSheet.Header.Add("知识单元名称");
            excelSheet.Header.Add("知识点名称");
            excelSheet.Header.Add("知识点分数");

            foreach (XKZSTXView xkzstxview in xkzstxviews)
            {
                string[] row=new string[4];
                row[0]=xkzstxview.ZSLYMC;
                row[1]=xkzstxview.ZSDYMC;
                row[2]=xkzstxview.ZSDMC;
                row[3]=ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_ZSD(xsbh, xkzstxview.ZSDBH).ToString();

                excelSheet.Content.Add(row);
               
            }
            excelSheet.MergeColNum=new int[]{0,1};
            return excelSheet;
        }
        public ExcelSheet getResult_ZSDY() {
            
           
            //获取学科下面的知识点
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();
            int size = xkzstxview_dal.GetCount("zsdybh", "xkbh=" + xkbh);
            
            DataSet ds = xkzstxview_dal.getZSDYByXkbh(xkbh, 0, size-1);
            DataRowCollection datarows = ds.Tables[0].Rows;

            ZYNLPJPT.Utility.ExcelSheet excelSheet = new Utility.ExcelSheet();
            excelSheet.Name = "知识单元分数";
            excelSheet.Header.Add("知识领域名称");
            excelSheet.Header.Add("知识单元名称");
            excelSheet.Header.Add("知识单元分数");

            foreach (DataRow row in datarows)
            {
                string[] rowArray = new string[3];
                rowArray[0] = row["zslymc"].ToString();
                rowArray[1] = row["zsdymc"].ToString();
                rowArray[2] = ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_ZSDY(xsbh, int.Parse(row["zsdybh"].ToString())).ToString();

                excelSheet.Content.Add(rowArray);

            }
            excelSheet.MergeColNum = new int[] { 0 };
            return excelSheet;
        }
        public ExcelSheet getResult_ZSLY() {
            //获取学科下面的知识领域
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();
        
            int size = xkzstxview_dal.GetCount("zslybh", "xkbh=" + xkbh);
           
            DataSet ds = xkzstxview_dal.getZSLYByXkbh(xkbh, 0, size-1);
            DataRowCollection datarows = ds.Tables[0].Rows;
            ZYNLPJPT.Utility.ExcelSheet excelSheet = new Utility.ExcelSheet();
            excelSheet.Name = "知识领域分数";
            excelSheet.Header.Add("知识领域名称");
            excelSheet.Header.Add("知识领域分数");

            foreach (DataRow row in datarows)
            {
                string[] rowArray = new string[2];
                rowArray[0] = row["zslymc"].ToString();
                rowArray[1] = ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_ZSLY(xsbh, int.Parse(row["zslybh"].ToString())).ToString();

                excelSheet.Content.Add(rowArray);

            }
            excelSheet.MergeColNum = new int[] {  };
            return excelSheet;
           
            
        }
        public ExcelSheet getResult_EJZB()
        {
            //获取学科下面的二级指标
            XKNLZBView_DAL xknlzbview_dal = new XKNLZBView_DAL();
            int size = xknlzbview_dal.GetRecordCount("xkbh=" + xkbh);
            DataSet ds = xknlzbview_dal.GetListByPage("xkbh=" + xkbh, "ejzbbh", 0, size);
            DataRowCollection datarows = ds.Tables[0].Rows;
            ZYNLPJPT.Utility.ExcelSheet excelSheet = new Utility.ExcelSheet();
            excelSheet.Name = "二级指标分数";
            excelSheet.Header.Add("一级指标名称");
            excelSheet.Header.Add("二级指标名称");
            excelSheet.Header.Add("二级指标分数");

            foreach (DataRow row in datarows)
            { 
                
                string[] rowArray = new string[3];
                rowArray[0] = row["yjzbmc"].ToString();
                rowArray[1] = row["ejzbmc"].ToString();
                rowArray[2] = ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_EJZB(xsbh, int.Parse(row["ejzbbh"].ToString())).ToString();

                excelSheet.Content.Add(rowArray);

            }
            excelSheet.MergeColNum = new int[] {0};
            return excelSheet;


        }
        public ExcelSheet getResult_YJZB()
        {
            //获取学科下面的一级指标
            YJZB_DAL yjzb_dal = new YJZB_DAL();
            int size = yjzb_dal.GetRecordCount("xkbh=" + xkbh);
            DataSet ds = yjzb_dal.GetListByPage("xkbh=" + xkbh, "yjzbbh",0, size-1);
            DataRowCollection datarows = ds.Tables[0].Rows;
            ZYNLPJPT.Utility.ExcelSheet excelSheet = new Utility.ExcelSheet();
            excelSheet.Name = "一级指标分数";
            excelSheet.Header.Add("一级指标名称");
            excelSheet.Header.Add("一级指标分数");

            foreach (DataRow row in datarows)
            {

                string[] rowArray = new string[2];
                rowArray[0] = row["yjzbmc"].ToString();
                rowArray[1] = ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_YJZB(xsbh, int.Parse(row["yjzbbh"].ToString()),zybh).ToString();

                excelSheet.Content.Add(rowArray);

            }
            excelSheet.MergeColNum = new int[] { };
            return excelSheet;


        }
    }
  
}