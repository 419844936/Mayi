using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class Dro_select
    {
        
         
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="comname"></param>
        /// <returns></returns>
        public static DataTable ComName(string where = "1=1")
        {
            return DAL.Dro_XuanZeSelect.ComName(where);
        }
    }
}
