using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;


using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public class Exceldaoru
    {
        public void GetSheet()
        {
            Stream s = new FileStream(@"F:/asd.xls", FileMode.Open, FileAccess.Read);
            IWorkbook workbook = new HSSFWorkbook(s);//从流内容创建Workbook对象
            ISheet sheet = workbook.GetSheetAt(0);//获取第一个工作表
            IRow headerRow = sheet.GetRow(0);//读取表头
            int cellCount = headerRow.LastCellNum;//读取列数
            int rowCount = sheet.LastRowNum;//读取行数
            System.Diagnostics.Debug.WriteLine(cellCount + "=============" + rowCount);
            List<Object> rlist = new List<Object>();
            for (int i = 1; i < rowCount;i++ )
            {
                IRow row = sheet.GetRow(i);//获取工作表第i行
                List<Object> list = new List<Object>();
                for (int j = 0; j < cellCount; j++) 
                {
                    ICell cell = row.GetCell(j);//获取行的第j列
                    string value = cell.ToString();//获取列的值
                    list.Add(value);
                    System.Diagnostics.Debug.WriteLine(value);
                }
                rlist.Add(list);
            }
            for (int n = 0; n < rlist.Count;n++ )
            {
                List<Object> list = (List<Object>)rlist[n];
               
            }
        }
    }
}