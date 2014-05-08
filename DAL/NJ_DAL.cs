/**  版本信息模板在安装目录下，可自行修改。
* NJ_DAL.cs
*
* 功 能： N/A
* 类 名： NJ_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:15   N/A    初版
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
using ZYNLPJPT.Model;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:NJ_DAL
	/// </summary>
	public partial class NJ_DAL
	{
		public NJ_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NJBH", "NJ"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NJBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NJ");
			strSql.Append(" where NJBH=@NJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = NJBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}



        public bool Exists(string njmc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from NJ");
            strSql.Append(" where NJMC=@NJMC");
            SqlParameter[] parameters = {
					new SqlParameter("@NJMC", SqlDbType.VarChar,50)
			};
            parameters[0].Value = njmc;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Exists(string njmc,int NJBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from NJ");
            strSql.Append(" where NJMC=@NJMC and NJBH!=@NJBH");
            SqlParameter[] parameters = {
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
                    new SqlParameter("@NJBH",SqlDbType.Int,4)
			};
            parameters[0].Value = njmc;
            parameters[1].Value = NJBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.NJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NJ(");
			strSql.Append("NJMC,RXNF)");
			strSql.Append(" values (");
			strSql.Append("@NJMC,@RXNF)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
                    new SqlParameter("@RXNF",SqlDbType.DateTime)                    };
			parameters[0].Value = model.NJMC;
            parameters[1].Value = model.RXNF;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(ZYNLPJPT.Model.NJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NJ set ");
			strSql.Append("NJMC=@NJMC , RXNF=@RXNF");
			strSql.Append(" where NJBH=@NJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
                    new SqlParameter("@RXNF",SqlDbType.DateTime)
                                        };
			parameters[0].Value = model.NJMC;
			parameters[1].Value = model.NJBH;
            parameters[2].Value = model.RXNF;

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
		public bool Delete(int NJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NJ ");
			strSql.Append(" where NJBH=@NJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = NJBH;

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
		public bool DeleteList(string NJBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NJ ");
			strSql.Append(" where NJBH in ("+NJBHlist + ")  ");
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
		public ZYNLPJPT.Model.NJ GetModel(int NJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NJBH,NJMC from NJ ");
			strSql.Append(" where NJBH=@NJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = NJBH;

			ZYNLPJPT.Model.NJ model=new ZYNLPJPT.Model.NJ();
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


        public ZYNLPJPT.Model.NJ GetModel(string njName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 NJBH,NJMC,RXNF from NJ ");
            strSql.Append(" where njmc=@njmc");
            SqlParameter[] parameters = {
					new SqlParameter("@njmc", SqlDbType.VarChar,50)
			};
            parameters[0].Value =njName;

            ZYNLPJPT.Model.NJ model = new ZYNLPJPT.Model.NJ();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
		public ZYNLPJPT.Model.NJ DataRowToModel(DataRow row)
		{
            ZYNLPJPT.Model.NJ model = new ZYNLPJPT.Model.NJ();
            if (row != null)
            {
                if (row["NJBH"] != null && row["NJBH"].ToString() != "")
                {
                    model.NJBH = int.Parse(row["NJBH"].ToString());
                }
                if (row["NJMC"] != null)
                {
                    model.NJMC = row["NJMC"].ToString();
                }
                if (row["RXNF"] != null && row["RXNF"].ToString() != "")
                {
                    model.RXNF = DateTime.Parse(row["RXNF"].ToString());
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
			strSql.Append("select NJBH,NJMC ");
			strSql.Append(" FROM NJ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getArray()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NJBH,NJMC ");
            strSql.Append(" FROM NJ ");
            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results=new string[length];
            for (int i = 0; i < length; i++) {
                DataRow row = ds.Tables[0].Rows[i];
                results[i]=row["njmc"].ToString();
            }
            return results;
        }

        public string[] getRecentyArray()
        {
            DateTime now = DateTime.Now;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NJBH,NJMC ");
            DateTime preTime=now.AddYears(-5);
            strSql.Append(" FROM NJ where RXNF<='"+now.Date+"' and RXNF>='"+preTime.Date+"'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results = new string[length];
            for (int i = 0; i < length; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                results[i] = row["njmc"].ToString();
            }
            return results;
        }


        public ZYNLPJPT.Model.NJ[] getAllObjArray()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NJBH,NJMC,RXNF ");
            strSql.Append(" FROM NJ ");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            NJ[] njs = new NJ[length];
            for (int i = 0; i < length; i++)
            {
                njs[i] = new NJ();
                DataRow row = ds.Tables[0].Rows[i];
                njs[i].NJBH = int.Parse(row["njbh"].ToString());
                njs[i].NJMC = row["njmc"].ToString();
                njs[i].RXNF = DateTime.Parse(row["RXNF"].ToString());
            }
            return njs;
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
			strSql.Append(" NJBH,NJMC ");
			strSql.Append(" FROM NJ ");
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
			strSql.Append("select count(1) FROM NJ ");
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
				strSql.Append("order by T.NJBH desc");
			}
			strSql.Append(")AS Row, T.*  from NJ T ");
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
			parameters[0].Value = "NJ";
			parameters[1].Value = "NJBH";
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

