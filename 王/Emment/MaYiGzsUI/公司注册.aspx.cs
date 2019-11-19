using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MaYiGzsUI
{
    public partial class 公司注册 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void u162_text_Click(object sender, EventArgs e)
        {
            Models.UserInfo model = new Models.UserInfo();
            model.UserType = "招聘者";
            model.Num = u159_input.Text;
            model.Pwd = u160_input.Text;
            if (u172_input.Text != u160_input.Text)
            {
                Response.Write("<script>alert('失败')</script>");
                return;
            }
            DataTable tb = BLL.UserInfoBLL.select1();
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    string a = dr["Num"].ToString();
                    if (a == u159_input.Text)
                    {
                        Response.Write("<script>alert('注册用户已存在，请重新注册')</script>");
                        return;
                    }
                }


                if (u143_input.Checked)
                {
                    if (BLL.UserInfoBLL.Insert(model))
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('请勾选用户协议')</script>");
                    return;
                }
            }
        }
    }
}