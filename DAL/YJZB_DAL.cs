﻿
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
    /// <summary>
    /// 数据访问类:YJZB_DAL
    /// </summary>
    public partial class YJZB_DAL
    {
        public YJZB_DAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("YJZBBH", "YJZB");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int YJZBBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from YJZB");
            strSql.Append(" where YJZBBH=@YJZBBH");
            SqlParameter[] parameters = {
					new SqlParameter("@YJZBBH", SqlDbType.Int,4)
			};
            parameters[0].Value = YJZBBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZYNLPJPT.Model.YJZB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into YJZB(");
            strSql.Append("YJZBMC,XKBH)");
            strSql.Append(" values (");
            strSql.Append("@YJZBMC,@XKBH)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4)};
            parameters[0].Value = model.YJZBMC;
            parameters[1].Value = model.XKBH;

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
        public bool Update(ZYNLPJPT.Model.YJZB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update YJZB set ");
            strSql.Append("YJZBMC=@YJZBMC,");
            strSql.Append("XKBH=@XKBH");
            strSql.Append(" where YJZBBH=@YJZBBH");
            SqlParameter[] parameters = {
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4)};
            parameters[0].Value = model.YJZBMC;
            parameters[1].Value = model.XKBH;
            parameters[2].Value = model.YJZBBH;

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
        public bool Delete(int YJZBBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YJZB ");
            strSql.Append(" where YJZBBH=@YJZBBH");
            SqlParameter[] parameters = {
					new SqlParameter("@YJZBBH", SqlDbType.Int,4)
			};
            parameters[0].Value = YJZBBH;

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
        public bool DeleteList(string YJZBBHlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YJZB ");
            strSql.Append(" where YJZBBH in (" + YJZBBHlist + ")  ");
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
        public ZYNLPJPT.Model.YJZB GetModel(int YJZBBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 YJZBBH,YJZBMC,XKBH from YJZB ");
            strSql.Append(" where YJZBBH=@YJZBBH");
            SqlParameter[] parameters = {
					new SqlParameter("@YJZBBH", SqlDbType.Int,4)
			};
            parameters[0].Value = YJZBBH;

            ZYNLPJPT.Model.YJZB model = new ZYNLPJPT.Model.YJZB();
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
        public ZYNLPJPT.Model.YJZB DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.YJZB model = new ZYNLPJPT.Model.YJZB();
            if (row != null)
            {
                if (row["YJZBBH"] != null && row["YJZBBH"].ToString() != "")
                {
                    model.YJZBBH = int.Parse(row["YJZBBH"].ToString());
                }
                if (row["YJZBMC"] != null)
                {
                    model.YJZBMC = row["YJZBMC"].ToString();
                }
                if (row["XKBH"] != null && row["XKBH"].ToString() != "")
                {
                    model.XKBH = int.Parse(row["XKBH"].ToString());
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
            strSql.Append("select YJZBBH,YJZBMC,XKBH ");
            strSql.Append(" FROM YJZB ");
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
            strSql.Append(" YJZBBH,YJZBMC,XKBH ");
            strSql.Append(" FROM YJZB ");
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
            strSql.Append("select count(1) FROM YJZB ");
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
                strSql.Append("order by T.YJZBBH desc");
            }
            strSql.Append(")AS Row, T.*  from YJZB T ");
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
            parameters[0].Value = "YJZB";
            parameters[1].Value = "YJZBBH";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
