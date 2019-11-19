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
    public class UserInfoDAL
    {
        public static bool Insert(UserInfo user)
        {
            string sql = string.Format(@"INSERT INTO [dbo].[UserInfo]
                                             ([Num]
                                             ,[Pwd]
                                             ,[UserType])
                                       VALUES
                                             ('{0}'
                                             ,'{1}'
                                             ,'{2}')",user.Num,user.Pwd,user.UserType);
            return DBHepler.ENQ(sql);
        }
        public static bool Update(UserInfo user)
        {
            string sql = string.Format(@"UPDATE [dbo].[UserInfo]
                                          SET [Num] = '{0}'
                                             ,[Pwd] = '{1}'
                                             ,[UserType] = '{2}'
                                        WHERE JobSeekerID='{3}'", user.Num, user.Pwd, user.UserType,user.JobSeekerID);
            return DBHepler.ENQ(sql);
        }
        public static bool Delete(int id)
        {
            string sql = string.Format(@"DELETE FROM [dbo].[UserInfo]  WHERE JobSeekerID='{0}'", id);
            return DBHepler.ENQ(sql);
        }
        public static DataTable select(UserInfo us)
        {
            string sql = string.Format(@"SELECT * FROM [dbo].[UserInfo] where num='{0}' and pwd='{1}'", us.Num, us.Pwd);
            return DBHepler.GetDataTable(sql);
        }
        public static DataTable select1()
        {
            string sql = string.Format(@"SELECT * FROM [dbo].[UserInfo]");
            return DBHepler.GetDataTable(sql);
        }
    }
}
