/**  版本信息模板在安装目录下，可自行修改。
* XKDetailView_DAL.cs
*
* 功 能： N/A
* 类 名： XKDetailView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/1 20:19:17   N/A    初版
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
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XKDetailView_DAL
	/// </summary>
	public partial class XKDetailView_DAL
	{
		public XKDetailView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XKDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XKDetailView(");
			strSql.Append("XKBH,XYBH,XKFZR,XKMC,XYMC)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@XYBH,@XKFZR,@XKMC,@XYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XYBH;
			parameters[2].Value = model.XKFZR;
			parameters[3].Value = model.XKMC;
			parameters[4].Value = model.XYMC;

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
		public bool Update(ZYNLPJPT.Model.XKDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XKDetailView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XKFZR=@XKFZR,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("XYMC=@XYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XYBH;
			parameters[2].Value = model.XKFZR;
			parameters[3].Value = model.XKMC;
			parameters[4].Value = model.XYMC;

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
			strSql.Append("delete from XKDetailView ");
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
		public ZYNLPJPT.Model.XKDetailView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,XYBH,XKFZR,XKMC,XYMC from XKDetailView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XKDetailView model=new ZYNLPJPT.Model.XKDetailView();
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

        public ZYNLPJPT.Model.XKDetailView GetModel(string xyName,string xkName)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 XKBH,XYBH,XKFZR,XKMC,XYMC from XKDetailView ");
            strSql.Append(" where XYMC=@XYMC and XKMC=@XKMC");
            SqlParameter[] parameters = {
                                            new SqlParameter("@XYMC",SqlDbType.VarChar,50),
                                            new SqlParameter("@XKMC",SqlDbType.VarChar,50),
			};

            parameters[0].Value = xyName;
            parameters[1].Value = xkName;
            ZYNLPJPT.Model.XKDetailView model = new ZYNLPJPT.Model.XKDetailView();
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
		public ZYNLPJPT.Model.XKDetailView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XKDetailView model=new ZYNLPJPT.Model.XKDetailView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XKFZR"]!=null)
				{
					model.XKFZR=row["XKFZR"].ToString();
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
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
			strSql.Append("select XKBH,XYBH,XKFZR,XKMC,XYMC ");
			strSql.Append(" FROM XKDetailView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public ZYNLPJPT.Model.XKDetailView[] getAllArray()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XKBH,XYBH,XKFZR,XKMC,XYMC ");
			strSql.Append(" FROM XKDetailView ");
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            XKDetailView[] xkDetailViews=new XKDetailView[length];
            for (int i = 0; i < length; i++) {
                xkDetailViews[i] = new XKDetailView();
                DataRow row = ds.Tables[0].Rows[i];
                xkDetailViews[i].XYMC=row["xymc"].ToString();
                xkDetailViews[i].XYBH = int.Parse(row["xybh"].ToString());
                xkDetailViews[i].XKMC=row["xkmc"].ToString();
                xkDetailViews[i].XKBH = int.Parse(row["xkbh"].ToString());
                if (row["xkfzr"] == null || row["xkfzr"].ToString() == "" || row["xkfzr"].ToString() == "null" || row["xkfzr"].ToString() == null)
                {
                    xkDetailViews[i].XKFZR = "暂无";
                }
                else {
                    xkDetailViews[i].XKFZR = row["xkfzr"].ToString();
                }
            }
            return xkDetailViews;
		}

        public string[] getStrArray(string xymc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKMC ");
            strSql.Append(" FROM XKDetailView ");
            strSql.Append(" where xymc='"+xymc+"'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] result = new string[length];
            for (int i = 0; i < length; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
              result[i] = row["xkmc"].ToString();
            }
            return result ;
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
			strSql.Append(" XKBH,XYBH,XKFZR,XKMC,XYMC ");
			strSql.Append(" FROM XKDetailView ");
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
			strSql.Append("select count(1) FROM XKDetailView ");
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
			strSql.Append(")AS Row, T.*  from XKDetailView T ");
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
			parameters[0].Value = "XKDetailView";
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

