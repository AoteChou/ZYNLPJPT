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
        /// <returns>试题编号</returns>
        public int getSTBH(string xsbh,int kcbh) {
            //获取试题算法
            int stbh =  3;

            return stbh;
        }
    }
}