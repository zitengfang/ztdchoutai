﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Business.BLL
{
    /// <summary>
    /// 催单信息 业务操作类
    /// </summary>
    public class UrgeOrderInfoBLL
    {

        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();
        public UrgeOrderInfoBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetUrgeOrderInfoDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(UrgeOrderInfo model)
        {
            return factory.GetUrgeOrderInfoDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UrgeOrderInfo model)
        {
            return factory.GetUrgeOrderInfoDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetUrgeOrderInfoDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetUrgeOrderInfoDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UrgeOrderInfo GetModel(int id)
        {

            return factory.GetUrgeOrderInfoDAL().GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetUrgeOrderInfoDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetUrgeOrderInfoDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<UrgeOrderInfo> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetUrgeOrderInfoDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<UrgeOrderInfo> DataTableToList(DataTable dt)
        {
            List<UrgeOrderInfo> modelList = new List<UrgeOrderInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                UrgeOrderInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetUrgeOrderInfoDAL().DataRowToModel(dt.Rows[n]);
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
            return factory.GetUrgeOrderInfoDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetUrgeOrderInfoDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetUrgeOrderInfoDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


