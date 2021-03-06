﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:NJZYKC_DAL
	/// </summary>
	public partial class NJZYKC_DAL
	{
		public NJZYKC_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("KCBH", "NJZYKC"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int KCBH,int ZYBH,int NJBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NJZYKC");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.NJZYKC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NJZYKC(");
			strSql.Append("KCBH,ZYBH,NJBH)");
			strSql.Append(" values (");
			strSql.Append("@KCBH,@ZYBH,@NJBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.NJBH;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ZYNLPJPT.Model.NJZYKC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NJZYKC set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("NJBH=@NJBH");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.NJBH;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int KCBH,int ZYBH,int NJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NJZYKC ");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public ZYNLPJPT.Model.NJZYKC GetModel(int KCBH,int ZYBH,int NJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCBH,ZYBH,NJBH from NJZYKC ");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;

			ZYNLPJPT.Model.NJZYKC model=new ZYNLPJPT.Model.NJZYKC();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public ZYNLPJPT.Model.NJZYKC DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.NJZYKC model=new ZYNLPJPT.Model.NJZYKC();
			if (row != null)
			{
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select KCBH,ZYBH,NJBH ");
			strSql.Append(" FROM NJZYKC ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" KCBH,ZYBH,NJBH ");
			strSql.Append(" FROM NJZYKC ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM NJZYKC ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.NJBH desc");
			}
			strSql.Append(")AS Row, T.*  from NJZYKC T ");
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
			parameters[0].Value = "NJZYKC";
			parameters[1].Value = "NJBH";
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

