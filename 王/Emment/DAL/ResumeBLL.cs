using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class ResumeBLL
    {
        public static bool Insert(Resume res)
        {
            return DAL.ResumeDAL.Insert(res);
        }
        public static bool Update(Resume res)
        {
            return DAL.ResumeDAL.Update(res);
        }
        public static bool Delete(int id)
        {
            return DAL.ResumeDAL.Delete(id);
        }
        public static DataTable select(int id)
        {
            return DAL.ResumeDAL.select(id);
        }
        //public static bool Update2(int JobSeekerID, string Name, string Sex, int Age, string Education, string Phone, string Expectedjob, decimal Expectedsalary, string WorkExp, string School, DateTime GraduationTime, string Vocational)
        //{
        //    return DAL.ResumeDAL.Update2( JobSeekerID,  Name,  Sex,  Age,  Education,  Phone,  Expectedjob,  Expectedsalary,  WorkExp,  School,  GraduationTime,  Vocational);
        //}
        }
}
