using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// AdminMerchantRelation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class AdminMerchantRelation
    {
        public AdminMerchantRelation()
        { }
        #region Model
        private int _id;
        private int? _adminid;
        private int? _merchantid;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? adminId
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? merchantId
        {
            set { _merchantid = value; }
            get { return _merchantid; }
        }
        #endregion Model

    }
}


