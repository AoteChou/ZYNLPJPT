/**  版本信息模板在安装目录下，可自行修改。
* JDKCXS_DAL.cs
*
* 功 能： N/A
* 类 名： JDKCXS_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:12   N/A    初版
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
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:JDKCXS_DAL
	/// </summary>
	public partial class JDKCXS_DAL
	{
		public JDKCXS_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("KCBH", "JDKCXS"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int KCBH,int ZYBH,int NJBH,int JDBH,string XSBH,string JSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JDKCXS");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH and XSBH=@XSBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;
			parameters[3].Value = JDBH;
			parameters[4].Value = XSBH;
			parameters[5].Value = JSBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(int ZYBH, int NJBH, int JDBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from JDKCXS");
            strSql.Append(" where ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
                                        };
            parameters[0].Value = ZYBH;
            parameters[1].Value = NJBH;
            parameters[2].Value = JDBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Exists(int ZYBH, int NJBH, int JDBH,int kcbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from JDKCXS");
            strSql.Append(" where ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH and KCBH=@kcbh");
            SqlParameter[] parameters = {
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
                    new SqlParameter("@kcbh",SqlDbType.Int,4)
                                        };
            parameters[0].Value = ZYBH;
            parameters[1].Value = NJBH;
            parameters[2].Value = JDBH;
            parameters[3].Value = kcbh;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JDKCXS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JDKCXS(");
			strSql.Append("KCBH,ZYBH,NJBH,JDBH,XSBH,JSBH)");
			strSql.Append(" values (");
			strSql.Append("@KCBH,@ZYBH,@NJBH,@JDBH,@XSBH,@JSBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.NJBH;
			parameters[3].Value = model.JDBH;
			parameters[4].Value = model.XSBH;
			parameters[5].Value = model.JSBH;

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

        public bool AddArray(ZYNLPJPT.Model.JDKCXS[] models)
        {
            StringBuilder strSql = new StringBuilder();
            for (int i = 0; i < models.Length; i++) {
                strSql.Append("insert into JDKCXS(");
                strSql.Append("KCBH,ZYBH,NJBH,JDBH,XSBH,JSBH)");
                strSql.Append(" values (");
                strSql.Append(models[i].KCBH+","+models[i].ZYBH+","+models[i].NJBH+","+models[i].JDBH+",'"+models[i].XSBH+"','"+models[i].JSBH+"'");
                strSql.Append(");");
            }
            
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public bool Update(ZYNLPJPT.Model.JDKCXS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JDKCXS set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("JDBH=@JDBH,");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("JSBH=@JSBH");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH and XSBH=@XSBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.KCBH;
			parameters[1].Value = model.ZYBH;
			parameters[2].Value = model.NJBH;
			parameters[3].Value = model.JDBH;
			parameters[4].Value = model.XSBH;
			parameters[5].Value = model.JSBH;

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
		public bool Delete(int KCBH,int ZYBH,int NJBH,int JDBH,string XSBH,string JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JDKCXS ");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH and XSBH=@XSBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;
			parameters[3].Value = JDBH;
			parameters[4].Value = XSBH;
			parameters[5].Value = JSBH;

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

        public bool Delete(int KCBH, int ZYBH, int NJBH, int JDBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from JDKCXS ");
            strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4) };
            parameters[0].Value = KCBH;
            parameters[1].Value = ZYBH;
            parameters[2].Value = NJBH;
            parameters[3].Value = JDBH;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public ZYNLPJPT.Model.JDKCXS GetModel(int KCBH,int ZYBH,int NJBH,int JDBH,string XSBH,string JSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 KCBH,ZYBH,NJBH,JDBH,XSBH,JSBH from JDKCXS ");
			strSql.Append(" where KCBH=@KCBH and ZYBH=@ZYBH and NJBH=@NJBH and JDBH=@JDBH and XSBH=@XSBH and JSBH=@JSBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = KCBH;
			parameters[1].Value = ZYBH;
			parameters[2].Value = NJBH;
			parameters[3].Value = JDBH;
			parameters[4].Value = XSBH;
			parameters[5].Value = JSBH;

			ZYNLPJPT.Model.JDKCXS model=new ZYNLPJPT.Model.JDKCXS();
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
		public ZYNLPJPT.Model.JDKCXS DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JDKCXS model=new ZYNLPJPT.Model.JDKCXS();
			if (row != null)
			{
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["JDBH"]!=null && row["JDBH"].ToString()!="")
				{
					model.JDBH=int.Parse(row["JDBH"].ToString());
				}
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["JSBH"]!=null)
				{
					model.JSBH=row["JSBH"].ToString();
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
			strSql.Append("select KCBH,ZYBH,NJBH,JDBH,XSBH,JSBH ");
			strSql.Append(" FROM JDKCXS ");
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
			strSql.Append(" KCBH,ZYBH,NJBH,JDBH,XSBH,JSBH ");
			strSql.Append(" FROM JDKCXS ");
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
			strSql.Append("select count(1) FROM JDKCXS ");
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
				strSql.Append("order by T.JSBH desc");
			}
			strSql.Append(")AS Row, T.*  from JDKCXS T ");
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
			parameters[0].Value = "JDKCXS";
			parameters[1].Value = "JSBH";
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

