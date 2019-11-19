using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 岗位
    /// </summary>
   public class Job
    {
       /// <summary>
       /// 岗位ID
       /// </summary>
        public int JobID { get; set; }
       /// <summary>
       /// 公司ID
       /// </summary>
        public int CompanyID { get; set; }
       /// <summary>
       /// 岗位名称
       /// </summary>
        public string JobName { get; set; }
       /// <summary>
       /// 招聘人数
       /// </summary>
        public int Recruitingnumbers { get; set; }
       /// <summary>
       /// 学历要求
       /// </summary>
        public string Educationrequired { get; set; }
       /// <summary>
       /// 支付薪水
       /// </summary>
        public decimal Salary { get; set; }
       /// <summary>
       /// 岗位介绍
       /// </summary>
        public string JobDesc { get; set; }
    }
}
