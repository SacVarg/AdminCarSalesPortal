using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Payment_Methods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Enabled = false;
                dml ob = new dml();
                TextBox1.Text = ob.inc9();
                rept_type.DataSource = ob.getPayment_Details();
                rept_type.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob=new dml();
            TextBox1.Text = ob.inc9();
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            ob.payment_details(TextBox1.Text, TextBox2.Text);
            rept_type.DataSource = ob.getPayment_Details();
            rept_type.DataBind();
            TextBox1.Text = ob.inc9();
            TextBox2.Text = "";
        }
    }
}