using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace BLL
{
    public class JobBLL
    {
        public static bool Insert(Job jo)
        {
            return DAL.JobDAL.Insert(jo);
        }
        public static bool Delete(int id)
        {
            return DAL.JobDAL.Delete(id);
        }
        public static bool Update(Job jo)
        {
            return DAL.JobDAL.Update(jo);
        }
        public static DataTable Select()
        {
            return DAL.JobDAL.Select();
        }
    }
}
