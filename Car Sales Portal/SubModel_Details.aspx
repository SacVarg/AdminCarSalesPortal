<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SubModel_Details.aspx.cs" Inherits="Car_Sales_Portal.SubModel_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function showimagepreview(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image1').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }

        function Validate()
        {
            var submodel = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var model = document.getElementById("ContentPlaceHolder1_DropDownList1");
            var model_name = model.options[model.selectedIndex].text;

            var type = document.getElementById("ContentPlaceHolder1_DropDownList2");
            var type_name = type.options[type.selectedIndex].text;


            var amount = document.getElementById("ContentPlaceHolder1_TextBox3").value;

            var filevalue = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            if(submodel.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Sub Model Name Is Mandatory");
                return false;
            }
            if(model_name=="<---Select---->")
            {
                alert("Model Name Is Mandatory");
                return false;
            }
            if(type_name=="<---Select---->")
            {
                alert("Type Name Is Mandatory");
                return false;
            }
            if(amount.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Adv Amount Is Mandatory");
                return false;
            }
            if(amount!="")
            {
                if(isNaN(amount))
                {
                    document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                    alert("Invalid Amount");
                    return false;
                }
            }
            if (filevalue == "") {
                alert("Insert Image File");
                return false;
            }
            if (filevalue != "")
            {
                function ValidateExtension()
                {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload2");
                    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:\(\)])+(" + allowedFiles.join('|') + ")$");
                    if (!regex.test(fileUpload.value.toLowerCase())) {
                        return false;
                    }
                }
                var b = ValidateExtension();
                if (b == false) {
                    alert("Invalid File");
                    return false;
                }
            }
        }
        function Validate_Update()
        {
            var submodel = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var model = document.getElementById("ContentPlaceHolder1_DropDownList1");
            var model_name = model.options[model.selectedIndex].text;

            var type = document.getElementById("ContentPlaceHolder1_DropDownList2");
            var type_name = type.options[type.selectedIndex].text;


            var filevalue = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            var amount = document.getElementById("ContentPlaceHolder1_TextBox3").value;

            if (submodel.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Sub Model Name Is Mandatory");
                return false;
            }
            if (model_name == "<---Select---->") {
                alert("Model Name Is Mandatory");
                return false;
            }
            if (type_name == "<---Select---->") {
                alert("Type Name Is Mandatory");
                return false;
            }
            if (amount.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Adv Amount Is Mandatory");
                return false;
            }
            if (amount != "") {
                if (isNaN(amount)) {
                    document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                    alert("Invalid Amount");
                    return false;
                }
            }
            if (filevalue != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload2");
                    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:\(\)])+(" + allowedFiles.join('|') + ")$");
                    if (!regex.test(fileUpload.value.toLowerCase())) {
                        return false;
                    }
                }
                var b = ValidateExtension();
                if (b == false) {
                    alert("Invalid File");
                    return false;
                }
            }
        }



    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Sub-Model Details</h5>
        </div>
        <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate">--%>
                <div class="control-group">
                    <label class="control-label">Sub-Model ID</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Sub-Model Name</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList1" CssClass="select2-choice" runat="server" Width="200px">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Type Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList2" CssClass="select2-choice" runat="server" Width="200px">
                        </asp:DropDownList>
                    </div>
                </div>
                <%--<div class="control-group">
                    <label class="control-label">Price(RS)</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                    </div>
                </div>--%>

                <div class="control-group">
                    <label class="control-label">Upload Photos</label>
                    <div class="controls">
                        <asp:FileUpload ID="FileUpload2" onchange="showimagepreview(this)" runat="server" />
                        <asp:Image ID="Image1" runat="server" Height="70px" Width="100px" />

                    </div>



                </div>

                

                <div class="control-group">
                    <label class="control-label">Advance Amount</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox3" runat="server" pattern="[0-9]+"></asp:TextBox>
                    </div>
                </div>


                <div class="form-actions">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return Validate();" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return Validate_Update();" OnClick="Button4_Click" />
                </div>






                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Sub-Model Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_submodel" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Sub Model ID</th>
                                            <th>Sub Model Name</th>
                                            <th>Model ID</th>
                                            <th>Adv_Amount</th>
                                            <th>Image</th>
                                            <th>UPDATE</th>

                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("SUBMODEL_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("SUBMODEL_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("MODEL_ID") %>
                                    </td>
                                    <td>
                                        <%# Eval("ADV_AMOUNT") %>
                                    </td>
                                    <td>
                                        <asp:Image ID="Image2" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("PICTURE").ToString() %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("SUBMODEL_ID") %>' OnClick="Btn_edit" Text="CLICK" />
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





            <%--</form>--%>

        </div>
    </div>

</asp:Content>
