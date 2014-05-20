using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using ZYNLPJPT.Model;


namespace ZYNLPJPT.Utility
{
    public class ExcelOutputHelper
    {
        public static MemoryStream RenderToExcel(List<ExcelSheet> excelSheets)
        {
            MemoryStream ms = new MemoryStream();

            
                IWorkbook workbook = new HSSFWorkbook();
                foreach (ExcelSheet excelSheet in excelSheets)
                {
                    if (excelSheet != null)
                    {
                        RenderToExcel_Sheet(workbook, excelSheet);
                    } 
                }
               
                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                
            
            return ms;
        }
        private static void RenderToExcel_Sheet(IWorkbook workbook, ExcelSheet excelSheet)
        {

            ISheet sheet = workbook.CreateSheet(excelSheet.Name);
                
                IRow headerRow = sheet.CreateRow(0);
               
                // handling header.
                for(int i=0;i<excelSheet.Header.Count;i++){
                    headerRow.CreateCell(i).SetCellValue(excelSheet.Header[i]);
                }
                    
                // handling value.
                int rowIndex = 1;

                foreach (string[] row in excelSheet.Content)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);
                    for (int i = 0; i < row.Length; i++)
                    {
                        dataRow.CreateCell(i).SetCellValue(row[i]);
                    }
                    rowIndex++;
                }
                for(int k=0;k<excelSheet.Header.Count;k++){
                    sheet.AutoSizeColumn(k);
                }
                
                mergeColumns(sheet,excelSheet.MergeColNum);

        }
        private static void mergeColumns(ISheet sheet,int[] mergeColNum) {
            IRow headerRow = sheet.GetRow(0);//读取表头
            int cellCount = headerRow.LastCellNum;//读取列数
            int rowCount = sheet.LastRowNum;//读取行数

            for (int i = 1; i < rowCount;i++ )
            {
                foreach(int j in mergeColNum){
                    string fString=sheet.GetRow(i).GetCell(j).ToString();
                    string sString=sheet.GetRow(i + 1).GetCell(j).ToString();
                    if ( fString==sString &&!string.IsNullOrEmpty(fString)) { 
                        sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(i,i+1,j,j));
                    }
                }                
            }
        }

       
    }
}