/**  版本信息模板在安装目录下，可自行修改。
* ZYEJZBView_DAL.cs
*
* 功 能： N/A
* 类 名： ZYEJZBView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:34   N/A    初版
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
	/// 数据访问类:ZYEJZBView_DAL
	/// </summary>
	public partial class ZYEJZBView_DAL
	{
		public ZYEJZBView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.ZYEJZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZYEJZBView(");
			strSql.Append("ZYBH,XKBH,ZYM,ZYFZR,YJZBBH,EJZBMC,EJZBBH,NLYQ)");
			strSql.Append(" values (");
			strSql.Append("@ZYBH,@XKBH,@ZYM,@ZYFZR,@YJZBBH,@EJZBMC,@EJZBBH,@NLYQ)");
			SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@NLYQ", SqlDbType.Int,4)};
			parameters[0].Value = model.ZYBH;
			parameters[1].Value = model.XKBH;
			parameters[2].Value = model.ZYM;
			parameters[3].Value = model.ZYFZR;
			parameters[4].Value = model.YJZBBH;
			parameters[5].Value = model.EJZBMC;
			parameters[6].Value = model.EJZBBH;
			parameters[7].Value = model.NLYQ;

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
		public bool Update(ZYNLPJPT.Model.ZYEJZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZYEJZBView set ");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("YJZBBH=@YJZBBH,");
			strSql.Append("EJZBMC=@EJZBMC,");
			strSql.Append("EJZBBH=@EJZBBH,");
			strSql.Append("NLYQ=@NLYQ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@NLYQ", SqlDbType.Int,4)};
			parameters[0].Value = model.ZYBH;
			parameters[1].Value = model.XKBH;
			parameters[2].Value = model.ZYM;
			parameters[3].Value = model.ZYFZR;
			parameters[4].Value = model.YJZBBH;
			parameters[5].Value = model.EJZBMC;
			parameters[6].Value = model.EJZBBH;
			parameters[7].Value = model.NLYQ;

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
			strSql.Append("delete from ZYEJZBView ");
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
		public ZYNLPJPT.Model.ZYEJZBView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZYBH,XKBH,ZYM,ZYFZR,YJZBBH,EJZBMC,EJZBBH,NLYQ from ZYEJZBView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.ZYEJZBView model=new ZYNLPJPT.Model.ZYEJZBView();
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
		public ZYNLPJPT.Model.ZYEJZBView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZYEJZBView model=new ZYNLPJPT.Model.ZYEJZBView();
			if (row != null)
			{
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
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
				if(row["YJZBBH"]!=null && row["YJZBBH"].ToString()!="")
				{
					model.YJZBBH=int.Parse(row["YJZBBH"].ToString());
				}
				if(row["EJZBMC"]!=null)
				{
					model.EJZBMC=row["EJZBMC"].ToString();
				}
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
				}
				if(row["NLYQ"]!=null && row["NLYQ"].ToString()!="")
				{
					model.NLYQ=int.Parse(row["NLYQ"].ToString());
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
			strSql.Append("select ZYBH,XKBH,ZYM,ZYFZR,YJZBBH,EJZBMC,EJZBBH,NLYQ ");
			strSql.Append(" FROM ZYEJZBView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getEJZBCs(int xkbh, int zybh) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EJZBMC ");
            strSql.Append(" FROM ZYEJZBView ");
            strSql.Append(" where zybh= " + zybh + " and xkbh= " + xkbh);

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] result;
            if (length == 0)
            {
                result = new string[1];
                result[0] = "暂无";
            }
            else
            {
                result = new string[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = ds.Tables[0].Rows[i]["EJZBMC"].ToString().Trim();
                }
            }
            return result;
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
			strSql.Append(" ZYBH,XKBH,ZYM,ZYFZR,YJZBBH,EJZBMC,EJZBBH,NLYQ ");
			strSql.Append(" FROM ZYEJZBView ");
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
			strSql.Append("select count(1) FROM ZYEJZBView ");
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
			strSql.Append(")AS Row, T.*  from ZYEJZBView T ");
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
			parameters[0].Value = "ZYEJZBView";
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

