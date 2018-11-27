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
    public partial class Model_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob1 = new dml();
                TextBox1.Text = ob1.inc2();
                TextBox1.Enabled = false;
                Button4.Enabled = false;
                rept_model.DataSource = ob1.getmodeldetails("");
                rept_model.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            string status="";
            if(Radio1.Checked==true)
            {
                status = "NEW";
            }
            if(Radio2.Checked==true)
            {
                status = "OLD";
            }
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


            ob1.modeldetails(TextBox1.Text, TextBox2.Text,extension,status,TextBox4.Text);
            TextBox1.Text = ob1.inc2();
            TextBox2.Text = "";
            TextBox4.Text = "";
            Radio1.Checked = false;
            Radio2.Checked = false;
            rept_model.DataSource = ob1.getmodeldetails("");
            rept_model.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            TextBox1.Text = ob1.inc2();
            TextBox2.Text = "";
            TextBox4.Text = "";
            Button1.Enabled = true;
            Button4.Enabled = false;
            Radio1.Checked = false;
            Radio2.Checked = false;
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
           
            Button bt = (Button)sender;
            string modelid = bt.CommandName;
            dml ob1 = new dml();
            Button4.Enabled = true;
            Button1.Enabled = false;
            DataTable dt = new DataTable();
            dt = ob1.getmodeldetails_rep(modelid);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["MODEL_ID"].ToString();
                TextBox2.Text = dt.Rows[0]["MODEL_NAME"].ToString();
                TextBox4.Text = dt.Rows[0]["VIDEO_LINK"].ToString();
                string status = dt.Rows[0]["STATUS"].ToString();
                if(status=="NEW")
                {
                    Radio1.Checked = true;
                    Radio2.Checked = false;
                }
                else
                {
                    Radio2.Checked = true;
                    Radio1.Checked = false;
                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            string status = "";
            if (Radio1.Checked == true)
            {
                status = "NEW";
            }
            if (Radio2.Checked == true)
            {
                status = "OLD";
            }
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
            ob.update_model_details(TextBox1.Text, TextBox2.Text,extension,status,TextBox4.Text);
            TextBox1.Text = ob.inc2();
            TextBox2.Text = "";
            TextBox4.Text = "";
            Radio1.Checked = false;
            Radio2.Checked = false;
            Button1.Enabled = true;
            Button4.Enabled = false;
            rept_model.DataSource = ob.getmodeldetails("");
            rept_model.DataBind();
        }


    }
}