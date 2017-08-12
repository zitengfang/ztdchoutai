using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Business.BLL
{
    /// <summary>
    /// 商家支付账户 业务逻辑操作类
    /// </summary>
    public class PaymentAccountBLL
    {
        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();

        public PaymentAccountBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetPaymentAccountDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(PaymentAccount model)
        {
            return factory.GetPaymentAccountDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PaymentAccount model)
        {
            return factory.GetPaymentAccountDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetPaymentAccountDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetPaymentAccountDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PaymentAccount GetModel(int id)
        {

            return factory.GetPaymentAccountDAL().GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetPaymentAccountDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetPaymentAccountDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PaymentAccount> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetPaymentAccountDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PaymentAccount> DataTableToList(DataTable dt)
        {
            List<PaymentAccount> modelList = new List<PaymentAccount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PaymentAccount model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetPaymentAccountDAL().DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return factory.GetPaymentAccountDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetPaymentAccountDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetPaymentAccountDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

