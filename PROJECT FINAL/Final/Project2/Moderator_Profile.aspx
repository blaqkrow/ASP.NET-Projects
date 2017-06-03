<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_Profile.aspx.cs" Inherits="Moderator_Profile" %>

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
                        <td class="style3"><asp:Button ID="btn_Edit" runat="server" Text="Edit" 
                                onclick="btn_Edit_Click" /></td>                
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">ProfileImage:</td>
                        <td class="style3"><asp:Image ID="Image1" runat="server" style=" width: 250px;height: 200px;" /></td>                
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">User Name:</td>
                        <td class="style3"><asp:Label ID="lbl_UName" runat="server" Text="lbl_UName" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>                
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style4">First Name:</td>
                        <td class="style3"><asp:Label ID="lbl_FName" runat="server" Text="lbl_FName" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>
                        <td class="style5">Last Name:</td>
                        <td class="style3"><asp:Label ID="lbl_LName" runat="server" Text="lbl_LName" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Password:</td>
                        <td class="style3"><asp:Label ID="lbl_Password" runat="server" Text="lbl_Password" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Email:</td>
                        <td class="style3"><asp:Label ID="lbl_Email" runat="server" Text="lbl_Email" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>
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
                        <td class="style3"><asp:Label ID="lbl_Payment" runat="server" Text="lbl_Payment" style="font-weight: bold;font-size: 20px;color: black;"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

