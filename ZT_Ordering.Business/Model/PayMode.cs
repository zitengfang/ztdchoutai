using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// PayMode: 支付方式信息
    /// </summary>
    [Serializable]
    public partial class PayMode
    {
        public PayMode()
        { }
        #region Model
        private int _id;
        private string _name;
        private bool _enable;
        private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 名称
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
        /// 备注
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}

