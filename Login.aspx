<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Shree_Plus.Login" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title>Log In</title>
    <style>
        .margin-bottom {
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="h-100 row align-items-center">
            <div class="container">
                <div class="row">
                    <div class="span12">
                        <fieldset>
                            <div id="legend">
                                <h1>Log In</h1>
                                <hr />
                            </div>
                            <div class="control-group">
                                <!-- Username -->
                                <h4>
                                    <label class="control-label" for="username">Username</label></h4>
                                <div class="controls ">
                                    <asp:TextBox ID="txtUserName" runat="server" placeholder="UserName" CssClass="input-xlarge margin-bottom form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="control-group">
                                <!-- Password-->
                                <h4>
                                    <label class="control-label" for="password">Password</label></h4>
                                <div class="controls">
                                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" CssClass="input-xlarge margin-bottom form-control"></asp:TextBox>
                                </div>
                            </div>
                            <hr />
                            <div class="control-group">
                                <!-- Button -->
                                <div class="controls">
                                    <asp:Button ID="btnLogin" runat="server" Text="LogIn" CssClass="btn btn-success" OnClick="btnLogin_Click" />
                                </div>
                            </div>
                            <hr />
                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
