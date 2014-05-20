/**  版本信息模板在安装目录下，可自行修改。
* JS_DAL.cs
*
* 功 能： N/A
* 类 名： JS_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:12   N/A    初版
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
	/// 数据访问类:JS_DAL
	/// </summary>
	public partial class JSTea_DAL
	{
		public JSTea_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string JSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JS");
			strSql.Append(" where JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = JSBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JS(");
			strSql.Append("JSBH,SFSXKFZR,SFSKCFZR,SSXK)");
			strSql.Append(" values (");
			strSql.Append("@JSBH,@SFSXKFZR,@SFSKCFZR,@SSXK)");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4)};
			parameters[0].Value = model.JSBH;
			parameters[1].Value = model.SFSXKFZR;
			parameters[2].Value = model.SFSKCFZR;
			parameters[3].Value = model.SSXK;

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
		public bool Update(ZYNLPJPT.Model.JS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JS set ");
			strSql.Append("SFSXKFZR=@SFSXKFZR,");
			strSql.Append("SFSKCFZR=@SFSKCFZR,");
			strSql.Append("SSXK=@SSXK");
			strSql.Append(" where JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.SFSXKFZR;
			parameters[1].Value = model.SFSKCFZR;
			parameters[2].Value = model.SSXK;
			parameters[3].Value = model.JSBH;

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
		public bool Delete(string JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JS ");
			strSql.Append(" where JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = JSBH;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string JSBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JS ");
			strSql.Append(" where JSBH in ("+JSBHlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ZYNLPJPT.Model.JS GetModel(string JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JSBH,SFSXKFZR,SFSKCFZR,SSXK from JS ");
			strSql.Append(" where JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = JSBH;

			ZYNLPJPT.Model.JS model=new ZYNLPJPT.Model.JS();
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
		public ZYNLPJPT.Model.JS DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JS model=new ZYNLPJPT.Model.JS();
			if (row != null)
			{
				if(row["JSBH"]!=null)
				{
					model.JSBH=row["JSBH"].ToString();
				}
				if(row["SFSXKFZR"]!=null && row["SFSXKFZR"].ToString()!="")
				{
					if((row["SFSXKFZR"].ToString()=="1")||(row["SFSXKFZR"].ToString().ToLower()=="true"))
					{
						model.SFSXKFZR=true;
					}
					else
					{
						model.SFSXKFZR=false;
					}
				}
				if(row["SFSKCFZR"]!=null && row["SFSKCFZR"].ToString()!="")
				{
					if((row["SFSKCFZR"].ToString()=="1")||(row["SFSKCFZR"].ToString().ToLower()=="true"))
					{
						model.SFSKCFZR=true;
					}
					else
					{
						model.SFSKCFZR=false;
					}
				}
				if(row["SSXK"]!=null && row["SSXK"].ToString()!="")
				{
					model.SSXK=int.Parse(row["SSXK"].ToString());
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
			strSql.Append("select JSBH,SFSXKFZR,SFSKCFZR,SSXK ");
			strSql.Append(" FROM JS ");
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
			strSql.Append(" JSBH,SFSXKFZR,SFSKCFZR,SSXK ");
			strSql.Append(" FROM JS ");
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
			strSql.Append("select count(1) FROM JS ");
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
			strSql.Append(")AS Row, T.*  from JS T ");
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
			parameters[0].Value = "JS";
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
        /// <summary>
        /// 更新(是否是课程负责人)
        /// </summary>
        public bool UpdateSFSKCFZR(bool sfskcfzr,string jsbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update JS set ");
            strSql.Append("SFSKCFZR=@SFSKCFZR");
            strSql.Append(" where JSBH=@JSBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)};
            parameters[0].Value =sfskcfzr;
            parameters[1].Value = jsbh;

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
		#endregion  ExtensionMethod
	}
}

