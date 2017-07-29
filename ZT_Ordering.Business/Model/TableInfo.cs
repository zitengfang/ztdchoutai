using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// TableInfo:餐桌信息
    /// </summary>
    [Serializable]
    public partial class TableInfo
    {
        public TableInfo()
        { }
        #region Model
        private int _id;
        private Guid _code;
        private string _name;
        private int? _personcount;
        private Guid _merchantcode;
        private bool _enable;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public Guid code
        {
            set { _code = value; }
            get { return _code; }
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
        /// 人数
        /// </summary>
        public int? personCount
        {
            set { _personcount = value; }
            get { return _personcount; }
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
        ///  是否启用
        /// </summary>
        public bool enable
        {
            set { _enable = value; }
            get { return _enable; }
        }
        #endregion Model

    }
}


