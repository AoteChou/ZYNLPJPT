
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XSBJZYView_DAL
	/// </summary>
	public partial class XSBJZYView_DAL
	{
		public XSBJZYView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XSBJZYView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XSBJZYView(");
			strSql.Append("BJBH,XSBH,ZYBH,BJMC,XKBH,ZYM)");
			strSql.Append(" values (");
			strSql.Append("@BJBH,@XSBH,@ZYBH,@BJMC,@XKBH,@ZYM)");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.XSBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.XKBH;
			parameters[5].Value = model.ZYM;

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
		public bool Update(ZYNLPJPT.Model.XSBJZYView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XSBJZYView set ");
			strSql.Append("BJBH=@BJBH,");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("BJMC=@BJMC,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.XSBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.XKBH;
			parameters[5].Value = model.ZYM;

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
			strSql.Append("delete from XSBJZYView ");
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
		public ZYNLPJPT.Model.XSBJZYView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BJBH,XSBH,ZYBH,BJMC,XKBH,ZYM from XSBJZYView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XSBJZYView model=new ZYNLPJPT.Model.XSBJZYView();
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
		public ZYNLPJPT.Model.XSBJZYView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XSBJZYView model=new ZYNLPJPT.Model.XSBJZYView();
			if (row != null)
			{
				if(row["BJBH"]!=null && row["BJBH"].ToString()!="")
				{
					model.BJBH=int.Parse(row["BJBH"].ToString());
				}
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["BJMC"]!=null)
				{
					model.BJMC=row["BJMC"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["ZYM"]!=null)
				{
					model.ZYM=row["ZYM"].ToString();
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
			strSql.Append("select BJBH,XSBH,ZYBH,BJMC,XKBH,ZYM ");
			strSql.Append(" FROM XSBJZYView ");
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
			strSql.Append(" BJBH,XSBH,ZYBH,BJMC,XKBH,ZYM ");
			strSql.Append(" FROM XSBJZYView ");
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
			strSql.Append("select count(1) FROM XSBJZYView ");
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
			strSql.Append(")AS Row, T.*  from XSBJZYView T ");
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
			parameters[0].Value = "XSBJZYView";
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

