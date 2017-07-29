using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// MerchantPayPattern: 商户支付模式（例如：先吃饭后付款）
	/// </summary>
	[Serializable]
    public partial class MerchantPayPattern
    {
        public MerchantPayPattern()
        { }
        #region Model
        private int _id;
        private Guid _merchantcode;
        private int? _paypatternid;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 商家 编码
        /// </summary>
        public Guid merchantCode
        {
            set { _merchantcode = value; }
            get { return _merchantcode; }
        }
        /// <summary>
        ///  付款模式id（外键）
        /// </summary>
        public int? payPatternId
        {
            set { _paypatternid = value; }
            get { return _paypatternid; }
        }
        #endregion Model

    }
}

