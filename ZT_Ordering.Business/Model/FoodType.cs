using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZT_Ordering.Business.Model
{
    /// <summary>
	/// FoodType:菜品类别 实体类 
	/// </summary>
	[Serializable]
    public partial class FoodType
    {
        public FoodType()
        { }
        #region Model
        private int _id;
        private Guid _merchantcode;
        private string _name;
        private string _description;
        private int? _status;
        private int? _displayorder;
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
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? displayOrder
        {
            set { _displayorder = value; }
            get { return _displayorder; }
        }
        #endregion Model

    }
}

