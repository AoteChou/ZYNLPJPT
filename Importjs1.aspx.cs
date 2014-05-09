using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class Importjs1 : System.Web.UI.Page
    {
        private bool flag;
        private int xkbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xkbh = int.Parse(Request["xkbh"]);
 
            }
            
        }
        protected void Import_Clicked(object sender, EventArgs e)
        {
            xkbh = int.Parse(Request["xkbh"]);
            flag = true;
            if (IsValid && fileInput.HasFile)
            {

                Stream s = fileInput.FileContent;
                IWorkbook workbook = new HSSFWorkbook(s);//从流内容创建Workbook对象
                ISheet sheet = workbook.GetSheetAt(0);//获取第一个工作表
                IRow headerRow = sheet.GetRow(0);//读取表头
                int cellCount = headerRow.LastCellNum;//读取列数
                int rowCount = sheet.LastRowNum;//读取行数
                //Response.Write(cellCount + "=============" + rowCount);
                List<Object> rlist = new List<Object>();
                for (int i = 1; i <= rowCount; i++)
                {
                    IRow row = sheet.GetRow(i);//获取工作表第i行
                    List<Object> list = new List<Object>();
                    for (int j = 0; j < cellCount; j++)
                    {
                        ICell cell = row.GetCell(j);//获取行的第j列
                        string value = "";
                        if (cell != null)
                        {
                            value = cell.ToString();//获取列的值

                        }
                        if (j == 0)
                        {
                            checkYHBH(value, i);
                            list.Add(value);
                        }
                        else if (j == 1)
                        {

                            checkXM(value, i);
                            list.Add(value);
                        }
                        else if (j == 2)
                        {
                            list.Add(checkXB(value, i));
                        }
                        else if (j == 3)
                        {
                            list.Add(checkSFSXKFZR(value, i));
                        }
                        else if (j == 4)
                        {
                            list.Add(checkSFSKCFZR(value, i));
                        }


                        //Response.Write(value);
                    }
                    rlist.Add(list);
                }
                int failNum = 0;
                int successNum = rlist.Count;
                if (flag)
                {

                    for (int n = 0; n < rlist.Count; n++)
                    {
                        List<Object> list = (List<Object>)rlist[n];




                        YH yh = new YH();
                        yh.YHBH = list[0].ToString();
                        yh.MM = list[0].ToString();
                        yh.XM = list[1].ToString();
                        yh.XB = (bool)list[2];
                        JS js = new JS();
                        js.JSBH = list[0].ToString();
                        js.SFSKCFZR = (bool)list[3];
                        js.SFSXKFZR = (bool)list[4];
                        js.SSXK = xkbh;
                        YHJSB yhjsb = new YHJSB();
                        yhjsb.YHBH = list[0].ToString();
                        yhjsb.JSBH = 1;

                        try
                        {
                            new YH_DAL().AddJS(yh, js, yhjsb);
                            //new YH_DAL().Add(yh);
                            //new JSTea_DAL().Add(js);
                            //new YHJSB_DAL().Add(yhjsb);

                        }
                        catch (Exception)
                        {
                            appendContent("导入错误-----导入用户：" + yh.YHBH + "时出错,请重试<br/>");
                            failNum++;
                            successNum--;
                            continue;
                           //throw;
                        }


                    }
                    appendContent("导入成功，成功" + successNum + "条  失败：" + failNum + " 条<br/>");



                }

            }
        }
        public void appendContent(string addString)
        {
            //ClientScript.RegisterStartupScript(Page.GetType(), "myjs", "<script type='text/javascript'>$(\"#ResultDiv\").append('" + addString + "')</script>");
            Response.Write(addString);
        }
        public void checkYHBH(string value, int rowID)
        {
            if (value.Length != 7)
            {
                appendContent("数据错误-----第" + rowID + "行导入出错,教师编号需为7位<br/>");
                flag = false;
            }
        }
        public void checkXM(string value, int rowID)
        {
            if (value.Trim() == "")
            {
                appendContent("数据错误-----第" + rowID + "行导入出错,姓名不许为空<br/>");
                flag = false;
            }
        }
        public bool checkXB(string value, int rowID)
        {
            if (value == "男")
            {
                return true;
            }
            else if (value == "女")
            {
                return false;
            }
            else
            {
                appendContent("数据错误-----第" + rowID + "行导入出错,性别填写出错<br/>");
                flag = false;
            }
            return false;
        }
        public bool checkSFSXKFZR(string value, int rowID)
        {
            if (value == "是")
            {
                return true;
            }
            else if (value == "否")
            {
                return false;
            }
            else
            {
                appendContent("数据错误-----第" + rowID + "行导入出错,是否是学科负责人填写出错<br/>");
                flag = false;
            }
            return false;
        }

        public bool checkSFSKCFZR(string value, int rowID)
        {
            if (value == "是")
            {
                return true;
            }
            else if (value == "否")
            {
                return false;
            }
            else
            {
                appendContent("数据错误-----第" + rowID + "行导入出错,是否是课程负责人填写出错<br/>");
                flag = false;
            }
            return false;
        }
    }
}
    

