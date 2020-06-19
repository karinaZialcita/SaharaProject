<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webpage_sahara.aspx.cs" Inherits="sahara.webpage_sahara" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara Rugs And Mats</title>
    <style>
        body{
            font-family: Georgia;
            color: saddlebrown;
            text-align:center;
            font-display: block;
        }
          * {
              align-content:center;
            box-sizing: border-box;
            background-color: burlywood;
        }
        .column {
            float: left;
            width: 20.333%;
            padding: 0px;
        }
        .row::after {
            content: "";
            clear: both;
            display: table;
        }

        #searchWallpaper {
            text-align:center;
            display:inline-block;

        }
        .column {
            float: left;
            padding: 10px;
            height: 300px;
            width:300px;
        }
        .row:after {
            content: "";
            display: table;
            clear: both;
        }
        #caption {
            border: solid black 1px;
            border-radius: 25px;
            text-align: center;


        }
        #wrapper {
            width: 75%;
            float:left;
            margin-left:15%;
            margin-right:25%;

            padding-top:5px;
        }
        #searchImage{
            width:50%;
            border-radius: 25px;
            text-align:center;
        }
        .searchColumn{
            width:50%;
            margin-left:25%;
            margin-right:25%;
        }
        
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <h1>Sahara</h1>
        <div id="searchWallpaper">
            <p id="welcomeName" runat="server"></p>

            <asp:TextBox ID="searchItem" runat="server" BorderColor="#000000" Width="318px" Height="30px"></asp:TextBox>
            <asp:Button ID="searchButton" runat="server"  text="Search" OnClick="onClickSearch" />

                <asp:Button ID="showCatalog" runat="server" style="text-align:center" text="Show Catalog" OnClick="toggleCatalog" />
                    <asp:Label ID="cartLabel" Text="Cart: " runat="server"></asp:Label>
                    <asp:Label ID="cartQuantity" Text="" runat="server"></asp:Label>
                
                    <asp:Button ID="goToCartBttn" runat="server" text ="Go To Cart" OnClick="goToCart"/>

                <div id="searchResult" runat="server">
                </div>
            <br /> 
                <div id="searchResult2" runat="server" style="display:none">
                    <asp:Label ID="searchName" runat="server"></asp:Label>
                </div>
            <br />
                </div>

            <div class="searchColumn">
                <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>

            </div>

        
        <div id="wrapper" style="display:none" runat="server">

            <div class="row">
            
            <div class="column">
            <p id="caption">Rugs</p>
                <asp:PlaceHolder runat="server" ID="PlaceHolderRugs"/>

                <%--onclick?
                <asp:ImageButton ID="Image1" runat="server" onClick="clickItem" ImageUrl="items/bedrockRug.jpg"/>--%>

            </div>
            <div class="column">
            <p id="caption">Mats</p>
                <asp:PlaceHolder runat="server" ID="PlaceHolderMats" />
            </div>
                <div class="column">
                    <p id="caption">Floorings</p>
                <asp:PlaceHolder runat="server" ID="PlaceHolderFloorings"/>

                </div>
            </div>
        </div>
    </form>
</body>
</html>

