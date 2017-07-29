using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// FoodImageInfoRelation：菜品图片关联表
	/// </summary>
	[Serializable]
    public partial class FoodImageInfoRelation
    {
        public FoodImageInfoRelation()
        { }
        #region Model
        private int _id;
        private Guid _foodcode;
        private int? _imageinfoid;
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
        public Guid foodCode
        {
            set { _foodcode = value; }
            get { return _foodcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? imageInfoId
        {
            set { _imageinfoid = value; }
            get { return _imageinfoid; }
        }
        #endregion Model

    }
}


