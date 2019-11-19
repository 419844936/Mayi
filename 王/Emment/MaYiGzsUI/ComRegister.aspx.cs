using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaYiGzsUI
{
    public partial class ComRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void u142_Click(object sender, EventArgs e)
        {
            Models.UserInfo model = new Models.UserInfo();
            model.UserType = "招聘者";
            model.Num = u134_input.Text;
            model.Pwd = u135_input.Text;
            if (u140_input.Text != u135_input.Text)
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

                    if (a == u134_input.Text)
                    {
                        Response.Write("<script>alert('注册公司已存在，请重新注册')</script>");
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