<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sahara_registration.aspx.cs" Inherits="sahara.sahara_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara Registration</title>
    <style>
        *{
            text-align:center;
            box-sizing:border-box;
        }
        h1, h3
        {
            font-family: 'Segoe Script';
            color: sandybrown;
        }
        #registration, #login
        {
            width:50%;
            float:left;
            padding:10px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to Sahara</h1>
        <h3>Where you can buy the best rugs and mats!</h3>
        <div class="row">
        <div id="registration">
            <h2>Register</h2>
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p /> 
            <asp:Label ID="lblEmailAdr" runat="server" Text="Email Address:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmailAdr" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" BorderColor="#000000" Width="318px" Height="30px" TextMode="Password"></asp:TextBox>
            <p />
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p />
            <asp:Label ID="lblPhoneNum" runat="server" Text="Phone Number:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPhoneNum" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p />
            <asp:Button ID="register" runat="server" Text="Register" Height="30px" Width="97px" OnClick="register_name"/>
        </div>
        <div id="login">
            <h2>Login</h2>
            <asp:Label ID="popuplabel" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="nameBox" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p />
            <asp:Label ID="lblLoginEmail" runat="server" Text="Email Address:"></asp:Label>
            <br />
            <asp:TextBox ID="txtLoginEmail" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <p />
            <asp:Label ID="lblLoginPass" runat="server" Text="Password:" ></asp:Label>
            <br />
            <asp:TextBox ID="txtLoginPass" runat="server" BorderColor="#000000" Width="318px" Height="30px" TextMode="Password"></asp:TextBox>
            <p />
            <asp:Button ID="loginButton" runat="server" Text="Login" Height="30px" Width="97px" OnClick="clickLogin"/>
        </div>


    </div>
    </form>
</body>
</html>
