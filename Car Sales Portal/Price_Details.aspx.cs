using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Price_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dml obj1=new dml();
                if(!IsPostBack)
                {
                    TextBox1.Text = obj1.inc7();
                    TextBox1.Enabled = false;
                    DropDownList1.DataSource = obj1.getmodeldetails("0");
                    DropDownList1.DataTextField = "MODEL_NAME";
                    DropDownList1.DataValueField = "MODEL_ID";
                    DropDownList1.DataBind();


                    DropDownList3.DataSource = obj1.getcolordetails("0");
                    DropDownList3.DataTextField = "COLOR_NAME";
                    DropDownList3.DataValueField = "COLOR_ID";
                    DropDownList3.DataBind();
                    rept_price.DataSource = obj1.getpricedetails();
                    rept_price.DataBind();
                    Button3.Enabled = false;
                }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dml obj1=new dml();
            Label1.Text = "";
            DropDownList2.DataSource = obj1.getsubmodel_drop(DropDownList1.SelectedValue.ToString());
            DropDownList2.DataTextField = "SUBMODEL_NAME";
            DropDownList2.DataValueField = "SUBMODEL_ID";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml obj1 = new dml();

            int flag=obj1.check1(DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString());
            if(flag==0)
            {
                obj1.pricedetails(TextBox1.Text, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), TextBox2.Text,TextBox3.Text);
                TextBox1.Text = obj1.inc7();
                TextBox2.Text = "";
                TextBox3.Text = "";
                DropDownList1.SelectedValue = "0";
                DropDownList2.SelectedValue = "0";
                DropDownList3.SelectedValue = "0";
                rept_price.DataSource = obj1.getpricedetails();
                rept_price.DataBind();
            }
            else
            {
                Label1.Text = "Alredy Exist";
            }

        }

        protected void Btn_edit(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button3.Enabled = true;
            Button bt = (Button)sender;
            string priceid = bt.CommandName;
            dml ob1 = new dml();
            DataTable dt = new DataTable();
            dt = ob1.getpricedetails_edit(priceid);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["PRICE_ID"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["MODEL_ID"].ToString();
                DropDownList2.DataSource = ob1.getsubmodel_drop(DropDownList1.SelectedValue.ToString());
                DropDownList2.DataTextField = "SUBMODEL_NAME";
                DropDownList2.DataValueField = "SUBMODEL_ID";
                DropDownList2.DataBind();
                DropDownList2.SelectedValue = dt.Rows[0]["SUBMODEL_ID"].ToString();
                DropDownList3.SelectedValue = dt.Rows[0]["COLOR_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["PRICE"].ToString();
                TextBox3.Text = dt.Rows[0]["EXPECTED_DAYS"].ToString();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            dml obj1 = new dml();

            //int flag=obj1.check1(DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString());
            //if(flag==0)
            //{
                obj1.update_pricedetails(TextBox1.Text, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(), TextBox2.Text,TextBox3.Text);
                TextBox1.Text = obj1.inc7();
                TextBox2.Text = "";
                TextBox3.Text = "";
                DropDownList1.SelectedValue = "0";
                DropDownList2.SelectedValue = "0";
                DropDownList3.SelectedValue = "0";
            //}
            //else
            //{
                //Label1.Text = "Alredy Exist";
            //}
            rept_price.DataSource = obj1.getpricedetails();
            rept_price.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button3.Enabled = false;
            dml obj=new dml();
            TextBox1.Text = obj.inc7();
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedValue = "0";
            DropDownList2.SelectedValue = "0";
            DropDownList3.SelectedValue = "0";
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
        }


    }
}