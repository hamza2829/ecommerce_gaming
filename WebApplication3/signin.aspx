<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="WebApplication3.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="./StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>HS</h1>
        </div>
        <div class="box">
            <div class="login">
                <h2>Login</h2>
                <p></p>
                Username<asp:TextBox runat="server" ID="txtUserName" Text="Enter name" />
                 
                <p></p>
                Password <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <p></p>
                <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            </div>
            
    </form>
</body>
</html>
