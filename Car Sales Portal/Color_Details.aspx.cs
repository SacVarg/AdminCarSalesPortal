using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Color_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dml obj1 = new dml();
            if(!IsPostBack)
            {
                TextBox1.Text = obj1.inc6();
                TextBox1.Enabled = false;
                rept_color.DataSource = obj1.getcolordetails("");
                rept_color.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml obj1 = new dml();
            obj1.colordetails(TextBox1.Text, TextBox2.Text);
            TextBox1.Text = obj1.inc6();
            TextBox2.Text = "";
            rept_color.DataSource = obj1.getcolordetails("");
            rept_color.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml obj1 = new dml();
            TextBox1.Text = obj1.inc6();
            TextBox2.Text = "";
        }
    }
}