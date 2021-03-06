﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_Events.aspx.cs" Inherits="Moderator_Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
  
                 
                 <div id="admin"> 
                    <h3>Events</h3>
                    <div class = "adminstrator">
                        <div class ="adminstrator_btn"><asp:Button ID="btn_Add" runat="server" 
                                onclick="btn_Add_Click" Text="Add Event" /></div>
                        <div class ="adminstrator_btn"></div>
                         <div class ="adminstrator_btn"></div>
                    </div>
                    <div id="search_bar">
                     <h3>Search</h3>
                     <div class ="search_bar_txtfield" ><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    </div>
                 </div>
                &nbsp;<asp:GridView ID="GridView1" runat="server" CellPadding="4" Height="100%" 
                        
    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%" 
    AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" 
    AutoGenerateSelectButton="True" AutoGenerateColumns = "False" onrowdeleting="GridView1_RowDeleting" 
    onrowediting="GridView1_RowEditing" SelectedIndex="0" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Event_ID" HeaderText="ID"  />
                            <asp:BoundField DataField="Event_Name" HeaderText="EventName"  />
                            <asp:BoundField DataField="Event_Description" HeaderText="Description" />
                            <asp:BoundField DataField="Event_Date" HeaderText="EventDate" />
                            <asp:BoundField DataField="Event_CreateBy" HeaderText="CreateBy" />
                            <asp:BoundField DataField="Event_CreateDate" HeaderText="CreateDate" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    <div class="cleaner"></div>
                  
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

