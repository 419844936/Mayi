using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Models;
namespace MaYiGzsUI
{
    public partial class 我的求职 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            UserInfo fo = (UserInfo)Session["User"];
            if (fo.UserType != "求职者")
            {
                Response.Write("<script>alert('请使用个人账户操作');location.href='ShouYeNew.aspx'</script>");
                return;
            }
            string id = fo.JobSeekerID.ToString();
            DataTable da = BLL.ResumeBLL.select(int.Parse(id));
            if (da != null && da.Rows.Count > 0)
            {
                DataRow dr = da.Rows[0];
                foreach (DataRow dr1 in da.Rows)
                {
                    Models.Resume r = new Models.Resume();
                    r.Name = dr["Name"].ToString();
                    r.Sex = dr["Sex"].ToString();
                    r.Age = int.Parse(dr["Age"].ToString());
                    r.Education = dr["Education"].ToString();
                    r.Phone = dr["Phone"].ToString();
                    r.Expectedjob = dr["Expectedjob"].ToString();
                    r.Expectedsalary = decimal.Parse(dr["Expectedsalary"].ToString());
                    r.WorkExp = dr["WorkExp"].ToString();
                    r.School = dr["School"].ToString();
                    r.GraduationTime = DateTime.Parse(dr["GraduationTime"].ToString());
                    r.Vocational = dr["Vocational"].ToString();
                }
                this.labName.Text = dr["Name"].ToString();
                this.labSex.Text = dr["Sex"].ToString();
                this.labAge.Text = dr["Age"].ToString();
                this.labZY.Text = dr["Vocational"].ToString();
                this.labPhone.Text = dr["Phone"].ToString();
                this.labWork.Text = dr["Expectedjob"].ToString();
                this.labMoney.Text = dr["Expectedsalary"].ToString();
                this.labWorkExe.Text = dr["WorkExp"].ToString();
                this.labXueli.Text = dr["Education"].ToString();
                this.labSchool.Text = dr["School"].ToString();
                this.Label1.Text = dr["GraduationTime"].ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("求职档案.aspx");
        }

    }
}