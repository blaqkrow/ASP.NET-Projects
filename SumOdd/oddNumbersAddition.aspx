<%@ Page Language="C#" AutoEventWireup="true" CodeFile="oddNumbersAddition.aspx.cs" Inherits="oddNumbersAddition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Sum Odd<br />
        <asp:TextBox ID="tbMsg" runat="server" BorderStyle="Inset" Height="133px" ReadOnly="True" style="margin-top: 0px" TextMode="MultiLine" Width="821px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Compute" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <br />
        <br />
        Sum Even<br />
        <asp:TextBox ID="tbMsg2" runat="server" BorderStyle="Inset" Height="133px" ReadOnly="True" style="margin-top: 0px" TextMode="MultiLine" Width="821px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Button ID="btnCompute2" runat="server" OnClick="btnCompute2_Click" Text="Compute" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear2" runat="server" OnClick="btnClear2_Click" Text="Clear" />
        <br />
    
    </div>
    </form>
</body>
</html>
