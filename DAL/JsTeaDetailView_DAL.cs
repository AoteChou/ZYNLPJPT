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
	/// 数据访问类:JsTeaDetailView_DAL
	/// </summary>
	public partial class JsTeaDetailView_DAL
	{
		public JsTeaDetailView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JsTeaDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JsTeaDetailView(");
			strSql.Append("JSBH,SFSXKFZR,SFSKCFZR,SSXK,XM,XB,XYBH,XYMC,XKMC)");
			strSql.Append(" values (");
			strSql.Append("@JSBH,@SFSXKFZR,@SFSKCFZR,@SSXK,@XM,@XB,@XYBH,@XYMC,@XKMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.JSBH;
			parameters[1].Value = model.SFSXKFZR;
			parameters[2].Value = model.SFSKCFZR;
			parameters[3].Value = model.SSXK;
			parameters[4].Value = model.XM;
			parameters[5].Value = model.XB;
			parameters[6].Value = model.XYBH;
			parameters[7].Value = model.XYMC;
			parameters[8].Value = model.XKMC;

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
		public bool Update(ZYNLPJPT.Model.JsTeaDetailView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JsTeaDetailView set ");
			strSql.Append("JSBH=@JSBH,");
			strSql.Append("SFSXKFZR=@SFSXKFZR,");
			strSql.Append("SFSKCFZR=@SFSKCFZR,");
			strSql.Append("SSXK=@SSXK,");
			strSql.Append("XM=@XM,");
			strSql.Append("XB=@XB,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XYMC=@XYMC,");
			strSql.Append("XKMC=@XKMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.JSBH;
			parameters[1].Value = model.SFSXKFZR;
			parameters[2].Value = model.SFSKCFZR;
			parameters[3].Value = model.SSXK;
			parameters[4].Value = model.XM;
			parameters[5].Value = model.XB;
			parameters[6].Value = model.XYBH;
			parameters[7].Value = model.XYMC;
			parameters[8].Value = model.XKMC;

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
			strSql.Append("delete from JsTeaDetailView ");
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
		public ZYNLPJPT.Model.JsTeaDetailView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JSBH,SFSXKFZR,SFSKCFZR,SSXK,XM,XB,XYBH,XYMC,XKMC from JsTeaDetailView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.JsTeaDetailView model=new ZYNLPJPT.Model.JsTeaDetailView();
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
		public ZYNLPJPT.Model.JsTeaDetailView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JsTeaDetailView model=new ZYNLPJPT.Model.JsTeaDetailView();
			if (row != null)
			{
				if(row["JSBH"]!=null)
				{
					model.JSBH=row["JSBH"].ToString();
				}
				if(row["SFSXKFZR"]!=null && row["SFSXKFZR"].ToString()!="")
				{
					if((row["SFSXKFZR"].ToString()=="1")||(row["SFSXKFZR"].ToString().ToLower()=="true"))
					{
						model.SFSXKFZR=true;
					}
					else
					{
						model.SFSXKFZR=false;
					}
				}
				if(row["SFSKCFZR"]!=null && row["SFSKCFZR"].ToString()!="")
				{
					if((row["SFSKCFZR"].ToString()=="1")||(row["SFSKCFZR"].ToString().ToLower()=="true"))
					{
						model.SFSKCFZR=true;
					}
					else
					{
						model.SFSKCFZR=false;
					}
				}
				if(row["SSXK"]!=null && row["SSXK"].ToString()!="")
				{
					model.SSXK=int.Parse(row["SSXK"].ToString());
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
				if(row["XYBH"]!=null && row["XYBH"].ToString()!="")
				{
					model.XYBH=int.Parse(row["XYBH"].ToString());
				}
				if(row["XYMC"]!=null)
				{
					model.XYMC=row["XYMC"].ToString();
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
			strSql.Append("select JSBH,SFSXKFZR,SFSKCFZR,SSXK,XM,XB,XYBH,XYMC,XKMC ");
			strSql.Append(" FROM JsTeaDetailView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public JsTeaDetailView[] getArray(int kcbh, int zybh, int njbh, int jdbh,int xkbh)
        {
            XK xk = new XK_DAL().GetModel(xkbh);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JSBH,SFSXKFZR,SFSKCFZR,SSXK,XM,XB,XYBH,XYMC,XKMC ");
            strSql.Append(" FROM JsTeaDetailView ");
            strSql.Append(" where xybh="+xk.XYBH+" and jsbh not in(");
            strSql.Append(" select jsbh from jdkcxs where njbh="+njbh+" and zybh="+zybh+" and jdbh="+jdbh+" and kcbh="+kcbh);
            strSql.Append(")");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            JsTeaDetailView[] jsTeaDetailViews=new  JsTeaDetailView[length];
            for (int i = 0; i < length; i++) {
                DataRow row = ds.Tables[0].Rows[i];
                jsTeaDetailViews[i] = new JsTeaDetailView();
                jsTeaDetailViews[i].JSBH = row["jsbh"].ToString();
                if ((row["sfsxkfzr"].ToString() == "1") || (row["sfsxkfzr"].ToString().ToLower() == "true"))
                {
                    jsTeaDetailViews[i].SFSXKFZR = true;
                }
                else
                {
                    jsTeaDetailViews[i].SFSXKFZR = false;
                }
                if ((row["sfskcfzr"].ToString() == "1") || (row["sfskcfzr"].ToString().ToLower() == "true"))
                {
                    jsTeaDetailViews[i].SFSKCFZR = true;
                }
                else
                {
                    jsTeaDetailViews[i].SFSKCFZR = false;
                }
                jsTeaDetailViews[i].SSXK = int.Parse(row["ssxk"].ToString());
                jsTeaDetailViews[i].XM = row["xm"].ToString();
                if ((row["xb"].ToString() == "1") || (row["xb"].ToString().ToLower() == "true"))
                {
                    jsTeaDetailViews[i].XB = true;
                }
                else
                {
                    jsTeaDetailViews[i].XB = false;
                }
                jsTeaDetailViews[i].XYBH = int.Parse(row["xybh"].ToString());
                jsTeaDetailViews[i].XYMC=row["xymc"].ToString();
                jsTeaDetailViews[i].XKMC = row["xkmc"].ToString();
            }
            return jsTeaDetailViews;
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
			strSql.Append(" JSBH,SFSXKFZR,SFSKCFZR,SSXK,XM,XB,XYBH,XYMC,XKMC ");
			strSql.Append(" FROM JsTeaDetailView ");
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
			strSql.Append("select count(1) FROM JsTeaDetailView ");
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
			strSql.Append(")AS Row, T.*  from JsTeaDetailView T ");
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
			parameters[0].Value = "JsTeaDetailView";
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

