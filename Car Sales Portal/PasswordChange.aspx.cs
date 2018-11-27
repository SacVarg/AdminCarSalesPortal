using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            dml ob = new dml();
            DataTable dt = new DataTable();
            string id = TextBox1.Text;
            dt = ob.get_admin(TextBox1.Text);
            if(dt.Rows.Count>0)
            {
                if (TextBox3.Text == TextBox4.Text && TextBox2.Text == dt.Rows[0]["PASSWORD"].ToString())
                {
                    ob.change_password(id, TextBox3.Text);
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Wrong old password/ New password not match confirm password');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid User Name');", true);
            }
            
        }
    }
}