using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 招聘邀请表
    /// </summary>
    public class Invite
    {
        /// <summary>
        /// 招聘邀请ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 岗位ID
        /// </summary>
        public int JobID { get; set; }
        /// <summary>
        /// 求职者ID
        /// </summary>
        public int ResumeID { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Condition { get; set; }
    }
}
