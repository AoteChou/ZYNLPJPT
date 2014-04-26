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
	/// 数据访问类:BjXsDetailView_DAL
	/// </summary>
	public partial class BjXsDetailView_DAL
	{
		public BjXsDetailView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.BjXsDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BjXsDetailView(");
			strSql.Append("BJBH,NJBH,ZYBH,BJMC,RXNF,XSBH,Expr1,XM,XB,ZYM,XKBH,XKMC)");
			strSql.Append(" values (");
			strSql.Append("@BJBH,@NJBH,@ZYBH,@BJMC,@RXNF,@XSBH,@Expr1,@XM,@XB,@ZYM,@XKBH,@XKMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@Expr1", SqlDbType.DateTime),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.NJBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.RXNF;
			parameters[5].Value = model.XSBH;
			parameters[6].Value = model.Expr1;
			parameters[7].Value = model.XM;
			parameters[8].Value = model.XB;
			parameters[9].Value = model.ZYM;
			parameters[10].Value = model.XKBH;
			parameters[11].Value = model.XKMC;

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
		public bool Update(ZYNLPJPT.Model.BjXsDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BjXsDetailView set ");
			strSql.Append("BJBH=@BJBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("BJMC=@BJMC,");
			strSql.Append("RXNF=@RXNF,");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("Expr1=@Expr1,");
			strSql.Append("XM=@XM,");
			strSql.Append("XB=@XB,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XKMC=@XKMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@BJMC", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@Expr1", SqlDbType.DateTime),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.NJBH;
			parameters[2].Value = model.ZYBH;
			parameters[3].Value = model.BJMC;
			parameters[4].Value = model.RXNF;
			parameters[5].Value = model.XSBH;
			parameters[6].Value = model.Expr1;
			parameters[7].Value = model.XM;
			parameters[8].Value = model.XB;
			parameters[9].Value = model.ZYM;
			parameters[10].Value = model.XKBH;
			parameters[11].Value = model.XKMC;

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
			strSql.Append("delete from BjXsDetailView ");
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
		public ZYNLPJPT.Model.BjXsDetailView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BJBH,NJBH,ZYBH,BJMC,RXNF,XSBH,Expr1,XM,XB,ZYM,XKBH,XKMC from BjXsDetailView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.BjXsDetailView model=new ZYNLPJPT.Model.BjXsDetailView();
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
		public ZYNLPJPT.Model.BjXsDetailView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.BjXsDetailView model=new ZYNLPJPT.Model.BjXsDetailView();
			if (row != null)
			{
				if(row["BJBH"]!=null && row["BJBH"].ToString()!="")
				{
					model.BJBH=int.Parse(row["BJBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["BJMC"]!=null)
				{
					model.BJMC=row["BJMC"].ToString();
				}
				if(row["RXNF"]!=null && row["RXNF"].ToString()!="")
				{
					model.RXNF=DateTime.Parse(row["RXNF"].ToString());
				}
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["Expr1"]!=null && row["Expr1"].ToString()!="")
				{
					model.Expr1=DateTime.Parse(row["Expr1"].ToString());
				}
				if(row["XM"]!=null)
				{
					model.XM=row["XM"].ToString();
				}
				if(row["XB"]!=null && row["XB"].ToString()!="")
				{
					if((row["XB"].ToString()=="1")||(row["XB"].ToString().ToLower()=="true"))
					{
						model.XB=true;
					}
					else
					{
						model.XB=false;
					}
				}
				if(row["ZYM"]!=null)
				{
					model.ZYM=row["ZYM"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
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
			strSql.Append("select BJBH,NJBH,ZYBH,BJMC,RXNF,XSBH,Expr1,XM,XB,ZYM,XKBH,XKMC ");
			strSql.Append(" FROM BjXsDetailView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public BjXsDetailView[] getArray(int kcbh,int zybh,int njbh,int jdbh) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BJBH,NJBH,ZYBH,BJMC,RXNF,XSBH,Expr1,XM,XB,ZYM,XKBH,XKMC ");
            strSql.Append("from BjXsDetailView");
            strSql.Append(" where njbh="+njbh+" and zybh="+zybh);
            strSql.Append(" and xsbh not in( ");
            strSql.Append("select xsbh from jdkcxs where njbh="+njbh+" and zybh="+zybh+" and jdbh="+jdbh+" and kcbh="+kcbh);
            strSql.Append(" )");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            BjXsDetailView[] bjXsDetailViews=new BjXsDetailView[length];
            for (int i = 0; i < length; i++) {
                DataRow row = ds.Tables[0].Rows[i];
                bjXsDetailViews[i] = new BjXsDetailView();
                bjXsDetailViews[i].BJBH = int.Parse(row["bjbh"].ToString());
                bjXsDetailViews[i].NJBH = int.Parse(row["njbh"].ToString());
                bjXsDetailViews[i].ZYBH = int.Parse(row["zybh"].ToString());
                bjXsDetailViews[i].BJMC=row["bjmc"].ToString();
                bjXsDetailViews[i].RXNF = DateTime.Parse(row["rxnf"].ToString());
                bjXsDetailViews[i].XSBH = row["xsbh"].ToString();
                bjXsDetailViews[i].Expr1 = DateTime.Parse(row["Expr1"].ToString());
                bjXsDetailViews[i].XM=row["xm"].ToString();
                if ((row["XB"].ToString() == "1") || (row["XB"].ToString().ToLower() == "true"))
                {
                    bjXsDetailViews[i].XB = true;
                }
                else
                {
                    bjXsDetailViews[i].XB = false;
                }
                bjXsDetailViews[i].ZYM = row["zym"].ToString();
                bjXsDetailViews[i].XKBH = int.Parse(row["xkbh"].ToString());
                bjXsDetailViews[i].XKMC = row["XKMC"].ToString();
            }
            return bjXsDetailViews;
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
			strSql.Append(" BJBH,NJBH,ZYBH,BJMC,RXNF,XSBH,Expr1,XM,XB,ZYM,XKBH,XKMC ");
			strSql.Append(" FROM BjXsDetailView ");
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
			strSql.Append("select count(1) FROM BjXsDetailView ");
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
			strSql.Append(")AS Row, T.*  from BjXsDetailView T ");
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
			parameters[0].Value = "BjXsDetailView";
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

