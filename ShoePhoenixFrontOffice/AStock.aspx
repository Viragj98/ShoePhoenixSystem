<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 374px; top: 189px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; top: 189px; position: absolute; left: 463px"></asp:TextBox>
        </div>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 125px; top: 302px; position: absolute; width: 62px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 197px; top: 302px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblShoeName" runat="server" style="z-index: 1; left: 22px; top: 69px; position: absolute" Text="Shoe Name"></asp:Label>
        <asp:TextBox ID="txtShoeName" runat="server" style="z-index: 1; left: 106px; top: 68px; position: absolute; width: 207px"></asp:TextBox>
        <asp:Label ID="lblShoeType" runat="server" style="z-index: 1; left: 22px; top: 109px; position: absolute; width: 76px; right: 586px; bottom: 622px; margin-bottom: 0px" Text="Shoe Type"></asp:Label>
        <asp:TextBox ID="txtShoeSize" runat="server" style="z-index: 1; left: 463px; top: 65px; position: absolute; width: 45px"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 106px; top: 196px; position: absolute; height: 19px; width: 61px"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 463px; top: 107px; position: absolute; width: 110px; height: 16px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 464px; top: 147px; position: absolute; width: 90px"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 30px; top: 198px; position: absolute; bottom: 533px" Text="Quantity"></asp:Label>
        <asp:Label ID="lblShoeSize" runat="server" style="z-index: 1; left: 377px; top: 68px; position: absolute" Text="Shoe Size"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 385px; top: 109px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 391px; top: 149px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 36px; top: 153px; position: absolute" Text="Brand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 106px; top: 153px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtShoeType" runat="server" style="z-index: 1; left: 106px; top: 108px; position: absolute; width: 178px; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 365px; position: absolute; height: 19px"></asp:Label>
    
       
        <asp:TextBox ID="txtShoeID" runat="server" style="z-index: 1; left: 108px; top: 37px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblShoeID" runat="server" style="z-index: 1; left: 29px; top: 38px; position: absolute" Text="Shoe ID"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 52px; top: 302px; position: absolute; width: 64px" Text="Find" />
    
       
    </form>
</body>
</html>
