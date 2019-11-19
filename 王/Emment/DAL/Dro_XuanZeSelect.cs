using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Dro_XuanZeSelect
    {
        
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="comname"></param>
        /// <returns></returns>
        public static DataTable ComName(string where = "1=1")
        {
            string sql = "SELECT *  FROM [dbo].[View_Com_Job] where " + where;
            return DBHepler.GetDataTable(sql);
        }
    }
}
