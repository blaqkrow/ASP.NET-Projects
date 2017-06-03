<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_EditEvent.aspx.cs" Inherits="Moderator_EditEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="18pt" Text="Update Events"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Event Name:"></asp:Label>
&nbsp;
<br />
<asp:TextBox ID="txtEName" runat="server" Width="242px"></asp:TextBox>
<br />
    <br />
    Event Image:<br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
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
<asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" Text="Update" />
<br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

