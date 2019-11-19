using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace DAL
{
    public class CompanyDAL
    {
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public static bool Insert(Company co)
        {
            string sql = string.Format(@"INSERT INTO [dbo].[Company]
           ([JobSeekerID]
           ,[ComparyName]
           ,[Comparylocation]
           ,[CompantDesc])
     VALUES
           ('{0}','{1}','{2}','{3}')",co.JobSeekerID,co.ComparyName,co.Comparylocation,co.CompantDesc);
            return DBHepler.ENQ(sql);
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            string sql = string.Format(@"DELETE FROM [dbo].[Company]
      WHERE CompanyID='{0}'",id);
            return DBHepler.ENQ(sql);
        }
        /// <summary>
        /// 改
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public static bool Update(Company co)
        {
            string sql = string.Format(@"UPDATE [dbo].[Company]
   SET [JobSeekerID] =     '{0}'
      ,[ComparyName] =     '{1}'
      ,[Comparylocation] = '{2}'
      ,[CompantDesc] =     '{3}'
 WHERE CompanyID ='{4}'",co.JobSeekerID,co.ComparyName,co.Comparylocation,co.CompantDesc,co.CompanyID);
            return DBHepler.ENQ(sql);
        }
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        public static DataTable Select()
        {
            string sql = string.Format(@"SELECT [CompanyID]
      ,[JobSeekerID]
      ,[ComparyName]
      ,[Comparylocation]
      ,[CompantDesc]
  FROM [dbo].[Company]");
            return DBHepler.GetDataTable(sql);
        }

        public static DataTable GetComJob(string orderstr = " CompanyID asc")
        {
            string sql = string.Format(@"SELECT  dbo.Company.CompanyID,dbo.Company.CompantDesc,dbo.Company.ComparyName,dbo.Job.JobName,dbo.Company.Comparylocation,dbo.Job.Salary
                                         FROM dbo.Company INNER JOIN
                                         dbo.Job ON dbo.Company.CompanyID = dbo.Job.CompanyID order by {0}", orderstr);
            return DBHepler.GetDataTable(sql);
        }
    }
}
