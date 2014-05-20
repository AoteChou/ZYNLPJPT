/**  版本信息模板在安装目录下，可自行修改。
* STZSDB_DAL.cs
*
* 功 能： N/A
* 类 名： STZSDB_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:17   N/A    初版
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
	/// 数据访问类:STZSDB_DAL
	/// </summary>
	public partial class STZSDB_DAL
	{
		public STZSDB_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ZSLYBH", "STZSDB"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ZSLYBH,int ZSDYBH,int ZSDBH,int STBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STZSDB");
			strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and STBH=@STBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4)			};
			parameters[0].Value = ZSLYBH;
			parameters[1].Value = ZSDYBH;
			parameters[2].Value = ZSDBH;
			parameters[3].Value = STBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(int ZSLYBH, int ZSDYBH, int ZSDBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from STZSDB");
            strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4)		};
            parameters[0].Value = ZSLYBH;
            parameters[1].Value = ZSDYBH;
            parameters[2].Value = ZSDBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.STZSDB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STZSDB(");
			strSql.Append("ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ)");
			strSql.Append(" values (");
			strSql.Append("@ZSLYBH,@ZSDYBH,@ZSDBH,@STBH,@ZSDBZ)");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ZSLYBH;
			parameters[1].Value = model.ZSDYBH;
			parameters[2].Value = model.ZSDBH;
			parameters[3].Value = model.STBH;
			parameters[4].Value = model.ZSDBZ;

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
		public bool Update(ZYNLPJPT.Model.STZSDB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STZSDB set ");
			strSql.Append("ZSDBZ=@ZSDBZ");
			strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and STBH=@STBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSDBZ;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;
			parameters[3].Value = model.ZSDBH;
			parameters[4].Value = model.STBH;

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
		public bool Delete(int ZSLYBH,int ZSDYBH,int ZSDBH,int STBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STZSDB ");
			strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and STBH=@STBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4)			};
			parameters[0].Value = ZSLYBH;
			parameters[1].Value = ZSDYBH;
			parameters[2].Value = ZSDBH;
			parameters[3].Value = STBH;

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
		public ZYNLPJPT.Model.STZSDB GetModel(int ZSLYBH,int ZSDYBH,int ZSDBH,int STBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ from STZSDB ");
			strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and STBH=@STBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4)			};
			parameters[0].Value = ZSLYBH;
			parameters[1].Value = ZSDYBH;
			parameters[2].Value = ZSDBH;
			parameters[3].Value = STBH;

			ZYNLPJPT.Model.STZSDB model=new ZYNLPJPT.Model.STZSDB();
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
		public ZYNLPJPT.Model.STZSDB DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.STZSDB model=new ZYNLPJPT.Model.STZSDB();
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
				if(row["STBH"]!=null && row["STBH"].ToString()!="")
				{
					model.STBH=int.Parse(row["STBH"].ToString());
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
			strSql.Append("select ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ ");
			strSql.Append(" FROM STZSDB ");
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
			strSql.Append(" ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ ");
			strSql.Append(" FROM STZSDB ");
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
			strSql.Append("select count(1) FROM STZSDB ");
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
				strSql.Append("order by T.STBH desc");
			}
			strSql.Append(")AS Row, T.*  from STZSDB T ");
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
			parameters[0].Value = "STZSDB";
			parameters[1].Value = "STBH";
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

