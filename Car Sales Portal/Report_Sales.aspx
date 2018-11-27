<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Report_Sales.aspx.cs" Inherits="Car_Sales_Portal.Report_Sales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function printData() {
            var panel = document.getElementById("printTable1");
            var printWindow = window.open('', '', 'height=900,width=1200');
            printWindow.document.write('<html><head>  <title>Sales Report</title>');
            printWindow.document.write('</head><body >');
            panel.style = '';
            printWindow.document.write(panel.outerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            // panel.style.
            $("#printTable1").css('display', 'none');

            return false;

        }
    </script>
    <div class="widget-title">
        <span class="icon"><i class="icon-info-sign"></i></span>
        <h5>Sales Report</h5>
    </div>
    <div class="widget-content nopadding">


        <div class="control-group">
            <label class="control-label">From Date</label>
            <div class="controls">
                <asp:TextBox ID="TextBox1" runat="server" data-date="01-02-2013" value="2017-04-21" data-date-format="yyyy-mm-dd" CssClass="datepicker span11" Width="100"></asp:TextBox>
                <span class="help-block">Date with Formate of  (dd-mm-yy)</span>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">To Date</label>
            <div class="controls">
                <asp:TextBox ID="TextBox2" runat="server" data-date="01-02-2013" value="2017-04-21" data-date-format="yyyy-mm-dd" CssClass="datepicker span11" Width="100"></asp:TextBox>
                <span class="help-block">Date with Formate of  (dd-mm-yy)</span>
            </div>
        </div>
        <div class="form-actions">
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="PRINT" OnClientClick="return printData();" />
        </div>
        <div class="widget-box">
            <div class="widget-title">
                <span class="icon"><i class="icon-th"></i></span>
                <h5>Sales Details</h5>
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
                                    <th>Amount</th>
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
                                <%# Eval("PRICE") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Total Revenue</th>
                                <td>&nbsp</td>
                                <td>&nbsp</td>
                                <td>&nbsp</td>
                                <td>
                                    <asp:Label ID="Label1" Text=' <%# Eval("tPRICE") %>' runat="server"></asp:Label>
                                </td>
                            </tr>
                        </tfoot>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>

                <table id="printTable1" border="1" style="display: none; visibility: hidden;">

                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <thead>
                                <tr>
                                    <th>First Name</th>
                                    <th>Second Name</th>
                                    <th>Model Name</th>
                                    <th>Sub Model Name</th>
                                    <th>Amount</th>
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
                                    <%# Eval("PRICE") %>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                        </FooterTemplate>
                    </asp:Repeater>
                    <tr>
                        <th>Total Revenue</th>
                        <td>&nbsp</td>
                        <td>&nbsp</td>
                        <td>&nbsp</td>
                        <td>
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                    </tr>

                </table>

            </div>
        </div>

    </div>
</asp:Content>
