using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.BLL
{
    public class AdminMerchantRelationBLL
    {
        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();
        public AdminMerchantRelationBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetAdminMerchantRelationDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZT_Ordering.Business.Model.AdminMerchantRelation model)
        {
            return factory.GetAdminMerchantRelationDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ZT_Ordering.Business.Model.AdminMerchantRelation model)
        {
            return factory.GetAdminMerchantRelationDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetAdminMerchantRelationDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetAdminMerchantRelationDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZT_Ordering.Business.Model.AdminMerchantRelation GetModel(int id)
        {

            return factory.GetAdminMerchantRelationDAL().GetModel(id);
        }

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetAdminMerchantRelationDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetAdminMerchantRelationDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ZT_Ordering.Business.Model.AdminMerchantRelation> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetAdminMerchantRelationDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ZT_Ordering.Business.Model.AdminMerchantRelation> DataTableToList(DataTable dt)
        {
            List<ZT_Ordering.Business.Model.AdminMerchantRelation> modelList = new List<ZT_Ordering.Business.Model.AdminMerchantRelation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ZT_Ordering.Business.Model.AdminMerchantRelation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetAdminMerchantRelationDAL().DataRowToModel(dt.Rows[n]);
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
            return factory.GetAdminMerchantRelationDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetAdminMerchantRelationDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetAdminMerchantRelationDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
