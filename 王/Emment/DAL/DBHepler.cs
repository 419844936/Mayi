using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHepler
    {
        /// <summary>
        /// 链接语句
        /// </summary>
        public static string ConnStr = "Data Source=.;Initial Catalog=MaYi;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(ConnStr);
        /// <summary>
        /// DataTable方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string str)
        {
            conn.Close();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            da.Fill(dt);
            
            return dt;
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ENQ(string str)
        {
conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(str,conn);
            int zsg = cmd.ExecuteNonQuery();
            return zsg > 0;
        }
    }
}
