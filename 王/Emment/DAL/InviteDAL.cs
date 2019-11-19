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
    public class InviteDAL
    {
        public static bool Insert(Invite inv)
        {
            string sql = string.Format(@"INSERT INTO [dbo].[Invite]
                                               ([JobID]
                                               ,[ResumeID]
                                               ,[AddTime]
                                               ,[Condition])
                                         VALUES
                                               ('{0}'
                                               ,'{1}'
                                               ,'{2}'
                                               ,'{3}')",inv.JobID,inv.ResumeID,inv.AddTime,inv.Condition);
            return DBHepler.ENQ(sql);
        }
        public static bool Update(Invite inv)
        {
            string sql = string.Format(@"UPDATE [dbo].[Invite]
                                            SET [JobID] = '{0}'
                                               ,[ResumeID] = '{1}'
                                               ,[AddTime] ='{2}'
                                               ,[Condition] ='{3}'
                                          WHERE ID='{4}'", inv.JobID, inv.ResumeID, inv.AddTime, inv.Condition,inv.ID);
            return DBHepler.ENQ(sql);
        }
        public static bool Delete(int id)
        {
            string sql = string.Format(@"DELETE FROM [dbo].[Invite] WHERE id='{0}'",id);
            return DBHepler.ENQ(sql);
        }
        public static DataTable select()
        {
            string sql = string.Format(@"SELECT * FROM [dbo].[Invite]");
            return DBHepler.GetDataTable(sql);
        }
    }
}
