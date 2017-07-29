using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// ImageType:图片类别 实体类
    /// </summary>
    [Serializable]
    public partial class ImageType
    {
        public ImageType()
        { }
        #region Model
        private int _id;
        private string _name;
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
        public string name
        {
            set { _name = value; }
            get { return _name; }
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

