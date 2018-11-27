<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Color_Details.aspx.cs" Inherits="Car_Sales_Portal.Color_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate()
        {
            var name = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            if(name.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Color Name Field Is Mandatory");
                return false;
            }
        }
    </script>
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Color Details</h5>
        </div>
        <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate">--%>
                <div class="control-group">
                    <label class="control-label">Color ID</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Color Name</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </div>
                </div>
                <div class="form-actions">
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="RESET" OnClick="Button2_Click" />
                </div>

                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Color Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_color" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Color ID</th>
                                            <th>Color Name</th>
                                        </tr>
                                    </thead>
                                      <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("COLOR_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("COLOR_NAME") %>
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
