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
    /// 菜品业务逻辑处理
    /// </summary>
    public class FoodBLL
    {
        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();

        public FoodBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetFoodDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Food model)
        {
            return factory.GetFoodDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Food model)
        {
            return factory.GetFoodDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetFoodDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetFoodDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Food GetModel(int id)
        {

            return factory.GetFoodDAL().GetModel(id);
        }       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetFoodDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetFoodDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Food> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetFoodDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Food> DataTableToList(DataTable dt)
        {
            List<Food> modelList = new List<Food>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Food model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetFoodDAL().DataRowToModel(dt.Rows[n]);
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
            return factory.GetFoodDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetFoodDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetFoodDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


