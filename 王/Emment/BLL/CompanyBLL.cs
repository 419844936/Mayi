using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
namespace BLL
{
    public class CompanyBLL
    {
        public static bool Insert(Company co)
        {
            return DAL.CompanyDAL.Insert(co);
        }
        public static bool Delete(int id)
        {
            return DAL.CompanyDAL.Delete(id);
        }
        public static bool Update(Company co)
        {
            return DAL.CompanyDAL.Update(co);
        }
        public static DataTable Select()
        {
            return DAL.CompanyDAL.Select();
        }
        public static DataTable GetComJob(string orderstr = " CompanyID asc")
        {
            return DAL.CompanyDAL.GetComJob(orderstr);

        }
    }
}
