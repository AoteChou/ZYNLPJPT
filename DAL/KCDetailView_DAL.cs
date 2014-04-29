using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:KCDetailView_DAL
	/// </summary>
	public partial class KCDetailView_DAL
	{
		public KCDetailView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.KCDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KCDetailView(");
			strSql.Append("KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC)");
			strSql.Append(" values (");
			strSql.Append("@KCBH,@KCMC,@KCJJ,@KCFZR,@KKXK,@XKMC,@XYBH,@XYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.KCMC;
			parameters[2].Value = model.KCJJ;
			parameters[3].Value = model.KCFZR;
			parameters[4].Value = model.KKXK;
			parameters[5].Value = model.XKMC;
			parameters[6].Value = model.XYBH;
			parameters[7].Value = model.XYMC;

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
		public bool Update(ZYNLPJPT.Model.KCDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KCDetailView set ");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("KCJJ=@KCJJ,");
			strSql.Append("KCFZR=@KCFZR,");
			strSql.Append("KKXK=@KKXK,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XYMC=@XYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.KCMC;
			parameters[2].Value = model.KCJJ;
			parameters[3].Value = model.KCFZR;
			parameters[4].Value = model.KKXK;
			parameters[5].Value = model.XKMC;
			parameters[6].Value = model.XYBH;
			parameters[7].Value = model.XYMC;

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
			strSql.Append("delete from KCDetailView ");
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
		public ZYNLPJPT.Model.KCDetailView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC from KCDetailView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.KCDetailView model=new ZYNLPJPT.Model.KCDetailView();
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
		public ZYNLPJPT.Model.KCDetailView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.KCDetailView model=new ZYNLPJPT.Model.KCDetailView();
			if (row != null)
			{
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
				}
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
				}
				if(row["KCFZR"]!=null)
				{
					model.KCFZR=row["KCFZR"].ToString();
				}
				if(row["KKXK"]!=null && row["KKXK"].ToString()!="")
				{
					model.KKXK=int.Parse(row["KKXK"].ToString());
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
				}
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XYMC"]!=null)
				{
					model.XYMC=row["XYMC"].ToString();
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
			strSql.Append("select KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC ");
			strSql.Append(" FROM KCDetailView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public KCDetailView[] getArray(int xkbh) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC ");
            strSql.Append(" FROM KCDetailView ");
            strSql.Append("where kkxk="+xkbh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            KCDetailView[] kcDetailViews=new KCDetailView[length];
            for (int i = 0; i < length; i++) {
                kcDetailViews[i] = new KCDetailView();
                DataRow row = ds.Tables[0].Rows[i];
                kcDetailViews[i].KCBH = int.Parse(row["kcbh"].ToString());
                kcDetailViews[i].KCMC = row["kcmc"].ToString();
                string kcjj=row["kcjj"].ToString();
                if(kcjj==null||kcjj=="null"||kcjj==""){
                    kcDetailViews[i].KCJJ="暂无";
                }else{
                    kcDetailViews[i].KCJJ=kcjj;
                }
                if (row["kcfzr"] == null || row["kcfzr"].ToString() == null || row["kcfzr"] == "" || row["kcfzr"] == "null")
                {
                    kcDetailViews[i].KCFZR = "暂无";
                }
                else {
                    kcDetailViews[i].KCFZR = row["kcfzr"].ToString();
                }
                kcDetailViews[i].KKXK = int.Parse(row["KKXK"].ToString());
                kcDetailViews[i].XKMC = row["xkmc"].ToString();
                kcDetailViews[i].XYBH = int.Parse(row["xybh"].ToString());
                kcDetailViews[i].XYMC = row["xymc"].ToString();
            }
            return kcDetailViews;
        }

        public KCDetailView[] getSCAndCKArray(int xkbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC ");
            strSql.Append(" FROM KCDetailView ");
            strSql.Append(" where kkxk=" + xkbh);
            strSql.Append(" and kcbh in(");
            strSql.Append(" select kcbh from kczsdy");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            KCDetailView[] kcDetailViews = new KCDetailView[length];
            for (int i = 0; i < length; i++)
            {
                kcDetailViews[i] = new KCDetailView();
                DataRow row = ds.Tables[0].Rows[i];
                kcDetailViews[i].KCBH = int.Parse(row["kcbh"].ToString());
                kcDetailViews[i].KCMC = row["kcmc"].ToString();
                string kcjj = row["kcjj"].ToString();
                if (kcjj == null || kcjj == "null" || kcjj == "")
                {
                    kcDetailViews[i].KCJJ = "暂无";
                }
                else
                {
                    kcDetailViews[i].KCJJ = kcjj;
                }
                if (row["kcfzr"] == null || row["kcfzr"].ToString() == null || row["kcfzr"] == "" || row["kcfzr"] == "null")
                {
                    kcDetailViews[i].KCFZR = "暂无";
                }
                else
                {
                    kcDetailViews[i].KCFZR = row["kcfzr"].ToString();
                }
                kcDetailViews[i].KKXK = int.Parse(row["KKXK"].ToString());
                kcDetailViews[i].XKMC = row["xkmc"].ToString();
                kcDetailViews[i].XYBH = int.Parse(row["xybh"].ToString());
                kcDetailViews[i].XYMC = row["xymc"].ToString();
            }
            return kcDetailViews;
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
			strSql.Append(" KCBH,KCMC,KCJJ,KCFZR,KKXK,XKMC,XYBH,XYMC ");
			strSql.Append(" FROM KCDetailView ");
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
			strSql.Append("select count(1) FROM KCDetailView ");
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
			strSql.Append(")AS Row, T.*  from KCDetailView T ");
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
			parameters[0].Value = "KCDetailView";
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

