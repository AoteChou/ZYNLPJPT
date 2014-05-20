using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class ExcelSheet
    {
        public ExcelSheet()
        {
            name = new Random().Next().ToString();
            header = new List<string>();
            content = new List<string[]>();
            mergeColNum = null;

        }
        private int[] mergeColNum;//需要合并的列

        public int[] MergeColNum
        {
            get { return mergeColNum; }
            set { mergeColNum = value; }
        }
        private string name;//sheet名

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<string> header;//表头

        public List<string> Header
        {
            get { return header; }
            set { header = value; }
        }
        private List<string[]> content;//表内容

        public List<string[]> Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}