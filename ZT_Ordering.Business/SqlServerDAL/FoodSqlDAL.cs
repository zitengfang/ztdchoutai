﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZT_Ordering.Business.IDAL;
using ZT_Ordering.Business.Model;
using ZT_Ordering.Common;

namespace ZT_Ordering.Business.SqlServerDAL
{
    /// <summary>
    /// 数据访问类:FoodSqlDAL
    /// </summary>
    public partial class FoodSqlDAL : IFood
    {
        public FoodSqlDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Food");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            return MSSqlHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Food model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Food(");
            strSql.Append("foodTypeId,merchantCode,name,price,description,addTime,displayOrder,status)");
            strSql.Append(" values (");
            strSql.Append("@foodTypeId,@merchantCode,@name,@price,@description,@addTime,@displayOrder,@status)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@foodTypeId", SqlDbType.Int,4),
                    new SqlParameter("@merchantCode", SqlDbType.UniqueIdentifier,16),
                    new SqlParameter("@name", SqlDbType.VarChar,30),
                    new SqlParameter("@price", SqlDbType.Decimal,9),
                    new SqlParameter("@description", SqlDbType.VarChar,200),
                    new SqlParameter("@addTime", SqlDbType.DateTime),
                    new SqlParameter("@displayOrder", SqlDbType.Int,4),
                    new SqlParameter("@status", SqlDbType.Int,4)};
            parameters[0].Value = model.foodTypeId;
            parameters[1].Value = Guid.NewGuid();
            parameters[2].Value = model.name;
            parameters[3].Value = model.price;
            parameters[4].Value = model.description;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.displayOrder;
            parameters[7].Value = model.status;

            object obj = MSSqlHelper.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Food model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Food set ");
            strSql.Append("foodTypeId=@foodTypeId,");
            strSql.Append("merchantCode=@merchantCode,");
            strSql.Append("name=@name,");
            strSql.Append("price=@price,");
            strSql.Append("description=@description,");
            strSql.Append("addTime=@addTime,");
            strSql.Append("displayOrder=@displayOrder,");
            strSql.Append("status=@status");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@foodTypeId", SqlDbType.Int,4),
                    new SqlParameter("@merchantCode", SqlDbType.UniqueIdentifier,16),
                    new SqlParameter("@name", SqlDbType.VarChar,30),
                    new SqlParameter("@price", SqlDbType.Decimal,9),
                    new SqlParameter("@description", SqlDbType.VarChar,200),
                    new SqlParameter("@addTime", SqlDbType.DateTime),
                    new SqlParameter("@displayOrder", SqlDbType.Int,4),
                    new SqlParameter("@status", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.foodTypeId;
            parameters[1].Value = model.merchantCode;
            parameters[2].Value = model.name;
            parameters[3].Value = model.price;
            parameters[4].Value = model.description;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.displayOrder;
            parameters[7].Value = model.status;
            parameters[8].Value = model.id;

            int rows = MSSqlHelper.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Food ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = MSSqlHelper.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Food ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = MSSqlHelper.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Food GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,foodTypeId,merchantCode,name,price,description,addTime,displayOrder,status from Food ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Food model = new Food();
            DataSet ds = MSSqlHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Food DataRowToModel(DataRow row)
        {
            Food model = new Food();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["foodTypeId"] != null && row["foodTypeId"].ToString() != "")
                {
                    model.foodTypeId = int.Parse(row["foodTypeId"].ToString());
                }
                if (row["merchantCode"] != null && row["merchantCode"].ToString() != "")
                {
                    model.merchantCode = new Guid(row["merchantCode"].ToString());
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["price"] != null && row["price"].ToString() != "")
                {
                    model.price = decimal.Parse(row["price"].ToString());
                }
                if (row["description"] != null)
                {
                    model.description = row["description"].ToString();
                }
                if (row["addTime"] != null && row["addTime"].ToString() != "")
                {
                    model.addTime = DateTime.Parse(row["addTime"].ToString());
                }
                if (row["displayOrder"] != null && row["displayOrder"].ToString() != "")
                {
                    model.displayOrder = int.Parse(row["displayOrder"].ToString());
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,foodTypeId,merchantCode,name,price,description,addTime,displayOrder,status ");
            strSql.Append(" FROM Food ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return MSSqlHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,foodTypeId,merchantCode,name,price,description,addTime,displayOrder,status ");
            strSql.Append(" FROM Food ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return MSSqlHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Food ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = MSSqlHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from Food T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return MSSqlHelper.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Food";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return MSSqlHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

