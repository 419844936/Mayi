using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaYiGzsUI
{
    public partial class ShouYeNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void u58_Click(object sender, EventArgs e)
        {
            //获取输入的信息
            string shuru = u57.Text;
            //跳转到职位浏览页面
            Response.Redirect("Job.aspx");
        }
    }
}