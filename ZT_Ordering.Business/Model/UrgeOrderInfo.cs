using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// UrgeOrderInfo:催单信息
    /// </summary>
    [Serializable]
    public partial class UrgeOrderInfo
    {
        public UrgeOrderInfo()
        { }
        #region Model
        private int _id;
        private int? _orderinfoid;
        private DateTime? _createtime;
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
        public int? orderInfoId
        {
            set { _orderinfoid = value; }
            get { return _orderinfoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model

    }
}

