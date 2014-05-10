
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using System.Collections.Generic;
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:YH_DAL
	/// </summary>
	public partial class YH_DAL
	{
		public YH_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string YHBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YH");
			strSql.Append(" where YHBH=@YHBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = YHBH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool isExist(string yhbh,string yhmm)
        {
            string sql = "select * from yh where yhbh=@yhbh and mm=@mm";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yhbh),
                new SqlParameter("@mm",yhmm)
                           };
            return DbHelperSQL.Exists(sql.ToString(), sqlparameters);

        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.YH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YH(");
			strSql.Append("YHBH,MM,XM,XB)");
			strSql.Append(" values (");
			strSql.Append("@YHBH,@MM,@XM,@XB)");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1)};
			parameters[0].Value = model.YHBH;
			parameters[1].Value = model.MM;
			parameters[2].Value = model.XM;
			parameters[3].Value = model.XB;

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
		public bool Update(ZYNLPJPT.Model.YH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YH set ");
			strSql.Append("MM=@MM,");
			strSql.Append("XM=@XM,");
			strSql.Append("XB=@XB");
			strSql.Append(" where YHBH=@YHBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1),
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MM;
			parameters[1].Value = model.XM;
			parameters[2].Value = model.XB;
			parameters[3].Value = model.YHBH;

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
		public bool Delete(string YHBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YH ");
			strSql.Append(" where YHBH=@YHBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = YHBH;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string YHBHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YH ");
			strSql.Append(" where YHBH in ("+YHBHlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ZYNLPJPT.Model.YH GetModel(string YHBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 YHBH,MM,XM,XB from YH ");
			strSql.Append(" where YHBH=@YHBH ");
			SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50)			};
			parameters[0].Value = YHBH;

			ZYNLPJPT.Model.YH model=new ZYNLPJPT.Model.YH();
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
		public ZYNLPJPT.Model.YH DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.YH model=new ZYNLPJPT.Model.YH();
			if (row != null)
			{
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
			strSql.Append("select YHBH,MM,XM,XB ");
			strSql.Append(" FROM YH ");
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
			strSql.Append(" YHBH,MM,XM,XB ");
			strSql.Append(" FROM YH ");
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
			strSql.Append("select count(1) FROM YH ");
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
				strSql.Append("order by T.YHBH desc");
			}
			strSql.Append(")AS Row, T.*  from YH T ");
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
			parameters[0].Value = "YH";
			parameters[1].Value = "YHBH";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public string[] getYHXMbyYHBH(string[] yhbhs) {
            List<string> stringList = new List<string>();
            foreach(string yhbh in yhbhs){
                if (yhbh == "")
                {
                    stringList.Add("");
                }
                else {
                    string sqlString = "select xm from yh where yhbh=@yhbh";
                    SqlParameter[] sqlparameters = { new SqlParameter("@yhbh", yhbh) };
                    SqlDataReader sdReader = DbHelperSQL.ExecuteReader(sqlString, sqlparameters);
                    if (sdReader.Read())
                    {
                        stringList.Add((string)(sdReader[0]));
                    }
                    sdReader.Close();
                }
                
            }

            return stringList.ToArray();
        }


        public void AddXS(ZYNLPJPT.Model.YH yh,ZYNLPJPT.Model.XS xs, ZYNLPJPT.Model.YHJSB sb)
        {
            try
            {
                List<string> SQLStringList=new List<string>();
                List<SqlParameter[]> SqlParameterList = new List<SqlParameter[]>();

                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into YH(");
                strSql.Append("YHBH,MM,XM,XB)");
                strSql.Append(" values (");
                strSql.Append("@YHBH,@MM,@XM,@XB)");
                SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1)};
                parameters[0].Value = yh.YHBH;
                parameters[1].Value = yh.MM;
                parameters[2].Value = yh.XM;
                parameters[3].Value = yh.XB;
                SQLStringList.Add(strSql.ToString());
                SqlParameterList.Add(parameters);

                StringBuilder strSql1 = new StringBuilder();
                strSql1.Append("insert into XS(");
                strSql1.Append("BJBH,XSBH,RXNF)");
                strSql1.Append(" values (");
                strSql1.Append("@BJBH,@XSBH,@RXNF)");
                SqlParameter[] parameters1 = {
					new SqlParameter("@BJBH", SqlDbType.Int,4),
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@RXNF", SqlDbType.DateTime)};
                parameters1[0].Value = xs.BJBH;
                parameters1[1].Value = xs.XSBH;
                parameters1[2].Value = xs.RXNF;
                SQLStringList.Add(strSql1.ToString());
                SqlParameterList.Add(parameters1);




                StringBuilder strSql2 = new StringBuilder();
                strSql2.Append("insert into YHJSB(");
                strSql2.Append("YHBH,JSBH)");
                strSql2.Append(" values (");
                strSql2.Append("@YHBH,@JSBH)");
                SqlParameter[] parameters2 = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
                parameters2[0].Value = sb.YHBH;
                parameters2[1].Value = sb.JSBH;
                SQLStringList.Add(strSql2.ToString());
                SqlParameterList.Add(parameters2);

                DbHelperSQL.ExecuteSqlTran(SQLStringList, SqlParameterList);
                
                



               
            }
            catch (Exception)
            {
                
                throw;
                
            }
        }
        public void AddJS(ZYNLPJPT.Model.YH yh, ZYNLPJPT.Model.JS js, ZYNLPJPT.Model.YHJSB sb)
        {
            try
            {
                

                List<string> SQLStringList = new List<string>();
                List<SqlParameter[]> SqlParameterList = new List<SqlParameter[]>();

                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into YH(");
                strSql.Append("YHBH,MM,XM,XB)");
                strSql.Append(" values (");
                strSql.Append("@YHBH,@MM,@XM,@XB)");
                SqlParameter[] parameters = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@MM", SqlDbType.VarChar,50),
					new SqlParameter("@XM", SqlDbType.VarChar,50),
					new SqlParameter("@XB", SqlDbType.Bit,1)};
                parameters[0].Value = yh.YHBH;
                parameters[1].Value = yh.MM;
                parameters[2].Value = yh.XM;
                parameters[3].Value = yh.XB;
                SQLStringList.Add(strSql.ToString());
                SqlParameterList.Add(parameters);

                StringBuilder strSql1 = new StringBuilder();
                strSql1.Append("insert into JS(");
                strSql1.Append("JSBH,SFSXKFZR,SFSKCFZR,SSXK)");
                strSql1.Append(" values (");
                strSql1.Append("@JSBH,@SFSXKFZR,@SFSKCFZR,@SSXK)");
                SqlParameter[] parameters1 = {
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@SFSXKFZR", SqlDbType.Bit,1),
					new SqlParameter("@SFSKCFZR", SqlDbType.Bit,1),
					new SqlParameter("@SSXK", SqlDbType.Int,4)};
                parameters1[0].Value = js.JSBH;
                parameters1[1].Value = js.SFSXKFZR;
                parameters1[2].Value = js.SFSKCFZR;
                parameters1[3].Value = js.SSXK;
                SQLStringList.Add(strSql1.ToString());
                SqlParameterList.Add(parameters1);



                StringBuilder strSql2 = new StringBuilder();
                strSql2.Append("insert into YHJSB(");
                strSql2.Append("YHBH,JSBH)");
                strSql2.Append(" values (");
                strSql2.Append("@YHBH,@JSBH)");
                SqlParameter[] parameters2 = {
					new SqlParameter("@YHBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.Int,4)};
                parameters2[0].Value = sb.YHBH;
                parameters2[1].Value = sb.JSBH;
                SQLStringList.Add(strSql2.ToString());
                SqlParameterList.Add(parameters2);

                DbHelperSQL.ExecuteSqlTran(SQLStringList, SqlParameterList);






            }
            catch (Exception)
            {

                throw;

            }
        }
		#endregion  ExtensionMethod

        internal void GetModel()
        {
            throw new NotImplementedException();
        }
    }
}

