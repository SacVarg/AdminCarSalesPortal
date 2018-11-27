using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Company_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dml ob1 = new dml();
                TextBox1.Text = ob1.inc();
                TextBox1.Enabled = false;
                Button4.Enabled = false;

                rept_comp.DataSource = ob1.getcompdetails();
                rept_comp.DataBind();
            }

        }

        protected void Btn_edit(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string cmpid = bt.CommandName;
            dml ob1 = new dml();
            Button4.Enabled = true;
            Button1.Enabled = false;
            DataTable dt = new DataTable();
            dt = ob1.getcompdetails(cmpid);
            if(dt.Rows.Count>0)
            {
                TextBox1.Text = dt.Rows[0]["COMPANY_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["COMPANY_NAME"].ToString();
                TextBox3.Text = dt.Rows[0]["ADDRESS"].ToString();
                TextBox4.Text = dt.Rows[0]["MOBILE_CONTACT_NO"].ToString();
                TextBox5.Text = dt.Rows[0]["LAND_CONTACT_NO"].ToString();
                TextBox6.Text = dt.Rows[0]["E_MAIL"].ToString();
                TextBox7.Text = dt.Rows[0]["WEB_ADDRESS"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            ob.companydetails(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            TextBox1.Text = ob.inc();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            rept_comp.DataSource = ob.getcompdetails();
            rept_comp.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            TextBox1.Text = ob1.inc();
            Button1.Enabled = true;
            Button4.Enabled = false;
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            ob1.update_company_details(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            rept_comp.DataSource = ob1.getcompdetails();
            rept_comp.DataBind();
            TextBox1.Text = ob1.inc();
            Button1.Enabled = true;
            Button4.Enabled = false;
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
    }
}