using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Data;
namespace MaYiGzsUI
{
    public partial class 求职档案 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }
                UserInfo fo = (UserInfo)Session["User"];
                if (fo.UserType!="求职者")
                {
                    Response.Write("<script>alert('请使用个人账户操作');location.href='ShouYeNew.aspx'</script>");
                    return;
                }
                string id = fo.JobSeekerID.ToString();
                DataTable da = BLL.ResumeBLL.select(int.Parse("1"));
                if (da != null && da.Rows.Count > 0)
                {
                    foreach (DataRow dr in da.Rows)
                    {
                        u448_input.Text = dr["Name"].ToString();
                        u454_input.Text = dr["Sex"].ToString();
                        u450_input.Text = dr["Age"].ToString();
                        u456_input.Text = dr["WorkExp"].ToString();
                        u452_input.Text = dr["Phone"].ToString();
                        u473_input.Text = dr["Expectedjob"].ToString();
                        u479_input.Text = dr["GraduationTime"].ToString();
                        u486_input.Text = dr["WorkExp"].ToString();
                        u480_input.Text = dr["School"].ToString();
                        u481_input.Text = dr["Vocational"].ToString();
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void u438_text_Click(object sender, EventArgs e)
        {
            UserInfo fo = (UserInfo)Session["User"];
            string id = fo.JobSeekerID.ToString();
            if (BLL.ResumeBLL.select(int.Parse(id)) == null && BLL.ResumeBLL.select(int.Parse(id)).Rows.Count == 0)
            {
                int jid = ((UserInfo)Session["User"]).JobSeekerID;
                string name = u448_input.Text;
                string sex = u454_input.Text;
                string age = u450_input.Text;
                string workexe = u456_input.Text;
                string phone = u452_input.Text;
                string qiwang = u473_input.Text;
                string time = u479_input.Text;
                string xueli = u486_input.Text;
                string school = u480_input.Text;
                string zhuanye = u481_input.Text;
                Models.Resume res = new Resume()
                {
                    Name = name,
                    Sex = sex,
                    Age = int.Parse(age),
                    WorkExp = workexe,
                    Phone = phone,
                    Expectedjob = qiwang,
                    GraduationTime = DateTime.Parse(time),
                    Education = xueli,
                    School = school,
                    Vocational = zhuanye,
                    Expectedsalary = 5000,
                    JobSeekerID = jid
                };
                if (BLL.ResumeBLL.Insert(res))
                {
                    Response.Write("<script>alert('添加成功')</script>");
                }
            }
            else
            {

                int jid = ((UserInfo)Session["User"]).JobSeekerID;
                //string name = u448_input.Text;
                //string sex = u454_input.Text;
                //string age = u450_input.Text;
                //string workexe = u456_input.Text;
                //string phone = u452_input.Text;
                //string qiwang = u473_input.Text;
                //string time = u479_input.Text;
                //string xueli = u486_input.Text;
                //string school = u480_input.Text;
                //string zhuanye = u481_input.Text;
                Models.Resume res = new Resume()
                {
                    Name = u448_input.Text,
                    Sex = u454_input.Text,
                    Age = int.Parse(u450_input.Text),
                    WorkExp = u456_input.Text,
                    Phone = u452_input.Text,
                    Expectedjob = u473_input.Text,
                    GraduationTime = DateTime.Parse(u479_input.Text),
                    Education = u486_input.Text,
                    School = u480_input.Text,
                    Vocational = u481_input.Text,
                    Expectedsalary = 5000,
                    JobSeekerID = jid
                };
                if (BLL.ResumeBLL.Update(res))
                {
                    Response.Redirect("我的求职.aspx");
                }
            }




        }

        protected void u439_div_Click(object sender, EventArgs e)
        {
            Response.Redirect("我要求职.aspx");
        }
    }
}