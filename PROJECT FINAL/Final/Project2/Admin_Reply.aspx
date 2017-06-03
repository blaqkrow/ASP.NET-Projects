<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_5.master" AutoEventWireup="true" CodeFile="Admin_Reply.aspx.cs" Inherits="Admin_Reply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="19pt" Text="Reply Message"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Reciever Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtRecieverName" runat="server" Width="203px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Message Subject:"></asp:Label>
    </p>
    <p>
&nbsp;<asp:TextBox ID="txtMessageSubject" runat="server" Height="25px" 
            ontextchanged="Page_Load" Width="307px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Message:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtMessage" runat="server" Height="158px" Width="307px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Reply" runat="server" onclick="Reply_Click" Text="Reply" />
    </p>
    <p>
    </p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

