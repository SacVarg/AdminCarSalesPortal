<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Model_Details.aspx.cs" Inherits="Car_Sales_Portal.Model_Details" %>

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


        function Validate() {
            var modelname = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var filevalue = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            var video = document.getElementById("ContentPlaceHolder1_TextBox4").value;
            var radio1 = document.getElementById("ContentPlaceHolder1_Radio1");
            var radio2 = document.getElementById("ContentPlaceHolder1_Radio2");

            if (modelname.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Model Name Is Mandatory");
                return false;
            }
            if (filevalue == "") {
                alert("Insert Image File");
                return false;
            }
            if (filevalue != "")
            {
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
            if (radio1.checked == false && radio2.checked == false)
            {
                alert("Select Status of Model");
                return false;
            }
            if(video.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Video Link Is Mandatory");
                return false;
            }
        }
        function validate_update()
        {
            var modelname = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var filevalue = document.getElementById("ContentPlaceHolder1_FileUpload2").value;
            var video = document.getElementById("ContentPlaceHolder1_TextBox4").value;
            var radio1 = document.getElementById("ContentPlaceHolder1_Radio1");
            var radio2 = document.getElementById("ContentPlaceHolder1_Radio2");

            if (modelname.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Model Name Is Mandatory");
                return false;
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
            if (radio1.checked == false && radio2.checked == false) {
                alert("Select Status of Model");
                return false;
            }
            if (video.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Video Link Is Mandatory");
                return false;
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Model Details</h5>
        </div>
        <div class="widget-content nopadding">
            <div class="control-group">
                <label class="control-label">Model ID</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label">Model Name</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                </div>
            </div>


            <div class="control-group">
                <label class="control-label">Status</label>
                <div class="controls">
                    
                  <label>
                  <div class="radio" id="uniform-undefined"><span class="checked"><asp:RadioButton ID="Radio1" GroupName="jesus" runat="server"></asp:RadioButton>  </span></div>
                  New</label>
                   <label>
                  <div class="radio" id="uniform-undefined1"><span class="checked"><asp:RadioButton ID="Radio2" GroupName="jesus" runat="server"></asp:RadioButton>  </span></div>
                  Old</label>
                </div>
            </div>
           
            <div class="control-group">
                <label class="control-label">Upload Photo</label>
                <div class="controls">
                    <asp:FileUpload ID="FileUpload2" onchange="showimagepreview(this)" runat="server" />
                    <asp:Image ID="Image1" runat="server" Height="70px" Width="100px" />
                </div>
            </div>
            <div class="control-group">
                    <label class="control-label">Video Link</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </div>
             </div>

            <div class="form-actions">
                <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return Validate();" OnClick="Button1_Click" />
                <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
                <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validate_update();" OnClick="Button4_Click" />
            </div>

            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"><i class="icon-th"></i></span>
                    <h5>Model Details</h5>
                </div>


                <div class="widget-content nopadding">
                    <asp:Repeater ID="rept_model" runat="server">
                        <HeaderTemplate>
                            <table class="table table-bordered data-table">

                                <thead>
                                    <tr>
                                        <th>Model ID</th>
                                        <th>Model Name</th>
                                        <th>Status</th>
                                        <th>Picture</th>
                                        <th>Video Link</th>
                                        <th>UPDATE</th>

                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <%# Eval("MODEL_ID") %>
                                    <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                </td>
                                <td>
                                    <%# Eval("MODEL_NAME") %>
                                </td>
                                <td>
                                    <%# Eval("STATUS") %>
                                </td>
                                <td>
                                    <asp:Image ID="Image2" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("MODEL_PICTURE").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <%# Eval("VIDEO_LINK") %>
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









            <%--</form>--%>
        </div>
    </div>
</asp:Content>
