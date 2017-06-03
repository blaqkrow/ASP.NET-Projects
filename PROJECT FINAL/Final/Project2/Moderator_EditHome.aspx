<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_EditHome.aspx.cs" Inherits="Moderator_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class = "editing"> 
		<div class = "editing_header">
			<h2>Edit Home Page Information</h2>
			<div class = "editing_header_button">
                <asp:Button ID="txt_Update" runat="server" Text="Update" 
                    onclick="txt_Update_Click" />
            </div>
		</div>
		<div class = "editing_body">
			<div class = "editing_tittle">
			<!-- Content Tittle Field -->
            <asp:TextBox ID="txt_tittle" runat="server" Text = "Enter Tittle Here"></asp:TextBox>
			</div>
			<div class = "editing_content">
			<!-- Content Data Field -->
            <asp:TextBox ID="txt_Description" runat="server" Height="302px" Width="610px"></asp:TextBox>
			</div>
			<!-- Content Footer Field -->
			<div class = "editing_footer">
				<div class = "footer_information"><asp:Label ID="lbl_CreateBy" runat="server" Text=""></asp:Label></div>
				<div class = "footer_information"><asp:Label ID="lbl_CreateDate" runat="server" Text=""></asp:Label></div>
				<div class = "footer_information"><asp:Label ID="lbl_EditBy" runat="server" Text=""></asp:Label></div>
				<div class = "footer_information"><asp:Label ID="lbl_EditDate" runat="server" Text=""></asp:Label></div>
			</div>
		</div>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

