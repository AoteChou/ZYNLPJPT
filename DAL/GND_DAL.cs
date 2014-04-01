
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:GND_DAL
	/// </summary>
	public partial class GND_DAL
	{
		public GND_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GNBH", "GND"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GNBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GND");
			strSql.Append(" where GNBH=@GNBH");
			SqlParameter[] parameters = {
					new SqlParameter("@GNBH", SqlDbType.Int,4)
			};
			parameters[0].Value = GNBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.GND model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GND(");
			strSql.Append("GNM,GNLJ,SSML)");
			strSql.Append(" values (");
			strSql.Append("@GNM,@GNLJ,@SSML)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GNM", SqlDbType.VarChar,50),
					new SqlParameter("@GNLJ", SqlDbType.VarChar,300),
					new SqlParameter("@SSML", SqlDbType.VarChar,50)};
			parameters[0].Value = model.GNM;
			parameters[1].Value = model.GNLJ;
			parameters[2].Value = model.SSML;

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
		public bool Update(ZYNLPJPT.Model.GND model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GND set ");
			strSql.Append("GNM=@GNM,");
			strSql.Append("GNLJ=@GNLJ,");
			strSql.Append("SSML=@SSML");
			strSql.Append(" where GNBH=@GNBH");
			SqlParameter[] parameters = {
					new SqlParameter("@GNM", SqlDbType.VarChar,50),
					new SqlParameter("@GNLJ", SqlDbType.VarChar,300),
					new SqlParameter("@SSML", SqlDbType.VarChar,50),
					new SqlParameter("@GNBH", SqlDbType.Int,4)};
			parameters[0].Value = model.GNM;
			parameters[1].Value = model.GNLJ;
			parameters[2].Value = model.SSML;
			parameters[3].Value = model.GNBH;

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
		public bool Delete(int GNBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GND ");
			strSql.Append(" where GNBH=@GNBH");
			SqlParameter[] parameters = {
					new SqlParameter("@GNBH", SqlDbType.Int,4)
			};
			parameters[0].Value = GNBH;

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
		public bool DeleteList(string GNBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GND ");
			strSql.Append(" where GNBH in ("+GNBHlist + ")  ");
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
		public ZYNLPJPT.Model.GND GetModel(int GNBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GNBH,GNM,GNLJ,SSML from GND ");
			strSql.Append(" where GNBH=@GNBH");
			SqlParameter[] parameters = {
					new SqlParameter("@GNBH", SqlDbType.Int,4)
			};
			parameters[0].Value = GNBH;

			ZYNLPJPT.Model.GND model=new ZYNLPJPT.Model.GND();
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
		public ZYNLPJPT.Model.GND DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.GND model=new ZYNLPJPT.Model.GND();
			if (row != null)
			{
				if(row["GNBH"]!=null && row["GNBH"].ToString()!="")
				{
					model.GNBH=int.Parse(row["GNBH"].ToString());
				}
				if(row["GNM"]!=null)
				{
					model.GNM=row["GNM"].ToString();
				}
				if(row["GNLJ"]!=null)
				{
					model.GNLJ=row["GNLJ"].ToString();
				}
				if(row["SSML"]!=null)
				{
					model.SSML=row["SSML"].ToString();
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
			strSql.Append("select GNBH,GNM,GNLJ,SSML ");
			strSql.Append(" FROM GND ");
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
			strSql.Append(" GNBH,GNM,GNLJ,SSML ");
			strSql.Append(" FROM GND ");
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
			strSql.Append("select count(1) FROM GND ");
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
				strSql.Append("order by T.GNBH desc");
			}
			strSql.Append(")AS Row, T.*  from GND T ");
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
			parameters[0].Value = "GND";
			parameters[1].Value = "GNBH";
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

