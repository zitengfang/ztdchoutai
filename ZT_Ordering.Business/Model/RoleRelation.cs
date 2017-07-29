using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// RoleRelation:管理员角色关系
	/// </summary>
	[Serializable]
    public partial class RoleRelation
    {
        public RoleRelation()
        { }
        #region Model
        private int _id;
        private int? _adminid;
        private int? _roleid;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 管理员Id
        /// </summary>
        public int? adminId
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public int? roleId
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        #endregion Model

    }
}


