using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace MaYiGzsUI
{
    public partial class 登录 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void u109_Click(object sender, EventArgs e)
        {
            Models.UserInfo model = new Models.UserInfo();
            model.Num = u101_input.Text;
            model.Pwd = u102.Text;
            DataTable tb = BLL.UserInfoBLL.select(model);

            if (tb != null && tb.Rows.Count > 0)
            {
                model.JobSeekerID = (int)tb.Rows[0]["JobSeekerID"];
                model.UserType = tb.Rows[0]["UserType"].ToString();
                Session["User"] = model;
                Response.Redirect("ShouYeNew.aspx");
            }
            else
            {
                Response.Write("<script>alert('账号密码错误，请重新登录')</script>");
            }
        }
    }
}