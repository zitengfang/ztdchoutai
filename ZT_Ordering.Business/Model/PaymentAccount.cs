using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// PaymentAccount:商家支付账户信息表
	/// </summary>
	[Serializable]
    public partial class PaymentAccount
    {
        public PaymentAccount()
        { }
        #region Model
        private int _id;
        private Guid _merchantcode;
        private string _name;
        private bool _enable;
        private string _account;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 商户编码
        /// </summary>
        public Guid merchantCode
        {
            set { _merchantcode = value; }
            get { return _merchantcode; }
        }
        /// <summary>
        ///  名称
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool enable
        {
            set { _enable = value; }
            get { return _enable; }
        }

        /// <summary>
        /// 账户信息
        /// </summary>
        public string account
        {
            set { _account = value; }
            get { return _account; }
        }

        #endregion Model

    }
}

