<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Slider_Images.aspx.cs" Inherits="Car_Sales_Portal.Slider_Images" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Slider Images</h5>
        </div>

        <div class="widget-content nopadding">
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
                <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
                <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClick="Button4_Click" />
            </div>

            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"><i class="icon-th"></i></span>
                    <h5>Slider Images</h5>
                </div>


                <div class="widget-content nopadding">
                    <asp:Repeater ID="rept_model" runat="server">
                        <HeaderTemplate>
                            <table class="table table-bordered data-table">

                                <thead>
                                    <tr>
                                        <th>Picture ID</th>
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
                                    <%# Eval("PIC_ID") %>
                                </td>
                                <td>
                                    <asp:Image ID="Image1" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("PICTURE1").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Image ID="Image2" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("PICTURE2").ToString() %>' runat="server" />
                                </td>   

                                <td>
                                    <asp:Image ID="Image3" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("PICTURE3").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Image ID="Image4" Width="60px" Height="60px" ImageUrl='<%# "Images/"+Eval("PICTURE4").ToString() %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("PIC_ID") %>' OnClick="Btn_edit" Text="CLICK" />
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
