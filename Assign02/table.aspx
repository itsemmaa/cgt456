﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="table.aspx.cs" Inherits="Assign02.table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Link to Index</asp:HyperLink>
            <asp:Panel ID="myTable" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
