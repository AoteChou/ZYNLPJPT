
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:ST_DAL
	/// </summary>
	public partial class ST_DAL
	{
		public ST_DAL()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("STBH", "ST");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int STBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ST");
            strSql.Append(" where STBH=@STBH");
            SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4)
			};
            parameters[0].Value = STBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZYNLPJPT.Model.ST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ST(");
            strSql.Append("KCBH,CTSJ,TMNR,TMDA,CTR,SFZDYJ,SFSC,HZM)");
            strSql.Append(" values (");
            strSql.Append("@KCBH,@CTSJ,@TMNR,@TMDA,@CTR,@SFZDYJ,@SFSC,@HZM)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@CTSJ", SqlDbType.DateTime),
					new SqlParameter("@TMNR", SqlDbType.VarBinary,-1),
					new SqlParameter("@TMDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@CTR", SqlDbType.VarChar,50),
					new SqlParameter("@SFZDYJ", SqlDbType.Bit,1),
					new SqlParameter("@SFSC", SqlDbType.Bit,1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50)};
            parameters[0].Value = model.KCBH;
            parameters[1].Value = model.CTSJ;
            parameters[2].Value = model.TMNR;
            parameters[3].Value = model.TMDA;
            parameters[4].Value = model.CTR;
            parameters[5].Value = model.SFZDYJ;
            parameters[6].Value = model.SFSC;
            parameters[7].Value = model.HZM;

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
        public bool Update(ZYNLPJPT.Model.ST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ST set ");
            strSql.Append("KCBH=@KCBH,");
            strSql.Append("CTSJ=@CTSJ,");
            strSql.Append("TMNR=@TMNR,");
            strSql.Append("TMDA=@TMDA,");
            strSql.Append("CTR=@CTR,");
            strSql.Append("SFZDYJ=@SFZDYJ,");
            strSql.Append("SFSC=@SFSC,");
            strSql.Append("HZM=@HZM");
            strSql.Append(" where STBH=@STBH");
            SqlParameter[] parameters = {
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@CTSJ", SqlDbType.DateTime),
					new SqlParameter("@TMNR", SqlDbType.VarBinary,-1),
					new SqlParameter("@TMDA", SqlDbType.VarBinary,-1),
					new SqlParameter("@CTR", SqlDbType.VarChar,50),
					new SqlParameter("@SFZDYJ", SqlDbType.Bit,1),
					new SqlParameter("@SFSC", SqlDbType.Bit,1),
					new SqlParameter("@HZM", SqlDbType.VarChar,50),
					new SqlParameter("@STBH", SqlDbType.Int,4)};
            parameters[0].Value = model.KCBH;
            parameters[1].Value = model.CTSJ;
            parameters[2].Value = model.TMNR;
            parameters[3].Value = model.TMDA;
            parameters[4].Value = model.CTR;
            parameters[5].Value = model.SFZDYJ;
            parameters[6].Value = model.SFSC;
            parameters[7].Value = model.HZM;
            parameters[8].Value = model.STBH;

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
        public bool Delete(int STBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ST ");
            strSql.Append(" where STBH=@STBH");
            SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4)
			};
            parameters[0].Value = STBH;

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
        public bool DeleteList(string STBHlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ST ");
            strSql.Append(" where STBH in (" + STBHlist + ")  ");
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
        public ZYNLPJPT.Model.ST GetModel(int STBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 STBH,KCBH,CTSJ,TMNR,TMDA,CTR,SFZDYJ,SFSC,HZM from ST ");
            strSql.Append(" where STBH=@STBH");
            SqlParameter[] parameters = {
					new SqlParameter("@STBH", SqlDbType.Int,4)
			};
            parameters[0].Value = STBH;

            ZYNLPJPT.Model.ST model = new ZYNLPJPT.Model.ST();
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
        public ZYNLPJPT.Model.ST DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.ST model = new ZYNLPJPT.Model.ST();
            if (row != null)
            {
                if (row["STBH"] != null && row["STBH"].ToString() != "")
                {
                    model.STBH = int.Parse(row["STBH"].ToString());
                }
                if (row["KCBH"] != null && row["KCBH"].ToString() != "")
                {
                    model.KCBH = int.Parse(row["KCBH"].ToString());
                }
                if (row["CTSJ"] != null && row["CTSJ"].ToString() != "")
                {
                    model.CTSJ = DateTime.Parse(row["CTSJ"].ToString());
                }
                if (row["TMNR"] != null && row["TMNR"].ToString() != "")
                {
                    model.TMNR = (byte[])row["TMNR"];
                }
                if (row["TMDA"] != null && row["TMDA"].ToString() != "")
                {
                    model.TMDA = (byte[])row["TMDA"];
                }
                if (row["CTR"] != null)
                {
                    model.CTR = row["CTR"].ToString();
                }
                if (row["SFZDYJ"] != null && row["SFZDYJ"].ToString() != "")
                {
                    if ((row["SFZDYJ"].ToString() == "1") || (row["SFZDYJ"].ToString().ToLower() == "true"))
                    {
                        model.SFZDYJ = true;
                    }
                    else
                    {
                        model.SFZDYJ = false;
                    }
                }
                if (row["SFSC"] != null && row["SFSC"].ToString() != "")
                {
                    if ((row["SFSC"].ToString() == "1") || (row["SFSC"].ToString().ToLower() == "true"))
                    {
                        model.SFSC = true;
                    }
                    else
                    {
                        model.SFSC = false;
                    }
                }
                if (row["HZM"] != null)
                {
                    model.HZM = row["HZM"].ToString();
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
            strSql.Append("select STBH,KCBH,CTSJ,TMNR,TMDA,CTR,SFZDYJ,SFSC,HZM ");
            strSql.Append(" FROM ST ");
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
            strSql.Append(" STBH,KCBH,CTSJ,TMNR,TMDA,CTR,SFZDYJ,SFSC,HZM ");
            strSql.Append(" FROM ST ");
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
            strSql.Append("select count(1) FROM ST ");
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
                strSql.Append("order by T.STBH desc");
            }
            strSql.Append(")AS Row, T.*  from ST T ");
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
            parameters[0].Value = "ST";
            parameters[1].Value = "STBH";
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

