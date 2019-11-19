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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void u142_Click(object sender, EventArgs e)
        {
            Models.UserInfo model = new Models.UserInfo();
            model.UserType = "求职者";
            model.Num = u134_input.Text;
            model.Pwd = u135_input.Text;
            if (u140_input.Text != u135_input.Text)
            {
                Response.Write("<script>alert('失败')</script>");
                return;
            }
            //BLL.UserInfoBLL.Insert(model);
            //Response.Redirect("登录.aspx");



            DataTable tb = BLL.UserInfoBLL.select1();

            if (tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    string a = dr["Num"].ToString();

                    if (a == u134_input.Text)
                    {
                        Response.Write("<script>alert('账户已存在，请重新注册')</script>");
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