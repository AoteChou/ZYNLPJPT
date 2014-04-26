using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using System.Data;

namespace ZYNLPJPT.BLL
{
    public class GetTestResult_BLL
    {
        public static int getTestResult_ZSD(int zsdbh)
        {
            int result;
            PCJLZSDView_DAL pcjlzsdview_dal=new PCJLZSDView_DAL();
            DataSet ds = new DataSet();
            ds=pcjlzsdview_dal.GetList("zsdbh=" + zsdbh+" and pcfs IS NOT NULL");
            if(ds.Tables[0].Rows.Count==0){ //还没有分数的情况
             return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows) {
                fsandqz.FsList.Add(int.Parse(row["pcfs"].ToString()));
                fsandqz.QzList.Add(float.Parse(row["zsdbz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static List<int> getTestResult_ZSD(int[] zsdbhs) {
            List<int> result=new List<int>();
            foreach (int zsdbh in zsdbhs)
            {
                result.Add(getTestResult_ZSD(zsdbh));
            }
            return result;
        }
        private int getTestResult_ZSDY(int zsdybh)
        {
            int result;
            ZSD_DAL zsd_dal = new ZSD_DAL();
            DataSet ds = new DataSet();
            ds = zsd_dal.GetList("zsdybh=" + zsdybh);
            if (ds.Tables[0].Rows.Count == 0)
            { //知识单元下面没有知识点的情况
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                fsandqz.FsList.Add(getTestResult_ZSD(int.Parse(row["zsdbh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["zsdqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public List<int> getTestResult_ZSDY(int[] zsdybhs)
        {
            List<int> result = new List<int>();
            foreach (int zsdybh in zsdybhs)
            {
                result.Add(getTestResult_ZSDY(zsdybh));
            }
            return result;
        }
        
    }
}