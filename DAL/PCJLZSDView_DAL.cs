﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;//Please add references
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:PCJLZSDView_DAL
	/// </summary>
	public partial class PCJLZSDView_DAL
	{
		public PCJLZSDView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.PCJLZSDView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PCJLZSDView(");
			strSql.Append("STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM,ZSDBH,ZSDYBH,ZSLYBH,ZSDBZ)");
			strSql.Append(" values (");
			strSql.Append("@STBH,@XSBH,@XZRQ,@SCRQ,@PCFS,@PCJLBH,@GTR,@XSSTDA,@HZM,@ZSDBH,@ZSDYBH,@ZSLYBH,@ZSDBZ)");
			SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@PCFS", SqlDbType.Int,4),
					new SqlParameter("@PCJLBH", SqlDbType.Int,4),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@XSSTDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9)};
			parameters[0].Value = model.STBH;
			parameters[1].Value = model.XSBH;
			parameters[2].Value = model.XZRQ;
			parameters[3].Value = model.SCRQ;
			parameters[4].Value = model.PCFS;
			parameters[5].Value = model.PCJLBH;
			parameters[6].Value = model.GTR;
			parameters[7].Value = model.XSSTDA;
			parameters[8].Value = model.HZM;
			parameters[9].Value = model.ZSDBH;
			parameters[10].Value = model.ZSDYBH;
			parameters[11].Value = model.ZSLYBH;
			parameters[12].Value = model.ZSDBZ;

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
		public bool Update(ZYNLPJPT.Model.PCJLZSDView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PCJLZSDView set ");
			strSql.Append("STBH=@STBH,");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("XZRQ=@XZRQ,");
			strSql.Append("SCRQ=@SCRQ,");
			strSql.Append("PCFS=@PCFS,");
			strSql.Append("PCJLBH=@PCJLBH,");
			strSql.Append("GTR=@GTR,");
			strSql.Append("XSSTDA=@XSSTDA,");
			strSql.Append("HZM=@HZM,");
			strSql.Append("ZSDBH=@ZSDBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDBZ=@ZSDBZ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@XZRQ", SqlDbType.DateTime),
					new SqlParameter("@SCRQ", SqlDbType.DateTime),
					new SqlParameter("@PCFS", SqlDbType.Int,4),
					new SqlParameter("@PCJLBH", SqlDbType.Int,4),
					new SqlParameter("@GTR", SqlDbType.VarChar,50),
					new SqlParameter("@XSSTDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9)};
			parameters[0].Value = model.STBH;
			parameters[1].Value = model.XSBH;
			parameters[2].Value = model.XZRQ;
			parameters[3].Value = model.SCRQ;
			parameters[4].Value = model.PCFS;
			parameters[5].Value = model.PCJLBH;
			parameters[6].Value = model.GTR;
			parameters[7].Value = model.XSSTDA;
			parameters[8].Value = model.HZM;
			parameters[9].Value = model.ZSDBH;
			parameters[10].Value = model.ZSDYBH;
			parameters[11].Value = model.ZSLYBH;
			parameters[12].Value = model.ZSDBZ;

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
			strSql.Append("delete from PCJLZSDView ");
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
		public ZYNLPJPT.Model.PCJLZSDView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM,ZSDBH,ZSDYBH,ZSLYBH,ZSDBZ from PCJLZSDView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.PCJLZSDView model=new ZYNLPJPT.Model.PCJLZSDView();
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
		public ZYNLPJPT.Model.PCJLZSDView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.PCJLZSDView model=new ZYNLPJPT.Model.PCJLZSDView();
			if (row != null)
			{
				if(row["STBH"]!=null && row["STBH"].ToString()!="")
				{
					model.STBH=int.Parse(row["STBH"].ToString());
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
				if(row["PCFS"]!=null && row["PCFS"].ToString()!="")
				{
					model.PCFS=int.Parse(row["PCFS"].ToString());
				}
				if(row["PCJLBH"]!=null && row["PCJLBH"].ToString()!="")
				{
					model.PCJLBH=int.Parse(row["PCJLBH"].ToString());
				}
				if(row["GTR"]!=null)
				{
					model.GTR=row["GTR"].ToString();
				}
				if(row["XSSTDA"]!=null && row["XSSTDA"].ToString()!="")
				{
					model.XSSTDA=(byte[])row["XSSTDA"];
				}
				if(row["HZM"]!=null)
				{
					model.HZM=row["HZM"].ToString();
				}
				if(row["ZSDBH"]!=null && row["ZSDBH"].ToString()!="")
				{
					model.ZSDBH=int.Parse(row["ZSDBH"].ToString());
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
				}
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSDBZ"]!=null && row["ZSDBZ"].ToString()!="")
				{
					model.ZSDBZ=decimal.Parse(row["ZSDBZ"].ToString());
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
			strSql.Append("select STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM,ZSDBH,ZSDYBH,ZSLYBH,ZSDBZ ");
			strSql.Append(" FROM PCJLZSDView ");
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
			strSql.Append(" STBH,XSBH,XZRQ,SCRQ,PCFS,PCJLBH,GTR,XSSTDA,HZM,ZSDBH,ZSDYBH,ZSLYBH,ZSDBZ ");
			strSql.Append(" FROM PCJLZSDView ");
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
			strSql.Append("select count(1) FROM PCJLZSDView ");
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
			strSql.Append(")AS Row, T.*  from PCJLZSDView T ");
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
			parameters[0].Value = "PCJLZSDView";
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

