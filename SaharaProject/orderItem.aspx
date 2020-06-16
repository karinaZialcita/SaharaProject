<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderItem.aspx.cs" Inherits="sahara.orderItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara</title>
    <style>
        *{
            text-align:center;
            align-content:center;
        }
        body
        {
            font-family: 'Segoe Script';
            color: sandybrown;
        }
        #cookieImage
        {
            width:40%;
            border-radius:25px;
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
                <img id="itemImage" runat="server" />
                   <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>
                <div id="buttons" runat="server">
                    <asp:Button ID="buyButton" onClick="clickBuy" Text="Buy" runat="server"/>
                    <asp:Button ID="cancelButton" onClick="clickCancel" Text="Cancel" runat="server" />
                    
                </div>
                <asp:Button ID="menu" onClick="clickMenu" Text="Main Menu" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
