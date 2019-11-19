using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 简历表
    /// </summary>
    public class Resume
    {

        /// <summary>
        /// 简历Id
        /// </summary>
        public int ResumeID { get; set; }
        /// <summary>
        /// 求职者ID
        /// </summary>
        public int JobSeekerID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Education { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string  Phone { get; set; }
        /// <summary>
        /// 期待职业
        /// </summary>
        public string  Expectedjob { get; set; }
        /// <summary>
        /// 期待工资
        /// </summary>
        public decimal Expectedsalary { get; set; }
        /// <summary>
        /// 工作经验
        /// </summary>
        public string WorkExp { get; set; }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// 毕业时间
        /// </summary>
        public DateTime GraduationTime { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public string Vocational { get; set; }
    }
}
