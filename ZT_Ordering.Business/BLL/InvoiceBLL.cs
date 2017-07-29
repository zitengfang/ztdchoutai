﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Business.BLL
{
    public class InvoiceBLL
    {
        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();

        public InvoiceBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetInvoiceDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Invoice model)
        {
            return factory.GetInvoiceDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Invoice model)
        {
            return factory.GetInvoiceDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetInvoiceDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetInvoiceDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Invoice GetModel(int id)
        {

            return factory.GetInvoiceDAL().GetModel(id);
        }      

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetInvoiceDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetInvoiceDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Invoice> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetInvoiceDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Invoice> DataTableToList(DataTable dt)
        {
            List<Invoice> modelList = new List<Invoice>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Invoice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetInvoiceDAL().DataRowToModel(dt.Rows[n]);
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
            return factory.GetInvoiceDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetInvoiceDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetInvoiceDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


