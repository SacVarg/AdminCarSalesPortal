<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Model_Photos.aspx.cs" Inherits="Car_Sales_Portal.Model_Photos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate()
        {
            var model = document.getElementById("ContentPlaceHolder1_DropDownList1");
            var model_name = model.options[model.selectedIndex].text;

            var filevalue1 = document.getElementById("ContentPlaceHolder1_FileUpload1").value;
            var filevalue2 = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            var filevalue3 = document.getElementById("ContentPlaceHolder1_FileUpload3").value;
            var filevalue4 = document.getElementById("ContentPlaceHolder1_FileUpload4").value;

            if (model_name == "<---Select---->")
            {
                alert("Model Name Is Mandatory");
                return false;
            }
            if (filevalue1 == "") {
                alert("Insert First Image File");
                return false;
            }
            if (filevalue2 == "") {
                alert("Insert Second Image File");
                return false;
            }
            if (filevalue3 == "") {
                alert("Insert Third Image File");
                return false;
            }
            if (filevalue4 == "") {
                alert("Insert Fourth Image File");
                return false;
            }
            if (filevalue1 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload1");
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
            if (filevalue2 != "") {
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
            if (filevalue3 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload3");
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
            if (filevalue4 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload4");
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

        function validate_update() {
            var model = document.getElementById("ContentPlaceHolder1_DropDownList1");
            var model_name = model.options[model.selectedIndex].text;

            var filevalue1 = document.getElementById("ContentPlaceHolder1_FileUpload1").value;
            var filevalue2 = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            var filevalue3 = document.getElementById("ContentPlaceHolder1_FileUpload3").value;
            var filevalue4 = document.getElementById("ContentPlaceHolder1_FileUpload4").value;

            if (model_name == "<---Select---->") {
                alert("Model Name Is Mandatory");
                return false;
            }
            if (filevalue1 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload1");
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
            if (filevalue2 != "") {
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
            if (filevalue3 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload3");
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
            if (filevalue4 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload4");
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

        function showimagepreview(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image11').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }

        function showimagepreview1(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image12').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }

        function showimagepreview2(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image13').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }

        function showimagepreview3(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image14').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }

    </script>

    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Model Images</h5>
        </div>

        <div class="widget-content nopadding">
            <div class="control-group">
                    <label class="control-label">Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList1" CssClass="select2-choice" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>

            <div class="control-group">
                <label class="control-label">Upload Photo1</label>
                <div class="controls">
                    <asp:FileUpload ID="FileUpload1" onchange="showimagepreview(this)" runat="server" />
                    <asp:Image ID="Image11" runat="server" Height="70px" Width="100px" />
                </div>
            </div>

            <div class="control-group">
                <label class="control-label">Upload Photo2</label>
                <div class="controls">
                    <asp:FileUpload ID="FileUpload2" onchange="showimagepreview1(this)" runat="server" />
                    <asp:Image ID="Image12" runat="server" Height="70px" Width="100px" />
                </div>
            </div>

            <div class="control-group">
                <label class="control-label">Upload Photo3</label>
                <div class="controls">
                    <asp:FileUpload ID="FileUpload3" onchange="showimagepreview2(this)" runat="server" />
                    <asp:Image ID="Image13" runat="server" Height="70px" Width="100px" />
                </div>
            </div>

            <div class="control-group">
                <label class="control-label">Upload Photo4</label>
                <div class="controls">
                    <asp:FileUpload ID="FileUpload4" onchange="showimagepreview3(this)" runat="server" />
                    <asp:Image ID="Image14" runat="server" Height="70px" Width="100px" />
                </div>
            </div>


            <div class="form-actions">
                <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button2_Click" />
                <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validate_update();" OnClick="Button4_Click" />
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button1_Click" />
                <asp:Label ID="Label1" CssClass="text-error" runat="server"></asp:Label>
            </div>

            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"><i class="icon-th"></i></span>
                    <h5>Model Images</h5>
                </div>


                <div class="widget-content nopadding">
                    <asp:Repeater ID="rept_model" runat="server">
                        <HeaderTemplate>
                            <table class="table table-bordered data-table">

                                <thead>
                                    <tr>
                                        <th>MODEL ID</th>
                                        <th>PIC1</th>
                                        <th>PIC2</th>
                                        <th>PIC3</th>
                                        <th>PIC4</th>
                                        <th>UPDATE</th>

                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <%# Eval("MODEL_ID") %>
                                </td>
                                <td>
                                    <asp:Image ID="Image1" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("MODEL_PHOTO1").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Image ID="Image2" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("MODEL_PHOTO2").ToString() %>' runat="server" />
                                </td>   

                                <td>
                                    <asp:Image ID="Image3" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("MODEL_PHOTO3").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Image ID="Image4" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("MODEL_PHOTO4").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("MODEL_ID") %>' OnClick="Btn_edit" Text="CLICK" />
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



        </div>
    </div>
</asp:Content>
