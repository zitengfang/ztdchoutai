using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// OrderInfo(订单信息):实体类
	/// </summary>
	[Serializable]
    public partial class OrderInfo
    {
        public OrderInfo()
        { }
        #region Model
        private int _id;
        private string _number;
        private DateTime? _createtime;
        private int? _status;
        private string _remark;
        private int? _paymodeid;
        private Guid _merchantcode;
        private int? _userid;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 编号
        /// </summary>
        public string number
        {
            set { _number = value; }
            get { return _number; }
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
        /// 状态
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        ///   备注
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        ///  支付方式
        /// </summary>
        public int? payModeId
        {
            set { _paymodeid = value; }
            get { return _paymodeid; }
        }
        /// <summary>
        ///  商家编码
        /// </summary>
        public Guid merchantCode
        {
            set { _merchantcode = value; }
            get { return _merchantcode; }
        }
        /// <summary>
        ///  用户id
        /// </summary>
        public int? userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        #endregion Model

    }
}


