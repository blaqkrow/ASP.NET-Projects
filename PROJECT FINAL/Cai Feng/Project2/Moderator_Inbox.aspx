<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_Inbox.aspx.cs" Inherits="Moderator_Inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    &nbsp;
                 <div id="admin"> 
                    <h3>Events</h3>
                    <div class = "adminstrator">
                        <div class ="adminstrator_btn"><asp:Button ID="btn_Delete" runat="server" Text="Delete"  CommandName="updaterow" onclick="btn_Delete_Click"/></div>
                    </div>
                    <div id="search_bar">
                     <h3>Search</h3>
                     <div class ="search_bar_txtfield" ><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    </div>
                     <asp:Label ID="lbl_test" runat="server" Text=""></asp:Label>
                 </div>
                &nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="White" 
                        BorderColor="#336666" BorderStyle="Double" 
        BorderWidth="3px" CellPadding="4" 
                        GridLines="Horizontal" Height="869px" 
                         Width="478px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Select">
                                <ItemTemplate>
                                <asp:CheckBox runat="server" id="chkdelete" AutoPostBack="false" />
                                </ItemTemplate>
                           </asp:TemplateField>
                            <asp:TemplateField HeaderText="From" >
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Sender_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Subject">
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Message_Subject") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Content">
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Message_Description") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SentDate">
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Message_Date") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
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
                    <div class="cleaner"></div>
                  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

