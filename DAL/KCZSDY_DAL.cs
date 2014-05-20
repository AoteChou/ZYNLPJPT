using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:KCZSDY_DAL
	/// </summary>
	public partial class KCZSDY_DAL
	{
		public KCZSDY_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("KCBH", "KCZSDY"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int KCBH,int ZSLYBH,int ZSDYBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KCZSDY");
			strSql.Append(" where KCBH=@KCBH and ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZSLYBH;
			parameters[2].Value = ZSDYBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(int ZSLYBH, int ZSDYBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from KCZSDY");
            strSql.Append(" where ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)			};
            parameters[0].Value = ZSLYBH;
            parameters[1].Value = ZSDYBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.KCZSDY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KCZSDY(");
			strSql.Append("KCBH,ZSLYBH,ZSDYBH)");
			strSql.Append(" values (");
			strSql.Append("@KCBH,@ZSLYBH,@ZSDYBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;

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

        public bool addArray(ZYNLPJPT.Model.KCZSDY[] models)
        {
            StringBuilder strSql = new StringBuilder();
            for (int i = 0; i < models.Length; i++) {
                strSql.Append("insert into KCZSDY(");
                strSql.Append("KCBH,ZSLYBH,ZSDYBH)");
                strSql.Append(" values (");
                strSql.Append(models[i].KCBH+","+models[i].ZSLYBH+","+models[i].ZSDYBH);
                strSql.Append(");");
            }
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public bool Update(ZYNLPJPT.Model.KCZSDY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KCZSDY set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH");
			strSql.Append(" where KCBH=@KCBH and ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;

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
		public bool Delete(int KCBH,int ZSLYBH,int ZSDYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KCZSDY ");
			strSql.Append(" where KCBH=@KCBH and ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZSLYBH;
			parameters[2].Value = ZSDYBH;

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

        public bool Delete(int KCBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KCZSDY ");
            strSql.Append(" where KCBH=@KCBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
						};
            parameters[0].Value = KCBH;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public ZYNLPJPT.Model.KCZSDY GetModel(int KCBH,int ZSLYBH,int ZSDYBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCBH,ZSLYBH,ZSDYBH from KCZSDY ");
			strSql.Append(" where KCBH=@KCBH and ZSLYBH=@ZSLYBH and ZSDYBH=@ZSDYBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZSLYBH;
			parameters[2].Value = ZSDYBH;

			ZYNLPJPT.Model.KCZSDY model=new ZYNLPJPT.Model.KCZSDY();
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
		public ZYNLPJPT.Model.KCZSDY DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.KCZSDY model=new ZYNLPJPT.Model.KCZSDY();
			if (row != null)
			{
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
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
			strSql.Append("select KCBH,ZSLYBH,ZSDYBH ");
			strSql.Append(" FROM KCZSDY ");
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
			strSql.Append(" KCBH,ZSLYBH,ZSDYBH ");
			strSql.Append(" FROM KCZSDY ");
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
			strSql.Append("select count(1) FROM KCZSDY ");
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
				strSql.Append("order by T.ZSDYBH desc");
			}
			strSql.Append(")AS Row, T.*  from KCZSDY T ");
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
			parameters[0].Value = "KCZSDY";
			parameters[1].Value = "ZSDYBH";
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

