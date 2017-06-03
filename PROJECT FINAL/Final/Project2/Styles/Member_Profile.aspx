<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Member_Profile.aspx.cs" Inherits="Styles_Member_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 581px;
            height: 100px;
        }
        .style2
        {
            width: 443px;
        }
        .style3
        {
            width: 444px;
        }
        .style4
        {
            width: 445px;
        }
        .style5
        {
            width: 446px;
        }
        .style6
        {
            width: 6480px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td style="font-family: Calibri; font-size: larger; font-weight: bold; font-style: normal" 
                            class="style6">Profile Information</td>
                        <td class="style3"><asp:Button ID="btn_Edit" runat="server" Text="Edit" /></td>                
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">User Name:</td>
                        <td class="style3"><asp:Label ID="lbl_UName" runat="server" Text="lbl_UName"></asp:Label></td>                
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style4">First Name:</td>
                        <td class="style3"><asp:Label ID="lbl_FName" runat="server" Text="lbl_FName"></asp:Label></td>
                        <td class="style5">Last Name:</td>
                        <td class="style3"><asp:Label ID="lbl_LName" runat="server" Text="lbl_LName"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Password:</td>
                        <td class="style3"><asp:Label ID="lbl_Password" runat="server" Text="lbl_Password"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Email:</td>
                        <td class="style3"><asp:Label ID="lbl_Email" runat="server" Text="lbl_Email"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                         <td style="font-family: Calibri; font-size: larger; font-weight: bold; font-style: normal" class="style6">Payment Information</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Payment Method:</td>
                        <td class="style3"><asp:Label ID="lbl_Payment" runat="server" Text="lbl_Payment"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

