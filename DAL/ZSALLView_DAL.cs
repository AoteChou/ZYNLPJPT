/**  版本信息模板在安装目录下，可自行修改。
* ZSALLView_DAL.cs
*
* 功 能： N/A
* 类 名： ZSALLView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/1 14:36:09   N/A    初版
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
	/// 数据访问类:ZSALLView_DAL
	/// </summary>
	public partial class ZSALLView_DAL
	{
		public ZSALLView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.ZSALLView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZSALLView(");
			strSql.Append("XKBH,XKMC,ZSLYBH,ZSLYMC,ZSDYBH,ZSDYMC,ZSDBH,ZSDMC,ZSDQZ)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@XKMC,@ZSLYBH,@ZSLYMC,@ZSDYBH,@ZSDYMC,@ZSDBH,@ZSDMC,@ZSDQZ)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDQZ", SqlDbType.Int,4)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.ZSLYBH;
			parameters[3].Value = model.ZSLYMC;
			parameters[4].Value = model.ZSDYBH;
			parameters[5].Value = model.ZSDYMC;
			parameters[6].Value = model.ZSDBH;
			parameters[7].Value = model.ZSDMC;
			parameters[8].Value = model.ZSDQZ;

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
		public bool Update(ZYNLPJPT.Model.ZSALLView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZSALLView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSLYMC=@ZSLYMC,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("ZSDYMC=@ZSDYMC,");
			strSql.Append("ZSDBH=@ZSDBH,");
			strSql.Append("ZSDMC=@ZSDMC,");
			strSql.Append("ZSDQZ=@ZSDQZ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDQZ", SqlDbType.Int,4)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.ZSLYBH;
			parameters[3].Value = model.ZSLYMC;
			parameters[4].Value = model.ZSDYBH;
			parameters[5].Value = model.ZSDYMC;
			parameters[6].Value = model.ZSDBH;
			parameters[7].Value = model.ZSDMC;
			parameters[8].Value = model.ZSDQZ;

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
			strSql.Append("delete from ZSALLView ");
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
		public ZYNLPJPT.Model.ZSALLView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,XKMC,ZSLYBH,ZSLYMC,ZSDYBH,ZSDYMC,ZSDBH,ZSDMC,ZSDQZ from ZSALLView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.ZSALLView model=new ZYNLPJPT.Model.ZSALLView();
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
		public ZYNLPJPT.Model.ZSALLView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZSALLView model=new ZYNLPJPT.Model.ZSALLView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
				}
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSLYMC"]!=null)
				{
					model.ZSLYMC=row["ZSLYMC"].ToString();
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
				}
				if(row["ZSDBH"]!=null && row["ZSDBH"].ToString()!="")
				{
					model.ZSDBH=int.Parse(row["ZSDBH"].ToString());
				}
				if(row["ZSDMC"]!=null)
				{
					model.ZSDMC=row["ZSDMC"].ToString();
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
			strSql.Append("select XKBH,XKMC,ZSLYBH,ZSLYMC,ZSDYBH,ZSDYMC,ZSDBH,ZSDMC,ZSDQZ ");
			strSql.Append(" FROM ZSALLView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public ZSALLView[] getArrayByXkbh(int xkbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKBH,XKMC,ZSLYBH,ZSLYMC,ZSDYBH,ZSDYMC,ZSDBH,ZSDMC,ZSDQZ ");
            strSql.Append(" FROM ZSALLView ");
            strSql.Append(" where xkbh="+xkbh);
            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            ZSALLView[] zsAllViews=new  ZSALLView[length];
            for (int i = 0; i < length; i++) {
                zsAllViews[i] = new ZSALLView();
                DataRow row = ds.Tables[0].Rows[i];
                if (row["XKBH"] != null && row["XKBH"].ToString() != "")
                {
                    zsAllViews[i].XKBH = int.Parse(row["XKBH"].ToString());
                }
                if (row["XKMC"] != null)
                {
                    zsAllViews[i].XKMC = row["XKMC"].ToString();
                }
                if (row["ZSLYBH"] != null && row["ZSLYBH"].ToString() != "")
                {
                    zsAllViews[i].ZSLYBH = int.Parse(row["ZSLYBH"].ToString());
                }
                if (row["ZSLYMC"] != null)
                {
                    zsAllViews[i].ZSLYMC = row["ZSLYMC"].ToString();
                }
                if (row["ZSDYBH"] != null && row["ZSDYBH"].ToString() != "")
                {
                    zsAllViews[i].ZSDYBH = int.Parse(row["ZSDYBH"].ToString());
                }
                if (row["ZSDYMC"] != null)
                {
                    zsAllViews[i].ZSDYMC = row["ZSDYMC"].ToString();
                }
                if (row["ZSDBH"] != null && row["ZSDBH"].ToString() != "")
                {
                    zsAllViews[i].ZSDBH = int.Parse(row["ZSDBH"].ToString());
                }
                if (row["ZSDMC"] != null)
                {
                    zsAllViews[i].ZSDMC = row["ZSDMC"].ToString();
                }
                if (row["ZSDQZ"] != null && row["ZSDQZ"].ToString() != "")
                {
                    zsAllViews[i].ZSDQZ = int.Parse(row["ZSDQZ"].ToString());
                }
            }
            return zsAllViews;
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
			strSql.Append(" XKBH,XKMC,ZSLYBH,ZSLYMC,ZSDYBH,ZSDYMC,ZSDBH,ZSDMC,ZSDQZ ");
			strSql.Append(" FROM ZSALLView ");
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
			strSql.Append("select count(1) FROM ZSALLView ");
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
			strSql.Append(")AS Row, T.*  from ZSALLView T ");
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
			parameters[0].Value = "ZSALLView";
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

