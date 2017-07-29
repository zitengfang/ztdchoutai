using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// Invoice:发票 实体类
	/// </summary>
	[Serializable]
    public partial class Invoice
    {
        public Invoice()
        { }
        #region Model
        private int _id;
        private int? _orderinfoid;
        private string _title;
        private string _paytaxesnumber;
        private DateTime? _createtime;
        private bool _ishandle;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单id
        /// </summary>
        public int? orderInfoId
        {
            set { _orderinfoid = value; }
            get { return _orderinfoid; }
        }
        /// <summary>
        /// 抬头
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        ///  纳税人识别号
        /// </summary>
        public string payTaxesNumber
        {
            set { _paytaxesnumber = value; }
            get { return _paytaxesnumber; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 是否已开
        /// </summary>
        public bool isHandle
        {
            set { _ishandle = value; }
            get { return _ishandle; }
        }
        #endregion Model

    }
}


