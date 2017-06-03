<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Member_ComposeMessage.aspx.cs" Inherits="Member_ComposeMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
            <h2>Compose Message</h2>
                <div class="cleaner h20"></div>
                   <div id="contact_form">
                	<form method="post" name="contact" action="#">
					
                        <label for="author">To:<asp:Label ID="lbl_receiver" runat="server" Text=""></asp:Label>
                        </label> 
                        &nbsp;<asp:TextBox ID="txt_receiver" runat="server" class="validate-email required input_field" ></asp:TextBox>
                        <div class="cleaner h10"></div>
                                                                        
                        <label for="email">Suject:<asp:Label ID="lbl_subject" runat="server" Text=""></asp:Label></label> 
                        <asp:TextBox ID="txt_Subject" runat="server" class="validate-email required input_field" ></asp:TextBox>
                        <div class="cleaner h10"></div>
                                               
                        <label for="text">Message:<asp:Label ID="lbl_message" runat="server" Text=""></asp:Label></label> 
                        <asp:TextBox ID="txt_Message" runat="server"  Rows="5" TextMode="MultiLine" class="required"></asp:TextBox>	
                        <div class="cleaner h10"></div>				
                        
                        <asp:Button type="submit" ID="btn_Submit" runat="server" Text="Send" 
                            class="submit_btn float_l" onclick="btn_Submit_Click" />
                        <asp:Button type="reset" ID="btn_reset" runat="server" Text="Reset" 
                            class="submit_btn float_l" onclick="btn_reset_Click" />                    
                    </form>
                </div>
                
                <div class="cleaner h20"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

