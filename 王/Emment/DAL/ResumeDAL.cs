using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ResumeDAL
    {
        public static bool Insert(Resume res)
        {
            string sql = string.Format(@"INSERT INTO [dbo].[Resume]
                                              ([JobSeekerID]
                                               ,[Name]
                                               ,[Sex]
                                               ,[Age]
                                               ,[Education]
                                               ,[Phone]
                                               ,[Expectedjob]
                                               ,[WorkExp]
                                               ,[School]
                                               ,[GraduationTime]
                                               ,[Vocational]
                                                ,Expectedsalary)
                                         VALUES
                                               ('{0}'
                                               ,'{1}'
                                               ,'{2}'
                                               ,'{3}'
                                               ,'{4}'
                                               ,'{5}'
                                               ,'{6}'
                                               ,'{7}'
                                               ,'{8}'
                                               ,'{9}'
                                               ,'{10}'
                                               ,'{11}')", res.JobSeekerID, res.Name, res.Sex, res.Age, res.Education, res.Phone, res.Expectedjob
            , res.WorkExp, res.School, res.GraduationTime, res.Vocational, res.Expectedsalary);
            return DBHepler.ENQ(sql);
        }
        public static bool Update(Resume res)
        {
            string sql = string.Format(@"UPDATE [dbo].[Resume]
                                         SET [JobSeekerID]='{0}'
                                            ,[Name]= '{1}'
                                            ,[Sex]='{2}'
                                            ,[Age]='{3}'
                                            ,[Education]='{4}'
                                            ,[Phone]='{5}'
                                            ,[Expectedjob]='{6}'
                                            ,[WorkExp]='{7}'
                                            ,[School]='{8}'
                                            ,[GraduationTime]='{9}'
                                            ,[Vocational]='{10}'
                                            ,Expectedsalary='{11}'
                                       WHERE JobSeekerID='{12}'", res.JobSeekerID, res.Name, res.Sex, res.Age, res.Education, res.Phone, res.Expectedjob
            , res.WorkExp, res.School, res.GraduationTime, res.Vocational, res.Expectedsalary, res.JobSeekerID);
            return DBHepler.ENQ(sql);
        }
        //public static bool Update2(int JobSeekerID,string Name,string Sex,int Age, string Education, string Phone, string Expectedjob, decimal Expectedsalary, string WorkExp, string School,DateTime GraduationTime,string Vocational)
        //{
        //    string sql = string.Format(@"UPDATE [dbo].[Resume]
        //                                 SET [JobSeekerID]='{0}'
        //                                    ,[Name]= '{1}'
        //                                    ,[Sex]='{2}'
        //                                    ,[Age]='{3}'
        //                                    ,[Education]='{4}'
        //                                    ,[Phone]='{5}'
        //                                    ,[Expectedjob]='{6}'
        //                                    ,[WorkExp]='{7}'
        //                                    ,[School]='{8}'
        //                                    ,[GraduationTime]='{9}'
        //                                    ,[Vocational]='{10}'
        //                                    ,Expectedsalary='{11}'
        //                               WHERE JobSeekerID='{12}'", JobSeekerID, Name, Sex, Age, Education, Phone, Expectedjob
        //    , WorkExp, School, GraduationTime, Vocational, Expectedsalary, JobSeekerID);
        //    return DBHepler.ENQ(sql);
        //}
        public static bool Delete(int id)
        {
            string sql = string.Format(@"DELETE FROM [dbo].[Resume] WHERE ResumeID='{0}'", id);
            return DBHepler.ENQ(sql);
        }
        public static DataTable select(int id)
        {
            string sql = string.Format(@"SELECT * FROM [dbo].[Resume] where [JobSeekerID]=" + id);
            return DBHepler.GetDataTable(sql);
        }
    }
}
