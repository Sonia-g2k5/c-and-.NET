<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Department Management</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Department Management</h2>

        Department ID:
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br /><br />

        Department Name:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Button ID="btnInsert" runat="server"
            Text="Insert" OnClick="btnInsert_Click" />

        <asp:Button ID="btnUpdate" runat="server"
            Text="Update" OnClick="btnUpdate_Click" />

        <asp:Button ID="btnDelete" runat="server"
            Text="Delete" OnClick="btnDelete_Click" />

        <br /><br />

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    </form>
</body>
</html>
