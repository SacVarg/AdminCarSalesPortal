<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin_Log.aspx.cs" Inherits="Car_Sales_Portal.Admin_Log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="widget-box">
            <div class="widget-title">
                <span class="icon"><i class="icon-th"></i></span>
                <h5>Log Details</h5>
            </div>

            <div class="widget-content nopadding">
                <asp:Repeater ID="rept_price" runat="server">
                    <HeaderTemplate>
                        <table id="printTable" class="table table-bordered data-table ">
                            <thead>
                                <tr>
                                    <th>Admin Name</th>
                                    <th>Login Date</th>
                                    <th>Login Time</th>
                                    <th>Logout Date</th>
                                    <th>Logout Time</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("USER_NAME") %>
                             
                            </td>
                            <td>
                                <%# Eval("LOGIN_DATE") %>
                            </td>
                            <td>
                                <%# Eval("LOGIN_TIME") %>
                            </td>
                            <td>
                                <%# Eval("LOGOUT_DATE") %>
                            </td>
                            <td>
                                <%# Eval("LOGOUT_TIME") %>
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

</asp:Content>
