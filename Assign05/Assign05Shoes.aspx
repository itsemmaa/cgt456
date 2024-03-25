<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assign05Shoes.aspx.cs" Inherits="Assign05.Assign05Shoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
              <Triggers>
                <asp:AsyncPostBackTrigger ControlID="select" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="selectOne" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="insert" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="update" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="delete" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="deleteAll" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="truncate" EventName="Click" />
            </Triggers>
            <ContentTemplate>
                <asp:Button runat="server" ID="select" Text="select" OnClick="Select_Click" />
                <asp:Button runat="server" ID="selectOne" Text="select one" OnClick="SelectOne_Click" />
                <asp:Button runat="server" ID="insert" Text="insert" OnClick="Insert_Click" />
                <asp:Button runat="server" ID="update" Text="update" OnClick="Update_Click" />
                <asp:Button runat="server" ID="delete" Text="delete" OnClick="Delete_Click" />
                <asp:Button runat="server" ID="deleteAll" Text="delete all" OnClick="DeleteAll_Click" />
                <asp:Button runat="server" ID="truncate" Text="truncate" OnClick="Truncate_Click" />
                <br />

                <asp:DataGrid runat="server" ID="results" />
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:HyperLink ID="Assign05" runat="server" NavigateUrl="Assign05.aspx">Assign05</asp:HyperLink>
        <asp:HyperLink ID="Text" runat="server" NavigateUrl="Assign05.txt">Text</asp:HyperLink>B

        </div>
    </form>
</body>
</html>
