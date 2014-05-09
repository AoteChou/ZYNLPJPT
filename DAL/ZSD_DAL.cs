/**  版本信息模板在安装目录下，可自行修改。
* ZSD_DAL.cs
*
* 功 能： N/A
* 类 名： ZSD_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:22   N/A    初版
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
	/// 数据访问类:ZSD_DAL
	/// </summary>
	public partial class ZSD_DAL
	{
		public ZSD_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ZSDYBH", "ZSD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ZSDYBH,int ZSDBH,int ZSLYBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ZSD");
			strSql.Append(" where ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and ZSLYBH=@ZSLYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)			};
			parameters[0].Value = ZSDYBH;
			parameters[1].Value = ZSDBH;
			parameters[2].Value = ZSLYBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(int ZSDYBH, string ZSDMC, int ZSLYBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSD");
            strSql.Append(" where ZSDYBH=@ZSDYBH and ZSDMC=@ZSDMC and ZSLYBH=@ZSLYBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)			};
            parameters[0].Value = ZSDYBH;
            parameters[1].Value = ZSDMC;
            parameters[2].Value = ZSLYBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool ExistsForXG(int ZSDYBH, string ZSDMC, int ZSLYBH,int ZSDBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSD");
            strSql.Append(" where ZSDYBH=@ZSDYBH and ZSDMC=@ZSDMC and ZSLYBH=@ZSLYBH and ZSDBH!=@ZSDBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
                    new SqlParameter("@ZSDBH",SqlDbType.Int,4)    };
            parameters[0].Value = ZSDYBH;
            parameters[1].Value = ZSDMC;
            parameters[2].Value = ZSLYBH;
            parameters[3].Value = ZSDBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        public bool Exists(int ZSLYBH,int ZSDYBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSD");
            strSql.Append(" where ZSDYBH=@ZSDYBH and ZSLYBH=@ZSLYBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)			};
            parameters[0].Value = ZSDYBH;
            parameters[1].Value = ZSLYBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(ZYNLPJPT.Model.ZSD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ZSD(");
            strSql.Append("ZSLYBH,ZSDYBH,ZSDMC,BZ,ZSDQZ)");
            strSql.Append(" values (");
            strSql.Append("@ZSLYBH,@ZSDYBH,@ZSDMC,@BZ,@ZSDQZ)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@ZSDQZ", SqlDbType.Int,4)};
            parameters[0].Value = model.ZSLYBH;
            parameters[1].Value = model.ZSDYBH;
            parameters[2].Value = model.ZSDMC;
            parameters[3].Value = model.BZ;
            parameters[4].Value = model.ZSDQZ;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ZYNLPJPT.Model.ZSD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZSD set ");
			strSql.Append("ZSDMC=@ZSDMC,");
			strSql.Append("BZ=@BZ");
			strSql.Append(" where ZSLYBH=@ZSLYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSDMC;
			parameters[1].Value = model.BZ;
			parameters[2].Value = model.ZSLYBH;
			parameters[3].Value = model.ZSDYBH;
			parameters[4].Value = model.ZSDBH;

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

        public bool UpdateNotIncludeBZ(ZYNLPJPT.Model.ZSD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ZSD set ");
            strSql.Append("ZSDMC=@ZSDMC,");
            strSql.Append("ZSDQZ=@ZSDQZ");
            strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDQZ",SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4)};
            parameters[0].Value = model.ZSDMC;
            parameters[1].Value = model.ZSDQZ;
            parameters[2].Value = model.ZSLYBH;
            parameters[3].Value = model.ZSDYBH;
            parameters[4].Value = model.ZSDBH;

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

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ZSLYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZSD ");
			strSql.Append(" where ZSLYBH=@ZSLYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = ZSLYBH;

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
		public bool Delete(int ZSDYBH,int ZSDBH,int ZSLYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZSD ");
			strSql.Append(" where ZSDYBH=@ZSDYBH and ZSDBH=@ZSDBH and ZSLYBH=@ZSLYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)			};
			parameters[0].Value = ZSDYBH;
			parameters[1].Value = ZSDBH;
			parameters[2].Value = ZSLYBH;

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
		public bool DeleteList(string ZSLYBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZSD ");
			strSql.Append(" where ZSLYBH in ("+ZSLYBHlist + ")  ");
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
		public ZYNLPJPT.Model.ZSD GetModel(int ZSDBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,BZ from ZSD ");
			strSql.Append(" where ZSDBH=@ZSDBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSDBH", SqlDbType.Int,4)
			};
			parameters[0].Value = ZSDBH;

			ZYNLPJPT.Model.ZSD model=new ZYNLPJPT.Model.ZSD();
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
		public ZYNLPJPT.Model.ZSD DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZSD model=new ZYNLPJPT.Model.ZSD();
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
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
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
			strSql.Append("select ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,BZ,ZSDQZ ");
			strSql.Append(" FROM ZSD ");
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
			strSql.Append(" ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,BZ ");
			strSql.Append(" FROM ZSD ");
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
			strSql.Append("select count(1) FROM ZSD ");
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
				strSql.Append("order by T.ZSLYBH desc");
			}
			strSql.Append(")AS Row, T.*  from ZSD T ");
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
			parameters[0].Value = "ZSD";
			parameters[1].Value = "ZSLYBH";
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

