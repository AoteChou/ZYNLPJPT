using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;//Please add references
namespace ZYNLPJPT.DAL
{
    /// <summary>
    /// ���ݷ�����:JSGNB_DAL
    /// </summary>
    public partial class JSGNB_DAL
    {
        public JSGNB_DAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("JSBH", "JSGNB");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int JSBH, int GNBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from JSGNB");
            strSql.Append(" where JSBH=@JSBH and GNBH=@GNBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.Int,4),
					new SqlParameter("@GNBH", SqlDbType.Int,4)			};
            parameters[0].Value = JSBH;
            parameters[1].Value = GNBH;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add(ZYNLPJPT.Model.JSGNB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into JSGNB(");
            strSql.Append("JSBH,GNBH,SFMRGN)");
            strSql.Append(" values (");
            strSql.Append("@JSBH,@GNBH,@SFMRGN)");
            SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.Int,4),
					new SqlParameter("@GNBH", SqlDbType.Int,4),
					new SqlParameter("@SFMRGN", SqlDbType.Bit,1)};
            parameters[0].Value = model.JSBH;
            parameters[1].Value = model.GNBH;
            parameters[2].Value = model.SFMRGN;

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
        /// ����һ������
        /// </summary>
        public bool Update(ZYNLPJPT.Model.JSGNB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update JSGNB set ");
            strSql.Append("SFMRGN=@SFMRGN");
            strSql.Append(" where JSBH=@JSBH and GNBH=@GNBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@SFMRGN", SqlDbType.Bit,1),
					new SqlParameter("@JSBH", SqlDbType.Int,4),
					new SqlParameter("@GNBH", SqlDbType.Int,4)};
            parameters[0].Value = model.SFMRGN;
            parameters[1].Value = model.JSBH;
            parameters[2].Value = model.GNBH;

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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int JSBH, int GNBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from JSGNB ");
            strSql.Append(" where JSBH=@JSBH and GNBH=@GNBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.Int,4),
					new SqlParameter("@GNBH", SqlDbType.Int,4)			};
            parameters[0].Value = JSBH;
            parameters[1].Value = GNBH;

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
        /// �õ�һ������ʵ��
        /// </summary>
        public ZYNLPJPT.Model.JSGNB GetModel(int JSBH, int GNBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 JSBH,GNBH,SFMRGN from JSGNB ");
            strSql.Append(" where JSBH=@JSBH and GNBH=@GNBH ");
            SqlParameter[] parameters = {
					new SqlParameter("@JSBH", SqlDbType.Int,4),
					new SqlParameter("@GNBH", SqlDbType.Int,4)			};
            parameters[0].Value = JSBH;
            parameters[1].Value = GNBH;

            ZYNLPJPT.Model.JSGNB model = new ZYNLPJPT.Model.JSGNB();
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
        /// �õ�һ������ʵ��
        /// </summary>
        public ZYNLPJPT.Model.JSGNB DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.JSGNB model = new ZYNLPJPT.Model.JSGNB();
            if (row != null)
            {
                if (row["JSBH"] != null && row["JSBH"].ToString() != "")
                {
                    model.JSBH = int.Parse(row["JSBH"].ToString());
                }
                if (row["GNBH"] != null && row["GNBH"].ToString() != "")
                {
                    model.GNBH = int.Parse(row["GNBH"].ToString());
                }
                if (row["SFMRGN"] != null && row["SFMRGN"].ToString() != "")
                {
                    if ((row["SFMRGN"].ToString() == "1") || (row["SFMRGN"].ToString().ToLower() == "true"))
                    {
                        model.SFMRGN = true;
                    }
                    else
                    {
                        model.SFMRGN = false;
                    }
                }
            }
            return model;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JSBH,GNBH,SFMRGN ");
            strSql.Append(" FROM JSGNB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" JSBH,GNBH,SFMRGN ");
            strSql.Append(" FROM JSGNB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM JSGNB ");
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
        /// ��ҳ��ȡ�����б�
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
                strSql.Append("order by T.GNBH desc");
            }
            strSql.Append(")AS Row, T.*  from JSGNB T ");
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
        /// ��ҳ��ȡ�����б�
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
            parameters[0].Value = "JSGNB";
            parameters[1].Value = "GNBH";
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

