using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:ZY_DAL
	/// </summary>
	public partial class ZY_DAL
	{
		public ZY_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ZYBH", "ZY"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ZYBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ZY");
			strSql.Append(" where ZYBH=@ZYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = ZYBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(string  ZYMC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZY");
            strSql.Append(" where ZYM=@ZYM");
            SqlParameter[] parameters = {
					new SqlParameter("@ZYM", SqlDbType.VarChar,50)
			};
            parameters[0].Value = ZYMC;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.ZY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZY(");
			strSql.Append("XKBH,ZYM,ZYFZR)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@ZYM,@ZYFZR)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.ZYM;
			parameters[2].Value = model.ZYFZR;

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
		public bool Update(ZYNLPJPT.Model.ZY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZY set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR");
			strSql.Append(" where ZYBH=@ZYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@ZYBH", SqlDbType.Int,4)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.ZYM;
			parameters[2].Value = model.ZYFZR;
			parameters[3].Value = model.ZYBH;

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
		public bool Delete(int ZYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZY ");
			strSql.Append(" where ZYBH=@ZYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = ZYBH;

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
		public bool DeleteList(string ZYBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZY ");
			strSql.Append(" where ZYBH in ("+ZYBHlist + ")  ");
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
		public ZYNLPJPT.Model.ZY GetModel(int ZYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZYBH,XKBH,ZYM,ZYFZR from ZY ");
			strSql.Append(" where ZYBH=@ZYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4)
			};
			parameters[0].Value = ZYBH;

			ZYNLPJPT.Model.ZY model=new ZYNLPJPT.Model.ZY();
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

        public ZYNLPJPT.Model.ZY GetModel(string zym)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ZYBH,XKBH,ZYM,ZYFZR from ZY ");
            strSql.Append(" where zym=@zym");
            SqlParameter[] parameters = {
					new SqlParameter("@zym", SqlDbType.VarChar,50)
			};
            parameters[0].Value = zym;

            ZYNLPJPT.Model.ZY model = new ZYNLPJPT.Model.ZY();
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
		public ZYNLPJPT.Model.ZY DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.ZY model=new ZYNLPJPT.Model.ZY();
			if (row != null)
			{
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZYBH,XKBH,ZYM,ZYFZR ");
			strSql.Append(" FROM ZY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        public string[] getArrayByXkbh(int xkbh) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZYBH,XKBH,ZYM,ZYFZR ");
            strSql.Append(" FROM ZY ");
            strSql.Append(" where xkbh="+xkbh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results=new string[length];
            for (int i = 0; i < length; i++) { 
                DataRow row=ds.Tables[0].Rows[i];
                results[i]=row["zym"].ToString().Trim();
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
			strSql.Append(" ZYBH,XKBH,ZYM,ZYFZR ");
			strSql.Append(" FROM ZY ");
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
			strSql.Append("select count(1) FROM ZY ");
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
				strSql.Append("order by T.ZYBH desc");
			}
			strSql.Append(")AS Row, T.*  from ZY T ");
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
			parameters[0].Value = "ZY";
			parameters[1].Value = "ZYBH";
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

