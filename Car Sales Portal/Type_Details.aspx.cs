using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Type_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Button4.Enabled = false;
                dml ob1 = new dml();
                TextBox1.Text = ob1.inc1();
                TextBox1.Enabled = false;

                rept_type.DataSource = ob1.gettypedetails("");
                rept_type.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob1=new dml();
            ob1.typedetails(TextBox1.Text, TextBox2.Text);
            TextBox1.Text = ob1.inc1();
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button4.Enabled = false;
            dml ob1 = new dml();
            TextBox1.Text = ob1.inc1();
            TextBox2.Text = "";
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button4.Enabled = true;
            Button1.Enabled = false;
            Button bt = (Button)sender;
            string typeid = bt.CommandName;
            dml ob1 = new dml();
            DataTable dt = new DataTable();
            dt = ob1.gettypedetails_rep(typeid);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["TYPE_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["TYPE_NAME"].ToString();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            ob1.update_type_details(TextBox1.Text, TextBox2.Text);
            rept_type.DataSource = ob1.gettypedetails("");
            rept_type.DataBind();
            TextBox1.Text = ob1.inc1();
            TextBox2.Text = "";
        }
    }
}