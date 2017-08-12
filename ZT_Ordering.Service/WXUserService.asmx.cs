using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using ZT_Ordering.Business.BLL;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Service
{
    /// <summary>
    /// 微信用户（WXUserService）接口服务 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WXUserService : System.Web.Services.WebService
    {
        UserInfoBLL userInfoBll = new UserInfoBLL();

        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "验证用户登录")]
        public string CheckLogin(string WXNum, string loginName, string pwd)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(WXNum) && !string.IsNullOrEmpty(loginName) && !string.IsNullOrEmpty(pwd))
            {
                //对密码进行MD5加密
                byte[] resultBT = Encoding.Default.GetBytes(pwd);  
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(resultBT);
                string newPwd = BitConverter.ToString(output).Replace("-", ""); 
                //组装查询条件 
                string strWhere = " weChatCode='"+WXNum+ "' and name='"+loginName+"' and password='"+newPwd+"'";
                //调用接口获取满足条件的用户信息
                List<UserInfo> userList = userInfoBll.GetModelList(strWhere);
                if (userList !=null && userList.Count==1)
                {
                    //转换为json格式
                    result = JsonConvert.SerializeObject(userList[0]);
                }
            }

            return result;
        }
    }
}
