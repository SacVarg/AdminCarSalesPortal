using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class Report_Cancel_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob = new dml();
                DataTable dt = new DataTable();
                dt = ob.getCancel_Details();
                rept_price.DataSource = dt;
                rept_price.DataBind();
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
    }
}