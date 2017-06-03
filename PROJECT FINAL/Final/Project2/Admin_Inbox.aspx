<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_5.master" AutoEventWireup="true" CodeFile="Admin_Inbox.aspx.cs" Inherits="Admin_Inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 &nbsp;
                 <div id="admin"> 
                    <h3>Inbox</h3>
                    <div class = "adminstrator">
                        <div class ="adminstrator_btn"></div>
                    </div>
                    <div id="search_bar">
                     <h3>Search</h3>
                     <div class ="search_bar_txtfield" ><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    </div>
                 </div>
                &nbsp;<div class="cleaner">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
                                AutoGenerateSelectButton="True" BackColor="LightGoldenrodYellow" 
                                BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                                GridLines="None" Height="100%" onrowdeleting="GridView1_RowDeleting" 
                                onrowediting="GridView1_RowEditing" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                <Columns>
                                    <asp:ButtonField CommandName="Edit" Text="View &amp; Reply" />
                                    <asp:BoundField DataField="Message_ID" HeaderText="ID" />
                                    <asp:BoundField DataField="Sender_Name" HeaderText="From" />
                                    <asp:BoundField DataField="Message_Subject" HeaderText="Suject" />
                                    <asp:BoundField DataField="Message_Description" HeaderText="Description" />
                                    <asp:BoundField DataField="Message_Date" HeaderText="DateSent" />
                                </Columns>
                                <FooterStyle BackColor="Tan" />
                                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                                    HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
</div>
                  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

