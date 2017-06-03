<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Admin_AddEvent.aspx.cs" Inherits="Admin_AddEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="18pt" Text="Add Events"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Event Name:"></asp:Label>
&nbsp;
<br />
<asp:TextBox ID="txtEName" runat="server" Width="242px"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
&nbsp;<br />
<asp:TextBox ID="txtDescription" runat="server" Height="66px" Width="242px"></asp:TextBox>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:Label ID="Label4" runat="server" Text="Date held:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
&nbsp;<br />
&nbsp;
<br />
<br />
<asp:Button ID="txtAdd" runat="server" onclick="txtAdd_Click" Text="Add" />
<br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

