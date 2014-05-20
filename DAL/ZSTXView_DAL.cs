using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;
using System.Collections.Generic;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:ZSTXView_DAL
	/// </summary>
	public partial class ZSTXView_DAL
	{
		public ZSTXView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.ZSTXView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZSTXView(");
			strSql.Append("XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@ZSLYBH,@ZSDYBH,@ZSLYMC,@ZSDYMC,@EJZBBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;
			parameters[3].Value = model.ZSLYMC;
			parameters[4].Value = model.ZSDYMC;
			parameters[5].Value = model.EJZBBH;

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
		public bool Update(ZYNLPJPT.Model.ZSTXView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZSTXView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("ZSLYMC=@ZSLYMC,");
			strSql.Append("ZSDYMC=@ZSDYMC,");
			strSql.Append("EJZBBH=@EJZBBH");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;
			parameters[3].Value = model.ZSLYMC;
			parameters[4].Value = model.ZSDYMC;
			parameters[5].Value = model.EJZBBH;

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
			strSql.Append("delete from ZSTXView ");
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
		public ZYNLPJPT.Model.ZSTXView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH from ZSTXView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.ZSTXView model=new ZYNLPJPT.Model.ZSTXView();
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

        public ZYNLPJPT.Model.ZSTXView GetModel(string zslyName,string zsdyName)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH from ZSTXView ");
            strSql.Append(" where zslymc=@zslymc and zsdymc=@zsdymc ");
            SqlParameter[] parameters = {
                                            new SqlParameter("@zslymc",SqlDbType.VarChar,50),
                                            new SqlParameter("@zsdymc",SqlDbType.VarChar,50)
			};
            parameters[0].Value = zslyName;
            parameters[1].Value = zsdyName;
            ZYNLPJPT.Model.ZSTXView model = new ZYNLPJPT.Model.ZSTXView();
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
		public ZYNLPJPT.Model.ZSTXView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZSTXView model=new ZYNLPJPT.Model.ZSTXView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
				}
				if(row["ZSLYMC"]!=null)
				{
					model.ZSLYMC=row["ZSLYMC"].ToString();
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
				}
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
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
			strSql.Append("select XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH ");
			strSql.Append(" FROM ZSTXView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getArrayByXkbhAndYjzb(int xkbh, string zslyName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH ");
            strSql.Append(" FROM ZSTXView ");
            strSql.Append(" where xkbh=" + xkbh + " and zslymc='" + zslyName + "'");

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results = new string[length];
            for (int i = 0; i < length; i++)
            {
                results[i] = ds.Tables[0].Rows[i]["zsdymc"].ToString();
            }
            return results;
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
			strSql.Append(" XKBH,ZSLYBH,ZSDYBH,ZSLYMC,ZSDYMC,EJZBBH ");
			strSql.Append(" FROM ZSTXView ");
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
			strSql.Append("select count(1) FROM ZSTXView ");
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
			strSql.Append(")AS Row, T.*  from ZSTXView T ");
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
			parameters[0].Value = "ZSTXView";
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

