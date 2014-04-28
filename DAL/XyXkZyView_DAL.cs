using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XyXkZyView_DAL
	/// </summary>
	public partial class XyXkZyView_DAL
	{
		public XyXkZyView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XyXkZyView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XyXkZyView(");
			strSql.Append("XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR)");
			strSql.Append(" values (");
			strSql.Append("@XYBH,@XYMC,@XKBH,@XKFZR,@XKMC,@ZYBH,@ZYM,@ZYFZR)");
			SqlParameter[] parameters = {
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XYBH;
			parameters[1].Value = model.XYMC;
			parameters[2].Value = model.XKBH;
			parameters[3].Value = model.XKFZR;
			parameters[4].Value = model.XKMC;
			parameters[5].Value = model.ZYBH;
			parameters[6].Value = model.ZYM;
			parameters[7].Value = model.ZYFZR;

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
		public bool Update(ZYNLPJPT.Model.XyXkZyView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XyXkZyView set ");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XYMC=@XYMC,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XKFZR=@XKFZR,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKFZR", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XYBH;
			parameters[1].Value = model.XYMC;
			parameters[2].Value = model.XKBH;
			parameters[3].Value = model.XKFZR;
			parameters[4].Value = model.XKMC;
			parameters[5].Value = model.ZYBH;
			parameters[6].Value = model.ZYM;
			parameters[7].Value = model.ZYFZR;

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
			strSql.Append("delete from XyXkZyView ");
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
		public ZYNLPJPT.Model.XyXkZyView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR from XyXkZyView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XyXkZyView model=new ZYNLPJPT.Model.XyXkZyView();
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
		public ZYNLPJPT.Model.XyXkZyView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XyXkZyView model=new ZYNLPJPT.Model.XyXkZyView();
			if (row != null)
			{
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XYMC"]!=null)
				{
					model.XYMC=row["XYMC"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["XKFZR"]!=null)
				{
					model.XKFZR=row["XKFZR"].ToString();
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
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
			strSql.Append("select XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR ");
			strSql.Append(" FROM XyXkZyView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public XyXkZyView[] getArray(int xkbh) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR ");
            strSql.Append(" FROM XyXkZyView ");
            strSql.Append("where xkbh="+xkbh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            XyXkZyView[] xyXkZyView=new  XyXkZyView[length];
            for (int i = 0; i < length; i++) {
                xyXkZyView[i] = new XyXkZyView();
                xyXkZyView[i].XYMC=ds.Tables[0].Rows[i]["XYMC"].ToString();
                xyXkZyView[i].XYBH = int.Parse(ds.Tables[0].Rows[i]["xybh"].ToString());
                xyXkZyView[i].XKBH = int.Parse(ds.Tables[0].Rows[i]["xkbh"].ToString());
                xyXkZyView[i].XKMC = ds.Tables[0].Rows[i]["xkmc"].ToString();
                string xkfzr = ds.Tables[0].Rows[i]["xkfzr"].ToString();
                if (xkfzr == null || xkfzr == "null" || xkfzr == "")
                {
                    xyXkZyView[i].XKFZR = "暂无";
                }
                else {
                    xyXkZyView[i].XKFZR = xkfzr;
                }
                xyXkZyView[i].ZYBH = int.Parse(ds.Tables[0].Rows[i]["zybh"].ToString());
                xyXkZyView[i].ZYM=ds.Tables[0].Rows[i]["zym"].ToString();
            }
            return xyXkZyView;
        }

        public XyXkZyView[] getCKArray(int xkbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR ");
            strSql.Append(" FROM XyXkZyView ");
            strSql.Append(" where xkbh=" + xkbh);
            strSql.Append(" and zybh  in(");
            strSql.Append(" select zybh from zyejzb ");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            XyXkZyView[] xyXkZyView = new XyXkZyView[length];
            for (int i = 0; i < length; i++)
            {
                xyXkZyView[i] = new XyXkZyView();
                xyXkZyView[i].XYMC = ds.Tables[0].Rows[i]["XYMC"].ToString();
                xyXkZyView[i].XYBH = int.Parse(ds.Tables[0].Rows[i]["xybh"].ToString());
                xyXkZyView[i].XKBH = int.Parse(ds.Tables[0].Rows[i]["xkbh"].ToString());
                xyXkZyView[i].XKMC = ds.Tables[0].Rows[i]["xkmc"].ToString();
                string xkfzr = ds.Tables[0].Rows[i]["xkfzr"].ToString();
                if (xkfzr == null || xkfzr == "null" || xkfzr == "")
                {
                    xyXkZyView[i].XKFZR = "暂无";
                }
                else
                {
                    xyXkZyView[i].XKFZR = xkfzr;
                }
                xyXkZyView[i].ZYBH = int.Parse(ds.Tables[0].Rows[i]["zybh"].ToString());
                xyXkZyView[i].ZYM = ds.Tables[0].Rows[i]["zym"].ToString();
            }
            return xyXkZyView;
        }

        public XyXkZyView[] getPZArray(int xkbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR ");
            strSql.Append(" FROM XyXkZyView ");
            strSql.Append(" where xkbh=" + xkbh);
            strSql.Append(" and zybh not in(");
            strSql.Append(" select zybh from zyejzb ");
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            XyXkZyView[] xyXkZyView = new XyXkZyView[length];
            for (int i = 0; i < length; i++)
            {
                xyXkZyView[i] = new XyXkZyView();
                xyXkZyView[i].XYMC = ds.Tables[0].Rows[i]["XYMC"].ToString();
                xyXkZyView[i].XYBH = int.Parse(ds.Tables[0].Rows[i]["xybh"].ToString());
                xyXkZyView[i].XKBH = int.Parse(ds.Tables[0].Rows[i]["xkbh"].ToString());
                xyXkZyView[i].XKMC = ds.Tables[0].Rows[i]["xkmc"].ToString();
                string xkfzr = ds.Tables[0].Rows[i]["xkfzr"].ToString();
                if (xkfzr == null || xkfzr == "null" || xkfzr == "")
                {
                    xyXkZyView[i].XKFZR = "暂无";
                }
                else
                {
                    xyXkZyView[i].XKFZR = xkfzr;
                }
                xyXkZyView[i].ZYBH = int.Parse(ds.Tables[0].Rows[i]["zybh"].ToString());
                xyXkZyView[i].ZYM = ds.Tables[0].Rows[i]["zym"].ToString();
            }
            return xyXkZyView;
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
			strSql.Append(" XYBH,XYMC,XKBH,XKFZR,XKMC,ZYBH,ZYM,ZYFZR ");
			strSql.Append(" FROM XyXkZyView ");
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
			strSql.Append("select count(1) FROM XyXkZyView ");
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
			strSql.Append(")AS Row, T.*  from XyXkZyView T ");
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
			parameters[0].Value = "XyXkZyView";
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

