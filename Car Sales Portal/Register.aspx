<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Car_Sales_Portal.Register" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Matrix Admin</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script type="text/javascript">
        function validationText() {
            var email = document.getElementById("TextBox3").value;
            var name = document.getElementById("TextBox1").value;
            var pass = document.getElementById("TextBox2").value;

            if (email.trim() == "") {
                document.getElementById("TextBox3").focus();
                alert("Email is Mandatory");
                return false;
            }
            if (name.trim() == "") {
                document.getElementById("TextBox1").focus();
                alert("Name Field Is Mandatory");
                return false;
            }
            if (pass.trim() == "") {
                document.getElementById("TextBox2").focus();
                alert("Password Field Is Mandatory");
                return false;
            }
            if (email != "")
            {

                function IsValidEmail(email) {
                    var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
                    return expr.test(email);
                };
                function ValidateEmail() {
                    var email = document.getElementById("TextBox3").value;
                    if (!IsValidEmail(email)) {
                        return false;
                    }

                }
                var b = ValidateEmail();
                if (b == false) {
                    document.getElementById("TextBox3").focus();
                    alert("Email Address is Invalid");
                    return false;
                }
            }

        }
    </script>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/bootstrap-responsive.min.css" />
    <link rel="stylesheet" href="css/matrix-login.css" />
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700,800' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="recoverform" runat="server" class="form-vertical">
        

        <div id="loginbox">

            <p class="normal_text">Enter your e-mail address below.</p>
            <div class="control-group">
            <div class="controls">
                <div class="main_input_box">
                    <span class="add-on bg_lo"><i class="icon-envelope"></i></span>
                    <asp:TextBox ID="TextBox3" type="email" placeholder="E-mail address" runat="server"></asp:TextBox>
                </div>
            </div>
            </div>

            <div class="control-group">
            <div class="controls">
                <div class="main_input_box">
                    <span class="add-on bg_lg"><i class="icon-user"></i></span>
                    <asp:TextBox ID="TextBox1" placeholder="Username" runat="server"></asp:TextBox>
                </div>
            </div>
            </div>

            <div class="control-group">
            <div class="controls">
                <div class="main_input_box">
                    <span class="add-on bg_ly"><i class="icon-lock"></i></span>
                    <asp:TextBox ID="TextBox2" type="password" placeholder="Password" runat="server"></asp:TextBox>
                </div>
            </div>
            </div>
           

            <div class="form-actions">
                <span class="pull-left"><asp:LinkButton ID="LinkButton1" CssClass="flip-link btn btn-success" runat="server" OnClick="LinkButton1_Click">&laquo; Back to login</asp:LinkButton></span>
                <span class="pull-right"><asp:LinkButton ID="LinkButton2" CssClass="btn btn-info" runat="server" OnClick="LinkButton2_Click" OnClientClick="return validationText();">Submit</asp:LinkButton></span>
            </div>

        </div>

        <script src="js/jquery.min.js"></script>
        <script src="js/matrix.login.js"></script>
    </form>
</body>

</html>















