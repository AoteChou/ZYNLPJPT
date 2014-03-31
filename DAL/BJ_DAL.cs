
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.DAL
{


	/// <summary>  
	/// 数据访问类:BJ_DAL
	/// </summary>
	public partial class BJ_DAL
	{
		public BJ_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("BJBH", "BJ"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BJBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BJ");
			strSql.Append(" where BJBH=@BJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = BJBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.BJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BJ(");
			strSql.Append("NJBH,ZYBH,BJMC,RXNF)");
			strSql.Append(" values (");
			strSql.Append("@NJBH,@ZYBH,@BJMC,@RXNF)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime)};
			parameters[0].Value = model.NJBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.BJMC;
			parameters[3].Value = model.RXNF;

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
		public bool Update(ZYNLPJPT.Model.BJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BJ set ");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("BJMC=@BJMC,");
			strSql.Append("RXNF=@RXNF");
			strSql.Append(" where BJBH=@BJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@BJBH", SqlDbType.Int,4)};
			parameters[0].Value = model.NJBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.BJMC;
			parameters[3].Value = model.RXNF;
			parameters[4].Value = model.BJBH;

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
		public bool Delete(int BJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BJ ");
			strSql.Append(" where BJBH=@BJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = BJBH;

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
		public bool DeleteList(string BJBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BJ ");
			strSql.Append(" where BJBH in ("+BJBHlist + ")  ");
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
		public ZYNLPJPT.Model.BJ GetModel(int BJBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BJBH,NJBH,ZYBH,BJMC,RXNF from BJ ");
			strSql.Append(" where BJBH=@BJBH");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4)
			};
			parameters[0].Value = BJBH;

			ZYNLPJPT.Model.BJ model=new ZYNLPJPT.Model.BJ();
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
		public ZYNLPJPT.Model.BJ DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.BJ model=new ZYNLPJPT.Model.BJ();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BJBH,NJBH,ZYBH,BJMC,RXNF ");
			strSql.Append(" FROM BJ ");
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
			strSql.Append(" BJBH,NJBH,ZYBH,BJMC,RXNF ");
			strSql.Append(" FROM BJ ");
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
			strSql.Append("select count(1) FROM BJ ");
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
				strSql.Append("order by T.BJBH desc");
			}
			strSql.Append(")AS Row, T.*  from BJ T ");
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
			parameters[0].Value = "BJ";
			parameters[1].Value = "BJBH";
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

