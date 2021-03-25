<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffManagementList" runat="server" style="z-index: 1; left: 278px; top: 231px; position: absolute; height: 44px; width: 373px" Text="Staff Management List "></asp:Label>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 123px; top: 288px; position: absolute; height: 410px; width: 646px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 150px; top: 748px; position: absolute"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 125px; top: 808px; position: absolute; width: 129px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 294px; top: 808px; position: absolute; height: 23px; width: 141px;" Text="DisplayAll" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 115px; top: 917px; position: absolute; width: 83px; right: 1905px" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 327px; top: 914px; position: absolute; height: 25px; width: 92px;" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 221px; top: 916px; position: absolute; width: 87px; height: 25px; right: 1795px; margin-bottom: 9px" Text="Edit" />
    </form>
</body>
</html>
