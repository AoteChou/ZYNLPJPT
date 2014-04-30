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
	/// 数据访问类:JDKCView_DAL
	/// </summary>
	public partial class JDKCView_DAL
	{
		public JDKCView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JDKCView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JDKCView(");
			strSql.Append("JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC)");
			strSql.Append(" values (");
			strSql.Append("@JDMC,@QSXQ,@JZXQ,@CPJDJJ,@JDBH,@NJBH,@NJMC,@KCJJ,@KCMC,@XKBH,@ZYM,@ZYFZR,@KCBH,@ZYBH,@KCXZBH,@KKXQ,@LLXF,@SJXF,@KCXZMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@JDMC", SqlDbType.Char,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.Char,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.Char,50),
					new SqlParameter("@ZYFZR", SqlDbType.Char,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.Char,50)};
			parameters[0].Value = model.JDMC;
			parameters[1].Value = model.QSXQ;
			parameters[2].Value = model.JZXQ;
			parameters[3].Value = model.CPJDJJ;
			parameters[4].Value = model.JDBH;
			parameters[5].Value = model.NJBH;
			parameters[6].Value = model.NJMC;
			parameters[7].Value = model.KCJJ;
			parameters[8].Value = model.KCMC;
			parameters[9].Value = model.XKBH;
			parameters[10].Value = model.ZYM;
			parameters[11].Value = model.ZYFZR;
			parameters[12].Value = model.KCBH;
			parameters[13].Value = model.ZYBH;
			parameters[14].Value = model.KCXZBH;
			parameters[15].Value = model.KKXQ;
			parameters[16].Value = model.LLXF;
			parameters[17].Value = model.SJXF;
			parameters[18].Value = model.KCXZMC;

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
		public bool Update(ZYNLPJPT.Model.JDKCView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JDKCView set ");
			strSql.Append("JDMC=@JDMC,");
			strSql.Append("QSXQ=@QSXQ,");
			strSql.Append("JZXQ=@JZXQ,");
			strSql.Append("CPJDJJ=@CPJDJJ,");
			strSql.Append("JDBH=@JDBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("NJMC=@NJMC,");
			strSql.Append("KCJJ=@KCJJ,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("KCXZBH=@KCXZBH,");
			strSql.Append("KKXQ=@KKXQ,");
			strSql.Append("LLXF=@LLXF,");
			strSql.Append("SJXF=@SJXF,");
			strSql.Append("KCXZMC=@KCXZMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@JDMC", SqlDbType.Char,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.Char,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.Char,50),
					new SqlParameter("@ZYFZR", SqlDbType.Char,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.Char,50)};
			parameters[0].Value = model.JDMC;
			parameters[1].Value = model.QSXQ;
			parameters[2].Value = model.JZXQ;
			parameters[3].Value = model.CPJDJJ;
			parameters[4].Value = model.JDBH;
			parameters[5].Value = model.NJBH;
			parameters[6].Value = model.NJMC;
			parameters[7].Value = model.KCJJ;
			parameters[8].Value = model.KCMC;
			parameters[9].Value = model.XKBH;
			parameters[10].Value = model.ZYM;
			parameters[11].Value = model.ZYFZR;
			parameters[12].Value = model.KCBH;
			parameters[13].Value = model.ZYBH;
			parameters[14].Value = model.KCXZBH;
			parameters[15].Value = model.KKXQ;
			parameters[16].Value = model.LLXF;
			parameters[17].Value = model.SJXF;
			parameters[18].Value = model.KCXZMC;

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
			strSql.Append("delete from JDKCView ");
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
		public ZYNLPJPT.Model.JDKCView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC from JDKCView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.JDKCView model=new ZYNLPJPT.Model.JDKCView();
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
		public ZYNLPJPT.Model.JDKCView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JDKCView model=new ZYNLPJPT.Model.JDKCView();
			if (row != null)
			{
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
				if(row["JDBH"]!=null && row["JDBH"].ToString()!="")
				{
					model.JDBH=int.Parse(row["JDBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["NJMC"]!=null)
				{
					model.NJMC=row["NJMC"].ToString();
				}
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
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
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["KCXZBH"]!=null && row["KCXZBH"].ToString()!="")
				{
					model.KCXZBH=int.Parse(row["KCXZBH"].ToString());
				}
				if(row["KKXQ"]!=null && row["KKXQ"].ToString()!="")
				{
					model.KKXQ=int.Parse(row["KKXQ"].ToString());
				}
				if(row["LLXF"]!=null && row["LLXF"].ToString()!="")
				{
					model.LLXF=decimal.Parse(row["LLXF"].ToString());
				}
				if(row["SJXF"]!=null && row["SJXF"].ToString()!="")
				{
					model.SJXF=decimal.Parse(row["SJXF"].ToString());
				}
				if(row["KCXZMC"]!=null)
				{
					model.KCXZMC=row["KCXZMC"].ToString();
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
			strSql.Append("select JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC ");
			strSql.Append(" FROM JDKCView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public string[] getJDKCCs(int njbh,int jdbh,int  zybh){
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select kcmc ");
            strSql.Append(" FROM jdkcView ");
            strSql.Append(" where njbh= " + njbh + " and jdbh= " + jdbh+" and zybh="+zybh);

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
                    result[i] = ds.Tables[0].Rows[i]["kcmc"].ToString().Trim();
                }
            }
            return result;
        }

        public JDKCView[] getArrayByNjNameAndXkbh(int xkbh,string njmc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC ");
            strSql.Append(" FROM JDKCView  ");
            strSql.Append(" where xkbh="+xkbh+" and njmc='"+njmc+"'");
            strSql.Append("order by jdmc");
            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            JDKCView[] jdkcViews=new JDKCView[length];
            for (int i = 0; i < jdkcViews.Length; i++) {
                jdkcViews[i] = new JDKCView();
                DataRow row = ds.Tables[0].Rows[i];
                jdkcViews[i].JDMC = row["jdmc"].ToString();
                jdkcViews[i].QSXQ = int.Parse(row["qsxq"].ToString());
                jdkcViews[i].JZXQ = int.Parse(row["jzxq"].ToString());
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    jdkcViews[i].CPJDJJ = "暂无";
                }
                else { 
                    jdkcViews[i].CPJDJJ=row["cpjdjj"].ToString();
                }
                jdkcViews[i].JDBH = int.Parse(row["jdbh"].ToString());
                jdkcViews[i].NJBH = int.Parse(row["njbh"].ToString());
                jdkcViews[i].NJMC=row["njmc"].ToString();
                if (row["kcjj"] == null || row["kcjj"].ToString() == null || row["kcjj"].ToString() == "" || row["kcjj"].ToString() == "null")
                {
                    jdkcViews[i].KCJJ = "暂无";
                }
                else {
                    jdkcViews[i].KCJJ = row["kcjj"].ToString();
                }
                jdkcViews[i].KCMC = row["kcmc"].ToString();
                jdkcViews[i].XKBH = int.Parse(row["xkbh"].ToString());
                jdkcViews[i].ZYM = row["zym"].ToString();
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "" || row["zyfzr"].ToString() == "null")
                {
                    jdkcViews[i].ZYFZR = "暂无";
                }
                else { 
                    jdkcViews[i].ZYFZR=row["zyfzr"].ToString();
                }
                jdkcViews[i].KCBH = int.Parse(row["kcbh"].ToString());
                jdkcViews[i].ZYBH = int.Parse(row["zybh"].ToString());
                jdkcViews[i].KCXZBH = int.Parse(row["kcxzbh"].ToString());
                jdkcViews[i].KKXQ = int.Parse(row["kkxq"].ToString());
                jdkcViews[i].LLXF = decimal.Parse(row["llxf"].ToString());
                jdkcViews[i].SJXF = decimal.Parse(row["sjxf"].ToString());
                jdkcViews[i].KCXZMC = row["kcxzmc"].ToString();
            }
            return jdkcViews;
        }

        public JDKCView[] getCKAndSCArrayByNjNameAndXkbh(int xkbh, string njmc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC ");
            strSql.Append(" FROM JDKCView as A ");
            strSql.Append(" where xkbh=" + xkbh + " and njmc='" + njmc + "'");
            strSql.Append(" and kcbh in (select kcbh from jdkcxs where zybh=A.zybh");
            strSql.Append(" and njbh=A.njbh and jdbh=A.jdbh)");
            strSql.Append("order by jdmc");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            JDKCView[] jdkcViews = new JDKCView[length];
            for (int i = 0; i < jdkcViews.Length; i++)
            {
                jdkcViews[i] = new JDKCView();
                DataRow row = ds.Tables[0].Rows[i];
                jdkcViews[i].JDMC = row["jdmc"].ToString();
                jdkcViews[i].QSXQ = int.Parse(row["qsxq"].ToString());
                jdkcViews[i].JZXQ = int.Parse(row["jzxq"].ToString());
                if (row["cpjdjj"] == null || row["cpjdjj"].ToString() == null || row["cpjdjj"].ToString() == "" || row["cpjdjj"].ToString() == "null")
                {
                    jdkcViews[i].CPJDJJ = "暂无";
                }
                else
                {
                    jdkcViews[i].CPJDJJ = row["cpjdjj"].ToString();
                }
                jdkcViews[i].JDBH = int.Parse(row["jdbh"].ToString());
                jdkcViews[i].NJBH = int.Parse(row["njbh"].ToString());
                jdkcViews[i].NJMC = row["njmc"].ToString();
                if (row["kcjj"] == null || row["kcjj"].ToString() == null || row["kcjj"].ToString() == "" || row["kcjj"].ToString() == "null")
                {
                    jdkcViews[i].KCJJ = "暂无";
                }
                else
                {
                    jdkcViews[i].KCJJ = row["kcjj"].ToString();
                }
                jdkcViews[i].KCMC = row["kcmc"].ToString();
                jdkcViews[i].XKBH = int.Parse(row["xkbh"].ToString());
                jdkcViews[i].ZYM = row["zym"].ToString();
                if (row["zyfzr"] == null || row["zyfzr"].ToString() == null || row["zyfzr"].ToString() == "" || row["zyfzr"].ToString() == "null")
                {
                    jdkcViews[i].ZYFZR = "暂无";
                }
                else
                {
                    jdkcViews[i].ZYFZR = row["zyfzr"].ToString();
                }
                jdkcViews[i].KCBH = int.Parse(row["kcbh"].ToString());
                jdkcViews[i].ZYBH = int.Parse(row["zybh"].ToString());
                jdkcViews[i].KCXZBH = int.Parse(row["kcxzbh"].ToString());
                jdkcViews[i].KKXQ = int.Parse(row["kkxq"].ToString());
                jdkcViews[i].LLXF = decimal.Parse(row["llxf"].ToString());
                jdkcViews[i].SJXF = decimal.Parse(row["sjxf"].ToString());
                jdkcViews[i].KCXZMC = row["kcxzmc"].ToString();
            }
            return jdkcViews;
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
			strSql.Append(" JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC ");
			strSql.Append(" FROM JDKCView ");
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
			strSql.Append("select count(1) FROM JDKCView ");
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
			strSql.Append(")AS Row, T.*  from JDKCView T ");
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
			parameters[0].Value = "JDKCView";
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

