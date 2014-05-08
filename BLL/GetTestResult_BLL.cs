using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using System.Data;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.BLL
{
    public class GetTestResult_BLL
    {
        public static int getTestResult_ZSD(string xsbh,int zsdbh)
        {
            int result;
            PCJLZSDView_DAL pcjlzsdview_dal=new PCJLZSDView_DAL();
            DataSet ds = new DataSet();
            ds=pcjlzsdview_dal.GetList("zsdbh=" + zsdbh+" and pcfs IS NOT NULL and xsbh="+xsbh);
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
        public static List<int> getTestResult_ZSD(string xsbh, int[] zsdbhs)
        {
            List<int> result=new List<int>();
            foreach (int zsdbh in zsdbhs)
            {
                result.Add(getTestResult_ZSD(xsbh,zsdbh));
            }
            return result;
        }
        public static int getTestResult_ZSDY(string xsbh,int zsdybh)
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
                fsandqz.FsList.Add(getTestResult_ZSD(xsbh,int.Parse(row["zsdbh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["zsdqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static List<int> getTestResult_ZSDY(string xsbh,int[] zsdybhs)
        {
            List<int> result = new List<int>();
            foreach (int zsdybh in zsdybhs)
            {
                result.Add(getTestResult_ZSDY(xsbh,zsdybh));
            }
            return result;
        }
        public static int getTestResult_ZSLY(string xsbh,int zslybh)
        {
            int result;
            ZSTXQZView_DAL zstxqzview_dal = new ZSTXQZView_DAL();
            DataSet ds = new DataSet();
            ds = zstxqzview_dal.getZSDYByZSLYBH(zslybh); //获取下面有知识点的知识单元
            if (ds.Tables[0].Rows.Count == 0)
            { //知识领域下面没有知识单元的情况
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                fsandqz.FsList.Add(getTestResult_ZSDY(xsbh,int.Parse(row["zsdybh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["zsdyqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static List<int> getTestResult_ZSLY(string xsbh,int[] zslybhs)
        {
            List<int> result = new List<int>();
            foreach (int zslybh in zslybhs)
            {
                result.Add(getTestResult_ZSLY(xsbh,zslybh));
            }
            return result;
        }
        public static int getTestResult_EJZB(string xsbh,int ejzbbh)
        {
            int result;
            ZSDY_DAL zsdy_dal = new ZSDY_DAL();
            DataSet ds = new DataSet();
            ds = zsdy_dal.GetList("ejzbbh=" + ejzbbh); //获取二级指标对应的知识单元
            if (ds.Tables[0].Rows.Count == 0)
            { //二级指标没有对应的知识单元
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                fsandqz.FsList.Add(getTestResult_ZSDY(xsbh,int.Parse(row["zsdybh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["zsdyqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static int getTestResult_YJZB(string xsbh,int yjzbbh,int zybh)
        {
            int result;
            ZYNLZBView_DAL zynlzbview_dal = new ZYNLZBView_DAL();
            DataSet ds = new DataSet();
            ds = zynlzbview_dal.GetList("yjzbbh=" + yjzbbh+" and zybh="+zybh); //获取一级指标下的二级指标
            if (ds.Tables[0].Rows.Count == 0)
            { //一级指标下面没有二级指标
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                fsandqz.FsList.Add(getTestResult_EJZB(xsbh,int.Parse(row["ejzbbh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["nlyq"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static int getTestResult_YJZB(string xsbh, int yjzbbh, int zybh,ref List<ZBMCAndFS> ejzbmcandfsList)
        {
            int result;
            ZYNLZBView_DAL zynlzbview_dal = new ZYNLZBView_DAL();
            DataSet ds = new DataSet();
            ds = zynlzbview_dal.GetList("yjzbbh=" + yjzbbh + " and zybh=" + zybh); //获取一级指标下的二级指标
            if (ds.Tables[0].Rows.Count == 0)
            { //一级指标下面没有二级指标
                return 0;
            }

            

            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ZBMCAndFS zbmcandfs = new ZBMCAndFS(false);
                zbmcandfs.Zbmc = row["ejzbmc"].ToString();
                int fs = getTestResult_EJZB(xsbh, int.Parse(row["ejzbbh"].ToString()));
                zbmcandfs.Fs = fs;
                ejzbmcandfsList.Add(zbmcandfs);

                fsandqz.FsList.Add(getTestResult_EJZB(xsbh, int.Parse(row["ejzbbh"].ToString())));
                fsandqz.QzList.Add(int.Parse(row["nlyq"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        public static int getTestResult_Final(string xsbh)
        {

            int result;
            int xkbh = -1;
            int zybh = -1;
            //获取用户所属的学科编号 以及专业编号
            XSBJZYView_DAL xsbjzyview_dal = new XSBJZYView_DAL();
            DataSet ds1 = xsbjzyview_dal.GetList("xsbh=" +xsbh);
            if (ds1.Tables[0].Rows.Count >= 0)
            {
                xkbh = int.Parse(ds1.Tables[0].Rows[0]["xkbh"].ToString());
                zybh = int.Parse(ds1.Tables[0].Rows[0]["zybh"].ToString());
            }
            else
            {
                return 0;
            }

            YJZB_DAL yjzb_dal = new YJZB_DAL();
            DataSet ds = new DataSet();
            ds = yjzb_dal.GetList("xkbh=" + xkbh); //获取学科下的一级指标
            if (ds.Tables[0].Rows.Count == 0)
            { //学科下没有一级指标
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                fsandqz.FsList.Add(getTestResult_YJZB(xsbh,int.Parse(row["yjzbbh"].ToString()),zybh));
                fsandqz.QzList.Add(int.Parse(row["yjzbqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        /// <summary>
        /// 获取最终分数 并获取下面一级指标 二级指标的列表和分数
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="mcandfs"></param>
        /// <returns></returns>
        public static int getTestResult_Final(string xsbh,ref List<ZBMCAndFS> mcandfs)
        {

            int result;
            int xkbh = -1;
            int zybh = -1;
            //获取用户所属的学科编号 以及专业编号
            XSBJZYView_DAL xsbjzyview_dal = new XSBJZYView_DAL();
            DataSet ds1 = xsbjzyview_dal.GetList("xsbh=" + xsbh);
            if (ds1.Tables[0].Rows.Count >= 0)
            {
                xkbh = int.Parse(ds1.Tables[0].Rows[0]["xkbh"].ToString());
                zybh = int.Parse(ds1.Tables[0].Rows[0]["zybh"].ToString());
            }
            else
            {
                return 0;
            }

            YJZB_DAL yjzb_dal = new YJZB_DAL();
            DataSet ds = new DataSet();
            ds = yjzb_dal.GetList("xkbh=" + xkbh); //获取学科下的一级指标
            if (ds.Tables[0].Rows.Count == 0)
            { //学科下没有一级指标
                return 0;
            }
            ZYNLPJPT.Utility.FSAndQZ fsandqz = new Utility.FSAndQZ();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ZBMCAndFS zbmcandfs = new ZBMCAndFS(true);
                zbmcandfs.Zbmc = row["YJZBMC"].ToString();
                List<ZBMCAndFS> ejzbmcandfsList = new List<ZBMCAndFS>();
                int fs = getTestResult_YJZB(xsbh, int.Parse(row["yjzbbh"].ToString()), zybh,ref ejzbmcandfsList);
                zbmcandfs.Fs = fs;
                zbmcandfs.MCandFS_child = ejzbmcandfsList;

                mcandfs.Add(zbmcandfs);

                fsandqz.FsList.Add(fs);
                fsandqz.QzList.Add(int.Parse(row["yjzbqz"].ToString()));
            }
            result = fsandqz.getweightedaverage();
            return result;

        }
        
    }
}