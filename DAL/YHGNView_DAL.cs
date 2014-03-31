
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;
using System.Collections;
using System.Collections.Generic;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:YHGNView_DAL
	/// </summary>
	public partial class YHGNView_DAL
	{
		public YHGNView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.YHGNView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YHGNView(");
			strSql.Append("GNM,GNLJ,SSML,GNBH,YHBH)");
			strSql.Append(" values (");
			strSql.Append("@GNM,@GNLJ,@SSML,@GNBH,@YHBH)");
			SqlParameter[] parameters = {
					new SqlParameter("@GNM", SqlDbType.VarChar,50),
					new SqlParameter("@GNLJ", SqlDbType.VarChar,300),
					new SqlParameter("@SSML", SqlDbType.VarChar,50),
					new SqlParameter("@GNBH", SqlDbType.Int,4),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.GNM;
			parameters[1].Value = model.GNLJ;
			parameters[2].Value = model.SSML;
			parameters[3].Value = model.GNBH;
			parameters[4].Value = model.YHBH;

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
		public bool Update(ZYNLPJPT.Model.YHGNView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YHGNView set ");
			strSql.Append("GNM=@GNM,");
			strSql.Append("GNLJ=@GNLJ,");
			strSql.Append("SSML=@SSML,");
			strSql.Append("GNBH=@GNBH,");
			strSql.Append("YHBH=@YHBH");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@GNM", SqlDbType.VarChar,50),
					new SqlParameter("@GNLJ", SqlDbType.VarChar,300),
					new SqlParameter("@SSML", SqlDbType.VarChar,50),
					new SqlParameter("@GNBH", SqlDbType.Int,4),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.GNM;
			parameters[1].Value = model.GNLJ;
			parameters[2].Value = model.SSML;
			parameters[3].Value = model.GNBH;
			parameters[4].Value = model.YHBH;

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
			strSql.Append("delete from YHGNView ");
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
		public ZYNLPJPT.Model.YHGNView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GNM,GNLJ,SSML,GNBH,YHBH from YHGNView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.YHGNView model=new ZYNLPJPT.Model.YHGNView();
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
		public ZYNLPJPT.Model.YHGNView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.YHGNView model=new ZYNLPJPT.Model.YHGNView();
			if (row != null)
			{
				if(row["GNM"]!=null)
				{
					model.GNM=row["GNM"].ToString();
				}
				if(row["GNLJ"]!=null)
				{
					model.GNLJ=row["GNLJ"].ToString();
				}
				if(row["SSML"]!=null)
				{
					model.SSML=row["SSML"].ToString();
				}
				if(row["GNBH"]!=null && row["GNBH"].ToString()!="")
				{
					model.GNBH=int.Parse(row["GNBH"].ToString());
				}
				if(row["YHBH"]!=null)
				{
					model.YHBH=row["YHBH"].ToString();
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
			strSql.Append("select GNM,GNLJ,SSML,GNBH,YHBH ");
			strSql.Append(" FROM YHGNView ");
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
			strSql.Append(" GNM,GNLJ,SSML,GNBH,YHBH ");
			strSql.Append(" FROM YHGNView ");
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
			strSql.Append("select count(1) FROM YHGNView ");
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
			strSql.Append(")AS Row, T.*  from YHGNView T ");
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
			parameters[0].Value = "YHGNView";
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

        public MainMenu[] getUserMenu(YH yh)
        {

            string sql = "select distinct SSML from YHGNView where yhbh='" + yh.YHBH.Trim() + "'";


            SqlDataReader reader = DbHelperSQL.ExecuteReader(sql);
            List<string> ssmls = new List<string>();
            while (reader.Read())
            {
                ssmls.Add((string)reader["ssml"]);
            }
            reader.Close();

            List<MainMenu> mainMenus = new List<MainMenu>();
            foreach (string ssml in ssmls)
            {
                string realSql = "select * from YHGNView where yhbh=@yhbh and ssml=@ssml";
                SqlParameter[] sqlPars = { new SqlParameter("@yhbh",yh.YHBH),
                                           new SqlParameter("@ssml",ssml)
                                         };
                SqlDataReader realReader = DbHelperSQL.ExecuteReader(realSql, sqlPars);
                List<ItemMenu> itemMenus = new List<ItemMenu>();
                while (realReader.Read())
                {
                    itemMenus.Add(new ItemMenu((string)realReader["gnm"], (string)realReader["gnlj"], (int)realReader["gnbh"]));
                }
                realReader.Close();
                mainMenus.Add(new MainMenu(ssml, itemMenus.ToArray()));
            }
            MainMenu[] mainMenuArray = mainMenus.ToArray();
            return mainMenuArray;
        }
		#endregion  ExtensionMethod
	}
}

