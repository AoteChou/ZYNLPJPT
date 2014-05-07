using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:CPJD_DAL
	/// </summary>
	public partial class CPJD_DAL
	{
		public CPJD_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NJBH", "CPJD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NJBH,int ZYBH,int JDBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CPJD");
			strSql.Append(" where NJBH=@NJBH and ZYBH=@ZYBH and JDBH=@JDBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4)			};
			parameters[0].Value = NJBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = JDBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(string JDMC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CPJD");
            strSql.Append(" where JDMC=@JDMC ");
            SqlParameter[] parameters = {
					new SqlParameter("@JDMC", SqlDbType.VarChar,50)			};
            parameters[0].Value = JDMC;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool ExistsForXG(string JDMC,int JDBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CPJD");
            strSql.Append(" where JDMC=@JDMC and JDBH!=@JDBH");
            SqlParameter[] parameters = {
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
                    new SqlParameter("@JDBH",SqlDbType.Int,4)};
            parameters[0].Value = JDMC;
            parameters[1].Value = JDBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ZYNLPJPT.Model.CPJD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CPJD(");
			strSql.Append("NJBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ)");
			strSql.Append(" values (");
			strSql.Append("@NJBH,@ZYBH,@JDMC,@QSXQ,@JZXQ,@CPJDJJ)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text)};
			parameters[0].Value = model.NJBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.JDMC;
			parameters[3].Value = model.QSXQ;
			parameters[4].Value = model.JZXQ;
			parameters[5].Value = model.CPJDJJ;

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
		public bool Update(ZYNLPJPT.Model.CPJD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CPJD set ");
			strSql.Append("JDMC=@JDMC,");
			strSql.Append("QSXQ=@QSXQ,");
			strSql.Append("JZXQ=@JZXQ,");
			strSql.Append("CPJDJJ=@CPJDJJ");
			strSql.Append(" where JDBH=@JDBH and NJBH=@NJBH and ZYBH=@ZYBH");
			SqlParameter[] parameters = {
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4)};
			parameters[0].Value = model.JDMC;
			parameters[1].Value = model.QSXQ;
			parameters[2].Value = model.JZXQ;
			parameters[3].Value = model.CPJDJJ;
			parameters[4].Value = model.NJBH;
			parameters[5].Value = model.JDBH;
			parameters[6].Value = model.ZYBH;

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
		public bool Delete(int JDBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CPJD ");
			strSql.Append(" where JDBH=@JDBH");
			SqlParameter[] parameters = {
					new SqlParameter("@JDBH", SqlDbType.Int,4)
			};
			parameters[0].Value = JDBH;

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
		public bool Delete(int NJBH,int ZYBH,int JDBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CPJD ");
			strSql.Append(" where NJBH=@NJBH and ZYBH=@ZYBH and JDBH=@JDBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4)			};
			parameters[0].Value = NJBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = JDBH;

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
		public bool DeleteList(string JDBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CPJD ");
			strSql.Append(" where JDBH in ("+JDBHlist + ")  ");
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
		public ZYNLPJPT.Model.CPJD GetModel(int JDBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NJBH,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ from CPJD ");
			strSql.Append(" where JDBH=@JDBH");
			SqlParameter[] parameters = {
					new SqlParameter("@JDBH", SqlDbType.Int,4)
			};
			parameters[0].Value = JDBH;

			ZYNLPJPT.Model.CPJD model=new ZYNLPJPT.Model.CPJD();
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
		public ZYNLPJPT.Model.CPJD DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.CPJD model=new ZYNLPJPT.Model.CPJD();
			if (row != null)
			{
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["JDBH"]!=null && row["JDBH"].ToString()!="")
				{
					model.JDBH=int.Parse(row["JDBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["JDMC"]!=null)
				{
					model.JDMC=row["JDMC"].ToString();
				}
				if(row["QSXQ"]!=null && row["QSXQ"].ToString()!="")
				{
					model.QSXQ=int.Parse(row["QSXQ"].ToString());
				}
				if(row["JZXQ"]!=null && row["JZXQ"].ToString()!="")
				{
					model.JZXQ=int.Parse(row["JZXQ"].ToString());
				}
				if(row["CPJDJJ"]!=null)
				{
					model.CPJDJJ=row["CPJDJJ"].ToString();
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
			strSql.Append("select NJBH,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ ");
			strSql.Append(" FROM CPJD ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public CpjdView[] getArray(int xkbh,string queryedZym)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NJBH,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ ");
            strSql.Append(" FROM CPJD ");
            strSql.Append("where xkbh="+xkbh+"and zym='"+queryedZym+"'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            CpjdView[] cpjdViews=new CpjdView[length];
            for (int i = 0; i < length; i++) {
                cpjdViews[i] = new CpjdView();
                DataRow row = ds.Tables[0].Rows[i];
                cpjdViews[i].NJBH = int.Parse(row["njbh"].ToString());
                cpjdViews[i].NJMC = row["njmc"].ToString().Trim();
                cpjdViews[i].JDBH = int.Parse(row["jdbh"].ToString());
                cpjdViews[i].JDMC = row["jdmc"].ToString().Trim();
                cpjdViews[i].ZYBH = int.Parse(row["zybh"].ToString());
                cpjdViews[i].ZYM = row["zym"].ToString();
                cpjdViews[i].XKBH = int.Parse(row["xkbh"].ToString());
                cpjdViews[i].XKMC = row["xkmc"].ToString();
                cpjdViews[i].XYBH = int.Parse(row["xybh"].ToString());
                cpjdViews[i].QSXQ = int.Parse(row["qsxq"].ToString());
                cpjdViews[i].JZXQ = int.Parse(row["jzxq"].ToString());
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null") {
                    cpjdViews[i].CPJDJJ = "暂无";
                }else{
                    cpjdViews[i].CPJDJJ=row["cpjdjj"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == "")
                {
                    cpjdViews[i].ZYFZR = "暂无";
                }
                else {
                    cpjdViews[i].ZYFZR = row["zyfzr"].ToString();
                }

            }
            return cpjdViews;
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
			strSql.Append(" NJBH,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ ");
			strSql.Append(" FROM CPJD ");
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
			strSql.Append("select count(1) FROM CPJD ");
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
				strSql.Append("order by T.JDBH desc");
			}
			strSql.Append(")AS Row, T.*  from CPJD T ");
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
			parameters[0].Value = "CPJD";
			parameters[1].Value = "JDBH";
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

