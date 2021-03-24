<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 238px;
            height: 239px;
        }
        #form1 {
            height: 47px;
            width: 2097px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 230px; top: 152px; position: absolute; height: 42px; width: 154px; right: 1721px" Text="Staff ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 228px; top: 195px; position: absolute; width: 124px;"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 227px; top: 337px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 224px; top: 383px; position: absolute; right: 1629px;"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 615px; top: 333px; position: absolute; width: 180px;" Text="Last Name"></asp:Label>
        <img class="auto-style1" longdesc="http://localhost:58901/Logo.jpg" src="Logo.jpg" /><asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 595px; top: 376px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 227px; top: 518px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 228px; top: 568px; position: absolute; width: 472px;"></asp:TextBox>
        <asp:Label ID="lblContactNo" runat="server" style="z-index: 1; left: 229px; top: 609px; position: absolute; bottom: 721px; width: 132px;" Text="Contact No"></asp:Label>
        <asp:TextBox ID="txtContactNo" runat="server" style="z-index: 1; left: 225px; top: 661px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress1" runat="server" style="z-index: 1; left: 224px; top: 717px; position: absolute" Text="Address 1"></asp:Label>
        <asp:TextBox ID="txtAddress1" runat="server" style="z-index: 1; left: 219px; top: 771px; position: absolute; width: 244px; right: 1570px;"></asp:TextBox>
        <asp:Label ID="lblAddress2" runat="server" style="z-index: 1; left: 627px; top: 713px; position: absolute; width: 176px;" Text="Address 2"></asp:Label>
        <asp:TextBox ID="txtAddress2" runat="server" style="z-index: 1; left: 593px; top: 766px; position: absolute; width: 245px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 224px; top: 824px; position: absolute" Text="Post Code"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 218px; top: 875px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 637px; top: 824px; position: absolute" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 594px; top: 873px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 222px; top: 1052px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 218px; top: 1100px; position: absolute; height: 38px; width: 116px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 333px; top: 1100px; position: absolute; height: 38px; width: 116px" Text="Cancel" />
        <p>
            <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 229px; top: 426px; position: absolute" Text="Gender "></asp:Label>
            <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 226px; top: 468px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 226px; top: 235px; position: absolute" Text="Title "></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 227px; top: 281px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 223px; top: 935px; position: absolute" Text="StartDate"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 224px; top: 971px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkEmployeeStatus" runat="server" style="z-index: 1; left: 604px; top: 962px; position: absolute" Text="EmployeeStatus" />
        </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 985px; top: 177px; position: absolute; height: 37px; width: 126px" Text="Find" />
    </form>
    </body>
</html>
