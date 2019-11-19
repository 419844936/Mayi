using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace DAL
{
   public  class JobDAL
   {
       /// <summary>
       /// 增
       /// </summary>
       /// <param name="jo"></param>
       /// <returns></returns>
       public static bool Insert(Job jo)
       {
           string sql = string.Format(@"INSERT INTO [dbo].[Job]
           ([CompanyID]
           ,[JobName]
           ,[Recruitingnumbers]
           ,[Educationrequired]
           ,[Salary]
           ,[JobDesc])
     VALUES
           ('{0}','{1}','{2}','{3}','{4}','{5}')",jo.CompanyID,jo.JobName,jo.Recruitingnumbers,jo.Educationrequired,jo.Salary,jo.JobDesc);
           return DBHepler.ENQ(sql);
       }
       /// <summary>
       /// 删
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static bool Delete(int id)
       {
           string sql = string.Format(@" DELETE FROM [dbo].[Job]
      WHERE JobID='{0}'",id);
           return DBHepler.ENQ(sql);
       }
       /// <summary>
       /// 改
       /// </summary>
       /// <param name="jo"></param>
       /// <returns></returns>
       public static bool Update(Job  jo)
       {
           string sql = string.Format(@"UPDATE [dbo].[Job]
   SET [CompanyID] =         '{0}'
      ,[JobName] =           '{1}'
      ,[Recruitingnumbers] = '{2}'
      ,[Educationrequired] = '{3}'
      ,[Salary] =            '{4}'
      ,[JobDesc] =           '{5}'
 WHERE JobID ='{6}'",jo.CompanyID,jo.JobName,jo.Recruitingnumbers,jo.Educationrequired,jo.Educationrequired,jo.Salary,jo.JobDesc,jo.JobID);
           return DBHepler.ENQ(sql);
       }
       /// <summary>
       /// 查
       /// </summary>
       /// <returns></returns>
       public static DataTable Select()
       {
           string sql = string.Format(@"SELECT [JobID]
      ,[CompanyID]
      ,[JobName]
      ,[Recruitingnumbers]
      ,[Educationrequired]
      ,[Salary]
      ,[JobDesc]
  FROM [dbo].[Job]");
           return DBHepler.GetDataTable (sql);
       }
    }
}
