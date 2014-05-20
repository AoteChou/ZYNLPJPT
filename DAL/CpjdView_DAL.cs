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
	/// 数据访问类:CpjdView_DAL
	/// </summary>
	public partial class CpjdView_DAL
	{
		public CpjdView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.CpjdView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CpjdView(");
			strSql.Append("NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC)");
			strSql.Append(" values (");
			strSql.Append("@NJBH,@NJMC,@JDBH,@ZYBH,@JDMC,@QSXQ,@JZXQ,@CPJDJJ,@XKBH,@ZYM,@ZYFZR,@XYBH,@XKMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.NJBH;
			parameters[1].Value = model.NJMC;
			parameters[2].Value = model.JDBH;
			parameters[3].Value = model.ZYBH;
			parameters[4].Value = model.JDMC;
			parameters[5].Value = model.QSXQ;
			parameters[6].Value = model.JZXQ;
			parameters[7].Value = model.CPJDJJ;
			parameters[8].Value = model.XKBH;
			parameters[9].Value = model.ZYM;
			parameters[10].Value = model.ZYFZR;
			parameters[11].Value = model.XYBH;
			parameters[12].Value = model.XKMC;

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
		public bool Update(ZYNLPJPT.Model.CpjdView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CpjdView set ");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("NJMC=@NJMC,");
			strSql.Append("JDBH=@JDBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("JDMC=@JDMC,");
			strSql.Append("QSXQ=@QSXQ,");
			strSql.Append("JZXQ=@JZXQ,");
			strSql.Append("CPJDJJ=@CPJDJJ,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XKMC=@XKMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.NJBH;
			parameters[1].Value = model.NJMC;
			parameters[2].Value = model.JDBH;
			parameters[3].Value = model.ZYBH;
			parameters[4].Value = model.JDMC;
			parameters[5].Value = model.QSXQ;
			parameters[6].Value = model.JZXQ;
			parameters[7].Value = model.CPJDJJ;
			parameters[8].Value = model.XKBH;
			parameters[9].Value = model.ZYM;
			parameters[10].Value = model.ZYFZR;
			parameters[11].Value = model.XYBH;
			parameters[12].Value = model.XKMC;

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
			strSql.Append("delete from CpjdView ");
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
		public ZYNLPJPT.Model.CpjdView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC from CpjdView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.CpjdView model=new ZYNLPJPT.Model.CpjdView();
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
		public ZYNLPJPT.Model.CpjdView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.CpjdView model=new ZYNLPJPT.Model.CpjdView();
			if (row != null)
			{
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["NJMC"]!=null)
				{
					model.NJMC=row["NJMC"].ToString();
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
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
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
			strSql.Append("select NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC ");
			strSql.Append(" FROM CpjdView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        public CpjdView[] getArray(int xkbh, string queryedZym)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC ");
            strSql.Append(" FROM CpjdView ");
            strSql.Append("where xkbh=" + xkbh + "and zym='" + queryedZym + "'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            CpjdView[] cpjdViews = new CpjdView[length];
            for (int i = 0; i < length; i++)
            {
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
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    cpjdViews[i].CPJDJJ = "暂无";
                }
                else
                {
                    cpjdViews[i].CPJDJJ = row["cpjdjj"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == "")
                {
                    cpjdViews[i].ZYFZR = "暂无";
                }
                else
                {
                    cpjdViews[i].ZYFZR = row["zyfzr"].ToString();
                }

            }
            return cpjdViews;
        }

        public CpjdView[] getRecentlyArray(int xkbh, string queryedZym)
        {
            DateTime now = DateTime.Now;
            DateTime preTime = now.AddYears(-5);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select A.NJBH,A.NJMC,A.JDBH,A.ZYBH,A.JDMC,A.QSXQ,A.JZXQ,A.CPJDJJ,A.XKBH,A.ZYM,A.ZYFZR,A.XYBH,A.XKMC,NJ.RXNF ");
            strSql.Append(" FROM CpjdView as A,NJ ");
            strSql.Append("where xkbh=" + xkbh + "and zym='" + queryedZym + "'");
            strSql.Append(" and  NJ.NJBH=A.NJBH and NJ.RXNF<='"+now.Date+"' and NJ.RXNF>='"+preTime.Date+"'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            CpjdView[] cpjdViews = new CpjdView[length];
            for (int i = 0; i < length; i++)
            {
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
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    cpjdViews[i].CPJDJJ = "暂无";
                }
                else
                {
                    cpjdViews[i].CPJDJJ = row["cpjdjj"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == "")
                {
                    cpjdViews[i].ZYFZR = "暂无";
                }
                else
                {
                    cpjdViews[i].ZYFZR = row["zyfzr"].ToString();
                }

            }
            return cpjdViews;
        }

        public CpjdView[] getSCAndCKArray(int xkbh, string queryedZym)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC ");
            strSql.Append(" FROM CpjdView as A");
            strSql.Append(" where xkbh=" + xkbh + "and zym='" + queryedZym + "'");
            strSql.Append(" and jdbh in(");
            strSql.Append(" select jdbh from jdkc where A.zybh=zybh and A.njbh=njbh and A.jdbh=jdbh");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            CpjdView[] cpjdViews = new CpjdView[length];
            for (int i = 0; i < length; i++)
            {
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
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    cpjdViews[i].CPJDJJ = "暂无";
                }
                else
                {
                    cpjdViews[i].CPJDJJ = row["cpjdjj"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == "")
                {
                    cpjdViews[i].ZYFZR = "暂无";
                }
                else
                {
                    cpjdViews[i].ZYFZR = row["zyfzr"].ToString();
                }

            }
            return cpjdViews;
        }

        public CpjdView[] getRecentlySCAndCKArray(int xkbh, string queryedZym)
        {
            DateTime now = DateTime.Now;
            DateTime preTime = now.AddYears(-5);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select A.NJBH,A.NJMC,A.JDBH,A.ZYBH,A.JDMC,A.QSXQ,A.JZXQ,A.CPJDJJ,A.XKBH,A.ZYM,A.ZYFZR,A.XYBH,A.XKMC,NJ.RXNF ");
            strSql.Append(" FROM CpjdView as A ,NJ");
            strSql.Append(" where xkbh=" + xkbh + "and zym='" + queryedZym + "' and A.NJBH=NJ.NJBH and RXNF<='"+now.Date+"' and RXNF>='"+preTime.Date+"'");
            strSql.Append(" and jdbh in(");
            strSql.Append(" select jdbh from jdkc where A.zybh=zybh and A.njbh=njbh and A.jdbh=jdbh");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            CpjdView[] cpjdViews = new CpjdView[length];
            for (int i = 0; i < length; i++)
            {
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
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    cpjdViews[i].CPJDJJ = "暂无";
                }
                else
                {
                    cpjdViews[i].CPJDJJ = row["cpjdjj"].ToString();
                }
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "null" || row["zyfzr"].ToString() == "")
                {
                    cpjdViews[i].ZYFZR = "暂无";
                }
                else
                {
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
			strSql.Append(" NJBH,NJMC,JDBH,ZYBH,JDMC,QSXQ,JZXQ,CPJDJJ,XKBH,ZYM,ZYFZR,XYBH,XKMC ");
			strSql.Append(" FROM CpjdView ");
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
			strSql.Append("select count(1) FROM CpjdView ");
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
			strSql.Append(")AS Row, T.*  from CpjdView T ");
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
			parameters[0].Value = "CpjdView";
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

