<%@ Page Title="" Language="C#" MasterPageFile="~/aMasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>Name</td>
            <td>Address</td>
            <td>Handphone</td>
        </tr>
        <tr>
            <td>Daniel Tan Lek Soon</td>
            <td>15 Hougang Ave 3, #09-456</td>
            <td>87111112</td>
        </tr>
        <tr>
            <td>Mary Ng Sook Yuen</td>
            <td>12 Clementi Ave 5, #15-888</td>
            <td>90045669</td>
        </tr>
        <tr>
            <td>Ling Lay Choo</td>
            <td>23 Yishun Ave 1, #06-234</td>
            <td>98765432</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/ThankYou.aspx" style="text-align: center" Text="Click Me" Width="120px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

