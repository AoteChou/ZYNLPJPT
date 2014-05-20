using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:ZSLY_DAL
	/// </summary>
	public partial class ZSLY_DAL
	{
		public ZSLY_DAL()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ZSLYBH", "ZSLY");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ZSLYBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSLY");
            strSql.Append(" where ZSLYBH=@ZSLYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)
			};
            parameters[0].Value = ZSLYBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Exists(string ZSLYMC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSLY");
            strSql.Append(" where ZSLYMC=@ZSLYMC");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50)
			};
            parameters[0].Value = ZSLYMC;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool ExistsFoXG(string ZSLYMC,int ZSLYBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ZSLY");
            strSql.Append(" where ZSLYMC=@ZSLYMC and ZSLYBH!=@ZSLYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
                    new SqlParameter("@ZSLYBH",SqlDbType.Int,4)

			};
            parameters[0].Value = ZSLYMC;
            parameters[1].Value = ZSLYBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZYNLPJPT.Model.ZSLY model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ZSLY(");
            strSql.Append("ZSLYMC,BZ,XKBH)");
            strSql.Append(" values (");
            strSql.Append("@ZSLYMC,@BZ,@XKBH)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@XKBH", SqlDbType.Int,4)};
            parameters[0].Value = model.ZSLYMC;
            parameters[1].Value = model.BZ;
            parameters[2].Value = model.XKBH;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(ZYNLPJPT.Model.ZSLY model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ZSLY set ");
            strSql.Append("ZSLYMC=@ZSLYMC,");
            strSql.Append("BZ=@BZ,");
            strSql.Append("XKBH=@XKBH");
            strSql.Append(" where ZSLYBH=@ZSLYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@BZ", SqlDbType.Text),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)};
            parameters[0].Value = model.ZSLYMC;
            parameters[1].Value = model.BZ;
            parameters[2].Value = model.XKBH;
            parameters[3].Value = model.ZSLYBH;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ZSLYBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ZSLY ");
            strSql.Append(" where ZSLYBH=@ZSLYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)
			};
            parameters[0].Value = ZSLYBH;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string ZSLYBHlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ZSLY ");
            strSql.Append(" where ZSLYBH in (" + ZSLYBHlist + ")  ");
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
        /// 得到一个对象实体
        /// </summary>
        public ZYNLPJPT.Model.ZSLY GetModel(int ZSLYBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ZSLYBH,ZSLYMC,BZ,XKBH from ZSLY ");
            strSql.Append(" where ZSLYBH=@ZSLYBH");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4)
			};
            parameters[0].Value = ZSLYBH;

            ZYNLPJPT.Model.ZSLY model = new ZYNLPJPT.Model.ZSLY();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public ZYNLPJPT.Model.ZSLY GetModel(string zslyName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ZSLYBH,ZSLYMC,BZ,XKBH from ZSLY ");
            strSql.Append(" where zslymc=@zslymc");
            SqlParameter[] parameters = {
					new SqlParameter("@zslymc", SqlDbType.VarChar,50)
			};
            parameters[0].Value = zslyName;

            ZYNLPJPT.Model.ZSLY model = new ZYNLPJPT.Model.ZSLY();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public ZYNLPJPT.Model.ZSLY DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.ZSLY model = new ZYNLPJPT.Model.ZSLY();
            if (row != null)
            {
                if (row["ZSLYBH"] != null && row["ZSLYBH"].ToString() != "")
                {
                    model.ZSLYBH = int.Parse(row["ZSLYBH"].ToString());
                }
                if (row["ZSLYMC"] != null)
                {
                    model.ZSLYMC = row["ZSLYMC"].ToString();
                }
                if (row["BZ"] != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["XKBH"] != null && row["XKBH"].ToString() != "")
                {
                    model.XKBH = int.Parse(row["XKBH"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZSLYBH,ZSLYMC,BZ,XKBH ");
            strSql.Append(" FROM ZSLY ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public string[] getArrayByXkbh(int xkbh)
        {

            string sql = "select ZSLYMC from ZSLY where xkbh=" + xkbh;
            DataSet ds = DbHelperSQL.Query(sql.ToString());
            int length = ds.Tables[0].Rows.Count;
            string[] results = new string[length];
            for (int i = 0; i < length; i++)
            {
                results[i] = ds.Tables[0].Rows[i]["ZSLYMC"].ToString();
            }
            return results;
        }

        public ZSLY[] getModelArrayByXkbh(int xkbh)
        {

            string sql = "select * from ZSLY where xkbh=" + xkbh;
            DataSet ds = DbHelperSQL.Query(sql.ToString());
            int length = ds.Tables[0].Rows.Count;
            ZSLY[] zslys=new ZSLY[length];
            for (int i = 0; i < length; i++)
            {
                zslys[i] = new ZSLY();
                zslys[i].ZSLYMC = ds.Tables[0].Rows[i]["ZSLYMC"].ToString();
                if(ds.Tables[0].Rows[i]["bz"]==null||ds.Tables[0].Rows[i]["bz"].ToString()==""||ds.Tables[0].Rows[i]["bz"].ToString()=="null"){
                    zslys[i].BZ = "暂无";
                }else
                {
                    zslys[i].BZ=ds.Tables[0].Rows[i]["bz"].ToString();
                }
                zslys[i].ZSLYBH = int.Parse(ds.Tables[0].Rows[i]["zslybh"].ToString());
                zslys[i].XKBH = int.Parse(ds.Tables[0].Rows[i]["xkbh"].ToString());
            }
            return zslys;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ZSLYBH,ZSLYMC,BZ,XKBH ");
            strSql.Append(" FROM ZSLY ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ZSLY ");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ZSLYBH desc");
            }
            strSql.Append(")AS Row, T.*  from ZSLY T ");
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
            parameters[0].Value = "ZSLY";
            parameters[1].Value = "ZSLYBH";
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

