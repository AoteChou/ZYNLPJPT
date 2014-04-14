using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:ZSNLView_DAL
	/// </summary>
	public partial class ZSNLView_DAL
	{
		public ZSNLView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.ZSNLView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZSNLView(");
			strSql.Append("ZSLYBH,ZSDYBH,EJZBBH,ZSDYMC,BZ,ZSLYMC,XKBH)");
			strSql.Append(" values (");
			strSql.Append("@ZSLYBH,@ZSDYBH,@EJZBBH,@ZSDYMC,@BZ,@ZSLYMC,@XKBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSLYBH;
			parameters[1].Value = model.ZSDYBH;
			parameters[2].Value = model.EJZBBH;
			parameters[3].Value = model.ZSDYMC;
			parameters[4].Value = model.BZ;
			parameters[5].Value = model.ZSLYMC;
			parameters[6].Value = model.XKBH;

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
		public bool Update(ZYNLPJPT.Model.ZSNLView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZSNLView set ");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("EJZBBH=@EJZBBH,");
			strSql.Append("ZSDYMC=@ZSDYMC,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("ZSLYMC=@ZSLYMC,");
			strSql.Append("XKBH=@XKBH");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4)};
			parameters[0].Value = model.ZSLYBH;
			parameters[1].Value = model.ZSDYBH;
			parameters[2].Value = model.EJZBBH;
			parameters[3].Value = model.ZSDYMC;
			parameters[4].Value = model.BZ;
			parameters[5].Value = model.ZSLYMC;
			parameters[6].Value = model.XKBH;

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
			strSql.Append("delete from ZSNLView ");
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
		public ZYNLPJPT.Model.ZSNLView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZSLYBH,ZSDYBH,EJZBBH,ZSDYMC,BZ,ZSLYMC,XKBH from ZSNLView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.ZSNLView model=new ZYNLPJPT.Model.ZSNLView();
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
		public ZYNLPJPT.Model.ZSNLView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZSNLView model=new ZYNLPJPT.Model.ZSNLView();
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
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["ZSLYMC"]!=null)
				{
					model.ZSLYMC=row["ZSLYMC"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
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
			strSql.Append("select ZSLYBH,ZSDYBH,EJZBBH,ZSDYMC,BZ,ZSLYMC,XKBH ");
			strSql.Append(" FROM ZSNLView ");
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
			strSql.Append(" ZSLYBH,ZSDYBH,EJZBBH,ZSDYMC,BZ,ZSLYMC,XKBH ");
			strSql.Append(" FROM ZSNLView ");
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
			strSql.Append("select count(1) FROM ZSNLView ");
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
			strSql.Append(")AS Row, T.*  from ZSNLView T ");
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
			parameters[0].Value = "ZSNLView";
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

