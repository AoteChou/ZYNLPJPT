using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:NLZBView_DAL
	/// </summary>
	public partial class NLZBView_DAL
	{
		public NLZBView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.NLZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NLZBView(");
			strSql.Append("XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@YJZBBH,@EJZBBH,@YJZBMC,@EJZBMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.YJZBBH;
			parameters[2].Value = model.EJZBBH;
			parameters[3].Value = model.YJZBMC;
			parameters[4].Value = model.EJZBMC;

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
		public bool Update(ZYNLPJPT.Model.NLZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NLZBView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("YJZBBH=@YJZBBH,");
			strSql.Append("EJZBBH=@EJZBBH,");
			strSql.Append("YJZBMC=@YJZBMC,");
			strSql.Append("EJZBMC=@EJZBMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.YJZBBH;
			parameters[2].Value = model.EJZBBH;
			parameters[3].Value = model.YJZBMC;
			parameters[4].Value = model.EJZBMC;

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
			strSql.Append("delete from NLZBView ");
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
		public ZYNLPJPT.Model.NLZBView GetModel(int _xkbh,string _yjzbName)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC from NLZBView ");
			strSql.Append(" where xkbh=@xkbh and yjzbmc=@yjzbmc");
			SqlParameter[] parameters = {
                                            new SqlParameter("@xkbh",SqlDbType.Int,4),
                                            new SqlParameter("@yjzbmc",SqlDbType.VarChar,50)
			};
            parameters[0].Value = _xkbh;
            parameters[1].Value = _yjzbName;

			ZYNLPJPT.Model.NLZBView model=new ZYNLPJPT.Model.NLZBView();
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
		public ZYNLPJPT.Model.NLZBView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.NLZBView model=new ZYNLPJPT.Model.NLZBView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["YJZBBH"]!=null && row["YJZBBH"].ToString()!="")
				{
					model.YJZBBH=int.Parse(row["YJZBBH"].ToString());
				}
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
				}
				if(row["YJZBMC"]!=null)
				{
					model.YJZBMC=row["YJZBMC"].ToString();
				}
				if(row["EJZBMC"]!=null)
				{
					model.EJZBMC=row["EJZBMC"].ToString();
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
			strSql.Append("select XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC ");
			strSql.Append(" FROM NLZBView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getArrayByXkbhAndYjzb(int xkbh,string yjzbName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC ");
            strSql.Append(" FROM NLZBView ");
            strSql.Append(" where xkbh="+xkbh+" and yjzbmc='"+yjzbName+"'");

            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results = new string[length];
            for (int i = 0; i < length; i++)
            {
                results[i] = ds.Tables[0].Rows[i]["EJZBMC"].ToString();
            }
            return results;
        }

        public NLZBView[] getArrayByXkbh(int xkbh) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC ");
            strSql.Append(" FROM NLZBView ");
            strSql.Append(" where xkbh=" + xkbh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            NLZBView[] nlzbViews = new NLZBView[length];
            for (int i = 0; i < length; i++) {
                nlzbViews[i] = new NLZBView();
                DataRow dr = ds.Tables[0].Rows[i];
                nlzbViews[i].XKBH = int.Parse(dr["xkbh"].ToString());
                nlzbViews[i].YJZBBH = int.Parse(dr["yjzbbh"].ToString());
                nlzbViews[i].EJZBBH = int.Parse(dr["ejzbbh"].ToString());
                nlzbViews[i].YJZBMC = dr["yjzbmc"].ToString();
                nlzbViews[i].EJZBMC = dr["ejzbmc"].ToString();
            }

            return nlzbViews;
        }

        public NLZBView[] getArrayNotInZyejzbByXkbhAndZybh(int xkbh,int zybh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC ");
            strSql.Append(" FROM NLZBView ");
            strSql.Append(" where xkbh=" + xkbh);
            strSql.Append(" and ejzbbh not in( ");
            strSql.Append(" select ejzbbh from zyejzb where zybh="+zybh);
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            NLZBView[] nlzbViews = new NLZBView[length];
            for (int i = 0; i < length; i++)
            {
                nlzbViews[i] = new NLZBView();
                DataRow dr = ds.Tables[0].Rows[i];
                nlzbViews[i].XKBH = int.Parse(dr["xkbh"].ToString());
                nlzbViews[i].YJZBBH = int.Parse(dr["yjzbbh"].ToString());
                nlzbViews[i].EJZBBH = int.Parse(dr["ejzbbh"].ToString());
                nlzbViews[i].YJZBMC = dr["yjzbmc"].ToString();
                nlzbViews[i].EJZBMC = dr["ejzbmc"].ToString();
            }

            return nlzbViews;
        }

        public NLZBViewWrapper[] getArrayInZyejzbByXkbhAndZybhForSC(int xkbh, int zybh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select A.xkbh,A.yjzbbh,A.ejzbbh,A.yjzbmc,A.ejzbmc,B.NLYQ ");
            strSql.Append(" from NLZBView as A ,zyejzb as B  ");
            strSql.Append(" where A.xkbh=" + xkbh);
            strSql.Append(" and  A.ejzbbh  in(");
            strSql.Append(" select ejzbbh from zyejzb where zybh=" + zybh);
            strSql.Append(" and B.zybh=zybh");
            strSql.Append(" and B.ejzbbh=ejzbbh");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            NLZBViewWrapper[] nlzbViewWrappers=new NLZBViewWrapper[length];
            for (int i = 0; i < length; i++)
            {
                nlzbViewWrappers[i] = new NLZBViewWrapper();
                DataRow dr = ds.Tables[0].Rows[i];
                nlzbViewWrappers[i].NlzbView.XKBH = int.Parse(dr["xkbh"].ToString());
                nlzbViewWrappers[i].NlzbView.YJZBBH = int.Parse(dr["yjzbbh"].ToString());
                nlzbViewWrappers[i].NlzbView.EJZBBH = int.Parse(dr["ejzbbh"].ToString());
                nlzbViewWrappers[i].NlzbView.YJZBMC = dr["yjzbmc"].ToString();
                nlzbViewWrappers[i].NlzbView.EJZBMC = dr["ejzbmc"].ToString();
                nlzbViewWrappers[i].Nlyq = int.Parse(dr["nlyq"].ToString());
            }

            return nlzbViewWrappers;
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
			strSql.Append(" XKBH,YJZBBH,EJZBBH,YJZBMC,EJZBMC ");
			strSql.Append(" FROM NLZBView ");
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
			strSql.Append("select count(1) FROM NLZBView ");
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
			strSql.Append(")AS Row, T.*  from NLZBView T ");
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
			parameters[0].Value = "NLZBView";
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

