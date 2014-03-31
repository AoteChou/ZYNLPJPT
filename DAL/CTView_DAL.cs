﻿
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:CTView_DAL
	/// </summary>
	public partial class CTView_DAL
	{
		public CTView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.CTView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CTView(");
			strSql.Append("KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,CTR)");
			strSql.Append(" values (");
			strSql.Append("@KCJJ,@KCMC,@XKBH,@ZYM,@ZYFZR,@KCBH,@ZYBH,@KCXZBH,@KKXQ,@LLXF,@SJXF,@KCXZMC,@CTR)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.VarChar,50),
					new SqlParameter("@CTR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCJJ;
			parameters[1].Value = model.KCMC;
			parameters[2].Value = model.XKBH;
			parameters[3].Value = model.ZYM;
			parameters[4].Value = model.ZYFZR;
			parameters[5].Value = model.KCBH;
			parameters[6].Value = model.ZYBH;
			parameters[7].Value = model.KCXZBH;
			parameters[8].Value = model.KKXQ;
			parameters[9].Value = model.LLXF;
			parameters[10].Value = model.SJXF;
			parameters[11].Value = model.KCXZMC;
			parameters[12].Value = model.CTR;

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
		public bool Update(ZYNLPJPT.Model.CTView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CTView set ");
			strSql.Append("KCJJ=@KCJJ,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("KCXZBH=@KCXZBH,");
			strSql.Append("KKXQ=@KKXQ,");
			strSql.Append("LLXF=@LLXF,");
			strSql.Append("SJXF=@SJXF,");
			strSql.Append("KCXZMC=@KCXZMC,");
			strSql.Append("CTR=@CTR");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.VarChar,50),
					new SqlParameter("@CTR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCJJ;
			parameters[1].Value = model.KCMC;
			parameters[2].Value = model.XKBH;
			parameters[3].Value = model.ZYM;
			parameters[4].Value = model.ZYFZR;
			parameters[5].Value = model.KCBH;
			parameters[6].Value = model.ZYBH;
			parameters[7].Value = model.KCXZBH;
			parameters[8].Value = model.KKXQ;
			parameters[9].Value = model.LLXF;
			parameters[10].Value = model.SJXF;
			parameters[11].Value = model.KCXZMC;
			parameters[12].Value = model.CTR;

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
			strSql.Append("delete from CTView ");
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
		public ZYNLPJPT.Model.CTView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,CTR from CTView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.CTView model=new ZYNLPJPT.Model.CTView();
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
		public ZYNLPJPT.Model.CTView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.CTView model=new ZYNLPJPT.Model.CTView();
			if (row != null)
			{
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["ZYM"]!=null)
				{
					model.ZYM=row["ZYM"].ToString();
				}
				if(row["ZYFZR"]!=null)
				{
					model.ZYFZR=row["ZYFZR"].ToString();
				}
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["KCXZBH"]!=null && row["KCXZBH"].ToString()!="")
				{
					model.KCXZBH=int.Parse(row["KCXZBH"].ToString());
				}
				if(row["KKXQ"]!=null && row["KKXQ"].ToString()!="")
				{
					model.KKXQ=int.Parse(row["KKXQ"].ToString());
				}
				if(row["LLXF"]!=null && row["LLXF"].ToString()!="")
				{
					model.LLXF=decimal.Parse(row["LLXF"].ToString());
				}
				if(row["SJXF"]!=null && row["SJXF"].ToString()!="")
				{
					model.SJXF=decimal.Parse(row["SJXF"].ToString());
				}
				if(row["KCXZMC"]!=null)
				{
					model.KCXZMC=row["KCXZMC"].ToString();
				}
				if(row["CTR"]!=null)
				{
					model.CTR=row["CTR"].ToString();
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
			strSql.Append("select KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,CTR ");
			strSql.Append(" FROM CTView ");
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
			strSql.Append(" KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,CTR ");
			strSql.Append(" FROM CTView ");
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
			strSql.Append("select count(1) FROM CTView ");
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
			strSql.Append(")AS Row, T.*  from CTView T ");
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
			parameters[0].Value = "CTView";
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

