
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using System.Collections.Generic;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:PCJL_DAL
	/// </summary>
	public partial class PCJL_DAL
	{
		public PCJL_DAL()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("PCJLBH", "PCJL");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PCJLBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PCJL");
            strSql.Append(" where PCJLBH=@PCJLBH");
            SqlParameter[] parameters = {
					new SqlParameter("@PCJLBH", SqlDbType.Int,4)
			};
            parameters[0].Value = PCJLBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZYNLPJPT.Model.PCJL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PCJL(");
            strSql.Append("STBH,XSBH,XZRQ,SCRQ,PCFS,GTR,XSSTDA,HZM)");
            strSql.Append(" values (");
            strSql.Append("@STBH,@XSBH,@XZRQ,@SCRQ,@PCFS,@GTR,@XSSTDA,@HZM)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@PCFS", SqlDbType.Int,4),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@XSSTDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50)};
            parameters[0].Value = model.STBH;
            parameters[1].Value = model.XSBH;
            parameters[2].Value = model.XZRQ;
            parameters[3].Value = model.SCRQ;
            parameters[4].Value = model.PCFS;
            parameters[5].Value = model.GTR;
            parameters[6].Value = model.XSSTDA;
            parameters[7].Value = model.HZM;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ZYNLPJPT.Model.PCJL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PCJL set ");
            strSql.Append("STBH=@STBH,");
            strSql.Append("XSBH=@XSBH,");
            strSql.Append("XZRQ=@XZRQ,");
            strSql.Append("SCRQ=@SCRQ,");
            strSql.Append("PCFS=@PCFS,");
            strSql.Append("GTR=@GTR,");
            strSql.Append("XSSTDA=@XSSTDA,");
            strSql.Append("HZM=@HZM");
            strSql.Append(" where PCJLBH=@PCJLBH");
            SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@PCFS", SqlDbType.Int,4),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@XSSTDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50),
					new SqlParameter("@PCJLBH", SqlDbType.Int,4)};
            parameters[0].Value = model.STBH;
            parameters[1].Value = model.XSBH;
            parameters[2].Value = model.XZRQ;
            parameters[3].Value = model.SCRQ;
            parameters[4].Value = model.PCFS;
            parameters[5].Value = model.GTR;
            parameters[6].Value = model.XSSTDA;
            parameters[7].Value = model.HZM;
            parameters[8].Value = model.PCJLBH;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PCJLBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PCJL ");
            strSql.Append(" where PCJLBH=@PCJLBH");
            SqlParameter[] parameters = {
					new SqlParameter("@PCJLBH", SqlDbType.Int,4)
			};
            parameters[0].Value = PCJLBH;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string PCJLBHlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PCJL ");
            strSql.Append(" where PCJLBH in (" + PCJLBHlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZYNLPJPT.Model.PCJL GetModel(int PCJLBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM from PCJL ");
            strSql.Append(" where PCJLBH=@PCJLBH");
            SqlParameter[] parameters = {
					new SqlParameter("@PCJLBH", SqlDbType.Int,4)
			};
            parameters[0].Value = PCJLBH;

            ZYNLPJPT.Model.PCJL model = new ZYNLPJPT.Model.PCJL();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZYNLPJPT.Model.PCJL DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.PCJL model = new ZYNLPJPT.Model.PCJL();
            if (row != null)
            {
                if (row["STBH"] != null && row["STBH"].ToString() != "")
                {
                    model.STBH = int.Parse(row["STBH"].ToString());
                }
                if (row["XSBH"] != null)
                {
                    model.XSBH = row["XSBH"].ToString();
                }
                if (row["XZRQ"] != null && row["XZRQ"].ToString() != "")
                {
                    model.XZRQ = DateTime.Parse(row["XZRQ"].ToString());
                }
                if (row["SCRQ"] != null && row["SCRQ"].ToString() != "")
                {
                    model.SCRQ = DateTime.Parse(row["SCRQ"].ToString());
                }
                if (row["PCFS"] != null && row["PCFS"].ToString() != "")
                {
                    model.PCFS = int.Parse(row["PCFS"].ToString());
                }
                if (row["PCJLBH"] != null && row["PCJLBH"].ToString() != "")
                {
                    model.PCJLBH = int.Parse(row["PCJLBH"].ToString());
                }
                if (row["GTR"] != null)
                {
                    model.GTR = row["GTR"].ToString();
                }
                if (row["XSSTDA"] != null && row["XSSTDA"].ToString() != "")
                {
                    model.XSSTDA = (byte[])row["XSSTDA"];
                }
                if (row["HZM"] != null)
                {
                    model.HZM = row["HZM"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM ");
            strSql.Append(" FROM PCJL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM ");
            strSql.Append(" FROM PCJL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM PCJL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.PCJLBH desc");
            }
            strSql.Append(")AS Row, T.*  from PCJL T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "PCJL";
            parameters[1].Value = "PCJLBH";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 获取特定课程下的评测记录数目
        /// </summary>
        /// <param name="kcbh">课程编号（数组）</param>
        /// <returns>评测记录数目（数组）</returns>
        public int[] getPCJLNumByKCBH(int[] kcbhs)
        {

            List<int> numList = new List<int>();
            int num = 0;
            foreach (int kcbh in kcbhs)
            {
                string sqlString = "select count(*) from pcjl where pcjl.stbh in(select stbh from st where kcbh=@kcbh)";
                SqlParameter[] sqlparameters =
                {
                    new SqlParameter("@kcbh",kcbh)
                           };
                SqlDataReader sdReader = DbHelperSQL.ExecuteReader(sqlString, sqlparameters);
                if (sdReader.Read())
                {
                    num = (int)(sdReader[0]);
                }
                sdReader.Close();
                numList.Add(num);
            }

           
            return numList.ToArray();
        }
        /// <summary>
        /// 获取特定课程下未完成的评测记录数目
        /// </summary>
        /// <param name="kcbh">课程编号（数组）</param>
        /// <returns>评测记录数目（数组）</returns>
        public int[] getPCJLNumByKCBH_Undone(int[] kcbhs)
        {

            List<int> numList = new List<int>();
            int num = 0;
            foreach (int kcbh in kcbhs)
            {
                string sqlString = "select count(*) from pcjl where pcjl.stbh in(select stbh from st where kcbh=@kcbh) and xsstda IS NULL";
                SqlParameter[] sqlparameters =
                {
                    new SqlParameter("@kcbh",kcbh)
                           };
                SqlDataReader sdReader = DbHelperSQL.ExecuteReader(sqlString, sqlparameters);
                if (sdReader.Read())
                {
                    num = (int)(sdReader[0]);
                }
                sdReader.Close();
                numList.Add(num);
            }


            return numList.ToArray();
        }
        /// <summary>
        /// 获取特定课程下已完成的评测记录数目
        /// </summary>
        /// <param name="kcbh">课程编号（数组）</param>
        /// <returns>评测记录数目（数组）</returns>
        public int[] getPCJLNumByKCBH_Done(int[] kcbhs)
        {

            List<int> numList = new List<int>();
            int num = 0;
            foreach (int kcbh in kcbhs)
            {
                string sqlString = "select count(*) from pcjl where pcjl.stbh in(select stbh from st where kcbh=@kcbh) and xsstda IS NOT NULL";
                SqlParameter[] sqlparameters =
                {
                    new SqlParameter("@kcbh",kcbh)
                           };
                SqlDataReader sdReader = DbHelperSQL.ExecuteReader(sqlString, sqlparameters);
                if (sdReader.Read())
                {
                    num = (int)(sdReader[0]);
                }
                sdReader.Close();
                numList.Add(num);
            }


            return numList.ToArray();
        }
        /// <summary>
        /// 获取某个学生特定课程是否还存在上次还未完成的试题
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <returns></returns>
        public ZYNLPJPT.Model.PCJL getPCJL_Undone(string xsbh, int kcbh)
        {
            string sqlString = "select top 1 * from pcjl where xsbh=@xsbh and xsstda IS NULL and stbh in(select stbh from st where kcbh=@kcbh)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh),
                new SqlParameter("@kcbh",kcbh)
                       };
            ZYNLPJPT.Model.PCJL pcjl = null;

          
            DataSet ds= DbHelperSQL.Query(sqlString,sqlparameters);
            if (ds.Tables[0].Rows.Count>0)
            {
                pcjl = DataRowToModel(ds.Tables[0].Rows[0]);

            }

            return pcjl;
        }
        /// <summary>
        /// 获取某个学生特定课程是所有未完成的试题
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <returns></returns>
        public ZYNLPJPT.Model.PCJL[] getPCJL_Undone_ALL(string xsbh, int kcbh)
        {
            string sqlString = "select * from pcjl where xsbh=@xsbh and xsstda IS NULL and stbh in(select stbh from st where kcbh=@kcbh)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh),
                new SqlParameter("@kcbh",kcbh)
                       };

            List<ZYNLPJPT.Model.PCJL> pcjlList=new List<Model.PCJL>();
            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                pcjlList.Add(DataRowToModel(row));
            }

            return pcjlList.ToArray();
        }
        /// <summary>
        /// 获取某个学生特定课程是所有未完成的试题(分页)
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public ZYNLPJPT.Model.PCJL[] getPCJL_Undone_ALLByPage(string xsbh, int kcbh,int startIndex, int endIndex)
        {
            List<ZYNLPJPT.Model.PCJL> pcjlList=new List<Model.PCJL>();
            DataSet ds = GetListByPage("xsbh=" + xsbh + " and xsstda IS NULL and stbh in(select stbh from st where kcbh=" + kcbh, "", startIndex, endIndex);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                pcjlList.Add(DataRowToModel(row));
            }

            return pcjlList.ToArray();
        }
        /// <summary>
        /// 获取某个学生特定课程下所有有分数的试题
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <returns></returns>
        public ZYNLPJPT.Model.PCJL[] getPCJLWithMark_ALL(string xsbh, int kcbh)
        {
            string sqlString = "select * from pcjl where xsbh=@xsbh and pcfs IS NOT NULL and stbh in(select stbh from st where kcbh=@kcbh)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh),
                new SqlParameter("@kcbh",kcbh)
                       };

            List<ZYNLPJPT.Model.PCJL> pcjlList = new List<Model.PCJL>();
            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                pcjlList.Add(DataRowToModel(row));
            }

            return pcjlList.ToArray();
        }
        /// <summary>
        /// 获取某个学生特定课程下所有有分数的试题总数
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <returns></returns>
        public int getPCJLWithMark_ALL_Count(string xsbh, int kcbh)
        {
            string sqlString = "select * from pcjl where xsbh=@xsbh and pcfs IS NOT NULL and stbh in(select stbh from st where kcbh=@kcbh)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh),
                new SqlParameter("@kcbh",kcbh)
                       };

            List<ZYNLPJPT.Model.PCJL> pcjlList = new List<Model.PCJL>();
            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);


            return ds.Tables[0].Rows.Count;
        }
        /// <summary>
        /// 获取某个学生特定课程下所有有分数的试题（分页）
        /// </summary>
        /// <param name="xsbh"></param>
        /// <param name="kcbh"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public ZYNLPJPT.Model.PCJL[] getPCJLWithMark_ALLByPage(string xsbh, int kcbh, int startIndex, int endIndex)
        {
            List<ZYNLPJPT.Model.PCJL> pcjlList = new List<Model.PCJL>();
            DataSet ds = GetListByPage("xsbh=" + xsbh + " and pcfs IS NOT NULL and stbh in(select stbh from st where kcbh=" + kcbh+")", "", startIndex, endIndex);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                pcjlList.Add(DataRowToModel(row));
            }

            return pcjlList.ToArray();
        }
        
       
        /// <summary>
        /// 部分更新（更新条件上传时间以及评测记录编号）
        /// </summary>
        /// <param name="scrq">上传时间</param>
        /// <param name="xsstda">学生试题答案</param>
        /// <param name="pcjlbh">评测记录编号</param>
        /// <returns></returns>
        public bool Update(DateTime scrq,byte[] xsstda,int pcjlbh,string hzm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PCJL set ");
            strSql.Append("SCRQ=@SCRQ,");
            strSql.Append("XSSTDA=@XSSTDA,");
            strSql.Append("HZM=@HZM");
            strSql.Append(" where PCJLBH=@PCJLBH");
            SqlParameter[] parameters = {
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@XSSTDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@PCJLBH", SqlDbType.Int,4),
                    new SqlParameter("@HZM", SqlDbType.VarChar,50)};
            parameters[0].Value = scrq;
            parameters[1].Value = xsstda;
            parameters[2].Value = pcjlbh;
            parameters[3].Value = hzm;
          

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获取目前所有试题的最高分其中分数最低的试题
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>评测记录</returns>
        public ZYNLPJPT.Model.PCJL getPCJLWithLowestMark(string xsbh, int kcbh)
        {
            String sqlString ="select top 1 * from(select *, ROW_NUMBER() over(partition by stbh order by pcfs desc) as rowNum from pcjl) ranked where ranked.rowNum <= 1 and  xsbh=@xsbh and pcfs IS NOT NULL  and stbh in(select stbh from st where kcbh=@kcbh)order by ranked.pcfs asc";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh),
                new SqlParameter("@kcbh",kcbh)
                       };
            ZYNLPJPT.Model.PCJL pcjl = new ZYNLPJPT.Model.PCJL();
            DataSet ds = DbHelperSQL.Query(sqlString , sqlparameters);
            if(ds.Tables[0].Rows.Count>=0)
            {
               pcjl=DataRowToModel(ds.Tables[0].Rows[0]);
            }

            return pcjl;
        }
		#endregion  ExtensionMethod
	}
}

