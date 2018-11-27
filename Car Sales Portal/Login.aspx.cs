using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Login : System.Web.UI.Page
    {
        public static string id;
        protected void Page_Load(object sender, EventArgs e)
        {
           
               
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.check3(TextBox1.Text, TextBox2.Text);
            if(dt.Rows.Count>0)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                Session["adminname"] = dt.Rows[0]["ADMIN_NAME"].ToString();
                Session["adminid"] = dt.Rows[0]["ADMIN_ID"].ToString();
                Session["lid"] = ob.inc10().ToString();
                ob.log_details(ob.inc10().ToString(),dt.Rows[0]["ADMIN_ID"].ToString(), dt.Rows[0]["ADMIN_NAME"].ToString(), DateTime.Today.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH:mm:ss tt"));
                Response.Redirect("Company_Details.aspx");
            }
        }
    }
}