using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;


namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:YHJSView_DAL
	/// </summary>
	public partial class YHJSView_DAL
	{
        public YHJSView_DAL()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ZYNLPJPT.Model.YHJSView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into YHJSView(");
            strSql.Append("JSM,MM,XM,XB,YHBH,JSBH)");
            strSql.Append(" values (");
            strSql.Append("@JSM,@MM,@XM,@XB,@YHBH,@JSBH)");
            SqlParameter[] parameters = {
					new SqlParameter("@JSM", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
            parameters[0].Value = model.JSM;
            parameters[1].Value = model.MM;
            parameters[2].Value = model.XM;
            parameters[3].Value = model.XB;
            parameters[4].Value = model.YHBH;
            parameters[5].Value = model.JSBH;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(ZYNLPJPT.Model.YHJSView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update YHJSView set ");
            strSql.Append("JSM=@JSM,");
            strSql.Append("MM=@MM,");
            strSql.Append("XM=@XM,");
            strSql.Append("XB=@XB,");
            strSql.Append("YHBH=@YHBH,");
            strSql.Append("JSBH=@JSBH");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@JSM", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
            parameters[0].Value = model.JSM;
            parameters[1].Value = model.MM;
            parameters[2].Value = model.XM;
            parameters[3].Value = model.XB;
            parameters[4].Value = model.YHBH;
            parameters[5].Value = model.JSBH;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YHJSView ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

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
        public ZYNLPJPT.Model.YHJSView GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 JSM,MM,XM,XB,YHBH,JSBH from YHJSView ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            ZYNLPJPT.Model.YHJSView model = new ZYNLPJPT.Model.YHJSView();
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
        public ZYNLPJPT.Model.YHJSView GetModel(string yhbh)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 JSM,MM,XM,XB,YHBH,JSBH from YHJSView ");
            strSql.Append(" where yhbh=@yhbh");
            SqlParameter[] parameters = {
                                            new SqlParameter("@YHBH", SqlDbType.VarChar,50)
			};

            parameters[0].Value = yhbh;

            ZYNLPJPT.Model.YHJSView model = new ZYNLPJPT.Model.YHJSView();
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
        public ZYNLPJPT.Model.YHJSView DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.YHJSView model = new ZYNLPJPT.Model.YHJSView();
            if (row != null)
            {
                if (row["JSM"] != null)
                {
                    model.JSM = row["JSM"].ToString();
                }
                if (row["MM"] != null)
                {
                    model.MM = row["MM"].ToString();
                }
                if (row["XM"] != null)
                {
                    model.XM = row["XM"].ToString();
                }
                if (row["XB"] != null && row["XB"].ToString() != "")
                {
                    if ((row["XB"].ToString() == "1") || (row["XB"].ToString().ToLower() == "true"))
                    {
                        model.XB = true;
                    }
                    else
                    {
                        model.XB = false;
                    }
                }
                if (row["YHBH"] != null)
                {
                    model.YHBH = row["YHBH"].ToString();
                }
                if (row["JSBH"] != null && row["JSBH"].ToString() != "")
                {
                    model.JSBH = int.Parse(row["JSBH"].ToString());
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
            strSql.Append("select JSM,MM,XM,XB,YHBH,JSBH ");
            strSql.Append(" FROM YHJSView ");
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
            strSql.Append(" JSM,MM,XM,XB,YHBH,JSBH ");
            strSql.Append(" FROM YHJSView ");
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
            strSql.Append("select count(1) FROM YHJSView ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from YHJSView T ");
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
            parameters[0].Value = "YHJSView";
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

