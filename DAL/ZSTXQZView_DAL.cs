/**  版本信息模板在安装目录下，可自行修改。
* ZSTXQZView_DAL.cs
*
* 功 能： N/A
* 类 名： ZSTXQZView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/27 11:38:00   N/A    初版
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
	/// 数据访问类:ZSTXQZView_DAL
	/// </summary>
	public partial class ZSTXQZView_DAL
	{
		public ZSTXQZView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.ZSTXQZView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZSTXQZView(");
			strSql.Append("ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC,ZSDYQZ,ZSDQZ)");
			strSql.Append(" values (");
			strSql.Append("@ZSLYBH,@ZSDYBH,@ZSDBH,@ZSDMC,@ZSDYMC,@ZSLYMC,@ZSDYQZ,@ZSDQZ)");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYQZ", SqlDbType.Int,4),
					new SqlParameter("@ZSDQZ", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSLYBH;
			parameters[1].Value = model.ZSDYBH;
			parameters[2].Value = model.ZSDBH;
			parameters[3].Value = model.ZSDMC;
			parameters[4].Value = model.ZSDYMC;
			parameters[5].Value = model.ZSLYMC;
			parameters[6].Value = model.ZSDYQZ;
			parameters[7].Value = model.ZSDQZ;

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
		public bool Update(ZYNLPJPT.Model.ZSTXQZView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZSTXQZView set ");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("ZSDBH=@ZSDBH,");
			strSql.Append("ZSDMC=@ZSDMC,");
			strSql.Append("ZSDYMC=@ZSDYMC,");
			strSql.Append("ZSLYMC=@ZSLYMC,");
			strSql.Append("ZSDYQZ=@ZSDYQZ,");
			strSql.Append("ZSDQZ=@ZSDQZ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYQZ", SqlDbType.Int,4),
					new SqlParameter("@ZSDQZ", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSLYBH;
			parameters[1].Value = model.ZSDYBH;
			parameters[2].Value = model.ZSDBH;
			parameters[3].Value = model.ZSDMC;
			parameters[4].Value = model.ZSDYMC;
			parameters[5].Value = model.ZSLYMC;
			parameters[6].Value = model.ZSDYQZ;
			parameters[7].Value = model.ZSDQZ;

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
			strSql.Append("delete from ZSTXQZView ");
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
		public ZYNLPJPT.Model.ZSTXQZView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC,ZSDYQZ,ZSDQZ from ZSTXQZView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.ZSTXQZView model=new ZYNLPJPT.Model.ZSTXQZView();
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
		public ZYNLPJPT.Model.ZSTXQZView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZSTXQZView model=new ZYNLPJPT.Model.ZSTXQZView();
			if (row != null)
			{
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
				}
				if(row["ZSDBH"]!=null && row["ZSDBH"].ToString()!="")
				{
					model.ZSDBH=int.Parse(row["ZSDBH"].ToString());
				}
				if(row["ZSDMC"]!=null)
				{
					model.ZSDMC=row["ZSDMC"].ToString();
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
				}
				if(row["ZSLYMC"]!=null)
				{
					model.ZSLYMC=row["ZSLYMC"].ToString();
				}
				if(row["ZSDYQZ"]!=null && row["ZSDYQZ"].ToString()!="")
				{
					model.ZSDYQZ=int.Parse(row["ZSDYQZ"].ToString());
				}
				if(row["ZSDQZ"]!=null && row["ZSDQZ"].ToString()!="")
				{
					model.ZSDQZ=int.Parse(row["ZSDQZ"].ToString());
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
			strSql.Append("select ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC,ZSDYQZ,ZSDQZ ");
			strSql.Append(" FROM ZSTXQZView ");
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
			strSql.Append(" ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC,ZSDYQZ,ZSDQZ ");
			strSql.Append(" FROM ZSTXQZView ");
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
			strSql.Append("select count(1) FROM ZSTXQZView ");
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
			strSql.Append(")AS Row, T.*  from ZSTXQZView T ");
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
			parameters[0].Value = "ZSTXQZView";
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
        public DataSet getZSDYByZSLYBH(int zslybh)
        {


            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct zslybh,zslymc,zsdybh,zsdymc,zsdyqz from ZSTXQZView WHERE zslybh=" + zslybh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            return ds;

        }
		#endregion  ExtensionMethod
	}
}

