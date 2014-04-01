using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.BLL
{
    public class GetTest_BLL
    {
        /// <summary>
        /// 获取试题编号
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <param name="teststate">测试类型</param>
        /// <returns>试题编号</returns>
        public int getSTBH(string xsbh,int kcbh,ref int teststate) {

            int stbh = -1;
            ST_DAL st_dal=new ST_DAL();
            PCJL_DAL pcjl_dal = new PCJL_DAL();
            PCJL pcjl = pcjl_dal.getPCJL_Undone(xsbh, kcbh);
            if (pcjl == null)
            {
                //不存在未完成的测试，创建新测试
                //这里写算法 之后补充
                stbh = 2;
                teststate = TestState.NEWTEST;
            }
            else { 
                //完成未完成的测试
                stbh = pcjl.STBH;
                teststate = TestState.UNDONETEST;
            }
            


            return stbh;
        }
    }
}