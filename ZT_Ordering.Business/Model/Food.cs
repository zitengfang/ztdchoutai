using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
    /// Food:菜品 实体类
    /// </summary>
    [Serializable]
    public partial class Food
    {
        public Food()
        { }
        #region Model
        private int _id;
        private int? _foodtypeid;
        private Guid _merchantcode;
        private string _name;
        private decimal? _price;
        private string _description;
        private DateTime? _addtime;
        private int? _displayorder;
        private int? _status;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? foodTypeId
        {
            set { _foodtypeid = value; }
            get { return _foodtypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid merchantCode
        {
            set { _merchantcode = value; }
            get { return _merchantcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? displayOrder
        {
            set { _displayorder = value; }
            get { return _displayorder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        #endregion Model

    }
}

