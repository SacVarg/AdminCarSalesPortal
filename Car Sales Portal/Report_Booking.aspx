<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Report_Booking.aspx.cs" Inherits="Car_Sales_Portal.Report_Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function printData() {
            var panel = document.getElementById("printTable1");
            var printWindow = window.open('', '', 'height=900,width=1200');
            printWindow.document.write('<html><head>  <title>Booking Report</title>');
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
            <h5>Report</h5>
      </div>
    <div class="widget-content nopadding">


            <div class="control-group">
              <label class="control-label">Date picker (dd-mm)</label>
              <div class="controls">
                <asp:TextBox ID="TextBox1" runat="server" data-date="01-02-2013" value="2017-04-21" data-date-format="yyyy-mm-dd" CssClass="datepicker span11" Width="100"></asp:TextBox>
                <span class="help-block">Date with Formate of  (dd-mm-yy)</span> </div>
            </div>

        <div class="form-actions">
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="PRINT" OnClientClick="return printData();" />
        </div>
        <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Booking Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_price" runat="server">
                            <HeaderTemplate>
                               <%-- <table id="printTable" class="table table-bordered data-table ">--%>
                                <table id="printTable" class="table table-bordered data-table ">
                                    <thead>
                                        <tr>
                                            <th>Booking ID</th>
                                            <th>Model Name</th>
                                            <th>Fuel Type</th>
                                            <th>Sub Model</th>
                                            <th>Amount</th>
                                            <th>Color</th>
                                            <th>User Name</th>
                                            <th>E-Mail</th>
                                            <th>Booking Date</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("BOOKING_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("MODEL_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("TYPE_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("SUBMODEL_NAME") %>
                                    </td>
                                    <td>
                                         <%# Eval("AMOUNT") %>
                                    </td>
                                    <td>
                                        <%# Eval("COLOR_NAME") %>
                                    </td>
                                     <td>
                                        <%# Eval("FIRST_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("USER_NAME") %>
                                    </td>
                                     <td>
                                        <%# Eval("BOOKING_DATE") %>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </tbody>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>

                   
                        <asp:Repeater ID="Repeater1"   runat="server">
                            <HeaderTemplate>
                               <%-- <table id="printTable" class="table table-bordered data-table ">--%>
                                <table id="printTable1"  border="1" style="display: none; visibility: hidden;">
                                    <thead>
                                        <tr>
                                            <th>Booking ID</th>
                                            <th>Model Name</th>
                                            <th>Fuel Type</th>
                                            <th>Sub Model</th>
                                            <th>Amount</th>
                                            <th>Color</th>
                                            <th>User Name</th>
                                            <th>E-Mail</th>
                                            <th>Booking Date</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("BOOKING_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("MODEL_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("TYPE_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("SUBMODEL_NAME") %>
                                    </td>
                                    <td>
                                         <%# Eval("AMOUNT") %>
                                    </td>
                                    <td>
                                        <%# Eval("COLOR_NAME") %>
                                    </td>
                                     <td>
                                        <%# Eval("FIRST_NAME") %>
                                    </td>
                                    <td>
                                        <%# Eval("USER_NAME") %>
                                    </td>
                                     <td>
                                        <%# Eval("BOOKING_DATE") %>
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
    
</asp:Content>
