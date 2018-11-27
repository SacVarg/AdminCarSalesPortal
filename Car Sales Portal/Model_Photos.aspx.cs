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
    public partial class Model_Photos : System.Web.UI.Page
    {
        public static string mid;
        public static string pic1;
        public static string pic2;
        public static string pic3;
        public static string pic4;
        protected void Page_Load(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            if(!IsPostBack)
            {
                Button4.Enabled = false;
                DropDownList1.DataSource = ob1.getmodeldetails("0");
                DropDownList1.DataTextField = "MODEL_NAME";
                DropDownList1.DataValueField = "MODEL_ID";
                DropDownList1.DataBind();
                rept_model.DataSource = ob1.getModel_Photos();
                rept_model.DataBind();
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            int flag = ob.check3(DropDownList1.SelectedValue.ToString());
            if(flag==0)
            {
                string extension = "";
                string id = Guid.NewGuid().ToString();
                if (FileUpload1.HasFile)
                {
                    if (FileUpload1.PostedFile.ContentLength <= 2048000)
                    {

                        extension = id + Path.GetExtension(FileUpload1.FileName);

                        if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                        {
                            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension);
                        }
                    }
                }

                string extension1 = "";
                string id1 = Guid.NewGuid().ToString();
                if (FileUpload2.HasFile)
                {
                    if (FileUpload2.PostedFile.ContentLength <= 2048000)
                    {

                        extension1 = id1 + Path.GetExtension(FileUpload2.FileName);

                        if (FileUpload2.PostedFile.ContentType == "image/jpeg")
                        {
                            FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension1);
                        }
                    }
                }
                string extension2 = "";
                string id2 = Guid.NewGuid().ToString();
                if (FileUpload3.HasFile)
                {
                    if (FileUpload3.PostedFile.ContentLength <= 2048000)
                    {

                        extension2 = id2 + Path.GetExtension(FileUpload3.FileName);

                        if (FileUpload3.PostedFile.ContentType == "image/jpeg")
                        {
                            FileUpload3.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension2);
                        }
                    }
                }
                string extension3 = "";
                string id3 = Guid.NewGuid().ToString();
                if (FileUpload4.HasFile)
                {
                    if (FileUpload4.PostedFile.ContentLength <= 2048000)
                    {

                        extension3 = id3 + Path.GetExtension(FileUpload4.FileName);

                        if (FileUpload4.PostedFile.ContentType == "image/jpeg")

                            FileUpload4.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension3);
                    }
                }
                ob.model_photos_details(DropDownList1.SelectedValue.ToString(), extension, extension1, extension2, extension3);
                rept_model.DataSource = ob.getModel_Photos();
                rept_model.DataBind();
                DropDownList1.SelectedIndex = 0;
            }
            else
            {
                Label1.Text = "Alredy Exist";
            }
    
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            mid = bt.CommandName;
            Button4.Enabled = true;
            Button2.Enabled = false;
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.getModel_Photos_Update(mid);
            if (dt.Rows.Count > 0)
            {
                DropDownList1.SelectedValue = dt.Rows[0]["MODEL_ID"].ToString();
                pic1 = dt.Rows[0]["MODEL_PHOTO1"].ToString();
                pic2 = dt.Rows[0]["MODEL_PHOTO2"].ToString();
                pic3 = dt.Rows[0]["MODEL_PHOTO3"].ToString();
                pic4 = dt.Rows[0]["MODEL_PHOTO4"].ToString();
                Image11.ImageUrl = "~/Images/" + dt.Rows[0]["MODEL_PHOTO1"].ToString();
                Image12.ImageUrl = "~/Images/" + dt.Rows[0]["MODEL_PHOTO2"].ToString();
                Image13.ImageUrl = "~/Images/" + dt.Rows[0]["MODEL_PHOTO3"].ToString();
                Image14.ImageUrl = "~/Images/" + dt.Rows[0]["MODEL_PHOTO4"].ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob = new dml();

            string extension = "";
            string id = Guid.NewGuid().ToString();
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentLength <= 2048000)
                {

                    extension = id + Path.GetExtension(FileUpload1.FileName);

                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension);
                    }
                }
            }

            string extension1 = "";
            string id1 = Guid.NewGuid().ToString();
            if (FileUpload2.HasFile)
            {
                if (FileUpload2.PostedFile.ContentLength <= 2048000)
                {

                    extension1 = id1 + Path.GetExtension(FileUpload2.FileName);

                    if (FileUpload2.PostedFile.ContentType == "image/jpeg")
                    {
                        FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension1);
                    }
                }
            }
            string extension2 = "";
            string id2 = Guid.NewGuid().ToString();
            if (FileUpload3.HasFile)
            {
                if (FileUpload3.PostedFile.ContentLength <= 2048000)
                {

                    extension2 = id2 + Path.GetExtension(FileUpload3.FileName);

                    if (FileUpload3.PostedFile.ContentType == "image/jpeg")
                    {
                        FileUpload3.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension2);
                    }
                }
            }
            string extension3 = "";
            string id3 = Guid.NewGuid().ToString();
            if (FileUpload4.HasFile)
            {
                if (FileUpload4.PostedFile.ContentLength <= 2048000)
                {

                    extension3 = id3 + Path.GetExtension(FileUpload4.FileName);

                    if (FileUpload4.PostedFile.ContentType == "image/jpeg")
                    {
                        FileUpload4.PostedFile.SaveAs(Server.MapPath("~/Images/") + extension3);
                    }
                }
            }
            if (extension == "")
            {
                extension = pic1;
            }
            if (extension1 == "")
            {
                extension1 = pic2;
            }
            if (extension2 == "")
            {
                extension2 = pic3;
            }
            if (extension3 == "")
            {
                extension3 = pic4;
            }

            ob.update_model_photos(mid, extension, extension1, extension2, extension3);
            rept_model.DataSource = ob.getModel_Photos();
            rept_model.DataBind();
            Image11.ImageUrl = null;
            Image12.ImageUrl = null;
            Image13.ImageUrl = null;
            Image14.ImageUrl = null;
            DropDownList1.SelectedIndex = 0;
            Button4.Enabled = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = 0;
            Image11.ImageUrl = null;
            Image12.ImageUrl = null;
            Image13.ImageUrl = null;
            Image14.ImageUrl = null;
            Button4.Enabled = false;
            Button2.Enabled = true;
        }
           
          
        
    }
}