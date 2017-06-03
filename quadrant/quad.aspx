<%@ Page Language="C#" AutoEventWireup="true" CodeFile="quad.aspx.cs" Inherits="quad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Xcoord
        <asp:TextBox ID="tbX" runat="server"></asp:TextBox>
&nbsp;&nbsp; YCoord&nbsp;
        <asp:TextBox ID="tbY" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Height="75px">
            <br />
            <asp:Label ID="lblCoord" runat="server"></asp:Label>
        </asp:Panel>
        <br />
        <br />
        <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Compute" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
