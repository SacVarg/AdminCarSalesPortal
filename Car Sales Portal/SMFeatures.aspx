<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SMFeatures.aspx.cs" Inherits="Car_Sales_Portal.SMFeatures" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        label{display:inline-block;}
    </style>
    <script type="text/javascript">
        function validate() {
            var model = document.getElementById("ContentPlaceHolder1_DropDownList2");
            var model_name = model.options[model.selectedIndex].text;
            var flag = false;

            if (model_name == "<---Select---->") {
                alert("Model Name Is Mandatory");
                return false;
            }
            if (model_name != "<---Select---->") {
                var type = document.getElementById("ContentPlaceHolder1_DropDownList1");
                var type_name = type.options[type.selectedIndex].text;
                if (type_name == "<---Select---->") {
                    alert("Sub Model Name Is Mandatory");
                    return false;
                }
                flag = true;
            }
            if (flag == true && model_name != "<---Select---->")
            {
                var atLeast = 1
                var b = Validate_Checkbox();
                function Validate_Checkbox()
                {
                    var CHK = document.getElementById("<%=CheckBoxList1.ClientID%>");
                    var checkbox = CHK.getElementsByTagName("input");
                    var counter = 0;
                    for (var i = 0; i < checkbox.length; i++) {
                        if (checkbox[i].checked) {
                            counter++;
                        }
                    }
                    if (atLeast > counter) {
                        
                        return false;
                    }
                    return true;
                }
                if(b==false)
                {
                    alert("Please select atleast one Item");
                    return false;
                }
            }
            
        }


    </script>
    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"><i class="icon-info-sign"></i></span>
            <h5>Sub-Model Features</h5>
        </div>
        <div class="widget-content nopadding">
            <%--<form runat="server" class="form-horizontal" id="basic_validate">--%>

                <div class="control-group">
                    <label class="control-label">Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList2" CssClass="select2-choice" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>



                <div class="control-group">
                    <label class="control-label">Sub Model Name</label>
                    <div class="controls">
                        <asp:DropDownList ID="DropDownList1" CssClass="select2-choice" runat="server" Width="200px"></asp:DropDownList>
                    </div>
                </div>


                <div class="control-group">
                    <label class="control-label">Feature Name</label>
                    <div class="controls">
                        <%--<div id="uniform-undefined">--%>
                        <asp:CheckBoxList ID="CheckBoxList1" CssClass="checker hover focus" runat="server" RepeatLayout="Flow" Width="100%"></asp:CheckBoxList>
                        <%-- </div>--%>
                    </div>
                </div>


                <div class="form-actions">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClientClick="return validate();" OnClick="Button1_Click" />
                    <asp:Button ID="Button3" CssClass="btn btn-danger" runat="server" Text="UPDATE" OnClientClick="return validate();" OnClick="Button3_Click" />
                    <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="RESET" OnClick="Button4_Click" />
                    <asp:Label ID="Label1" CssClass="text-error" runat="server"></asp:Label>
                </div>

                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-th"></i></span>
                        <h5>SubModel-Feature Details</h5>
                    </div>


                    <div class="widget-content nopadding">
                        <asp:Repeater ID="rept_smfeature" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered data-table">

                                    <thead>
                                        <tr>
                                            <th>Model-Name</th>
                                            <th>SubModel-Name</th>
                                            <th>UPDATE</th>

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
                                        <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" CommandName='<%# Eval("SMF_ID") %>' OnClick="Btn_edit" Text="CLICK" />
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
