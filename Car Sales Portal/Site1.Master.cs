using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["adminname"]!=null)
            {
                Response.ClearHeaders();
                Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                Response.AddHeader("Pragma", "no-cache");
                string name = (string)Session["adminname"];
                Label1.Text = "Welcome" + " " + name;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Company_Details.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Model_Details.aspx");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Type_Details.aspx");
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubModel_Details.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Feature_Details.aspx");
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Color_Details.aspx");
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("SMFeatures.aspx");
        }
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Price_Details.aspx");
        }
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report_Booking.aspx");
        }
        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("PasswordChange.aspx");
        }
        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            Response.Redirect("Slider_Images.aspx");
        }
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            ob.update_log((string)Session["lid"], DateTime.Now.ToString("HH:mm:ss tt"));
            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("Issue_Vechicles.aspx");
        }

        protected void LinkButton19_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment_Methods.aspx");
        }
        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report_Sales.aspx");
        }
        protected void LinkButton22_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report_MostBooked_Car.aspx");
        }
        protected void LinkButton21_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report_Cancel_Details.aspx");
        }
        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            Response.Redirect("Model_Photos.aspx");
        }
        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Log.aspx");
        }
    }
}