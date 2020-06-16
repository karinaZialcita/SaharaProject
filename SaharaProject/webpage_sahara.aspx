<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webpage_sahara.aspx.cs" Inherits="sahara.webpage_sahara" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sahara Rugs And Mats</title>
    <style>
        body{
            font-family: 'Segoe Script';
            color: sandybrown;
            text-align:center;

        }
          * {
        box-sizing: border-box;
        }

        .column img {
        margin-top: 12px;
        }
        .column img {
        margin-top: 12px;
        }

        .column {
        float: left;
        width: 33.333%;
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
        }
        .itemPic{
          width:100%;
          border-radius: 25px;
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

            margin-left:25%;
            margin-right:25%;

            padding-top:5px;
        }
        #searchImage{
          width:50%;
          border-radius: 25px;
          text-align:center;
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

                <asp:Button ID="showCatalog" runat="server" style="text-align:center" text="Show Catalog" OnClick="onClickCatalog" />

                <div id="searchResult" runat="server"></div>
            <br /> 
                <div id="searchResult2" runat="server" style="display:none">
                    <asp:ImageButton ID="searchImage" runat="server" Onclick="clickItem"/>
                    <asp:Label ID="searchName" runat="server"></asp:Label>
                </div>
            <br />
                </div>
        
                    <div id="allItems" runat="server"></div>
        <div id="wrapper"  runat="server">
            <div class="row">
  
            <div class="column">
            <p id="caption">Rugs</p>
            <asp:ImageButton class="itemPic" src="items/bedrockRug.jpg" id="bedrockRug" onclick="clickItem" runat="server" AlternateText="Bed Rock Rug"/>
                <div class="itemDetail" >Bed Rock Rug</div>

            <asp:ImageButton class="itemPic" src="items/roseRug.jpg"  id="roseRug" onclick="clickItem" runat="server" AlternateText="Rose Rug"/>
            <div class="itemDetail" >Rose Rug</div>

            <asp:ImageButton class="itemPic" src="items/tropicalRug.jpg" id="tropicalRug" onclick="clickItem" runat="server" AlternateText="Tropical Rug"/>
                <div class="itemDetail" >Tropical Rug</div>

            <asp:ImageButton class="itemPic" src="items/lacyRug.jpg" id="lacyRug" onclick="clickItem" runat="server" AlternateText="Lacy Rug"/>
                <div class="itemDetail" >Lacy Rug</div>

            <asp:ImageButton class="itemPic" src="items/fluffyRug.jpg" id="fluffyRug" onclick="clickItem" runat="server" AlternateText="Fluffy Rug"/>
                <div class="itemDetail" >Fluffy Rug</div>

            </div>
            <div class="column">

            <p id="caption">Mats</p>
            <asp:ImageButton class="itemPic" src="items/brownMat.jpg" id="brownMat" onclick="clickItem" runat="server" AlternateText="Brown Mat"/>
                <p class="itemDetail" >Brown Mat</p>

            <asp:ImageButton class="itemPic" src="items/tatamiMat.jpg" id="tatamiMat" onclick="clickItem" runat="server" AlternateText="Tatami Mat"/>
                <p class="itemDetail">Tatami Mat</p>

            <asp:ImageButton class="itemPic" src="items/redKilimMat.jpg" id="redKilimMat" onclick="clickItem" runat="server" AlternateText="Red Kilim Mat"/>
                <p class="itemDetail" >Red Kilim Mat</p>

            <asp:ImageButton class="itemPic" src="items/avocadoMat.jpg" id="avocadoMat" onclick="clickItem" runat="server" AlternateText="Avocado Mat"/>
                <p class="itemDetail" >Avocado Mat</p>

            <asp:ImageButton class="itemPic" src="items/ivoryMat.jpg" id="ivoryMat" onclick="clickItem" runat="server"  AlternateText="Ivory Mat"/>
                <p class="itemDetail" >Ivory Mat</p>

            </div>
            </div>
        </div>
    </form>
</body>
</html>

