<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_5.master" AutoEventWireup="true" CodeFile="Admin_EditProfile.aspx.cs" Inherits="Admin_EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
        .style1
        {
            width: 560px;
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
  <table class="style1">
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td style="font-family: Calibri; font-size: larger; font-weight: bold; font-style: normal" class="style6">Profile Information</td>
                        <td class="style3"><asp:Button ID="btn_Confirm" runat="server" Text="Confirm" 
                                onclick="btn_Confirm_Click" /></td>                
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Image Upload:<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                        <td class="style3"><asp:FileUpload ID="FileUpload1" runat="server" /></td>                
                    </tr>
                   
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">User Name:</td>
                        <td class="style3"><asp:TextBox ID="txt_UName" runat="server"></asp:TextBox></td>                
                    </tr>
                   
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style4">First Name:</td>
                        <td class="style3"><asp:TextBox ID="txt_FName" runat="server"></asp:TextBox></td>
                        <td class="style5">Last Name:</td>
                        <td class="style3"><asp:TextBox ID="txt_LName" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Password:</td>
                        <td class="style3"><asp:TextBox ID="txt_Password" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Email:</td>
                        <td class="style3"><asp:TextBox ID="txt_Email" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                         <td style="font-family: Calibri; font-size: larger; font-weight: bold; font-style: normal" class="style6">Payment Information </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Payment Method:</td>
                        <td class="style3"><asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                AutoPostBack="True" 
                                onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem Value="0">None</asp:ListItem>
                            <asp:ListItem Value="1">MasterCard</asp:ListItem>
                            <asp:ListItem Value="2">Visa</asp:ListItem>
                            <asp:ListItem Value="3">AmericanExpress</asp:ListItem>
                            </asp:RadioButtonList></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Name of Card Holder:</td>
                        <td class="style3"><asp:TextBox ID="txt_Cardholder" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <table class="style1">
                    <tr>
                        <td class="style2">Card Number(16 Digit):</td>
                        <td class="style3"><asp:TextBox ID="txt_CardNo" runat="server"></asp:TextBox></td>
                        <td class="style2">Security Code:</td>
                        <td class="style3"><asp:TextBox ID="txt_SecurityCode" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

