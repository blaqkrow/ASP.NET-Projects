<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Member_Events.aspx.cs" Inherits="Member_Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
                
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                    <div class="gallery_box">
                        <a href='<%# Eval("Event_Image") %>' rel="lightbox[portfolio]" title="Pellentesque dictum feugiat">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Event_Image") %>' style="width:275px; height:200px"/>
                        </a>
                        <h5><asp:Label ID="lbl_EventTittle" runat="server" Text='<%# Eval("Event_Name") %>'></asp:Label></h5>
                        <p><asp:Label ID="lbl_Description" runat="server" Text='<%# Eval("Event_Description") %>'></asp:Label></p>
                        <asp:Button ID="lnkpro" runat="server" Text='<%#Eval("Event_ID")%>' onclick="lnkpro_Click" />
                    
			         </div>
                     </ItemTemplate>
                </asp:Repeater>
              
            
                <div class="cleaner"></div>
                <div class="pagging">
                    <ul>
                        <li><a href="http://www.templatemo.com" target="_parent">Previous</a></li>
                        <li><a href="http://www.templatemo.com/page/1" target="_parent">1</a></li>
                        <li><a href="http://www.templatemo.com/page/2" target="_parent">2</a></li>
                        <li><a href="http://www.templatemo.com/page/3" target="_parent">3</a></li>
                        <li><a href="http://www.templatemo.com/page/4" target="_parent">4</a></li>
                        <li><a href="http://www.templatemo.com/page/5" target="_parent">5</a></li>
                        <li><a href="http://www.templatemo.com/page/6" target="_parent">6</a></li>
                        <li><a href="http://www.templatemo.com/page/7" target="_parent">Next</a></li>
                    </ul>
                </div>   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

