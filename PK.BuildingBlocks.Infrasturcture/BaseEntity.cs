using System;
namespace PK.BuildingBlocks.Infrasturcture
{
    public class BaseEntity
    {
        /// <summary>
        /// declare for the purpose of Unique Id such as guid/uuid
        /// </summary>
        public string ID
        {
            get;
            set;
        }

        /// <summary>
        /// date declaration for any record created with datetime stamp
        /// </summary>
        public DateTime? CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// person/system creating a new record
        /// </summary>
        public string CreatedBy
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdatedDate
        {
            get;
            set;
        }
        /// <summary>
        /// date time declaration for any record getting updated
        /// </summary>
        public string UpdatedBy
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Convert.ToString(ID);
        }
    }
}
