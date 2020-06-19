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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Sahara</h1>
        <div>
            <div id="options" runat="server">
                <div id="item" runat="server">
                </div>
                   <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>
                <div id="buttons" runat="server">
                    <asp:Button ID="buyButton" onClick="clickBuy" Text="Buy" runat="server"/>
                    
                </div>
            </div>
        </div>
        <p>
                    <asp:Button ID="cancelButton" onClick="clickCancel" Text="Cancel" runat="server" />
                    
                </p>
        <p>
                <asp:Button ID="menu" onClick="clickMenu" Text="Main Menu" runat="server" />
            </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
