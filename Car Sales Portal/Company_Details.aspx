<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Company_Details.aspx.cs" Inherits="Car_Sales_Portal.Company_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validationText() {
            var name = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var address = document.getElementById("ContentPlaceHolder1_TextBox3").value;
            var mob_number = document.getElementById("ContentPlaceHolder1_TextBox4").value;
            var land_number = document.getElementById("ContentPlaceHolder1_TextBox5").value;
            var email = document.getElementById("ContentPlaceHolder1_TextBox6").value;
            var web_addr=document.getElementById("ContentPlaceHolder1_TextBox7").value;
            if (name.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Name Field Is Mandatory");
                return false;
                
            }
            if(address.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Address Field Is Mandatory");
                return false;
            }
            if (mob_number.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Mobile Number Field Is Mandatory");
                return false;
            }
            if (isNaN(mob_number)) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Invalid Mobile Number");
                return false;
            }
            if (ContentPlaceHolder1_TextBox4.value.length != 10) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Invalid Mobile Number");
                return false;
            }
            if (land_number.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Land Number Field Is Mandatory");
                return false;
            }
            if (isNaN(land_number)) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Invalid Land Number");
                return false;
            }
            if (ContentPlaceHolder1_TextBox5.value.length != 7) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Invalid Land Number");
                return false;
            }
            if(email.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox6").focus();
                alert("Email Address is Mandatory");
                return false;
            }
            if (web_addr.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox7").focus();
                alert("Web Address Field Is Mandatory");
                return false;
            }

            if(web_addr!="")
            {
                function validateWeb()
                {
                    var x = document.getElementById("ContentPlaceHolder1_TextBox7").value;
                    var atpos = x.indexOf(".");
                    var dotpos = x.lastIndexOf(".");
                    if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= x.length) {
                        return false;
                    }
                }
                var b = validateWeb();
                if(b==false)
                {
                    document.getElementById("ContentPlaceHolder1_TextBox7").focus();
                    alert("Invalid Web Address");
                    return false;
                }
                
            }
            if(email!="")
            {

                function IsValidEmail(email) {
                    var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
                    return expr.test(email);
                };
                function ValidateEmail() {
                    var email = document.getElementById("ContentPlaceHolder1_TextBox6").value;
                    if (!IsValidEmail(email)) {
                        return false;
                    }

                }
                var b = ValidateEmail();
                if(b==false)
                {
                    document.getElementById("ContentPlaceHolder1_TextBox6").focus();
                    alert("Email Address is Invalid");
                    return false;
                }
            }
            
        }
    </script>
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Company Details</h5>
        </div>
        <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate">--%>
                <div class="control-group">
                    <label class="control-label">Company ID</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Company Name</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Address</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>

                <div class="control-group">
                    <label class="control-label">Mobile Contact Number</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="control-group">
                    <label class="control-label">Land-Line Contact Nmber</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">E-Mail Address</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Web Address</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-actions">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validationText();" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validationText();" OnClick="Button4_Click" />
                </div>






                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Company Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_comp" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Company ID</th>
                                            <th>Company Name</th>
                                            <th>Address</th>
                                            <th>MOB Number</th>
                                            <th>Land Number</th>
                                            <th>e-Mail</th>
                                            <th>Web Address</th>
                                             <th>UPADATE</th>
                                        </tr>
                                    </thead>
                                      <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("COMPANY_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("COMPANY_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("ADDRESS") %>
                                    </td>
                                    <td>
                                        <%# Eval("MOBILE_CONTACT_NO") %>
                                    </td>
                                    <td>
                                        <%# Eval("LAND_CONTACT_NO") %>
                                    </td>
                                     <td>
                                        <%# Eval("E_MAIL") %>
                                    </td>
                                    <td>
                                        <%# Eval("WEB_ADDRESS") %>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("COMPANY_ID") %>' OnClick="Btn_edit" Text="Click" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                 </tbody>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>

                    </div>
                </div>






           <%-- </form>--%>
        </div>
    </div>

</asp:Content>
