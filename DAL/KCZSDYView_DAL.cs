using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:KCZSDYView_DAL
	/// </summary>
	public partial class KCZSDYView_DAL
	{
		public KCZSDYView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.KCZSDYView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KCZSDYView(");
			strSql.Append("KCBH,ZSLYBH,ZSDYBH,KCJJ,KCMC,KCFZR,KKXK,EJZBBH,ZSDYMC)");
			strSql.Append(" values (");
			strSql.Append("@KCBH,@ZSLYBH,@ZSDYBH,@KCJJ,@KCMC,@KCFZR,@KKXK,@EJZBBH,@ZSDYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;
			parameters[3].Value = model.KCJJ;
			parameters[4].Value = model.KCMC;
			parameters[5].Value = model.KCFZR;
			parameters[6].Value = model.KKXK;
			parameters[7].Value = model.EJZBBH;
			parameters[8].Value = model.ZSDYMC;

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
		public bool Update(ZYNLPJPT.Model.KCZSDYView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KCZSDYView set ");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("KCJJ=@KCJJ,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("KCFZR=@KCFZR,");
			strSql.Append("KKXK=@KKXK,");
			strSql.Append("EJZBBH=@EJZBBH,");
			strSql.Append("ZSDYMC=@ZSDYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZSLYBH;
			parameters[2].Value = model.ZSDYBH;
			parameters[3].Value = model.KCJJ;
			parameters[4].Value = model.KCMC;
			parameters[5].Value = model.KCFZR;
			parameters[6].Value = model.KKXK;
			parameters[7].Value = model.EJZBBH;
			parameters[8].Value = model.ZSDYMC;

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
			strSql.Append("delete from KCZSDYView ");
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
		public ZYNLPJPT.Model.KCZSDYView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCBH,ZSLYBH,ZSDYBH,KCJJ,KCMC,KCFZR,KKXK,EJZBBH,ZSDYMC from KCZSDYView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.KCZSDYView model=new ZYNLPJPT.Model.KCZSDYView();
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
		public ZYNLPJPT.Model.KCZSDYView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.KCZSDYView model=new ZYNLPJPT.Model.KCZSDYView();
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
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
				}
				if(row["KCFZR"]!=null)
				{
					model.KCFZR=row["KCFZR"].ToString();
				}
				if(row["KKXK"]!=null && row["KKXK"].ToString()!="")
				{
					model.KKXK=int.Parse(row["KKXK"].ToString());
				}
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
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
			strSql.Append("select KCBH,ZSLYBH,ZSDYBH,KCJJ,KCMC,KCFZR,KKXK,EJZBBH,ZSDYMC ");
			strSql.Append(" FROM KCZSDYView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getZSDYMCs(int xkbh, int kcbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZSDYMC ");
            strSql.Append(" FROM KCZSDYView ");
            strSql.Append(" where kcbh= "+kcbh+" and kkxk= "+xkbh);

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] result;
            if (length == 0)
            {
                result = new string[1];
                result[0] = "暂无";
            }
            else
            {
                result = new string[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = ds.Tables[0].Rows[i]["zsdymc"].ToString().Trim();
                }
            }
            return result;
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
			strSql.Append(" KCBH,ZSLYBH,ZSDYBH,KCJJ,KCMC,KCFZR,KKXK,EJZBBH,ZSDYMC ");
			strSql.Append(" FROM KCZSDYView ");
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
			strSql.Append("select count(1) FROM KCZSDYView ");
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
			strSql.Append(")AS Row, T.*  from KCZSDYView T ");
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
			parameters[0].Value = "KCZSDYView";
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

