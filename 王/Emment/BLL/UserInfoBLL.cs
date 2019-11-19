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
    public class UserInfoBLL
    {
        public static bool Insert(UserInfo user)
        {
            return DAL.UserInfoDAL.Insert(user);
        }
        public static bool Update(UserInfo user)
        {
            return DAL.UserInfoDAL.Update(user);
        }
        public static DataTable select1()
        {
            return DAL.UserInfoDAL.select1();
        }
        public static DataTable select(UserInfo us)
        {
            return DAL.UserInfoDAL.select(us);
        }
    }
}
