<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment_Methods.aspx.cs" Inherits="Car_Sales_Portal.Payment_Methods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate() {
            var type_name = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            if (type_name.trim() == "")
            {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Payment Method Name Is Mandatory");
                return false;
            }
        }
    </script>
    <div class="widget-box">
          <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
            <h5>Payment Methods</h5>
          </div>
          <div class="widget-content nopadding">
            
              <div class="control-group">
                <label class="control-label">Payment_Method ID</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  
                </div>
              </div>
              <div class="control-group">
                <label class="control-label">Method Name</label>
                <div class="controls">
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  
                </div>
              </div>

              <div class="form-actions">
                  <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button1_Click"/>
                  <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
              </div>
                
              <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Payment Method Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_type" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Payment Method ID</th>
                                            <th>Method Name</th>
                                        </tr>
                                    </thead>
                                      <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("METHOD_ID") %>
                                       
                                    </td>
                                    <td>
                                        <%# Eval("METHOD_NAME") %>
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
