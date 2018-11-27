using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Sales_Portal
{
    public partial class SMFeatures : System.Web.UI.Page
    {
        string smid;
        protected void Page_Load(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            if (!IsPostBack)
            {
                Button3.Enabled = false;
                
                DropDownList2.DataSource = ob1.getmodeldetails("0");
                DropDownList2.DataTextField = "MODEL_NAME";
                DropDownList2.DataValueField = "MODEL_ID";
                DropDownList2.DataBind();

                CheckBoxList1.DataSource = ob1.getfeaturedetails("0");
                CheckBoxList1.DataTextField = "FEATURE_NAME";
                CheckBoxList1.DataValueField = "FEATURE_ID";
                CheckBoxList1.DataBind();

                rept_smfeature.DataSource = ob1.getsmfeaturedetails();
                rept_smfeature.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            string id=ob1.inc5();
            int flag = ob1.check2(DropDownList2.SelectedValue.ToString(),DropDownList1.SelectedValue.ToString());
            if(flag==0)
            {
                foreach (ListItem li in CheckBoxList1.Items)
                {
                    if (li.Selected)
                    {
                        ob1.smdetails(id,DropDownList2.SelectedValue.ToString(),DropDownList1.SelectedValue.ToString(),li.Value);
                    }
                }
            }
            else
            {
                Label1.Text = "Alredy Exist";
            }
            
            rept_smfeature.DataSource = ob1.getsmfeaturedetails();
            rept_smfeature.DataBind();
            DropDownList2.SelectedValue = "0";
            DropDownList1.SelectedValue = "0";
            CheckBoxList1.DataSource = ob1.getfeaturedetails("0");
            CheckBoxList1.DataTextField = "FEATURE_NAME";
            CheckBoxList1.DataValueField = "FEATURE_ID";
            CheckBoxList1.DataBind();
        }
        protected void Btn_edit(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button3.Enabled = true;
            Button bt = (Button)sender;
            string smf_id= bt.CommandName;
            
            dml ob1 = new dml();
            DataTable dt = new DataTable();
            dt = ob1.get_sm_feature_details(smf_id);
            if (dt.Rows.Count > 0)
            {
                foreach(ListItem li in CheckBoxList1.Items)
                {
                    li.Selected = false;
                }
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    ListItem listItem = this.CheckBoxList1.Items.FindByValue(dt.Rows[i][3].ToString());
                    if(listItem!=null)
                    {
                        listItem.Selected = true;
                    }
                }
            }
            DataTable dt1 = new DataTable();
            dt1 = ob1.get_sm_feature_details(smf_id);
            if(dt1.Rows.Count>0)
            {
                DropDownList2.SelectedValue = dt1.Rows[0]["MODEL_ID"].ToString();
                DropDownList1.DataSource = ob1.getsubmodel_drop(DropDownList2.SelectedValue.ToString());
                DropDownList1.DataTextField = "SUBMODEL_NAME";
                DropDownList1.DataValueField = "SUBMODEL_ID";
                DropDownList1.DataBind();
                DropDownList1.SelectedValue = dt1.Rows[0]["SUBMODEL_ID"].ToString();
            }

       
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            string id=ob1.inc5();
            ob1.update_smfeature_details(DropDownList1.SelectedValue.ToString());
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ob1.smdetails(id,DropDownList2.SelectedValue.ToString(),DropDownList1.SelectedValue.ToString(), li.Value);
                }
            }
            rept_smfeature.DataSource = ob1.getsmfeaturedetails();
            rept_smfeature.DataBind();
            DropDownList2.SelectedValue = "0";
            DropDownList1.SelectedValue = "0";
            CheckBoxList1.DataSource = ob1.getfeaturedetails("0");
            CheckBoxList1.DataTextField = "FEATURE_NAME";
            CheckBoxList1.DataValueField = "FEATURE_ID";
            CheckBoxList1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dml ob1 = new dml();
            DropDownList1.SelectedValue = "0";
            DropDownList2.SelectedValue = "0";
            Button1.Enabled = true;
            Button3.Enabled = false;
            CheckBoxList1.DataSource = ob1.getfeaturedetails("0");
            CheckBoxList1.DataTextField = "FEATURE_NAME";
            CheckBoxList1.DataValueField = "FEATURE_ID";
            CheckBoxList1.DataBind();

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
            dml obj1 = new dml();
            DropDownList1.DataSource = obj1.getsubmodel_drop(DropDownList2.SelectedValue.ToString());
            DropDownList1.DataTextField = "SUBMODEL_NAME";
            DropDownList1.DataValueField = "SUBMODEL_ID";
            DropDownList1.DataBind();
        }
    }
}