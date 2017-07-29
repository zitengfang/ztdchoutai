using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// WeChatUserInfo:微信用户信息
    /// </summary>
    [Serializable]
    public partial class WeChatUserInfo
    {
        public WeChatUserInfo()
        { }
        #region Model
        private int _id;
        private string _wechatcode;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 微信号
        /// </summary>
        public string weChatCode
        {
            set { _wechatcode = value; }
            get { return _wechatcode; }
        }
        #endregion Model

    }
}
