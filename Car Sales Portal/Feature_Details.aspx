<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Feature_Details.aspx.cs" Inherits="Car_Sales_Portal.Feature_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate() {
            var type_name = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            if (type_name.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Feature Name Is Mandatory");
                return false;
            }
        }
    </script>
     <div class="widget-box">
          <div class="widget-title"> <span class="icon"> <i class="icon-info-sign"></i> </span>
            <h5>Feature Details</h5>
          </div>
          <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate" >--%>
              <div class="control-group">
                <label class="control-label">Fearture ID</label>
                <div class="controls">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  
                </div>
              </div>
              <div class="control-group">
                <label class="control-label">Feature Name</label>
                <div class="controls">
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  
                </div>
              </div>

              <div class="form-actions">
                  <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button1_Click" />
                  <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button2_Click" />
                  <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validate();" OnClick="Button4_Click" />
              </div>
                
                
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Feature Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_feature" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Type ID</th>
                                            <th>Type Name</th>
                                            <th>UPDATE</th>
                                            
                                        </tr>
                                    </thead>
                                      <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("FEATURE_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("FEATURE_NAME") %>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("FEATURE_ID") %>' OnClick="Btn_edit" Text="CLICK" />
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
