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
	/// 数据访问类:STZSDView_DAL
	/// </summary>
	public partial class STZSDView_DAL
	{
		public STZSDView_DAL()
		{}
		#region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ZYNLPJPT.Model.STZSDView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into STZSDView(");
            strSql.Append("ZSLYMC,ZSLY_BZ,EJZBBH,ZSDYMC,ZSDY_BZ,ZSDMC,ZSD_BZ,ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ,KCBH,CTSJ,CTR,SFSC,KCMC,SFZDYJ)");
            strSql.Append(" values (");
            strSql.Append("@ZSLYMC,@ZSLY_BZ,@EJZBBH,@ZSDYMC,@ZSDY_BZ,@ZSDMC,@ZSD_BZ,@ZSLYBH,@ZSDYBH,@ZSDBH,@STBH,@ZSDBZ,@KCBH,@CTSJ,@CTR,@SFSC,@KCMC,@SFZDYJ)");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLY_BZ", SqlDbType.Text),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDY_BZ", SqlDbType.Text),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSD_BZ", SqlDbType.Text),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@CTSJ", SqlDbType.DateTime),
					new SqlParameter("@CTR", SqlDbType.VarChar,50),
					new SqlParameter("@SFSC", SqlDbType.Bit,1),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@SFZDYJ", SqlDbType.Bit,1)};
            parameters[0].Value = model.ZSLYMC;
            parameters[1].Value = model.ZSLY_BZ;
            parameters[2].Value = model.EJZBBH;
            parameters[3].Value = model.ZSDYMC;
            parameters[4].Value = model.ZSDY_BZ;
            parameters[5].Value = model.ZSDMC;
            parameters[6].Value = model.ZSD_BZ;
            parameters[7].Value = model.ZSLYBH;
            parameters[8].Value = model.ZSDYBH;
            parameters[9].Value = model.ZSDBH;
            parameters[10].Value = model.STBH;
            parameters[11].Value = model.ZSDBZ;
            parameters[12].Value = model.KCBH;
            parameters[13].Value = model.CTSJ;
            parameters[14].Value = model.CTR;
            parameters[15].Value = model.SFSC;
            parameters[16].Value = model.KCMC;
            parameters[17].Value = model.SFZDYJ;

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
        public bool Update(ZYNLPJPT.Model.STZSDView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update STZSDView set ");
            strSql.Append("ZSLYMC=@ZSLYMC,");
            strSql.Append("ZSLY_BZ=@ZSLY_BZ,");
            strSql.Append("EJZBBH=@EJZBBH,");
            strSql.Append("ZSDYMC=@ZSDYMC,");
            strSql.Append("ZSDY_BZ=@ZSDY_BZ,");
            strSql.Append("ZSDMC=@ZSDMC,");
            strSql.Append("ZSD_BZ=@ZSD_BZ,");
            strSql.Append("ZSLYBH=@ZSLYBH,");
            strSql.Append("ZSDYBH=@ZSDYBH,");
            strSql.Append("ZSDBH=@ZSDBH,");
            strSql.Append("STBH=@STBH,");
            strSql.Append("ZSDBZ=@ZSDBZ,");
            strSql.Append("KCBH=@KCBH,");
            strSql.Append("CTSJ=@CTSJ,");
            strSql.Append("CTR=@CTR,");
            strSql.Append("SFSC=@SFSC,");
            strSql.Append("KCMC=@KCMC,");
            strSql.Append("SFZDYJ=@SFZDYJ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@ZSLYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSLY_BZ", SqlDbType.Text),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSDY_BZ", SqlDbType.Text),
					new SqlParameter("@ZSDMC", SqlDbType.VarChar,50),
					new SqlParameter("@ZSD_BZ", SqlDbType.Text),
					new SqlParameter("@ZSLYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDYBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBH", SqlDbType.Int,4),
					new SqlParameter("@STBH", SqlDbType.Int,4),
					new SqlParameter("@ZSDBZ", SqlDbType.Decimal,9),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@CTSJ", SqlDbType.DateTime),
					new SqlParameter("@CTR", SqlDbType.VarChar,50),
					new SqlParameter("@SFSC", SqlDbType.Bit,1),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@SFZDYJ", SqlDbType.Bit,1)};
            parameters[0].Value = model.ZSLYMC;
            parameters[1].Value = model.ZSLY_BZ;
            parameters[2].Value = model.EJZBBH;
            parameters[3].Value = model.ZSDYMC;
            parameters[4].Value = model.ZSDY_BZ;
            parameters[5].Value = model.ZSDMC;
            parameters[6].Value = model.ZSD_BZ;
            parameters[7].Value = model.ZSLYBH;
            parameters[8].Value = model.ZSDYBH;
            parameters[9].Value = model.ZSDBH;
            parameters[10].Value = model.STBH;
            parameters[11].Value = model.ZSDBZ;
            parameters[12].Value = model.KCBH;
            parameters[13].Value = model.CTSJ;
            parameters[14].Value = model.CTR;
            parameters[15].Value = model.SFSC;
            parameters[16].Value = model.KCMC;
            parameters[17].Value = model.SFZDYJ;

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
            strSql.Append("delete from STZSDView ");
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
        public ZYNLPJPT.Model.STZSDView GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ZSLYMC,ZSLY_BZ,EJZBBH,ZSDYMC,ZSDY_BZ,ZSDMC,ZSD_BZ,ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ,KCBH,CTSJ,CTR,SFSC,KCMC,SFZDYJ from STZSDView ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            ZYNLPJPT.Model.STZSDView model = new ZYNLPJPT.Model.STZSDView();
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
        public ZYNLPJPT.Model.STZSDView DataRowToModel(DataRow row)
        {
            ZYNLPJPT.Model.STZSDView model = new ZYNLPJPT.Model.STZSDView();
            if (row != null)
            {
                if (row["ZSLYMC"] != null)
                {
                    model.ZSLYMC = row["ZSLYMC"].ToString();
                }
                if (row["ZSLY_BZ"] != null)
                {
                    model.ZSLY_BZ = row["ZSLY_BZ"].ToString();
                }
                if (row["EJZBBH"] != null && row["EJZBBH"].ToString() != "")
                {
                    model.EJZBBH = int.Parse(row["EJZBBH"].ToString());
                }
                if (row["ZSDYMC"] != null)
                {
                    model.ZSDYMC = row["ZSDYMC"].ToString();
                }
                if (row["ZSDY_BZ"] != null)
                {
                    model.ZSDY_BZ = row["ZSDY_BZ"].ToString();
                }
                if (row["ZSDMC"] != null)
                {
                    model.ZSDMC = row["ZSDMC"].ToString();
                }
                if (row["ZSD_BZ"] != null)
                {
                    model.ZSD_BZ = row["ZSD_BZ"].ToString();
                }
                if (row["ZSLYBH"] != null && row["ZSLYBH"].ToString() != "")
                {
                    model.ZSLYBH = int.Parse(row["ZSLYBH"].ToString());
                }
                if (row["ZSDYBH"] != null && row["ZSDYBH"].ToString() != "")
                {
                    model.ZSDYBH = int.Parse(row["ZSDYBH"].ToString());
                }
                if (row["ZSDBH"] != null && row["ZSDBH"].ToString() != "")
                {
                    model.ZSDBH = int.Parse(row["ZSDBH"].ToString());
                }
                if (row["STBH"] != null && row["STBH"].ToString() != "")
                {
                    model.STBH = int.Parse(row["STBH"].ToString());
                }
                if (row["ZSDBZ"] != null && row["ZSDBZ"].ToString() != "")
                {
                    model.ZSDBZ = decimal.Parse(row["ZSDBZ"].ToString());
                }
                if (row["KCBH"] != null && row["KCBH"].ToString() != "")
                {
                    model.KCBH = int.Parse(row["KCBH"].ToString());
                }
                if (row["CTSJ"] != null && row["CTSJ"].ToString() != "")
                {
                    model.CTSJ = DateTime.Parse(row["CTSJ"].ToString());
                }
                if (row["CTR"] != null)
                {
                    model.CTR = row["CTR"].ToString();
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
                if (row["KCMC"] != null)
                {
                    model.KCMC = row["KCMC"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZSLYMC,ZSLY_BZ,EJZBBH,ZSDYMC,ZSDY_BZ,ZSDMC,ZSD_BZ,ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ,KCBH,CTSJ,CTR,SFSC,KCMC,SFZDYJ ");
            strSql.Append(" FROM STZSDView ");
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
            strSql.Append(" ZSLYMC,ZSLY_BZ,EJZBBH,ZSDYMC,ZSDY_BZ,ZSDMC,ZSD_BZ,ZSLYBH,ZSDYBH,ZSDBH,STBH,ZSDBZ,KCBH,CTSJ,CTR,SFSC,KCMC,SFZDYJ ");
            strSql.Append(" FROM STZSDView ");
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
            strSql.Append("select count(1) FROM STZSDView ");
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
            strSql.Append(")AS Row, T.*  from STZSDView T ");
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
            parameters[0].Value = "STZSDView";
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
        /// 通过试题编号获取具体的知识点
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <returns>试题知识点数组</returns>
        public STZSDView[] getbySTBH(int stbh)
        {
            string sqlString = "select * from stzsdview where stbh=@stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@stbh",stbh)
                           };


            List<STZSDView> stzsdList = new List<STZSDView>();


            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                 

                stzsdList.Add(DataRowToModel(row));

            }
            
            return stzsdList.ToArray();
        }
        /// <summary>
        /// 获取未做过的试题
        /// </summary>
        /// <param name="kcbh">课程编号</param>
        /// <param name="xsbh">学生编号</param>
        /// <returns>未完成试题对象数组</returns>
        public ST_Undone[] getST_Undone(int kcbh, string xsbh)
        {
            string sqlString = "select * from stzsdview where kcbh=@kcbh and stbh not in (select stbh from pcjl where xsbh=@xsbh) order by stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",kcbh),
                new SqlParameter("@xsbh",xsbh)
                           };


            List<ST_Undone> stundoneList = new List<ST_Undone>();


            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            int stbh = -1;
            ST_Undone st_undone=null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (stbh == -1) {  //第一次初始化

                    st_undone = new ST_Undone();
                    st_undone.Stbh = int.Parse(row["stbh"].ToString());
                    st_undone.ZsdbhList.Add(int.Parse(row["zsdbh"].ToString()));
                    stbh = st_undone.Stbh;

                } else if (int.Parse(row["stbh"].ToString()) == stbh) {//如果还是一道题的情况下

                    st_undone.ZsdbhList.Add(int.Parse(row["zsdbh"].ToString()));
                }
                else {
                    stundoneList.Add(st_undone);//先将上一道题加入list
                    st_undone = new ST_Undone();
                    st_undone.Stbh=int.Parse(row["stbh"].ToString());
                    st_undone.ZsdbhList.Add(int.Parse(row["zsdbh"].ToString()));
                    stbh = st_undone.Stbh;
                }
                

            }
            if (ds.Tables[0].Rows.Count > 0) {
                stundoneList.Add(st_undone);//最后一道题加入list
            }
            
            return stundoneList.ToArray();
        }
        /// <summary>
        /// 获取未下载过的知识点
        /// </summary>
        /// <param name="kcbh"></param>
        /// <param name="xsbh"></param>
        /// <returns></returns>
        public int[] getZSD_Undone(int kcbh, string xsbh)
        {
            string sqlString = "select distinct zsdbh from stzsdview where kcbh=@kcbh and zsdbh not in (select distinct zsdbh from pcjlzsdview where xsbh=@xsbh)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",kcbh),
                new SqlParameter("@xsbh",xsbh)
                           };


            List<int> zsdundoneList = new List<int>();


            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                zsdundoneList.Add(int.Parse(row["zsdbh"].ToString()));

            }

            return zsdundoneList.ToArray();
        }
        /// <summary>
        /// 获取未完成的知识点（包括没有下载的和下载了的但是没有做的）
        /// </summary>
        /// <param name="kcbh"></param>
        /// <param name="xsbh"></param>
        /// <returns></returns>
        public int[] getZSD_Unfinished(int kcbh, string xsbh)
        {
            string sqlString = "select distinct zsdbh from stzsdview where kcbh=@kcbh and zsdbh not in (select distinct zsdbh from pcjlzsdview where xsbh=@xsbh and xsstda IS NOT NULL)";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",kcbh),
                new SqlParameter("@xsbh",xsbh)
                           };


            List<int> zsdundoneList = new List<int>();


            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                zsdundoneList.Add(int.Parse(row["zsdbh"].ToString()));

            }

            return zsdundoneList.ToArray();
        }
        /// <summary>
        /// 获取该门课程下的知识点总数
        /// </summary>
        /// <param name="kcbh">课程编号</param>
        /// <returns>知识点数目</returns>
        public int getZSDCountbyKCBH(int kcbh)
        {
            string sqlString = "select count( distinct zsdbh) as zsdcount from stzsdview where kcbh=@kcbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",kcbh)
                           };
         

            int zsdcount=-1;
            DataSet ds = DbHelperSQL.Query(sqlString, sqlparameters);
            if(ds.Tables[0].Rows.Count>0)
            {
                zsdcount = int.Parse(ds.Tables[0].Rows[0]["zsdcount"].ToString());

            }

            return zsdcount;
        }
		#endregion  ExtensionMethod
	}
}

