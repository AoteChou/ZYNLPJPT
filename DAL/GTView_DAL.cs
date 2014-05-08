/**  版本信息模板在安装目录下，可自行修改。
* GTView_DAL.cs
*
* 功 能： N/A
* 类 名： GTView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/28 17:41:30   N/A    初版
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
using ZYNLPJPT.Utility;//Please add references
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:GTView_DAL
	/// </summary>
	public partial class GTView_DAL
	{
		public GTView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.GTView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GTView(");
			strSql.Append("PCJLBH,STBH,KCBH,XSBH,XZRQ,SCRQ,GTR,PCFS)");
			strSql.Append(" values (");
			strSql.Append("@PCJLBH,@STBH,@KCBH,@XSBH,@XZRQ,@SCRQ,@GTR,@PCFS)");
			SqlParameter[] parameters = {
					new SqlParameter("@PCJLBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@PCFS", SqlDbType.Int,4)};
			parameters[0].Value = model.PCJLBH;
			parameters[1].Value = model.STBH;
			parameters[2].Value = model.KCBH;
			parameters[3].Value = model.XSBH;
			parameters[4].Value = model.XZRQ;
			parameters[5].Value = model.SCRQ;
			parameters[6].Value = model.GTR;
			parameters[7].Value = model.PCFS;

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
		public bool Update(ZYNLPJPT.Model.GTView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GTView set ");
			strSql.Append("PCJLBH=@PCJLBH,");
			strSql.Append("STBH=@STBH,");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("XZRQ=@XZRQ,");
			strSql.Append("SCRQ=@SCRQ,");
			strSql.Append("GTR=@GTR,");
			strSql.Append("PCFS=@PCFS");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@PCJLBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@PCFS", SqlDbType.Int,4)};
			parameters[0].Value = model.PCJLBH;
			parameters[1].Value = model.STBH;
			parameters[2].Value = model.KCBH;
			parameters[3].Value = model.XSBH;
			parameters[4].Value = model.XZRQ;
			parameters[5].Value = model.SCRQ;
			parameters[6].Value = model.GTR;
			parameters[7].Value = model.PCFS;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GTView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public ZYNLPJPT.Model.GTView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PCJLBH,STBH,KCBH,XSBH,XZRQ,SCRQ,GTR,PCFS from GTView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.GTView model=new ZYNLPJPT.Model.GTView();
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
		public ZYNLPJPT.Model.GTView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.GTView model=new ZYNLPJPT.Model.GTView();
			if (row != null)
			{
				if(row["PCJLBH"]!=null && row["PCJLBH"].ToString()!="")
				{
					model.PCJLBH=int.Parse(row["PCJLBH"].ToString());
				}
				if(row["STBH"]!=null && row["STBH"].ToString()!="")
				{
					model.STBH=int.Parse(row["STBH"].ToString());
				}
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["XZRQ"]!=null && row["XZRQ"].ToString()!="")
				{
					model.XZRQ=DateTime.Parse(row["XZRQ"].ToString());
				}
				if(row["SCRQ"]!=null && row["SCRQ"].ToString()!="")
				{
					model.SCRQ=DateTime.Parse(row["SCRQ"].ToString());
				}
				if(row["GTR"]!=null)
				{
					model.GTR=row["GTR"].ToString();
				}
				if(row["PCFS"]!=null && row["PCFS"].ToString()!="")
				{
					model.PCFS=int.Parse(row["PCFS"].ToString());
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
			strSql.Append("select PCJLBH,STBH,KCBH,XSBH,XZRQ,SCRQ,GTR,PCFS ");
			strSql.Append(" FROM GTView ");
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
			strSql.Append(" PCJLBH,STBH,KCBH,XSBH,XZRQ,SCRQ,GTR,PCFS ");
			strSql.Append(" FROM GTView ");
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
			strSql.Append("select count(1) FROM GTView ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from GTView T ");
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
			parameters[0].Value = "GTView";
			parameters[1].Value = "";
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

