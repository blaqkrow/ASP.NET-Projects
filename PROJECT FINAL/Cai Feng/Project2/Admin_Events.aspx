<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_5.master" AutoEventWireup="true" CodeFile="Admin_Events.aspx.cs" Inherits="Admin_Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
  
                 &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                 <div id="admin"> 
                    <h3>Events</h3>
                    <div class = "adminstrator">
                        <div class ="adminstrator_btn"><asp:Button ID="btn_Add" runat="server" onclick="Button1_Click" Text="Add Event" /></div>
                        <div class ="adminstrator_btn"><asp:Button ID="btn_Delete" runat="server" onclick="Button2_Click" Text="Delete" /></div>
                         <div class ="adminstrator_btn"><asp:Button ID="btn_Edit" runat="server" onclick="Button3_Click" Text="Edit" /></div>
                    </div>
                    <div id="search_bar">
                     <h3>Search</h3>
                     <div class ="search_bar_txtfield" ><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    </div>
                 </div>
                &nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="White" 
                        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        GridLines="Horizontal" Height="869px" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" Width="478px">
                        <Columns>
                            <asp:TemplateField></asp:TemplateField>
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
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

