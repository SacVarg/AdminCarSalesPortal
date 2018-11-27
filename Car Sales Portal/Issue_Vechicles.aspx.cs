using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Issue_Vechicles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = System.DateTime.Today.ToString("dd-MM-yyyy");
                TextBox1.Enabled = false;
                dml ob = new dml();
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                Button1.Enabled = false;
                rept_model.DataSource = ob.getIssue_Details();
                rept_model.DataBind();
            }
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button bt = (Button)sender;
            string bid = bt.CommandArgument;
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.getIssue_Details_ToIssue(bid);
            if(dt.Rows.Count>0)
            {
                TextBox2.Text = dt.Rows[0]["BOOKING_ID"].ToString();
                TextBox3.Text = dt.Rows[0]["FIRST_NAME"].ToString();
            }
           
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            if(CheckBox1.Checked==true)
            {
                DateTime issuedate = Convert.ToDateTime(TextBox1.Text.ToString());
                ob.update_booking_status(TextBox2.Text, issuedate);
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox1.Text = System.DateTime.Today.ToString("dd-MM-yyyy");
                rept_model.DataSource = ob.getIssue_Details();
                rept_model.DataBind();
                Button1.Enabled = false;
            }
            else
            {
                Label1.Text = "Please Check Issue";
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Text = System.DateTime.Today.ToString("dd-MM-yyyy");
            rept_model.DataSource = ob.getIssue_Details();
            rept_model.DataBind();
            Button1.Enabled = false;
            CheckBox1.Checked = false;
        }
    }
}