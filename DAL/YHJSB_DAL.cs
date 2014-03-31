﻿/**  版本信息模板在安装目录下，可自行修改。
* YHJSB_DAL.cs
*
* 功 能： N/A
* 类 名： YHJSB_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:21   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:YHJSB_DAL
	/// </summary>
	public partial class YHJSB_DAL
	{
		public YHJSB_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("JSBH", "YHJSB"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string YHBH,int JSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YHJSB");
			strSql.Append(" where YHBH=@YHBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)			};
			parameters[0].Value = YHBH;
			parameters[1].Value = JSBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.YHJSB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YHJSB(");
			strSql.Append("YHBH,JSBH)");
			strSql.Append(" values (");
			strSql.Append("@YHBH,@JSBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
			parameters[0].Value = model.YHBH;
			parameters[1].Value = model.JSBH;

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
		public bool Update(ZYNLPJPT.Model.YHJSB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YHJSB set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("YHBH=@YHBH,");
			strSql.Append("JSBH=@JSBH");
			strSql.Append(" where YHBH=@YHBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
			parameters[0].Value = model.YHBH;
			parameters[1].Value = model.JSBH;

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
		public bool Delete(string YHBH,int JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YHJSB ");
			strSql.Append(" where YHBH=@YHBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)			};
			parameters[0].Value = YHBH;
			parameters[1].Value = JSBH;

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
		public ZYNLPJPT.Model.YHJSB GetModel(string YHBH,int JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 YHBH,JSBH from YHJSB ");
			strSql.Append(" where YHBH=@YHBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)			};
			parameters[0].Value = YHBH;
			parameters[1].Value = JSBH;

			ZYNLPJPT.Model.YHJSB model=new ZYNLPJPT.Model.YHJSB();
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
		public ZYNLPJPT.Model.YHJSB DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.YHJSB model=new ZYNLPJPT.Model.YHJSB();
			if (row != null)
			{
				if(row["YHBH"]!=null)
				{
					model.YHBH=row["YHBH"].ToString();
				}
				if(row["JSBH"]!=null && row["JSBH"].ToString()!="")
				{
					model.JSBH=int.Parse(row["JSBH"].ToString());
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
			strSql.Append("select YHBH,JSBH ");
			strSql.Append(" FROM YHJSB ");
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
			strSql.Append(" YHBH,JSBH ");
			strSql.Append(" FROM YHJSB ");
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
			strSql.Append("select count(1) FROM YHJSB ");
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
				strSql.Append("order by T.JSBH desc");
			}
			strSql.Append(")AS Row, T.*  from YHJSB T ");
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
			parameters[0].Value = "YHJSB";
			parameters[1].Value = "JSBH";
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

