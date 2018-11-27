<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Report_Cancel_Details.aspx.cs" Inherits="Car_Sales_Portal.Report_Cancel_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Report On Cancellation</h5>
     </div>
     <div class="form-actions">
            <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="PRINT" OnClientClick="return printData();" />
     </div>
    <div class="widget-box">
            <div class="widget-title">
                <span class="icon"><i class="icon-th"></i></span>
                <h5>Cancel Details</h5>
            </div>


            <div class="widget-content nopadding">
                <asp:Repeater ID="rept_price" runat="server">
                    <HeaderTemplate>
                        <table id="printTable" class="table table-bordered data-table ">
                            <thead>
                                <tr>
                                    <th>First Name</th>
                                    <th>Second Name</th>
                                    <th>Model Name</th>
                                    <th>Sub Model Name</th>
                                    <th>Account Info</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("FIRST_NAME") %>
                             
                            </td>
                            <td>
                                <%# Eval("LAST_NAME") %>
                            </td>
                            <td>
                                <%# Eval("MODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("SUBMODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("ACCOUNT_INFO") %>
                            </td>

                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                      </table>
                    </FooterTemplate>
                </asp:Repeater>


                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table id="printTable1" border="1" style="display: none; visibility: hidden;">
                            <thead>
                                <tr>
                                    <th>First Name</th>
                                    <th>Second Name</th>
                                    <th>Model Name</th>
                                    <th>Sub Model Name</th>
                                    <th>Account Info</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                             <td>
                                <%# Eval("FIRST_NAME") %>
                             
                            </td>
                            <td>
                                <%# Eval("LAST_NAME") %>
                            </td>
                            <td>
                                <%# Eval("MODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("SUBMODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("ACCOUNT_INFO") %>
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
