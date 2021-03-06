<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 230px; top: 152px; position: absolute; height: 42px; width: 154px; right: 1721px" Text="Staff ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 228px; top: 195px; position: absolute; width: 124px;"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 227px; top: 278px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 224px; top: 325px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 615px; top: 280px; position: absolute; width: 76px;" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 580px; top: 319px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 227px; top: 403px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 224px; top: 447px; position: absolute; width: 472px;"></asp:TextBox>
        <asp:Label ID="lblContactNo" runat="server" style="z-index: 1; left: 225px; top: 516px; position: absolute; bottom: 1115px" Text="Contact No"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 225px; top: 561px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress1" runat="server" style="z-index: 1; left: 224px; top: 629px; position: absolute" Text="Address 1"></asp:Label>
        <asp:TextBox ID="txtAddress1" runat="server" style="z-index: 1; left: 219px; top: 670px; position: absolute; width: 244px"></asp:TextBox>
        <asp:Label ID="lblAddress2" runat="server" style="z-index: 1; left: 617px; top: 629px; position: absolute; width: 85px;" Text="Address 2"></asp:Label>
        <asp:TextBox ID="txtAddress2" runat="server" style="z-index: 1; left: 578px; top: 668px; position: absolute; width: 245px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 224px; top: 740px; position: absolute" Text="Post Code"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 218px; top: 786px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 637px; top: 745px; position: absolute" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 585px; top: 781px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 222px; top: 880px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 218px; top: 1011px; position: absolute; height: 38px; width: 116px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 333px; top: 1011px; position: absolute; height: 38px; width: 116px" Text="Cancel" />
    </form>
</body>
</html>
