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
    public partial class Slider_Images : System.Web.UI.Page
    {
        public static string picid;
        public static string pic1;
        public static string pic2;
        public static string pic3;
        public static string pic4;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob=new dml();
                Button4.Enabled = false;
                rept_model.DataSource = ob.get_rept_sliderimages();
                rept_model.DataBind();
            }
            
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            picid = bt.CommandName;
            Button4.Enabled = true;
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.get_sliderimages(picid);
            if(dt.Rows.Count>0)
            {
                pic1 = dt.Rows[0]["PICTURE1"].ToString();
                pic2 = dt.Rows[0]["PICTURE2"].ToString();
                pic3 = dt.Rows[0]["PICTURE3"].ToString();
                pic4 = dt.Rows[0]["PICTURE4"].ToString();
                Image11.ImageUrl = "~/Images/" + dt.Rows[0]["PICTURE1"].ToString();
                Image12.ImageUrl = "~/Images/" + dt.Rows[0]["PICTURE2"].ToString();
                Image13.ImageUrl = "~/Images/" + dt.Rows[0]["PICTURE3"].ToString();
                Image14.ImageUrl = "~/Images/" + dt.Rows[0]["PICTURE4"].ToString();
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
            if(extension=="")
            {
                extension=pic1;
            }
            if(extension1=="")
            {
                extension1=pic2;
            }
            if(extension2=="")
            {
                extension2=pic3;
            }
            if(extension3=="")
            {
                extension3=pic4;
            }

            ob.update_slider(picid, extension, extension1, extension2, extension3);
            rept_model.DataSource = ob.get_rept_sliderimages();
            rept_model.DataBind();
            Button4.Enabled = false;
            Image11.ImageUrl = null;
            Image12.ImageUrl = null;
            Image13.ImageUrl = null;
            Image14.ImageUrl = null;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button4.Enabled = false;
            Image11.ImageUrl = null;
            Image12.ImageUrl = null;
            Image13.ImageUrl = null;
            Image14.ImageUrl = null;
        }
    }
}