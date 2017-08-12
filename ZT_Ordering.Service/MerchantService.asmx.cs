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
    /// MerchantService:商户信息服务文件
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class MerchantService : System.Web.Services.WebService
    {
        MerchantBLL merchantBll = new MerchantBLL();//商家
        FoodBLL foodBll = new FoodBLL();//菜品
        OrderInfoBLL orderInfoBll = new OrderInfoBLL();//订单
        MerchantPayPatternBLL merchantPayPatternBll = new MerchantPayPatternBLL();//商家支付模式
        PaymentAccountBLL paymentAccountBll = new PaymentAccountBLL();//商户支付家户

        /// <summary>
        /// 
        /// </summary>
        /// <param name="merchantCode"></param>
        /// <returns></returns>
        [WebMethod(Description ="根据编码获取商家信息")]
        public string GetMerchantByCode(string merchantCode)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(merchantCode))
            {
                Merchant merchant = merchantBll.GetMerchantByCode(merchantCode);

                if (merchant !=null)
                {
                    result= JsonConvert.SerializeObject(merchant);
                }
            }

            return result;
        }

        /// <summary>
        /// 根据商家编号分页获取菜品信息
        /// </summary>
        /// <param name="merchantCode"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSie"></param>
        /// <returns></returns>
        [WebMethod(Description ="根据商家编号分页获取菜品信息")]
        public string GetFoodListByMerchantCode(string merchantCode,string pageIndex,string pageSize)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(pageIndex) && !string.IsNullOrEmpty(pageSize))
            {
                //获取列表
                DataSet DSList = foodBll.GetListByPage("merchantCode =" + merchantCode, "", Convert.ToInt32(pageIndex), Convert.ToInt32(pageSize));

                if (DSList != null && DSList.Tables.Count > 0)
                {
                    //转换为json字符串
                    List<Food> listResult = foodBll.DataTableToList(DSList.Tables[0]);

                    result = JsonConvert.SerializeObject(listResult);
                }
            }

            return result;
        }      

        /// <summary>
        /// 根据商家编号获取支付模式（例如：先吃饭后付款）
        /// </summary>
        /// <param name="merchantCode"></param>
        /// <returns></returns>
        [WebMethod(Description = "根据商家编号获取支付模式（例如：先吃饭后付款）")]
        public string GetPayPatternByMerchantCode(string merchantCode)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(merchantCode))
            {
                //获取列表
                DataSet DSList = merchantPayPatternBll.GetList("merchantCode =" + merchantCode);

                if (DSList != null && DSList.Tables.Count > 0)
                {
                    //转换为json字符串
                    List<MerchantPayPattern> listResult = merchantPayPatternBll.DataTableToList(DSList.Tables[0]);

                    result = JsonConvert.SerializeObject(listResult);
                }
            }

            return result;
        }


        /// <summary>
        /// 获取商家 支付账户信息
        /// </summary>
        /// <param name="merchantCode"></param>
        /// <returns></returns>
        public string GetPaymentAccountByMerchantCode(string merchantCode)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(merchantCode))
            {
                //获取列表
                DataSet DSList = paymentAccountBll.GetList("merchantCode =" + merchantCode);

                if (DSList != null && DSList.Tables.Count > 0)
                {
                    //转换为json字符串
                    List<PaymentAccount> listResult = paymentAccountBll.DataTableToList(DSList.Tables[0]);

                    result = JsonConvert.SerializeObject(listResult);
                }
            }

            return result;
        }
    }
}
