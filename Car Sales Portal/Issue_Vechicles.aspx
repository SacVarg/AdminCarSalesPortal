<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Issue_Vechicles.aspx.cs" Inherits="Car_Sales_Portal.Issue_Vechicles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function validate() {
            var type_name = document.getElementById("ContentPlaceHolder1_CheckBox1");
            if (type_name.checked==false) 
            {
                alert("Please Check Issue");
                return false;
            }
        }
    </script>

    <style>
        label{display:inline-block;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget-box">
    <div class="widget-title">
        <span class="icon"><i class="icon-info-sign"></i></span>
        <h5>Issue Car</h5>
    </div>
    <div class="widget-content nopadding">
        
        <div class="control-group">
                <label class="control-label">Booking ID</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
         </div>
        <div class="control-group">
                <label class="control-label">User Name</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </div>
         </div>
        <div class="control-group">
            <label class="control-label">Issue Date (dd-mm)</label>
            <div class="controls">
                <asp:TextBox ID="TextBox1" runat="server" data-date="01-02-2013" value="12-04-2017" data-date-format="dd-mm-yyyy" CssClass="datepicker span11" Width="100"></asp:TextBox>
                <span class="help-block">Date with Formate of  (dd-mm-yy)</span>
            </div>
        </div>

        <div class="control-group">
            <label class="control-label">Check Me</label>
            <div class="controls">
                
                <asp:CheckBox ID="CheckBox1" CssClass="checker hover focus" Width="100%" Text="Issue" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
              
            </div>
        </div>

        <div class="form-actions">
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="ISSUE" OnClientClick="return validate();" OnClick="Button1_Click" />
            <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button5_Click" />
            <asp:Label ID="Label1" CssClass="text-error" runat="server"></asp:Label>
        </div>

        <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"><i class="icon-th"></i></span>
                    <h5>Booked Details</h5>
                </div>


                <div class="widget-content nopadding">
                    <asp:Repeater ID="rept_model" runat="server">
                        <HeaderTemplate>
                            <table class="table table-bordered data-table">

                                <thead>
                                    <tr>
                                        <th>Booking ID</th>
                                        <th>First Name</th>
                                        <th>Last Name</th>
                                        <th>Status</th>
                                        <th>Model Name</th>
                                        <th>Submodel Name</th>
                                        <th>Balance Amount</th>
                                        <th>UPDATE</th>

                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <%# Eval("BOOKING_ID") %>
                                </td>
                                <td>
                                    <%# Eval("FIRST_NAME") %>
                                </td>
                                <td>
                                    <%# Eval("LAST_NAME") %>
                                </td>
                                <td>
                                     <%# Eval("STATUS") %>
                                </td>
                                <td>
                                     <%# Eval("MODEL_NAME") %>
                                </td>
                                <td>
                                     <%# Eval("SUBMODEL_NAME") %>
                                </td>
                                <td>
                                     <%# Eval("BALANCE_AMOUNT") %>
                                </td>
                                <td>
                                    <asp:Button ID="Button2" CssClass="btn btn-success" CommandArgument='<%# Eval("BOOKING_ID") %>' runat="server" OnClick="Btn_edit" Text="CLICK" />
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
