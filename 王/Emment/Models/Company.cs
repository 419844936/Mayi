using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 公司表
    /// </summary>
    public class Company
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyID { get; set; }
        /// <summary>
        /// 招聘者ID
        /// </summary>
        public int JobSeekerID { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string ComparyName { get; set; }
        /// <summary>
        /// 公司所在地
        /// </summary>
        public string Comparylocation { get; set; }
        /// <summary>
        /// 公司介绍
        /// </summary>
        public string CompantDesc { get; set; }
    }
}
