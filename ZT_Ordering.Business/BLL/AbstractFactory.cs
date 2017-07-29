using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.IDAL;
using ZT_Ordering.Common;

namespace ZT_Ordering.Business.BLL
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 选择数据工厂，根据不同数据库选择对应的处理类，默认SQLServer
        /// </summary>
        /// <returns></returns>
        public static AbstractFactory ChooseFactory()
        {
            //根据不同数据库进行路由
            string dbType = ConfigurationManager.AppSettings["dbtype"];
            switch (dbType)
            {
                case "mssql":
                    MSSqlHelper.connectionString = ConfigurationManager.AppSettings.Get("MSSqlConnection");
                    return new SQLDALFactory();
                case "mysql":
                    MSSqlHelper.connectionString = ConfigurationManager.AppSettings.Get("MySqlConnection");
                    return null;//new MySqlDALFactory();
                default:
                    return new SQLDALFactory();
            }
        }

        #region 抽象方法

        /// <summary>
        ///  管理员抽象方法
        /// </summary>
        /// <returns></returns>        
        public abstract IAdministrator GetAdministratorDAL();

        /// <summary>
        /// 管理员商户关系表
        /// </summary>
        /// <returns></returns>
        public abstract IAdminMerchantRelation GetAdminMerchantRelationDAL();

        /// <summary>
        /// 管理员商户关系表
        /// </summary>
        /// <returns></returns>
        public abstract IFood GetFoodDAL();

        /// <summary>
        /// 菜品图片关联表
        /// </summary>
        /// <returns></returns>
        public abstract IFoodImageInfoRelation GetFoodImageInfoRelationDAL();

        /// <summary>
        /// 菜品订单关联表
        /// </summary>
        /// <returns></returns>
        public abstract IFoodOrderRelation GetFoodOrderRelationDAL();

        /// <summary>
        /// 菜品类别表
        /// </summary>
        /// <returns></returns>
        public abstract IFoodType GetFoodTypeDAL();

        /// <summary>
        /// 图片信息
        /// </summary>
        /// <returns></returns>
        public abstract IImageInfo GetImageInfoDAL();

        /// <summary>
        /// 图片类别
        /// </summary>
        /// <returns></returns>
        public abstract IImageType GetImageTypeDAL();

        /// <summary>
        /// 发票信息
        /// </summary>
        /// <returns></returns>
        public abstract IInvoice GetInvoiceDAL();

        /// <summary>
        /// 商家信息
        /// </summary>
        /// <returns></returns>
        public abstract IMerchant GetMerchantDAL();

        /// <summary>
        /// 商家图片信息关系
        /// </summary>
        /// <returns></returns>
        public abstract IMerchantImageRelation GetMerchantImageRelationDAL();

        /// <summary>
        /// 商家支付方式
        /// </summary>
        /// <returns></returns>
        public abstract IMerchantPayPattern GetMerchantPayPatternDAL();

        /// <summary>
        /// 订单信息
        /// </summary>
        /// <returns></returns>
        public abstract IOrderInfo GetOrderInfoDAL();

        /// <summary>
        /// 支付方式
        /// </summary>
        /// <returns></returns>
        public abstract IPayMode GetPayModeDAL();

        /// <summary>
        /// 支付模式（商家自定义）
        /// </summary>
        /// <returns></returns>
        public abstract IPayPattern GetPayPatternDAL();

        /// <summary>
        /// 角色信息
        /// </summary>
        /// <returns></returns>
        public abstract IRoleInfo GetRoleInfoDAL();

        /// <summary>
        /// 角色关系表
        /// </summary>
        /// <returns></returns>
        public abstract IRoleRelation GetRoleRelationDAL();

        /// <summary>
        /// 餐桌信息
        /// </summary>
        /// <returns></returns>
        public abstract ITableInfo GetTableInfoDAL();

        /// <summary>
        /// 催单信息
        /// </summary>
        /// <returns></returns>
        public abstract IUrgeOrderInfo GetUrgeOrderInfoDAL();

        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        public abstract IUserInfo GetUserInfoDAL();

        /// <summary>
        /// 微信信息
        /// </summary>
        /// <returns></returns>
        public abstract IWeChatUserInfo GetWeChatUserInfoDAL();


        #endregion

    }
}

