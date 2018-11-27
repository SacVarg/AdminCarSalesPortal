<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Price_Details.aspx.cs" Inherits="Car_Sales_Portal.Price_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">

        function validate()
        {
            var price = document.getElementById("ContentPlaceHolder1_TextBox2").value;

            var model = document.getElementById("ContentPlaceHolder1_DropDownList1");
            var model_name = model.options[model.selectedIndex].text;

            var color = document.getElementById("ContentPlaceHolder1_DropDownList3");
            var color_name = color.options[color.selectedIndex].text;

            var days = document.getElementById("ContentPlaceHolder1_TextBox3").value;

            if (model_name == "<---Select---->") {
                alert("Model Name Is Mandatory");
                return false;
            }
            if (model_name != "<---Select---->")
            {
                var type = document.getElementById("ContentPlaceHolder1_DropDownList2");
                var type_name = type.options[type.selectedIndex].text;
                if (type_name == "<---Select---->")
                {
                    alert("Sub Model Name Is Mandatory");
                    return false;
                }
            }
            if (color_name == "<---Select---->")
            {
                alert("Color Name Is Mandatory");
                return false;
            }
            if (price.trim() == "")
            {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Ex Showroom Price Is Mandatory");
                return false;
            }
            if (price != "")
            {
                if (isNaN(price)) {
                    document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                    alert("Invalid Price");
                    return false;
                }
            }
            if(days.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Expected Days Is Mandatory");
                return false;
            }
            if(days!="")
            {
                if (isNaN(days)) {
                    document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                    alert("Invalid day number");
                    return false;
                }
            }
        }

        
    </script>


    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Price Details</h5>
        </div>
        <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate">--%>
                <div class="control-group">
                    <label class="control-label">Price ID</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList1"  CssClass="select2-choice" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>

                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Sub-Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList2" CssClass="select2-choice" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>

                <div class="control-group">
                    <label class="control-label">Color Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList3" CssClass="select2-choice" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>

                <div class="control-group">
                    <label class="control-label">Ex-Showroom Price</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox2" runat="server" pattern="[0-9]+"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">Expected Days(Delivery)</label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox3" runat="server" pattern="[0-9]+"></asp:TextBox>
                    </div>
                </div>
                <div class="form-actions">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button1_Click" />
                    <asp:Button ID="Button3" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validate();" OnClick="Button3_Click" />
                    <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button4_Click" />
                    <asp:Label ID="Label1" CssClass="text-error" runat="server" ></asp:Label>
                </div>


                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>Price Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_price" runat="server">
                            <HeaderTemplate>
                                <table id="printTable" class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Price ID</th>
                                            <th>Model ID</th>
                                            <th>Sub-Model ID</th>
                                            <th>Color ID</th>
                                            <th>Ex Showroom Price</th>
                                            <th>Expected Days</th>
                                            <th>UPDATE</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# Eval("PRICE_ID") %>
                                        <%-- <asp:Label ID="lblcOMBANYID" runat="server" Text='<%# Eval("CustomerId") %>' />--%>
                                    </td>
                                    <td>
                                        <%# Eval("MODEL_ID") %>
                                    </td>
                                    <td>
                                        <%# Eval("SUBMODEL_ID") %>
                                    </td>
                                    <td>
                                        <%# Eval("COLOR_ID") %>
                                    </td>
                                    <td>
                                         <%# Eval("PRICE") %>
                                    </td>
                                    <td>
                                        <%# Eval("EXPECTED_DAYS") %>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" CommandName='<%# Eval("PRICE_ID") %>' OnClick="Btn_edit"  Text="CLICK" />
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


           <%-- </form>--%>
        </div>
    </div>




</asp:Content>
