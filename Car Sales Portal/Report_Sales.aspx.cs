using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Report_Sales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = System.DateTime.Today.ToString("yyyy-MM-dd");
                TextBox2.Text = System.DateTime.Today.ToString("yyyy-MM-dd");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml obj = new dml();
            DateTime fdate = Convert.ToDateTime(TextBox1.Text.ToString());
            DateTime tdate = Convert.ToDateTime(TextBox2.Text.ToString());
            DataTable dt = new DataTable();
            dt = obj.getSales_Details(fdate, tdate);


            int count = dt.Rows.Count;
            int sum=0;
            for (int i = 0; i < count;i++ )
            {
                sum = sum + Int32.Parse(dt.Rows[i]["PRICE"].ToString());
            }
            dt.Columns.Add("tPRICE");
            dt.Columns["tPRICE"].DefaultValue = sum;
            Label2.Text = sum.ToString();
            rept_price.DataSource = dt;
            rept_price.DataBind();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}