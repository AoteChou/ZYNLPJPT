using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:JDKCXSNewView_DAL
	/// </summary>
	public partial class JDKCXSNewView_DAL
	{
		public JDKCXSNewView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.JDKCXSNewView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JDKCXSNewView(");
			strSql.Append("XSBH,JSBH,JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,JSXM,JSXB,XSXM,XSXB)");
			strSql.Append(" values (");
			strSql.Append("@XSBH,@JSBH,@JDMC,@QSXQ,@JZXQ,@CPJDJJ,@JDBH,@NJBH,@NJMC,@KCJJ,@KCMC,@XKBH,@ZYM,@ZYFZR,@KCBH,@ZYBH,@KCXZBH,@KKXQ,@LLXF,@SJXF,@KCXZMC,@JSXM,@JSXB,@XSXM,@XSXB)");
			SqlParameter[] parameters = {
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.VarChar,50),
					new SqlParameter("@JSXM", SqlDbType.VarChar,50),
					new SqlParameter("@JSXB", SqlDbType.Bit,1),
					new SqlParameter("@XSXM", SqlDbType.VarChar,50),
					new SqlParameter("@XSXB", SqlDbType.Bit,1)};
			parameters[0].Value = model.XSBH;
			parameters[1].Value = model.JSBH;
			parameters[2].Value = model.JDMC;
			parameters[3].Value = model.QSXQ;
			parameters[4].Value = model.JZXQ;
			parameters[5].Value = model.CPJDJJ;
			parameters[6].Value = model.JDBH;
			parameters[7].Value = model.NJBH;
			parameters[8].Value = model.NJMC;
			parameters[9].Value = model.KCJJ;
			parameters[10].Value = model.KCMC;
			parameters[11].Value = model.XKBH;
			parameters[12].Value = model.ZYM;
			parameters[13].Value = model.ZYFZR;
			parameters[14].Value = model.KCBH;
			parameters[15].Value = model.ZYBH;
			parameters[16].Value = model.KCXZBH;
			parameters[17].Value = model.KKXQ;
			parameters[18].Value = model.LLXF;
			parameters[19].Value = model.SJXF;
			parameters[20].Value = model.KCXZMC;
			parameters[21].Value = model.JSXM;
			parameters[22].Value = model.JSXB;
			parameters[23].Value = model.XSXM;
			parameters[24].Value = model.XSXB;

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
		public bool Update(ZYNLPJPT.Model.JDKCXSNewView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JDKCXSNewView set ");
			strSql.Append("XSBH=@XSBH,");
			strSql.Append("JSBH=@JSBH,");
			strSql.Append("JDMC=@JDMC,");
			strSql.Append("QSXQ=@QSXQ,");
			strSql.Append("JZXQ=@JZXQ,");
			strSql.Append("CPJDJJ=@CPJDJJ,");
			strSql.Append("JDBH=@JDBH,");
			strSql.Append("NJBH=@NJBH,");
			strSql.Append("NJMC=@NJMC,");
			strSql.Append("KCJJ=@KCJJ,");
			strSql.Append("KCMC=@KCMC,");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("ZYM=@ZYM,");
			strSql.Append("ZYFZR=@ZYFZR,");
			strSql.Append("KCBH=@KCBH,");
			strSql.Append("ZYBH=@ZYBH,");
			strSql.Append("KCXZBH=@KCXZBH,");
			strSql.Append("KKXQ=@KKXQ,");
			strSql.Append("LLXF=@LLXF,");
			strSql.Append("SJXF=@SJXF,");
			strSql.Append("KCXZMC=@KCXZMC,");
			strSql.Append("JSXM=@JSXM,");
			strSql.Append("JSXB=@JSXB,");
			strSql.Append("XSXM=@XSXM,");
			strSql.Append("XSXB=@XSXB");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JSBH", SqlDbType.VarChar,50),
					new SqlParameter("@JDMC", SqlDbType.VarChar,50),
					new SqlParameter("@QSXQ", SqlDbType.Int,4),
					new SqlParameter("@JZXQ", SqlDbType.Int,4),
					new SqlParameter("@CPJDJJ", SqlDbType.Text),
					new SqlParameter("@JDBH", SqlDbType.Int,4),
					new SqlParameter("@NJBH", SqlDbType.Int,4),
					new SqlParameter("@NJMC", SqlDbType.VarChar,50),
					new SqlParameter("@KCJJ", SqlDbType.Text),
					new SqlParameter("@KCMC", SqlDbType.VarChar,50),
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@ZYM", SqlDbType.VarChar,50),
					new SqlParameter("@ZYFZR", SqlDbType.VarChar,50),
					new SqlParameter("@KCBH", SqlDbType.Int,4),
					new SqlParameter("@ZYBH", SqlDbType.Int,4),
					new SqlParameter("@KCXZBH", SqlDbType.Int,4),
					new SqlParameter("@KKXQ", SqlDbType.Int,4),
					new SqlParameter("@LLXF", SqlDbType.Decimal,9),
					new SqlParameter("@SJXF", SqlDbType.Decimal,9),
					new SqlParameter("@KCXZMC", SqlDbType.VarChar,50),
					new SqlParameter("@JSXM", SqlDbType.VarChar,50),
					new SqlParameter("@JSXB", SqlDbType.Bit,1),
					new SqlParameter("@XSXM", SqlDbType.VarChar,50),
					new SqlParameter("@XSXB", SqlDbType.Bit,1)};
			parameters[0].Value = model.XSBH;
			parameters[1].Value = model.JSBH;
			parameters[2].Value = model.JDMC;
			parameters[3].Value = model.QSXQ;
			parameters[4].Value = model.JZXQ;
			parameters[5].Value = model.CPJDJJ;
			parameters[6].Value = model.JDBH;
			parameters[7].Value = model.NJBH;
			parameters[8].Value = model.NJMC;
			parameters[9].Value = model.KCJJ;
			parameters[10].Value = model.KCMC;
			parameters[11].Value = model.XKBH;
			parameters[12].Value = model.ZYM;
			parameters[13].Value = model.ZYFZR;
			parameters[14].Value = model.KCBH;
			parameters[15].Value = model.ZYBH;
			parameters[16].Value = model.KCXZBH;
			parameters[17].Value = model.KKXQ;
			parameters[18].Value = model.LLXF;
			parameters[19].Value = model.SJXF;
			parameters[20].Value = model.KCXZMC;
			parameters[21].Value = model.JSXM;
			parameters[22].Value = model.JSXB;
			parameters[23].Value = model.XSXM;
			parameters[24].Value = model.XSXB;

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
			strSql.Append("delete from JDKCXSNewView ");
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
		public ZYNLPJPT.Model.JDKCXSNewView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XSBH,JSBH,JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,JSXM,JSXB,XSXM,XSXB from JDKCXSNewView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.JDKCXSNewView model=new ZYNLPJPT.Model.JDKCXSNewView();
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
		public ZYNLPJPT.Model.JDKCXSNewView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.JDKCXSNewView model=new ZYNLPJPT.Model.JDKCXSNewView();
			if (row != null)
			{
				if(row["XSBH"]!=null)
				{
					model.XSBH=row["XSBH"].ToString();
				}
				if(row["JSBH"]!=null)
				{
					model.JSBH=row["JSBH"].ToString();
				}
				if(row["JDMC"]!=null)
				{
					model.JDMC=row["JDMC"].ToString();
				}
				if(row["QSXQ"]!=null && row["QSXQ"].ToString()!="")
				{
					model.QSXQ=int.Parse(row["QSXQ"].ToString());
				}
				if(row["JZXQ"]!=null && row["JZXQ"].ToString()!="")
				{
					model.JZXQ=int.Parse(row["JZXQ"].ToString());
				}
				if(row["CPJDJJ"]!=null)
				{
					model.CPJDJJ=row["CPJDJJ"].ToString();
				}
				if(row["JDBH"]!=null && row["JDBH"].ToString()!="")
				{
					model.JDBH=int.Parse(row["JDBH"].ToString());
				}
				if(row["NJBH"]!=null && row["NJBH"].ToString()!="")
				{
					model.NJBH=int.Parse(row["NJBH"].ToString());
				}
				if(row["NJMC"]!=null)
				{
					model.NJMC=row["NJMC"].ToString();
				}
				if(row["KCJJ"]!=null)
				{
					model.KCJJ=row["KCJJ"].ToString();
				}
				if(row["KCMC"]!=null)
				{
					model.KCMC=row["KCMC"].ToString();
				}
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["ZYM"]!=null)
				{
					model.ZYM=row["ZYM"].ToString();
				}
				if(row["ZYFZR"]!=null)
				{
					model.ZYFZR=row["ZYFZR"].ToString();
				}
				if(row["KCBH"]!=null && row["KCBH"].ToString()!="")
				{
					model.KCBH=int.Parse(row["KCBH"].ToString());
				}
				if(row["ZYBH"]!=null && row["ZYBH"].ToString()!="")
				{
					model.ZYBH=int.Parse(row["ZYBH"].ToString());
				}
				if(row["KCXZBH"]!=null && row["KCXZBH"].ToString()!="")
				{
					model.KCXZBH=int.Parse(row["KCXZBH"].ToString());
				}
				if(row["KKXQ"]!=null && row["KKXQ"].ToString()!="")
				{
					model.KKXQ=int.Parse(row["KKXQ"].ToString());
				}
				if(row["LLXF"]!=null && row["LLXF"].ToString()!="")
				{
					model.LLXF=decimal.Parse(row["LLXF"].ToString());
				}
				if(row["SJXF"]!=null && row["SJXF"].ToString()!="")
				{
					model.SJXF=decimal.Parse(row["SJXF"].ToString());
				}
				if(row["KCXZMC"]!=null)
				{
					model.KCXZMC=row["KCXZMC"].ToString();
				}
				if(row["JSXM"]!=null)
				{
					model.JSXM=row["JSXM"].ToString();
				}
				if(row["JSXB"]!=null && row["JSXB"].ToString()!="")
				{
					if((row["JSXB"].ToString()=="1")||(row["JSXB"].ToString().ToLower()=="true"))
					{
						model.JSXB=true;
					}
					else
					{
						model.JSXB=false;
					}
				}
				if(row["XSXM"]!=null)
				{
					model.XSXM=row["XSXM"].ToString();
				}
				if(row["XSXB"]!=null && row["XSXB"].ToString()!="")
				{
					if((row["XSXB"].ToString()=="1")||(row["XSXB"].ToString().ToLower()=="true"))
					{
						model.XSXB=true;
					}
					else
					{
						model.XSXB=false;
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
			strSql.Append("select XSBH,JSBH,JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,JSXM,JSXB,XSXM,XSXB ");
			strSql.Append(" FROM JDKCXSNewView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public JDKCXSNewView[] getArray(int xkbh,int njbh,int kcbh,int jdbh,int zybh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select XSBH,JSBH,JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,JSXM,JSXB,XSXM,XSXB ");
            strSql.Append(" FROM JDKCXSNewView ");
            strSql.Append(" where xkbh="+xkbh);
            strSql.Append(" and jdbh="+jdbh);
            strSql.Append(" and kcbh="+kcbh);
            strSql.Append(" and njbh="+njbh);
            strSql.Append(" and zybh="+zybh);
            DataSet ds=DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            JDKCXSNewView[] jdkcxsNewViews=new JDKCXSNewView[length];
            for (int i = 0; i < length; i++) {
                jdkcxsNewViews[i] = new JDKCXSNewView();
                DataRow row = ds.Tables[0].Rows[i];

                if (row["XSBH"] != null)
                {
                    jdkcxsNewViews[i].XSBH = row["XSBH"].ToString();
                }
                if (row["JSBH"] != null)
                {
                    jdkcxsNewViews[i].JSBH = row["JSBH"].ToString();
                }
                if (row["JDMC"] != null)
                {
                    jdkcxsNewViews[i].JDMC = row["JDMC"].ToString();
                }
                if (row["QSXQ"] != null && row["QSXQ"].ToString() != "")
                {
                    jdkcxsNewViews[i].QSXQ = int.Parse(row["QSXQ"].ToString());
                }
                if (row["JZXQ"] != null && row["JZXQ"].ToString() != "")
                {
                    jdkcxsNewViews[i].JZXQ = int.Parse(row["JZXQ"].ToString());
                }
                if (row["CPJDJJ"] != null || row["CPJDJJ"].ToString() != "" || row["CPJDJJ"].ToString() != "null")
                {
                    jdkcxsNewViews[i].CPJDJJ = row["CPJDJJ"].ToString();
                }
                else {
                    jdkcxsNewViews[i].CPJDJJ = "暂无";
                }
                if (row["JDBH"] != null && row["JDBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].JDBH = int.Parse(row["JDBH"].ToString());
                }
                if (row["NJBH"] != null && row["NJBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].NJBH = int.Parse(row["NJBH"].ToString());
                }
                if (row["NJMC"] != null)
                {
                    jdkcxsNewViews[i].NJMC = row["NJMC"].ToString();
                }
                if (row["KCJJ"] != null || row["KCJJ"].ToString() != null || row["KCJJ"].ToString() != "" || row["KCJJ"].ToString() != "null")
                {
                    jdkcxsNewViews[i].KCJJ = row["KCJJ"].ToString();
                }
                else {
                    jdkcxsNewViews[i].KCJJ = "暂无";
                }
                if (row["KCMC"] != null)
                {
                    jdkcxsNewViews[i].KCMC = row["KCMC"].ToString();
                }
                if (row["XKBH"] != null && row["XKBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].XKBH = int.Parse(row["XKBH"].ToString());
                }
                if (row["ZYM"] != null)
                {
                    jdkcxsNewViews[i].ZYM = row["ZYM"].ToString();
                }
                if (row["ZYFZR"] != null || row["ZYFZR"].ToString() != null || row["ZYFZR"].ToString() != "null" || row["ZYFZR"].ToString() != "")
                {
                    jdkcxsNewViews[i].ZYFZR = row["ZYFZR"].ToString();
                }
                else {
                    jdkcxsNewViews[i].ZYFZR = "暂无";
                }
                if (row["KCBH"] != null && row["KCBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].KCBH = int.Parse(row["KCBH"].ToString());
                }
                if (row["ZYBH"] != null && row["ZYBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].ZYBH = int.Parse(row["ZYBH"].ToString());
                }
                if (row["KCXZBH"] != null && row["KCXZBH"].ToString() != "")
                {
                    jdkcxsNewViews[i].KCXZBH = int.Parse(row["KCXZBH"].ToString());
                }
                if (row["KKXQ"] != null && row["KKXQ"].ToString() != "")
                {
                    jdkcxsNewViews[i].KKXQ = int.Parse(row["KKXQ"].ToString());
                }
                if (row["LLXF"] != null && row["LLXF"].ToString() != "")
                {
                    jdkcxsNewViews[i].LLXF = decimal.Parse(row["LLXF"].ToString());
                }
                if (row["SJXF"] != null && row["SJXF"].ToString() != "")
                {
                    jdkcxsNewViews[i].SJXF = decimal.Parse(row["SJXF"].ToString());
                }
                if (row["KCXZMC"] != null)
                {
                    jdkcxsNewViews[i].KCXZMC = row["KCXZMC"].ToString();
                }
                if (row["JSXM"] != null)
                {
                    jdkcxsNewViews[i].JSXM = row["JSXM"].ToString();
                }
                if (row["JSXB"] != null && row["JSXB"].ToString() != "")
                {
                    if ((row["JSXB"].ToString() == "1") || (row["JSXB"].ToString().ToLower() == "true"))
                    {
                        jdkcxsNewViews[i].JSXB = true;
                    }
                    else
                    {
                        jdkcxsNewViews[i].JSXB = false;
                    }
                }
                if (row["XSXM"] != null)
                {
                    jdkcxsNewViews[i].XSXM = row["XSXM"].ToString();
                }
                if (row["XSXB"] != null && row["XSXB"].ToString() != "")
                {
                    if ((row["XSXB"].ToString() == "1") || (row["XSXB"].ToString().ToLower() == "true"))
                    {
                        jdkcxsNewViews[i].XSXB = true;
                    }
                    else
                    {
                        jdkcxsNewViews[i].XSXB = false;
                    }
                }
            }

            return jdkcxsNewViews;
        }

        public YH[] getGTTeas(int xkbh,int njbh,int kcbh,int jdbh,int zybh){

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct(jsbh),jsxm ");
            strSql.Append(" from jdkcxsNewView ");
            strSql.Append(" where kcbh="+kcbh+" and xkbh="+xkbh+" and njbh="+njbh+" and jdbh="+jdbh+" and zybh="+zybh);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            YH[] yhs=new YH[length];
            for (int i = 0; i < length; i++) {
                yhs[i] = new YH();
                DataRow row=ds.Tables[0].Rows[i];
                yhs[i].YHBH = row["jsbh"].ToString().Trim();
                yhs[i].XM = row["jsxm"].ToString().Trim();
            }
            return yhs;
        }

        public YH[] getGTXSs(int xkbh, int njbh, int kcbh, int jdbh, int zybh, string jsbh) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select xsbh,xsxm ");
            strSql.Append(" from jdkcxsNewView ");
            strSql.Append(" where kcbh=" + kcbh + " and xkbh=" + xkbh + " and njbh=" + njbh + " and jdbh=" + jdbh + " and zybh=" + zybh+" and jsbh='"+jsbh+"'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int length = ds.Tables[0].Rows.Count;
            YH[] yhs = new YH[length];
            for (int i = 0; i < length; i++)
            {
                yhs[i] = new YH();
                DataRow row = ds.Tables[0].Rows[i];
                yhs[i].YHBH = row["xsbh"].ToString().Trim();
                yhs[i].XM = row["xsxm"].ToString().Trim();
            }
            return yhs;
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
			strSql.Append(" XSBH,JSBH,JDMC,QSXQ,JZXQ,CPJDJJ,JDBH,NJBH,NJMC,KCJJ,KCMC,XKBH,ZYM,ZYFZR,KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF,KCXZMC,JSXM,JSXB,XSXM,XSXB ");
			strSql.Append(" FROM JDKCXSNewView ");
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
			strSql.Append("select count(1) FROM JDKCXSNewView ");
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
			strSql.Append(")AS Row, T.*  from JDKCXSNewView T ");
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
			parameters[0].Value = "JDKCXSNewView";
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

