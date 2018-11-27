<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Report_MostBooked_Car.aspx.cs" Inherits="Car_Sales_Portal.Report_MostBooked_Car" %>
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
            <h5>Report On Status</h5>
     </div>
     <div class="form-actions">
            <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="PRINT" OnClientClick="return printData();" />
     </div>

    <div class="widget-box">
            <div class="widget-title">
                <span class="icon"><i class="icon-th"></i></span>
                <h5>Status Details</h5>
            </div>


            <div class="widget-content nopadding">
                <asp:Repeater ID="rept_price" runat="server">
                    <HeaderTemplate>
                        <table id="printTable" class="table table-bordered data-table ">
                            <thead>
                                <tr>
                                    <th>Model Name</th>
                                    <th>Sub Model Name</th>
                                    <th>Status</th>
                                    <th>Count</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("MODEL_NAME") %>
                             
                            </td>
                            <td>
                                <%# Eval("SUBMODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("STATUS") %>
                            </td>
                            <td>
                                <%# Eval("NUMBER") %>
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
                                    <th>Model Name</th>
                                    <th>Sub Model Name</th>
                                    <th>Status</th>
                                    <th>Count</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                             <td>
                                <%# Eval("MODEL_NAME") %>
                             
                            </td>
                            <td>
                                <%# Eval("SUBMODEL_NAME") %>
                            </td>
                            <td>
                                <%# Eval("STATUS") %>
                            </td>
                            <td>
                                <%# Eval("NUMBER") %>
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
