using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// MerchantImageRelation:商家图片关系   实体类 
    /// </summary>
    [Serializable]
    public partial class MerchantImageRelation
    {
        public MerchantImageRelation()
        { }
        #region Model
        private int _id;
        private Guid _merchantcode;
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
        /// 商家编码
        /// </summary>
        public Guid merchantCode
        {
            set { _merchantcode = value; }
            get { return _merchantcode; }
        }
        /// <summary>
        /// 图片id
        /// </summary>
        public int? imageInfoId
        {
            set { _imageinfoid = value; }
            get { return _imageinfoid; }
        }
        #endregion Model

    }
}


