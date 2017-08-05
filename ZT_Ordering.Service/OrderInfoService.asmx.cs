using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using ZT_Ordering.Business.BLL;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Service
{
    /// <summary>
    /// OrderInfoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class OrderInfoService : System.Web.Services.WebService
    {

        OrderInfoBLL orderInfoBll = new OrderInfoBLL();

        #region 查询

        /// <summary>
        /// 分页获取用户订单信息
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页条数</param>
        /// <returns></returns>
        [WebMethod(Description = "分页获取用户订单信息")]
        public string GetListByUserIdForPage(string userId, string pageIndex, string pageSize)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(pageIndex) && !string.IsNullOrEmpty(pageSize))
            {
                //获取列表
                DataSet DSList = orderInfoBll.GetListByPage(userId,"", Convert.ToInt32(pageIndex), Convert.ToInt32(pageSize));

                if (DSList != null && DSList.Tables.Count > 0)
                {
                    //转换为json字符串
                    List<OrderInfo> listResult = orderInfoBll.DataTableToList(DSList.Tables[0]);

                    result = JsonConvert.SerializeObject(listResult);
                }
            }

            return result;
        }

        /// <summary>
        /// 分页获取商家的订单记录
        /// </summary>
        /// <param name="merchantCode"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [WebMethod(Description = "分页获取商家的订单记录")]
        public string GetListByMerchantForPage(string merchantCode, string pageIndex, string pageSize)
        {
            string result = string.Empty;
            
            //判断各参数是否有效
            if (!string.IsNullOrEmpty(pageIndex) && !string.IsNullOrEmpty(pageSize)  && !string.IsNullOrEmpty(merchantCode))
            {
                string strWhere = " merchantCode ='"+merchantCode+"'";

                //获取列表
                DataSet DSList = orderInfoBll.GetListByPage(strWhere,"", Convert.ToInt32(pageIndex), Convert.ToInt32(pageSize));

                if (DSList != null && DSList.Tables.Count > 0)
                {
                    //转换为json字符串
                    List<OrderInfo> listResult = orderInfoBll.DataTableToList(DSList.Tables[0]);

                    result = JsonConvert.SerializeObject(listResult);
                }
            }             

            return result;
        }

        #endregion


        #region 编辑

        /// <summary>
        /// 生成订单
        /// </summary>
        /// <param name="orderJson"></param>
        /// <returns></returns>
        [WebMethod(Description = "生成订单")]
        public string CreateOrder(string orderJson)
        {
            string result = string.Empty;


            return result;        
        }

        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [WebMethod(Description = "修改订单状态")]
        public string UpdateStatus(string orderNumber, string status)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(orderNumber))
            {
                //根据编号 获取对象
                OrderInfo orderInfo = orderInfoBll.GetModel(orderNumber);
                orderInfo.status =Convert.ToInt32(status);

                //修改订单，返回true/false
                if (orderInfoBll.Update(orderInfo))
                {
                    result = "{\"result\":\"success\"}";
                } else
                {
                    result = "{\"result\":\"false\"}";
                }
            }           
            return result;
        }

        #endregion

    }
}
