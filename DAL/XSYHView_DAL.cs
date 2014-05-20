/**  版本信息模板在安装目录下，可自行修改。
* XSYHView_DAL.cs
*
* 功 能： N/A
* 类 名： XSYHView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/6 22:18:24   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using System.Collections.Generic;//Please add references
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XSYHView_DAL
	/// </summary>
	public partial class XSYHView_DAL
	{
		public XSYHView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XSYHView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XSYHView(");
			strSql.Append("BJBH,RXNF,YHBH,MM,XM,XB)");
			strSql.Append(" values (");
			strSql.Append("@BJBH,@RXNF,@YHBH,@MM,@XM,@XB)");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.RXNF;
			parameters[2].Value = model.YHBH;
			parameters[3].Value = model.MM;
			parameters[4].Value = model.XM;
			parameters[5].Value = model.XB;

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
		public bool Update(ZYNLPJPT.Model.XSYHView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XSYHView set ");
			strSql.Append("BJBH=@BJBH,");
			strSql.Append("RXNF=@RXNF,");
			strSql.Append("YHBH=@YHBH,");
			strSql.Append("MM=@MM,");
			strSql.Append("XM=@XM,");
			strSql.Append("XB=@XB");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@RXNF", SqlDbType.DateTime),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1)};
			parameters[0].Value = model.BJBH;
			parameters[1].Value = model.RXNF;
			parameters[2].Value = model.YHBH;
			parameters[3].Value = model.MM;
			parameters[4].Value = model.XM;
			parameters[5].Value = model.XB;

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
			strSql.Append("delete from XSYHView ");
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
		public ZYNLPJPT.Model.XSYHView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BJBH,RXNF,YHBH,MM,XM,XB from XSYHView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XSYHView model=new ZYNLPJPT.Model.XSYHView();
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
		public ZYNLPJPT.Model.XSYHView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XSYHView model=new ZYNLPJPT.Model.XSYHView();
			if (row != null)
			{
				if(row["BJBH"]!=null && row["BJBH"].ToString()!="")
				{
					model.BJBH=int.Parse(row["BJBH"].ToString());
				}
				if(row["RXNF"]!=null && row["RXNF"].ToString()!="")
				{
					model.RXNF=DateTime.Parse(row["RXNF"].ToString());
				}
				if(row["YHBH"]!=null)
				{
					model.YHBH=row["YHBH"].ToString();
				}
				if(row["MM"]!=null)
				{
					model.MM=row["MM"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BJBH,RXNF,YHBH,MM,XM,XB ");
			strSql.Append(" FROM XSYHView ");
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
			strSql.Append(" BJBH,RXNF,YHBH,MM,XM,XB ");
			strSql.Append(" FROM XSYHView ");
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
			strSql.Append("select count(1) FROM XSYHView ");
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
			strSql.Append(")AS Row, T.*  from XSYHView T ");
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
			parameters[0].Value = "XSYHView";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        public int UpdateMiMa(string id, string mima)
        {
            string sql = "update XSYHView set MM=@mm where YHBH=@yhbh";
            SqlParameter[] ps ={
                                   new SqlParameter("@mm",SqlDbType.VarChar),
                                   new SqlParameter("@yhbh",SqlDbType.VarChar),
                              };
            ps[0].Value = mima;
            ps[1].Value = id;
            return DbHelperSQL.ExecuteSql(sql, ps);
        }


        public int DeleteUser(string id)
        {
            try
            {
                List<string> SQLStringList = new List<string>();
                List<SqlParameter[]> SqlParameterList = new List<SqlParameter[]>();

                string sql = "delete from XS where XSBH=@xsbh;";
                string sql1 = "delete from YHJSB where YHBH=@xsbh;";
                string sql2 = "delete from YH where YHBH=@xsbh;";
                SqlParameter[] ps ={
                                   new SqlParameter("@xsbh",SqlDbType.VarChar),
                              };
                ps[0].Value = id;
                SQLStringList.Add(sql);
                SqlParameterList.Add(ps);
                SQLStringList.Add(sql1);
                SqlParameterList.Add(ps);
                SQLStringList.Add(sql2);
                SqlParameterList.Add(ps);

                DbHelperSQL.ExecuteSqlTran(SQLStringList, SqlParameterList);





                return 1;
            }
            catch (Exception ex)
            { 
                return 0;
                
            }
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

