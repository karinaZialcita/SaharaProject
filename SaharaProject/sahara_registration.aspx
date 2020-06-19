<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sahara_registration.aspx.cs" Inherits="sahara.sahara_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara Registration</title>
    <style>
        *{
            text-align:center;
            box-sizing:border-box;
            background-color: burlywood;
        }
        h1, h3
        {
            font-family: Georgia;
            color: saddlebrown;
        }
        h2 
        {
            font-family: Georgia; 
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
        <h3>Where you can only buy the best products!</h3>
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
            <asp:TextBox ID="txtPassword" runat="server" BorderColor="#000000" Width="318px" Height="30px" TextMode="Password" MaxLength="6"></asp:TextBox>
            <p />
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" BorderColor="#000000" Width="318px" Height="30px" TextMode="Password" MaxLength="6"></asp:TextBox>
            <p />
            <asp:Label ID="lblPhoneNum" runat="server" Text="Phone Number:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPhoneNum" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>

            <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtPhoneNum" Type="Integer" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck">Numbers Only are allowed</asp:CompareValidator>--%>

            <%--<asp:CompareValidator runat="server" id="cmpnumbers" controltovalidate="txtPhoneNum" type="Integer" errormessage="Numbers only"/>--%>

            <p />
            <asp:Button ID="register" runat="server" Text="Register" Height="30px" Width="97px" OnClick="register_name" Font-Bold="true"/>
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
            <asp:Button ID="loginButton" runat="server" Text="Login" Height="30px" Width="97px" OnClick="clickLogin" Font-Bold="true"/>
        </div>


    </div>
    </form>
</body>
</html>
