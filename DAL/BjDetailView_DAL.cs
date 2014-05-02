/**  版本信息模板在安装目录下，可自行修改。
* BjDetailView_DAL.cs
*
* 功 能： N/A
* 类 名： BjDetailView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/2 2:07:24   N/A    初版
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
	/// 数据访问类:BjDetailView_DAL
	/// </summary>
	public partial class BjDetailView_DAL
	{
		public BjDetailView_DAL()
		{}
		#region  BasicMethod

        public bool Exists(string bjmc,string xymc,string xkmc,string zymc,string njmc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from BjDetailView");
            strSql.Append(" where BJMC=@BJMC");
            strSql.Append(" and XYMC=@XYMC");
            strSql.Append(" and XKMC=@XKMC");
            strSql.Append(" and ZYM=@ZYMC");
            strSql.Append(" and NJMC=@NJMC");
            SqlParameter[] parameters = {
                    new SqlParameter("@BJMC",SqlDbType.VarChar,50),
                    new SqlParameter("@XYMC",SqlDbType.VarChar,50),
                    new SqlParameter("@XKMC",SqlDbType.VarChar,50),
                    new SqlParameter("@ZYMC",SqlDbType.VarChar,50),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50)
			};
            parameters[0].Value = bjmc;
            parameters[1].Value = xymc;
            parameters[2].Value = xkmc;
            parameters[3].Value = zymc;
            parameters[4].Value = njmc;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.BjDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BjDetailView(");
			strSql.Append("BJBH,NJBH,ZYBH,BJMC,RXNF,NJMC,Expr1,XKBH,ZYM,ZYFZR,XYBH,XKFZR,XKMC,XYMC)");
			strSql.Append(" values (");
			strSql.Append("@BJBH,@NJBH,@ZYBH,@BJMC,@RXNF,@NJMC,@Expr1,@XKBH,@ZYM,@ZYFZR,@XYBH,@XKFZR,@XKMC,@XYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@Expr1", SqlDbType.DateTime),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.NJBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.RXNF;
			parameters[5].Value = model.NJMC;
			parameters[6].Value = model.Expr1;
			parameters[7].Value = model.XKBH;
			parameters[8].Value = model.ZYM;
			parameters[9].Value = model.ZYFZR;
			parameters[10].Value = model.XYBH;
			parameters[11].Value = model.XKFZR;
			parameters[12].Value = model.XKMC;
			parameters[13].Value = model.XYMC;

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
		public bool Update(ZYNLPJPT.Model.BjDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BjDetailView set ");
			strSql.Append("BJBH=@BJBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("BJMC=@BJMC,");
			strSql.Append("RXNF=@RXNF,");
			strSql.Append("NJMC=@NJMC,");
			strSql.Append("Expr1=@Expr1,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XKFZR=@XKFZR,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("XYMC=@XYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@Expr1", SqlDbType.DateTime),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.NJBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.RXNF;
			parameters[5].Value = model.NJMC;
			parameters[6].Value = model.Expr1;
			parameters[7].Value = model.XKBH;
			parameters[8].Value = model.ZYM;
			parameters[9].Value = model.ZYFZR;
			parameters[10].Value = model.XYBH;
			parameters[11].Value = model.XKFZR;
			parameters[12].Value = model.XKMC;
			parameters[13].Value = model.XYMC;

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
			strSql.Append("delete from BjDetailView ");
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
		public ZYNLPJPT.Model.BjDetailView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BJBH,NJBH,ZYBH,BJMC,RXNF,NJMC,Expr1,XKBH,ZYM,ZYFZR,XYBH,XKFZR,XKMC,XYMC from BjDetailView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.BjDetailView model=new ZYNLPJPT.Model.BjDetailView();
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
		public ZYNLPJPT.Model.BjDetailView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.BjDetailView model=new ZYNLPJPT.Model.BjDetailView();
			if (row != null)
			{
				if(row["BJBH"]!=null && row["BJBH"].ToString()!="")
				{
					model.BJBH=int.Parse(row["BJBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["BJMC"]!=null)
				{
					model.BJMC=row["BJMC"].ToString();
				}
				if(row["RXNF"]!=null && row["RXNF"].ToString()!="")
				{
					model.RXNF=DateTime.Parse(row["RXNF"].ToString());
				}
				if(row["NJMC"]!=null)
				{
					model.NJMC=row["NJMC"].ToString();
				}
				if(row["Expr1"]!=null && row["Expr1"].ToString()!="")
				{
					model.Expr1=DateTime.Parse(row["Expr1"].ToString());
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
			strSql.Append("select BJBH,NJBH,ZYBH,BJMC,RXNF,NJMC,Expr1,XKBH,ZYM,ZYFZR,XYBH,XKFZR,XKMC,XYMC ");
			strSql.Append(" FROM BjDetailView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public BjDetailView[] getObjArrayByNjmc(string njName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BJBH,NJBH,ZYBH,BJMC,RXNF,NJMC,Expr1,XKBH,ZYM,ZYFZR,XYBH,XKFZR,XKMC,XYMC ");
            strSql.Append(" FROM BjDetailView ");
            strSql.Append(" where NJMC='"+njName+"'");
            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            BjDetailView[] bjDetailViews=new BjDetailView[length];
            for (int i = 0; i < length; i++) {
                bjDetailViews[i] = new BjDetailView();
                DataRow row = ds.Tables[0].Rows[i];
                if (row["BJBH"] != null && row["BJBH"].ToString() != "")
                {
                    bjDetailViews[i].BJBH = int.Parse(row["BJBH"].ToString());
                }
                if (row["NJBH"] != null && row["NJBH"].ToString() != "")
                {
                    bjDetailViews[i].NJBH = int.Parse(row["NJBH"].ToString());
                }
                if (row["ZYBH"] != null && row["ZYBH"].ToString() != "")
                {
                    bjDetailViews[i].ZYBH = int.Parse(row["ZYBH"].ToString());
                }
                if (row["BJMC"] != null)
                {
                    bjDetailViews[i].BJMC = row["BJMC"].ToString();
                }
                if (row["RXNF"] != null && row["RXNF"].ToString() != "")
                {
                    bjDetailViews[i].RXNF = DateTime.Parse(row["RXNF"].ToString());
                }
                if (row["NJMC"] != null)
                {
                    bjDetailViews[i].NJMC = row["NJMC"].ToString();
                }
                if (row["Expr1"] != null && row["Expr1"].ToString() != "")
                {
                    bjDetailViews[i].Expr1 = DateTime.Parse(row["Expr1"].ToString());
                }
                if (row["XKBH"] != null && row["XKBH"].ToString() != "")
                {
                    bjDetailViews[i].XKBH = int.Parse(row["XKBH"].ToString());
                }
                if (row["ZYM"] != null)
                {
                    bjDetailViews[i].ZYM = row["ZYM"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == "" || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == null)
                {
                    bjDetailViews[i].ZYFZR = "暂无";
                }
                else 
                {
                    bjDetailViews[i].ZYFZR = row["ZYFZR"].ToString();
                }
                if (row["XYBH"] != null && row["XYBH"].ToString() != "")
                {
                    bjDetailViews[i].XYBH = int.Parse(row["XYBH"].ToString());
                }

                if (row["XKFZR"] == null || row["XKFZR"].ToString() == "" || row["XKFZR"].ToString() == "null" || row["XKFZR"].ToString() == null)
                {
                    bjDetailViews[i].XKFZR = "暂无";
                }
                else
                {
                    bjDetailViews[i].XKFZR = row["XKFZR"].ToString();
                }
                if (row["XKMC"] != null)
                {
                    bjDetailViews[i].XKMC = row["XKMC"].ToString();
                }
                if (row["XYMC"] != null)
                {
                    bjDetailViews[i].XYMC = row["XYMC"].ToString();
                }
            }
            return bjDetailViews;
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
			strSql.Append(" BJBH,NJBH,ZYBH,BJMC,RXNF,NJMC,Expr1,XKBH,ZYM,ZYFZR,XYBH,XKFZR,XKMC,XYMC ");
			strSql.Append(" FROM BjDetailView ");
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
			strSql.Append("select count(1) FROM BjDetailView ");
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
			strSql.Append(")AS Row, T.*  from BjDetailView T ");
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
			parameters[0].Value = "BjDetailView";
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

