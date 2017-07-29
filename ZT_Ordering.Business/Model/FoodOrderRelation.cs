using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// FoodOrderRelation:菜品订单关联实体类
	/// </summary>
	[Serializable]
    public partial class FoodOrderRelation
    {
        public FoodOrderRelation()
        { }
        #region Model
        private int _id;
        private int? _orderinfoid;
        private int? _foodid;
        private int? _count;
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
        public int? foodId
        {
            set { _foodid = value; }
            get { return _foodid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? count
        {
            set { _count = value; }
            get { return _count; }
        }
        #endregion Model

    }
}


