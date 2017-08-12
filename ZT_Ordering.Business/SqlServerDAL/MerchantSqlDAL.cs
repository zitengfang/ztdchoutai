using System;
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
    /// 商家 数据操作类
    /// </summary>
    public class MerchantSqlDAL : IMerchant
    {
        public MerchantSqlDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Merchant");
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
        public int Add(Merchant model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Merchant(");
            strSql.Append("code,name,phone,email,address,remark)");
            strSql.Append(" values (");
            strSql.Append("@code,@name,@phone,@email,@address,@remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@code", SqlDbType.UniqueIdentifier,16),
                    new SqlParameter("@name", SqlDbType.VarChar,50),
                    new SqlParameter("@phone", SqlDbType.VarChar,20),
                    new SqlParameter("@email", SqlDbType.VarChar,30),
                    new SqlParameter("@address", SqlDbType.VarChar,200),
                    new SqlParameter("@remark", SqlDbType.VarChar,300)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.name;
            parameters[2].Value = model.phone;
            parameters[3].Value = model.email;
            parameters[4].Value = model.address;
            parameters[5].Value = model.remark;

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
        public bool Update(Merchant model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Merchant set ");
            strSql.Append("code=@code,");
            strSql.Append("name=@name,");
            strSql.Append("phone=@phone,");
            strSql.Append("email=@email,");
            strSql.Append("address=@address,");
            strSql.Append("remark=@remark");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@code", SqlDbType.UniqueIdentifier,16),
                    new SqlParameter("@name", SqlDbType.VarChar,50),
                    new SqlParameter("@phone", SqlDbType.VarChar,20),
                    new SqlParameter("@email", SqlDbType.VarChar,30),
                    new SqlParameter("@address", SqlDbType.VarChar,200),
                    new SqlParameter("@remark", SqlDbType.VarChar,300),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.code;
            parameters[1].Value = model.name;
            parameters[2].Value = model.phone;
            parameters[3].Value = model.email;
            parameters[4].Value = model.address;
            parameters[5].Value = model.remark;
            parameters[6].Value = model.id;

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
            strSql.Append("delete from Merchant ");
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
            strSql.Append("delete from Merchant ");
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
        public Merchant GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,code,name,phone,email,address,remark from Merchant ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Merchant model = new Merchant();
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
        public Merchant DataRowToModel(DataRow row)
        {
            Merchant model = new Merchant();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["code"] != null && row["code"].ToString() != "")
                {
                    model.code = new Guid(row["code"].ToString());
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["phone"] != null)
                {
                    model.phone = row["phone"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
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
            strSql.Append("select id,code,name,phone,email,address,remark ");
            strSql.Append(" FROM Merchant ");
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
            strSql.Append(" id,code,name,phone,email,address,remark ");
            strSql.Append(" FROM Merchant ");
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
            strSql.Append("select count(1) FROM Merchant ");
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
            strSql.Append(")AS Row, T.*  from Merchant T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return MSSqlHelper.Query(strSql.ToString());
        }

        
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public Merchant GetMerchantByCode(string code)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,code,name,phone,email,address,remark from Merchant ");
            strSql.Append(" where code=@code");
            SqlParameter[] parameters = {
                    new SqlParameter("@code", SqlDbType.NVarChar,64)
            };
            parameters[0].Value = code;

            Merchant model = new Merchant();
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

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
