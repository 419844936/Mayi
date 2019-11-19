using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace MaYiGzsUI
{
    public partial class 我要招聘 : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jobName = u321_input.Text;
            string recruitingnumbers = u322_input.Text;
            string educationrequired = u323_input.Text;
            string salary = u324_input.Text;
            string jobDesc = u325_input.Text;

            Models.Job job = new Models.Job()
            {
                CompanyID = 4,
                JobName = jobName,
                Recruitingnumbers = int.Parse(recruitingnumbers),
                Educationrequired = educationrequired,
                Salary = decimal.Parse(salary),
                JobDesc = jobDesc
            };
            if (BLL.JobBLL.Insert(job))
            {
                Response.Redirect("Job.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            u321_input.Text = "";
            u322_input.Text = "";
            u323_input.Text = "";
            u324_input.Text = "";
            u325_input.Text = "";
        }
    }
}