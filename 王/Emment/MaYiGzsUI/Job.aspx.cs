using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaYiGzsUI
{
    public partial class Job : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropCS();
                DropComName();
                Dropjob();
                BindRerpter();
            }
        }
        void BindRerpter()
        {
            string where = "1=1";
            if (Drop_city.SelectedValue != "0")
            {
                where += " and Comparylocation ='" + Drop_city.SelectedItem.Text + "' ";
            }

            if (Drop_ComName.SelectedValue != "0")
            {
                where += " and ComparyName ='" + Drop_ComName.SelectedItem.Text + "' ";
            }
            if (Drop_job.SelectedValue != "0")
            {
                where += " and JobName ='" + Drop_job.SelectedItem.Text + "' ";
            }
            if (drop_xlk1.SelectedValue != "0")
            {
                where += " order by Salary asc ";
            }
            else
            {
                where += " order by Salary desc "; 
            }
            //绑定数据源
            Repeater1.DataSource = BLL.Dro_select.ComName(where);
            //绑定方法
            Repeater1.DataBind();
        }
        //下拉框 按工资排序
        protected void drop_xlk1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRerpter();
        }
        //绑定城市下拉框
        void DropCS()
        {
            Drop_city.DataSource = BLL.CompanyBLL.Select();
            Drop_city.DataTextField = "Comparylocation";
            Drop_city.DataValueField = "CompanyID";
            Drop_city.DataBind();
            Drop_city.Items.Insert(0, new ListItem("请选择", "0"));
        }
        //绑定公司名称下拉框
        void DropComName()
        {
            Drop_ComName.DataSource = BLL.CompanyBLL.Select();
            Drop_ComName.DataTextField = "ComparyName";
            Drop_ComName.DataValueField = "CompanyID";
            Drop_ComName.DataBind();
            Drop_ComName.Items.Insert(0, new ListItem("请选择", "0"));
        }
        //绑定岗位下拉框
        void Dropjob()
        {
            Drop_job.DataSource = BLL.CompanyBLL.GetComJob();
            Drop_job.DataTextField = "JobName";
            Drop_job.DataValueField = "CompanyID";
            Drop_job.DataBind();
            Drop_job.Items.Insert(0, new ListItem("请选择", "0"));
        }
        /// <summary>
        /// 城市
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Drop_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRerpter();
        }
        /// <summary>
        /// 岗位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Drop_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRerpter();
        }
        /// <summary>
        /// 公司
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Drop_ComName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRerpter();
        }

    }
}