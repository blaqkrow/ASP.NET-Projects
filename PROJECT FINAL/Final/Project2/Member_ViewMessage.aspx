<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Member_ViewMessage.aspx.cs" Inherits="Member_ViewMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="18pt" Text="Message Details"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Sender Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtSenderName" runat="server" ReadOnly="True" Width="369px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Subject:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRSubject" runat="server" ReadOnly="True" Width="261px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Message:"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMessage" runat="server" Height="160px" ReadOnly="True" 
            Width="367px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Date Recieved:"></asp:Label>
&nbsp;<asp:Label ID="lblDate" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Font-Size="18pt" Text="Send Message"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Subject:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSSubject" runat="server" Width="262px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Message:"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:TextBox ID="txtSMessage" runat="server" Height="160px" Width="367px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnReply" runat="server" onclick="btnReply_Click" 
            Text="Reply" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

