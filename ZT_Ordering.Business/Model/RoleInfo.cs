using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// RoleInfo:角色信息
	/// </summary>
	[Serializable]
    public partial class RoleInfo
    {
        public RoleInfo()
        { }
        #region Model
        private int _id;
        private string _rolename;
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
        /// 角色名称
        /// </summary>
        public string roleName
        {
            set { _rolename = value; }
            get { return _rolename; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool enable
        {
            set { _enable = value; }
            get { return _enable; }
        }
        #endregion Model

    }
}


