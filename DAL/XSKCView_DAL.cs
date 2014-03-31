/**  版本信息模板在安装目录下，可自行修改。
* XSKCView_DAL.cs
*
* 功 能： N/A
* 类 名： XSKCView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:31   N/A    初版
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
	/// 数据访问类:XSKCView_DAL
	/// </summary>
	public partial class XSKCView_DAL
	{
		public XSKCView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XSKCView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XSKCView(");
			strSql.Append("XSBH,KCBH,NJBH,ZYBH,JSBH,XKBH,KCMC,ZYM,ZYFZR,NJMC,KCJJ)");
			strSql.Append(" values (");
			strSql.Append("@XSBH,@KCBH,@NJBH,@ZYBH,@JSBH,@XKBH,@KCMC,@ZYM,@ZYFZR,@NJMC,@KCJJ)");
			SqlParameter[] parameters = {
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text)};
			parameters[0].Value = model.XSBH;
			parameters[1].Value = model.KCBH;
			parameters[2].Value = model.NJBH;
			parameters[3].Value = model.ZYBH;
			parameters[4].Value = model.JSBH;
			parameters[5].Value = model.XKBH;
			parameters[6].Value = model.KCMC;
			parameters[7].Value = model.ZYM;
			parameters[8].Value = model.ZYFZR;
			parameters[9].Value = model.NJMC;
			parameters[10].Value = model.KCJJ;

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
		public bool Update(ZYNLPJPT.Model.XSKCView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XSKCView set ");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("JSBH=@JSBH,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("NJMC=@NJMC,");
			strSql.Append("KCJJ=@KCJJ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text)};
			parameters[0].Value = model.XSBH;
			parameters[1].Value = model.KCBH;
			parameters[2].Value = model.NJBH;
			parameters[3].Value = model.ZYBH;
			parameters[4].Value = model.JSBH;
			parameters[5].Value = model.XKBH;
			parameters[6].Value = model.KCMC;
			parameters[7].Value = model.ZYM;
			parameters[8].Value = model.ZYFZR;
			parameters[9].Value = model.NJMC;
			parameters[10].Value = model.KCJJ;

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
			strSql.Append("delete from XSKCView ");
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
		public ZYNLPJPT.Model.XSKCView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XSBH,KCBH,NJBH,ZYBH,JSBH,XKBH,KCMC,ZYM,ZYFZR,NJMC,KCJJ from XSKCView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XSKCView model=new ZYNLPJPT.Model.XSKCView();
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
		public ZYNLPJPT.Model.XSKCView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XSKCView model=new ZYNLPJPT.Model.XSKCView();
			if (row != null)
			{
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["JSBH"]!=null)
				{
					model.JSBH=row["JSBH"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
				}
				if(row["ZYM"]!=null)
				{
					model.ZYM=row["ZYM"].ToString();
				}
				if(row["ZYFZR"]!=null)
				{
					model.ZYFZR=row["ZYFZR"].ToString();
				}
				if(row["NJMC"]!=null)
				{
					model.NJMC=row["NJMC"].ToString();
				}
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
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
			strSql.Append("select XSBH,KCBH,NJBH,ZYBH,JSBH,XKBH,KCMC,ZYM,ZYFZR,NJMC,KCJJ ");
			strSql.Append(" FROM XSKCView ");
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
			strSql.Append(" XSBH,KCBH,NJBH,ZYBH,JSBH,XKBH,KCMC,ZYM,ZYFZR,NJMC,KCJJ ");
			strSql.Append(" FROM XSKCView ");
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
			strSql.Append("select count(1) FROM XSKCView ");
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
				strSql.Append("order by T.ZYBH desc");
			}
			strSql.Append(")AS Row, T.*  from XSKCView T ");
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
			parameters[0].Value = "XSKCView";
			parameters[1].Value = "ZYBH";
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

