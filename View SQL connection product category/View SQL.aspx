<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View SQL.aspx.cs" Inherits="View_SQL_connection_product_category.View_SQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agil Gridview</title>
</head>
<link href="style.css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="CategoryName"></asp:Label>
            <asp:TextBox ID="txbox1" runat="server" OnTextChanged="txbox1_TextChanged"></asp:TextBox>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                HeaderStyle-CssClass="header" RowStyle-CssClass="rows"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btn1" runat="server" CssClass="button" Text="Search" OnClick="btn1_Click" />
        </div>
    </form>
</body>
</html>
