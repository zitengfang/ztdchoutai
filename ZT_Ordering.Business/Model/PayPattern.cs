using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// PayPattern:商家支付模式（例如：先付款） 
	/// </summary>
	[Serializable]
    public partial class PayPattern
    {
        public PayPattern()
        { }
        #region Model
        private int _id;
        private string _pattern;
        private bool _enable;
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
        public string pattern
        {
            set { _pattern = value; }
            get { return _pattern; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool enable
        {
            set { _enable = value; }
            get { return _enable; }
        }
        #endregion Model

    }
}


