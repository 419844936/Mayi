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
    public class InviteBLL
    {
        public static bool Insert(Invite inv)
        { 
            return DAL.InviteDAL.Insert(inv);
        }
        public static bool Update(Invite inv)
        {
            return DAL.InviteDAL.Update(inv);
        }
        public static bool Delete(int id)
        {
            return DAL.InviteDAL.Delete(id);
        }
        public static  DataTable select()
        {
            return DAL.InviteDAL.select();
        }
    }
}
