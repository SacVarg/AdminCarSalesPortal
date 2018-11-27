using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Feature_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob1 = new dml();
                TextBox1.Text = ob1.inc3();
                TextBox1.Enabled = false;
                Button4.Enabled = false;


                rept_feature.DataSource = ob1.getfeaturedetails("");
                rept_feature.DataBind();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            ob1.featuredetails(TextBox1.Text, TextBox2.Text);
            TextBox1.Text = ob1.inc3();
            TextBox2.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            TextBox1.Text = ob1.inc3();
            TextBox2.Text = "";
            Button1.Enabled = true;
            Button4.Enabled = false;
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button4.Enabled = true;
            Button1.Enabled = false;
            Button bt = (Button)sender;
            string featureid = bt.CommandName;
            dml ob1 = new dml();
            DataTable dt = new DataTable();
            dt = ob1.getfeaturedetails_rep(featureid);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["FEATURE_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["FEATURE_NAME"].ToString();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            ob1.update_feature_details(TextBox1.Text, TextBox2.Text);
            rept_feature.DataSource = ob1.getfeaturedetails("");
            rept_feature.DataBind();
            TextBox1.Text = ob1.inc3();
            TextBox2.Text = "";
            Button4.Enabled = false;
            Button1.Enabled = true;
        }
    }
}