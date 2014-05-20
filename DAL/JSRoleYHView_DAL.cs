using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:JSRoleYHView_DAL
	/// </summary>
	public partial class JSRoleYHView_DAL
	{
		public JSRoleYHView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JSRoleYHView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JSRoleYHView(");
			strSql.Append("YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC)");
			strSql.Append(" values (");
			strSql.Append("@YHBH,@XM,@XB,@SFSXKFZR,@SFSKCFZR,@SSXK,@XKMC,@XYBH,@XYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.YHBH;
			parameters[1].Value = model.XM;
			parameters[2].Value = model.XB;
			parameters[3].Value = model.SFSXKFZR;
			parameters[4].Value = model.SFSKCFZR;
			parameters[5].Value = model.SSXK;
			parameters[6].Value = model.XKMC;
			parameters[7].Value = model.XYBH;
			parameters[8].Value = model.XYMC;

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
		public bool Update(ZYNLPJPT.Model.JSRoleYHView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JSRoleYHView set ");
			strSql.Append("YHBH=@YHBH,");
			strSql.Append("XM=@XM,");
			strSql.Append("XB=@XB,");
			strSql.Append("SFSXKFZR=@SFSXKFZR,");
			strSql.Append("SFSKCFZR=@SFSKCFZR,");
			strSql.Append("SSXK=@SSXK,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("XYBH=@XYBH,");
			strSql.Append("XYMC=@XYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@XYBH", SqlDbType.Int,4),
					new SqlParameter("@XYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.YHBH;
			parameters[1].Value = model.XM;
			parameters[2].Value = model.XB;
			parameters[3].Value = model.SFSXKFZR;
			parameters[4].Value = model.SFSKCFZR;
			parameters[5].Value = model.SSXK;
			parameters[6].Value = model.XKMC;
			parameters[7].Value = model.XYBH;
			parameters[8].Value = model.XYMC;

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
			strSql.Append("delete from JSRoleYHView ");
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
		public ZYNLPJPT.Model.JSRoleYHView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC from JSRoleYHView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.JSRoleYHView model=new ZYNLPJPT.Model.JSRoleYHView();
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
		public ZYNLPJPT.Model.JSRoleYHView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JSRoleYHView model=new ZYNLPJPT.Model.JSRoleYHView();
			if (row != null)
			{
				if(row["YHBH"]!=null)
				{
					model.YHBH=row["YHBH"].ToString();
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

        public JSRoleYHView[] getArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC ");
            strSql.Append(" FROM JSRoleYHView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DataSet dataset = DbHelperSQL.Query(strSql.ToString());
            int length = dataset.Tables[0].Rows.Count;
            JSRoleYHView[] jsRoleYHViews = new JSRoleYHView[length];

            for (int i = 0; i < length; i++)
            {
                jsRoleYHViews[i] = new JSRoleYHView();
                jsRoleYHViews[i].YHBH = dataset.Tables[0].Rows[i]["YHBH"].ToString();
                jsRoleYHViews[i].XM = dataset.Tables[0].Rows[i]["XM"].ToString();
                
                if((dataset.Tables[0].Rows[i]["XB"].ToString()=="1")||(dataset.Tables[0].Rows[i]["XB"].ToString().ToLower()=="true"))
				{
				    jsRoleYHViews[i].XB=true;
				}
				else
				{
                    jsRoleYHViews[i].XB = false;
				}

                if ((dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSXKFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSXKFZR = false;
                }

                if ((dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSKCFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSKCFZR = false;
                }

                jsRoleYHViews[i].SSXK = int.Parse(dataset.Tables[0].Rows[i]["SSXK"].ToString());
                jsRoleYHViews[i].XKMC = dataset.Tables[0].Rows[i]["XKMC"].ToString();
                jsRoleYHViews[i].XYBH = int.Parse(dataset.Tables[0].Rows[i]["XYBH"].ToString());
                jsRoleYHViews[i].XYMC=dataset.Tables[0].Rows[i]["XYMC"].ToString();

            }
            return jsRoleYHViews;
        }

        public JSRoleYHView[] getArrayNotInCtr(int xkbh,int zybh,int kcbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC ");
            strSql.Append(" FROM JSRoleYHView ");
            strSql.Append(" where ssxk="+xkbh);
            strSql.Append(" and yhbh not in(");
            strSql.Append(" select ctr from ct where zybh="+zybh);
            strSql.Append(" and kcbh="+kcbh);
            strSql.Append(" )");
            DataSet dataset = DbHelperSQL.Query(strSql.ToString());
            int length = dataset.Tables[0].Rows.Count;
            JSRoleYHView[] jsRoleYHViews = new JSRoleYHView[length];

            for (int i = 0; i < length; i++)
            {
                jsRoleYHViews[i] = new JSRoleYHView();
                jsRoleYHViews[i].YHBH = dataset.Tables[0].Rows[i]["YHBH"].ToString();
                jsRoleYHViews[i].XM = dataset.Tables[0].Rows[i]["XM"].ToString();

                if ((dataset.Tables[0].Rows[i]["XB"].ToString() == "1") || (dataset.Tables[0].Rows[i]["XB"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].XB = true;
                }
                else
                {
                    jsRoleYHViews[i].XB = false;
                }

                if ((dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSXKFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSXKFZR = false;
                }

                if ((dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSKCFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSKCFZR = false;
                }

                jsRoleYHViews[i].SSXK = int.Parse(dataset.Tables[0].Rows[i]["SSXK"].ToString());
                jsRoleYHViews[i].XKMC = dataset.Tables[0].Rows[i]["XKMC"].ToString();
                jsRoleYHViews[i].XYBH = int.Parse(dataset.Tables[0].Rows[i]["XYBH"].ToString());
                jsRoleYHViews[i].XYMC = dataset.Tables[0].Rows[i]["XYMC"].ToString();

            }
            return jsRoleYHViews;
        }

        public JSRoleYHView[] getArrayInCtr(int xkbh, int zybh, int kcbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC ");
            strSql.Append(" FROM JSRoleYHView ");
            strSql.Append(" where ssxk=" + xkbh);
            strSql.Append(" and yhbh in(");
            strSql.Append(" select ctr from ct where zybh=" + zybh);
            strSql.Append(" and kcbh=" + kcbh);
            strSql.Append(" )");
            DataSet dataset = DbHelperSQL.Query(strSql.ToString());
            int length = dataset.Tables[0].Rows.Count;
            JSRoleYHView[] jsRoleYHViews = new JSRoleYHView[length];

            for (int i = 0; i < length; i++)
            {
                jsRoleYHViews[i] = new JSRoleYHView();
                jsRoleYHViews[i].YHBH = dataset.Tables[0].Rows[i]["YHBH"].ToString();
                jsRoleYHViews[i].XM = dataset.Tables[0].Rows[i]["XM"].ToString();

                if ((dataset.Tables[0].Rows[i]["XB"].ToString() == "1") || (dataset.Tables[0].Rows[i]["XB"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].XB = true;
                }
                else
                {
                    jsRoleYHViews[i].XB = false;
                }

                if ((dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSXKFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSXKFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSXKFZR = false;
                }

                if ((dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString() == "1") || (dataset.Tables[0].Rows[i]["SFSKCFZR"].ToString().ToLower() == "true"))
                {
                    jsRoleYHViews[i].SFSKCFZR = true;
                }
                else
                {
                    jsRoleYHViews[i].SFSKCFZR = false;
                }

                jsRoleYHViews[i].SSXK = int.Parse(dataset.Tables[0].Rows[i]["SSXK"].ToString());
                jsRoleYHViews[i].XKMC = dataset.Tables[0].Rows[i]["XKMC"].ToString();
                jsRoleYHViews[i].XYBH = int.Parse(dataset.Tables[0].Rows[i]["XYBH"].ToString());
                jsRoleYHViews[i].XYMC = dataset.Tables[0].Rows[i]["XYMC"].ToString();

            }
            return jsRoleYHViews;
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC ");
			strSql.Append(" FROM JSRoleYHView ");
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
			strSql.Append(" YHBH,XM,XB,SFSXKFZR,SFSKCFZR,SSXK,XKMC,XYBH,XYMC ");
			strSql.Append(" FROM JSRoleYHView ");
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
			strSql.Append("select count(1) FROM JSRoleYHView ");
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
			strSql.Append(")AS Row, T.*  from JSRoleYHView T ");
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
			parameters[0].Value = "JSRoleYHView";
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

