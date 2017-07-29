using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.IDAL;
using ZT_Ordering.Business.SqlServerDAL;

namespace ZT_Ordering.Business.BLL
{
    /// <summary>
    /// 根据不同数据库进行路由分配
    /// </summary>
    public class SQLDALFactory : AbstractFactory
    {
        /// <summary>
        /// 重载父方法，返回对应DAL类对象
        /// </summary>
        /// <returns></returns>
        public override IAdministrator GetAdministratorDAL()
        {
            return new AdministratorSqlDAL();
        }

        /// <summary>
        /// 重载父方法，返回对应DAL类对象
        /// </summary>
        /// <returns></returns>
        public override IAdminMerchantRelation GetAdminMerchantRelationDAL()
        {
            return new AdminMerchantRelationSqlDAL();
        }

        /// <summary>
        /// 重载父方法，返回对应DAL类对象
        /// </summary>
        /// <returns></returns>
        public override IFood GetFoodDAL()
        {
            return new FoodSqlDAL();
        }

        /// <summary>
        /// 菜品图片信息关联表
        /// </summary>
        /// <returns></returns>
        public override IFoodImageInfoRelation GetFoodImageInfoRelationDAL()
        {
            return new FoodImageInfoRelationSqlDAL();
        }


        /// <summary>
        /// 菜品订单信息关联表
        /// </summary>
        /// <returns></returns>
        public override IFoodOrderRelation GetFoodOrderRelationDAL()
        {
            return new FoodOrderRelationSqlDAL();
        }

        /// <summary>
        /// 菜品类别表
        /// </summary>
        /// <returns></returns>
        public override IFoodType GetFoodTypeDAL()
        {
            return new FoodTypeSqlDAL();
        }

        /// <summary>
        /// 图片信息
        /// </summary>
        /// <returns></returns>
        public override IImageInfo GetImageInfoDAL()
        {
            return new ImageInfoSqlDAL();
        }


        /// <summary>
        /// 图片类别
        /// </summary>
        /// <returns></returns>
        public override IImageType GetImageTypeDAL()
        {
            return new ImageTypeSqlDAL();
        }

        /// <summary>
        /// 发票信息
        /// </summary>
        /// <returns></returns>
        public override IInvoice GetInvoiceDAL()
        {
            return new InvoiceSqlDAL();
        }

        /// <summary>
        /// 商家信息
        /// </summary>
        /// <returns></returns>
        public override IMerchant GetMerchantDAL()
        {
            return new MerchantSqlDAL();
        }

        /// <summary>
        /// 商家图片信息关系
        /// </summary>
        /// <returns></returns>
        public override IMerchantImageRelation GetMerchantImageRelationDAL()
        {
            return new MerchantImageRelationSqlDAL();
        }

        /// <summary>
        /// 商家支付方式
        /// </summary>
        /// <returns></returns>
        public override IMerchantPayPattern GetMerchantPayPatternDAL()
        {
            return new MerchantPayPatternSqlDAL();
        }

        /// <summary>
        /// 订单信息
        /// </summary>
        /// <returns></returns>
        public override IOrderInfo GetOrderInfoDAL()
        {
            return new OrderInfoSqlDAL();
        }

        /// <summary>
        /// 支付方式
        /// </summary>
        /// <returns></returns>
        public override IPayMode GetPayModeDAL()
        {
            return new PayModeSqlDAL();
        }

        /// <summary>
        /// 支付模式（商家自定义）
        /// </summary>
        /// <returns></returns>
        public override IPayPattern GetPayPatternDAL()
        {
            return new PayPatternSqlDAL();
        }

        /// <summary>
        /// 角色信息
        /// </summary>
        /// <returns></returns>
        public override IRoleInfo GetRoleInfoDAL()
        {
            return new RoleInfoSqlDAL();
        }

        /// <summary>
        /// 角色关系表
        /// </summary>
        /// <returns></returns>
        public override IRoleRelation GetRoleRelationDAL()
        {
            return new RoleRelationSqlDAL();
        }

        /// <summary>
        /// 餐桌信息
        /// </summary>
        /// <returns></returns>
        public override ITableInfo GetTableInfoDAL()
        {
            return new TableInfoSqlDAL();
        }

        /// <summary>
        /// 催单信息
        /// </summary>
        /// <returns></returns>
        public override IUrgeOrderInfo GetUrgeOrderInfoDAL()
        {
            return new UrgeOrderInfoSqlDAL();
        }

        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        public override IUserInfo GetUserInfoDAL()
        {
            return new UserInfoSqlDAL();
        }

        /// <summary>
        /// 微信信息
        /// </summary>
        /// <returns></returns>
        public override IWeChatUserInfo GetWeChatUserInfoDAL()
        {
            return new WeChatUserInfoSqlDAL();
        }



    }
}
