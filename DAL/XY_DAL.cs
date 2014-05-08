/**  版本信息模板在安装目录下，可自行修改。
* XY_DAL.cs
*
* 功 能： N/A
* 类 名： XY_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:19   N/A    初版
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
	/// 数据访问类:XY_DAL
	/// </summary>
	public partial class XY_DAL
	{
		public XY_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("XYBH", "XY"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int XYBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from XY");
			strSql.Append(" where XYBH=@XYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@XYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = XYBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(string xymc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from XY");
            strSql.Append(" where XYMC=@XYMC");
            SqlParameter[] parameters = {
					new SqlParameter("@XYMC",SqlDbType.VarChar,50)
			};
            parameters[0].Value = xymc;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Exists(string xymc,int xybh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from XY");
            strSql.Append(" where XYMC=@XYMC and XYBH!=@XYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@XYMC",SqlDbType.VarChar,50),
                    new SqlParameter("@XYBH",SqlDbType.Int,4)
			};
            parameters[0].Value = xymc;
            parameters[1].Value = xybh;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.XY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XY(");
			strSql.Append("XYMC)");
			strSql.Append(" values (");
			strSql.Append("@XYMC)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XYMC;

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
		public bool Update(ZYNLPJPT.Model.XY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XY set ");
			strSql.Append("XYMC=@XYMC");
			strSql.Append(" where XYBH=@XYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@XYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4)};
			parameters[0].Value = model.XYMC;
			parameters[1].Value = model.XYBH;

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
		public bool Delete(int XYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XY ");
			strSql.Append(" where XYBH=@XYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@XYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = XYBH;

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
		public bool DeleteList(string XYBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XY ");
			strSql.Append(" where XYBH in ("+XYBHlist + ")  ");
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
		public ZYNLPJPT.Model.XY GetModel(int XYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XYBH,XYMC from XY ");
			strSql.Append(" where XYBH=@XYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@XYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = XYBH;

			ZYNLPJPT.Model.XY model=new ZYNLPJPT.Model.XY();
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

        public ZYNLPJPT.Model.XY GetModelByXymc(string xymc)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 XYBH,XYMC from XY ");
            strSql.Append(" where XYMC=@XYMC");
            SqlParameter[] parameters = {
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)
			};
            parameters[0].Value = xymc;

            ZYNLPJPT.Model.XY model = new ZYNLPJPT.Model.XY();
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
		public ZYNLPJPT.Model.XY DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XY model=new ZYNLPJPT.Model.XY();
			if (row != null)
			{
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XYMC"]!=null)
				{
					model.XYMC=row["XYMC"].ToString();
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
			strSql.Append("select XYBH,XYMC ");
			strSql.Append(" FROM XY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        public XY[] getAllArray()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XYBH,XYMC ");
			strSql.Append(" FROM XY ");
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            XY[] xys=new XY[length];
            for (int i = 0; i < length; i++) {
                xys[i] = new XY();
                DataRow row = ds.Tables[0].Rows[i];
                xys[i].XYBH = int.Parse(row["xybh"].ToString());
                xys[i].XYMC=row["xymc"].ToString();
            }
            return xys;
		}

        public string[] getAllArrayByStr()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XYBH,XYMC ");
            strSql.Append(" FROM XY ");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] xyNames=new string[length];
            for (int i = 0; i < length; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                xyNames[i] = row["xymc"].ToString();
            }
            return xyNames;
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
			strSql.Append(" XYBH,XYMC ");
			strSql.Append(" FROM XY ");
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
			strSql.Append("select count(1) FROM XY ");
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
				strSql.Append("order by T.XYBH desc");
			}
			strSql.Append(")AS Row, T.*  from XY T ");
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
			parameters[0].Value = "XY";
			parameters[1].Value = "XYBH";
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

