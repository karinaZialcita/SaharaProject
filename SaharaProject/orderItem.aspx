<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderItem.aspx.cs" Inherits="sahara.orderItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara</title>
    <style>
        *{
            text-align:center;
            align-content:center;
            background-color: burlywood;
        }
        #cookieImage
        {
            width:40%;
            border-radius:25px;
        }
        body
        {
            font-family: Georgia;
            color: saddlebrown;
        }
        #buttons {
            height: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Sahara</h1>
        <div>
            <asp:Label ID="label1" runat="server"></asp:Label>
            <div id="options" runat="server">
                <div id="item" runat="server">
                </div>
                   <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>
            <br/>
                <div id="buttons" runat="server">
                    <asp:Button ID="buyButton" runat="server" Text="Buy" OnClick="clickBuy" Width="147px"/>
                    <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="clickCancel" Width="146px" />
                </div>
            </div>
        </div>        
                <p>
                <asp:Button ID="menu" onClick="clickMenu" Text="Main Menu" runat="server" Width="167px" />  
                </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
