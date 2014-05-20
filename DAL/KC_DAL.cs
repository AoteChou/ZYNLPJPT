using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
    /// <summary>
    /// 数据访问类:KC_DAL
    /// </summary>
    public partial class KC_DAL
    {
        public KC_DAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("KCBH", "KC");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int KCBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from KC");
            strSql.Append(" where KCBH=@KCBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4)
			};
            parameters[0].Value = KCBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZYNLPJPT.Model.KC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into KC(");
            strSql.Append("KCJJ,KCMC,KCFZR,KKXK)");
            strSql.Append(" values (");
            strSql.Append("@KCJJ,@KCMC,@KCFZR,@KKXK)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4)};
            parameters[0].Value = model.KCJJ;
            parameters[1].Value = model.KCMC;
            parameters[2].Value = model.KCFZR;
            parameters[3].Value = model.KKXK;

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
        public bool Update(ZYNLPJPT.Model.KC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update KC set ");
            strSql.Append("KCJJ=@KCJJ,");
            strSql.Append("KCMC=@KCMC,");
            strSql.Append("KCFZR=@KCFZR,");
            strSql.Append("KKXK=@KKXK");
            strSql.Append(" where KCBH=@KCBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KKXK", SqlDbType.Int,4),
					new SqlParameter("@KCBH", SqlDbType.Int,4)};
            parameters[0].Value = model.KCJJ;
            parameters[1].Value = model.KCMC;
            parameters[2].Value = model.KCFZR;
            parameters[3].Value = model.KKXK;
            parameters[4].Value = model.KCBH;

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
        public bool Delete(int KCBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KC ");
            strSql.Append(" where KCBH=@KCBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4)
			};
            parameters[0].Value = KCBH;

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
        public bool DeleteList(string KCBHlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KC ");
            strSql.Append(" where KCBH in (" + KCBHlist + ")  ");
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
        public ZYNLPJPT.Model.KC GetModel(int KCBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 KCBH,KCJJ,KCMC,KCFZR,KKXK from KC ");
            strSql.Append(" where KCBH=@KCBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4)
			};
            parameters[0].Value = KCBH;

            ZYNLPJPT.Model.KC model = new ZYNLPJPT.Model.KC();
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
        public ZYNLPJPT.Model.KC DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.KC model = new ZYNLPJPT.Model.KC();
            if (row != null)
            {
                if (row["KCBH"] != null && row["KCBH"].ToString() != "")
                {
                    model.KCBH = int.Parse(row["KCBH"].ToString());
                }
                if (row["KCJJ"] != null)
                {
                    model.KCJJ = row["KCJJ"].ToString();
                }
                if (row["KCMC"] != null)
                {
                    model.KCMC = row["KCMC"].ToString();
                }
                if (row["KCFZR"] != null)
                {
                    model.KCFZR = row["KCFZR"].ToString();
                }
                if (row["KKXK"] != null && row["KKXK"].ToString() != "")
                {
                    model.KKXK = int.Parse(row["KKXK"].ToString());
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
            strSql.Append("select KCBH,KCJJ,KCMC,KCFZR,KKXK ");
            strSql.Append(" FROM KC ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
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
            strSql.Append(" KCBH,KCJJ,KCMC,KCFZR,KKXK ");
            strSql.Append(" FROM KC ");
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
            strSql.Append("select count(1) FROM KC ");
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
                strSql.Append("order by T.KCBH desc");
            }
            strSql.Append(")AS Row, T.*  from KC T ");
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
            parameters[0].Value = "KC";
            parameters[1].Value = "KCBH";
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


