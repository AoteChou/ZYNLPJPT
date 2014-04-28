
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;
using System.Collections.Generic;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XKZSTXView_DAL
	/// </summary>
	public partial class XKZSTXView_DAL
	{
		public XKZSTXView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XKZSTXView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XKZSTXView(");
			strSql.Append("XKBH,XKMC,ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@XKMC,@ZSLYBH,@ZSDYBH,@ZSDBH,@ZSDMC,@ZSDYMC,@ZSLYMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.ZSLYBH;
			parameters[3].Value = model.ZSDYBH;
			parameters[4].Value = model.ZSDBH;
			parameters[5].Value = model.ZSDMC;
			parameters[6].Value = model.ZSDYMC;
			parameters[7].Value = model.ZSLYMC;

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
		public bool Update(ZYNLPJPT.Model.XKZSTXView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XKZSTXView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("ZSLYBH=@ZSLYBH,");
			strSql.Append("ZSDYBH=@ZSDYBH,");
			strSql.Append("ZSDBH=@ZSDBH,");
			strSql.Append("ZSDMC=@ZSDMC,");
			strSql.Append("ZSDYMC=@ZSDYMC,");
			strSql.Append("ZSLYMC=@ZSLYMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.ZSLYBH;
			parameters[3].Value = model.ZSDYBH;
			parameters[4].Value = model.ZSDBH;
			parameters[5].Value = model.ZSDMC;
			parameters[6].Value = model.ZSDYMC;
			parameters[7].Value = model.ZSLYMC;

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
			strSql.Append("delete from XKZSTXView ");
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
		public ZYNLPJPT.Model.XKZSTXView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,XKMC,ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC from XKZSTXView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XKZSTXView model=new ZYNLPJPT.Model.XKZSTXView();
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
		public ZYNLPJPT.Model.XKZSTXView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XKZSTXView model=new ZYNLPJPT.Model.XKZSTXView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
				}
				if(row["ZSLYBH"]!=null && row["ZSLYBH"].ToString()!="")
				{
					model.ZSLYBH=int.Parse(row["ZSLYBH"].ToString());
				}
				if(row["ZSDYBH"]!=null && row["ZSDYBH"].ToString()!="")
				{
					model.ZSDYBH=int.Parse(row["ZSDYBH"].ToString());
				}
				if(row["ZSDBH"]!=null && row["ZSDBH"].ToString()!="")
				{
					model.ZSDBH=int.Parse(row["ZSDBH"].ToString());
				}
				if(row["ZSDMC"]!=null)
				{
					model.ZSDMC=row["ZSDMC"].ToString();
				}
				if(row["ZSDYMC"]!=null)
				{
					model.ZSDYMC=row["ZSDYMC"].ToString();
				}
				if(row["ZSLYMC"]!=null)
				{
					model.ZSLYMC=row["ZSLYMC"].ToString();
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
			strSql.Append("select XKBH,XKMC,ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC ");
			strSql.Append(" FROM XKZSTXView ");
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
			strSql.Append(" XKBH,XKMC,ZSLYBH,ZSDYBH,ZSDBH,ZSDMC,ZSDYMC,ZSLYMC ");
			strSql.Append(" FROM XKZSTXView ");
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
			strSql.Append("select count(1) FROM XKZSTXView ");
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
			strSql.Append(")AS Row, T.*  from XKZSTXView T ");
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
			parameters[0].Value = "XKZSTXView";
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
        /// <summary>
        /// 获取学科下面的知识体系(分页)
        /// </summary>
        /// <param name="xkbh"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public XKZSTXView[] getByXkbh(int xkbh, int startIndex, int endIndex)
        {

            
            List<XKZSTXView> xkzstxView  = new List<XKZSTXView>();
            DataSet ds = GetListByPage("xkbh="+xkbh,"zsdbh",startIndex,endIndex);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
               xkzstxView.Add(DataRowToModel(row));
            }
            
            return xkzstxView.ToArray();
        }
        /// <summary>
        /// 获取学科下面的知识体系
        /// </summary>
        /// <param name="xkbh"></param>
        /// <returns></returns>
        public XKZSTXView[] getByXkbh(int xkbh)
        {

            String strSql = "select * from XKZSTXView where xkbh=@xkbh ";
            SqlParameter[] parameters = {
                new SqlParameter("xkbh",xkbh)
			};

            List<XKZSTXView> xkzstxView = new List<XKZSTXView>();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                xkzstxView.Add(DataRowToModel(row));
            }

            return xkzstxView.ToArray();
        }
        /// <summary>
        /// 获取学科下面的知识单元（分页）
        /// </summary>
        /// <param name="xkbh"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet getZSDYByXkbh(int xkbh, int startIndex, int endIndex)
        {


            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.zsdybh asc");

            strSql.Append(")AS Row,T.* from ");
            strSql.Append("(select distinct zslybh,zslymc,zsdybh,zsdymc from XKZSTXView WHERE xkbh="+xkbh+") T" );
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            return ds;         
           
        }
        /// <summary>
        /// 获取学科下面的知识领域（分页）
        /// </summary>
        /// <param name="xkbh"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet getZSLYByXkbh(int xkbh, int startIndex, int endIndex)
        {


            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.zslybh asc");

            strSql.Append(")AS Row,T.* from ");
            strSql.Append("(select distinct zslybh,zslymc from XKZSTXView WHERE xkbh=" + xkbh + ") T");
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            return ds;

        }
        
        /// <summary>
        /// 获取某列distinct的数目
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetCount(string columnName,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(distinct "+columnName+") FROM XKZSTXView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
		#endregion  ExtensionMethod
	}
}

