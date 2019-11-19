using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
namespace MaYiGzsUI
{
    public partial class 公司页面 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            UserInfo fo = (UserInfo)Session["User"];
            if (fo.UserType != "招聘者")
            {
                Response.Write("<script>alert('请使用公司账户操作');location.href='ShouYeNew.aspx'</script>");
                return;
            }
        }

        protected void u504_div_Click(object sender, EventArgs e)
        {
            string comname = u496_input.Text;
            string suozaidi = u499_input.Text;
            string desc = u502_input.Text;
            Models.Company com = new Company()
            {
                JobSeekerID = 1,
                ComparyName = comname,
                Comparylocation = suozaidi,
                CompantDesc = desc
            };
            if (BLL.CompanyBLL.Insert(com))
            {
                Response.Write("<script>alert('添加成功')</script>");
                Response.Redirect("ShouYeNew.aspx");
            }
        }
    }
}