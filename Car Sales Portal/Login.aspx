﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Car_Sales_Portal.Login" %>
<!DOCTYPE html>
<html lang="en">
    
<head runat="server">
        <title>Matrix Admin</title><meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<link rel="stylesheet" href="css/bootstrap.min.css" />
		<link rel="stylesheet" href="css/bootstrap-responsive.min.css" />
        <link rel="stylesheet" href="css/matrix-login.css" />
        <link href="font-awesome/css/font-awesome.css" rel="stylesheet" />
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700,800' rel='stylesheet' type='text/css'>
    </head>
    <body>
        <form id="login" runat="server" class="form-vertical">
        <div id="loginbox">            
            
				<div class="control-group normal_text"> <h3><img src="img/logo.png" alt="Logo" /></h3></div>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <span class="add-on bg_lg"><i class="icon-user"> </i></span><asp:TextBox ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <span class="add-on bg_ly"><i class="icon-lock"></i></span><asp:TextBox ID="TextBox2" type="password" runat="server" placeholder="Password"></asp:TextBox>
                            
                        </div>
                    </div>
                </div>
                <div class="form-actions">
                    <span class="pull-left"><asp:LinkButton ID="LinkButton2" CssClass="flip-link btn btn-info" runat="server" OnClick="LinkButton2_Click">Register Here!</asp:LinkButton></span>
                    <span class="pull-right"><asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-success" OnClick="LinkButton1_Click"> Login</asp:LinkButton></span>
                </div>
            
            
        </div>
        
        <script src="js/jquery.min.js"></script>  
        <script src="js/matrix.login.js"></script>
       </form> 
    </body>

</html>














