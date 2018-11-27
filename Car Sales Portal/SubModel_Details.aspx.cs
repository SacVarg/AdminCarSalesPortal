using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class SubModel_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            if (!IsPostBack)
            {
                Button4.Enabled = false;
                DropDownList1.DataSource = ob1.getmodeldetails("0");
                DropDownList1.DataTextField = "MODEL_NAME";
                DropDownList1.DataValueField = "MODEL_ID";
                DropDownList1.DataBind();

                DropDownList2.DataSource = ob1.gettypedetails("0");
                DropDownList2.DataTextField = "TYPE_NAME";
                DropDownList2.DataValueField = "TYPE_ID";
                DropDownList2.DataBind();
                rept_submodel.DataSource = ob1.getsmodeldetails("");
                rept_submodel.DataBind();  
                TextBox1.Text = ob1.inc4();


            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string fileName = "";
            string extension = "";
            string id = Guid.NewGuid().ToString();
               if (FileUpload2.HasFile)
               {
                   if (FileUpload2.PostedFile.ContentLength <= 2048000000)
                   {

                       extension = id + Path.GetExtension(FileUpload2.FileName);

                       if (FileUpload2.PostedFile.ContentType == "image/jpeg")
                       {
                           //fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);
                           FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension);
                       }
                   }
               }
            dml ob1 = new dml();
            ob1.subdetails(TextBox1.Text, TextBox2.Text, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), extension,TextBox3.Text);
            TextBox1.Text = ob1.inc4();
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            rept_submodel.DataSource = ob1.getsmodeldetails("");
            rept_submodel.DataBind();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob1=new dml();
            TextBox1.Text = ob1.inc4();
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList2.SelectedIndex = 0;
            DropDownList1.SelectedIndex = 0;
            Button1.Enabled = true;
            Button4.Enabled = false;
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button4.Enabled = true;
            Button bt = (Button)sender;
            string submodelid = bt.CommandName;
            dml ob1 = new dml();
            DataTable dt = new DataTable();
            dt = ob1.getsubmodeldetails_rep(submodelid);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["SUBMODEL_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["SUBMODEL_NAME"].ToString();
                TextBox3.Text = dt.Rows[0]["ADV_AMOUNT"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["MODEL_ID"].ToString();
                DropDownList2.SelectedValue = dt.Rows[0]["TYPE_ID"].ToString();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            dml ob1 = new dml();

            //string fileName = "";
            string extension = "";
            string id = Guid.NewGuid().ToString();
            if (FileUpload2.HasFile)
            {
                if (FileUpload2.PostedFile.ContentLength <= 2048000)
                {

                    extension = id + Path.GetExtension(FileUpload2.FileName);

                    if (FileUpload2.PostedFile.ContentType == "image/jpeg")
                    {
                        //fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);
                        FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension);
                    }
                }
            }
            
         
            ob1.update_submodel_details(TextBox1.Text, TextBox2.Text, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), extension,TextBox3.Text);
            TextBox1.Text = ob1.inc4();
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            rept_submodel.DataSource = ob1.getsmodeldetails("");
            rept_submodel.DataBind();
        }
    }
}