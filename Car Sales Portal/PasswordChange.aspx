<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="Car_Sales_Portal.PasswordChange" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate()
        {
            var pass = document.getElementById("ContentPlaceHolder1_TextBox3").value;
            var pass1 = document.getElementById("ContentPlaceHolder1_TextBox4").value;

            if (pass.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Enter Valid Password");
                return false;
            }
            if(pass1.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Enter Valid Password");
                return false;
            }
        }
    </script>

    <div class="widget-title">
        <span class="icon"><i class="icon-info-sign"></i></span>
        <h5>Change Password</h5>
    </div>

    <div class="widget-content nopadding">
        <div class="control-group">
            <label class="control-label">UserName</label>
            <div class="controls">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Current Password</label>
            <div class="controls">
                <asp:TextBox ID="TextBox2" type="password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">New Password</label>
            <div class="controls">
                <asp:TextBox ID="TextBox3" type="password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Confirm Password</label>
            <div class="controls">
                <asp:TextBox ID="TextBox4" type="password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-actions">
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
        </div>
    </div>
</asp:Content>
