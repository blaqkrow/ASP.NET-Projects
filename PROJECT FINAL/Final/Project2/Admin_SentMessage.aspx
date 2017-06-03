﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_5.master" AutoEventWireup="true" CodeFile="Admin_SentMessage.aspx.cs" Inherits="Admin_SentMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   <div id="admin"> 
                    <h3>Sent Message</h3>
                    <div class = "adminstrator">
                        <div class ="adminstrator_btn"><asp:Button ID="btn_Delete" runat="server" Text="Delete" /></div>
                    </div>
                    <div id="search_bar">
                     <h3>Search</h3>
                     <div class ="search_bar_txtfield" ><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    </div>
                 </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
                    AutoGenerateDeleteButton="True" AutoGenerateSelectButton="True" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Height="100%" 
                    onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="Message_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Sender_Name" HeaderText="From" />
                        <asp:BoundField DataField="Receiver_Name" HeaderText="To" />
                        <asp:BoundField DataField="Message_Subject" HeaderText="Suject" />
                        <asp:BoundField DataField="Message_Description" HeaderText="Description" />
                        <asp:BoundField DataField="Message_Date" HeaderText="DateSent" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
                &nbsp;<div class="cleaner"></div>
                 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

