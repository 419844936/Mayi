using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaYiGzsUI
{
    public partial class ZhaoPin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void but_ok_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string xueli = txt_xueli.Text;
            string desc = txt_desc.Text;
            string year = txt_year.Text;
            string money = txt_money.Text;
        }
    }
}