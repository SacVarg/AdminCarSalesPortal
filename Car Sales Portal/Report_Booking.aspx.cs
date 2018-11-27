using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Report_Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = System.DateTime.Today.ToString("yyyy-MM-dd");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml obj = new dml();
            DataTable dt=new DataTable ();
            dt=obj.get_print(TextBox1.Text);
            rept_price.DataSource = dt;
            rept_price.DataBind();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            
            
           
        }
    }
}