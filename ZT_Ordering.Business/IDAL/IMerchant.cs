﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.Model;

namespace ZT_Ordering.Business.IDAL
{
    /// <summary>
	/// 接口层Merchant：商家
	/// </summary>
	public interface IMerchant
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Merchant model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Merchant model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int id);
        bool DeleteList(string idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Merchant GetModel(int id);
        Merchant DataRowToModel(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据编码获取商家信息
        /// </summary>
        Merchant GetMerchantByCode(string code);
        #endregion  成员方法
        #region  MethodEx

        #endregion  MethodEx
    }
}

