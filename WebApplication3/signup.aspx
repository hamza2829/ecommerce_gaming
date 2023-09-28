<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebApplication3.WebForm1" %>

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
    <div class="imager" >
            <div class="header">
                <h1>HS</h1>
            </div>
            <div class="Form">
                <h2 style="font-weight: bold;">Sign Up</h2>
                <hr />
                <p>Name</p>
                <asp:TextBox runat="server" ID="txtName" Text="Enter name" />
                <p>Email</p>
                <asp:TextBox runat="server" ID="txtEmail" Text="Enter Your Email" />
                <p>addresse</p>
                <asp:TextBox runat="server" ID="Textadd" Text="Enter Your addresse" />
                <p>contact</p>
                <asp:TextBox runat="server" ID="Textcontact" Text="Enter Your contact" />
                <p>Password</p>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <p></p>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                   <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
