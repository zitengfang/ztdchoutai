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
    /// 微信用户 业务逻辑操作类
    /// </summary>
    public class UserInfoBLL
    {
        /// <summary>
        /// 初始化抽象工厂
        /// </summary>
        AbstractFactory factory = AbstractFactory.ChooseFactory();
        public UserInfoBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return factory.GetUserInfoDAL().Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(UserInfo model)
        {
            return factory.GetUserInfoDAL().Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UserInfo model)
        {
            return factory.GetUserInfoDAL().Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return factory.GetUserInfoDAL().Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return factory.GetUserInfoDAL().DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfo GetModel(int id)
        {

            return factory.GetUserInfoDAL().GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return factory.GetUserInfoDAL().GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return factory.GetUserInfoDAL().GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<UserInfo> GetModelList(string strWhere)
        {
            DataSet ds = factory.GetUserInfoDAL().GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<UserInfo> DataTableToList(DataTable dt)
        {
            List<UserInfo> modelList = new List<UserInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                UserInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = factory.GetUserInfoDAL().DataRowToModel(dt.Rows[n]);
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
            return factory.GetUserInfoDAL().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return factory.GetUserInfoDAL().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return factory.GetUserInfoDAL().GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


