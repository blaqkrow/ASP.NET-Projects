<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_2.master" AutoEventWireup="true" CodeFile="Donation.aspx.cs" Inherits="Donation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
    <asp:Label ID="lblDonate" runat="server" Font-Size="18pt" Text="Donate!"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lblAmount" runat="server" Text="Donation Amount:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCharity" runat="server" Text="Charity Organisation:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Singapore Cancer Society</asp:ListItem>
        <asp:ListItem>NKF</asp:ListItem>
        <asp:ListItem>Community Chest</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Label ID="lblPayment" runat="server" Text="Payment Method:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                AutoPostBack="True" 
                                >
                            <asp:ListItem Value="0">None</asp:ListItem>
                            <asp:ListItem Value="1">MasterCard</asp:ListItem>
                            <asp:ListItem Value="2">Visa</asp:ListItem>
                            <asp:ListItem Value="3">AmericanExpress</asp:ListItem>
                            </asp:RadioButtonList>
    <br />
    <asp:Label ID="lblCardHolder" runat="server" Text="Card Holder:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCardHolder" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCardNumber" runat="server" Text="Card Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblSecurityCode" runat="server" Text="Security Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSecurity" runat="server" Width="95px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
&nbsp;<asp:Button ID="btnDonate" runat="server" onclick="btnDonate_Click" 
        Text="Donate" />
&nbsp;<p>
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

