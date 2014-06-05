using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// NJ:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [Serializable]
    public partial class NJ
    {
        public NJ()
        { }
        #region Model
        private int _njbh;
        private string _njmc;
        private DateTime _rxnf;
        /// <summary>
        /// 
        /// </summary>
        public int NJBH
        {
            set { _njbh = value; }
            get { return _njbh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NJMC
        {
            set { _njmc = value; }
            get { return _njmc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RXNF
        {
            set { _rxnf = value; }
            get { return _rxnf; }
        }
        #endregion Model

    }
}

