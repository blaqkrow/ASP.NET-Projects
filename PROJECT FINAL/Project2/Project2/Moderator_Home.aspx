<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_Home.aspx.cs" Inherits="Moderator_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="post">
                  <h2><asp:Label ID="lbl_tittle" runat="server" Text=""></asp:Label></h2>
                  <div class="meta">Created By: <a href="#"><asp:Label ID="lbl_CreatedBy" runat="server" Text=""></asp:Label></a>
                                    | Date Created:<asp:Label ID="lbl_CreatedDate" runat="server" Text=""></asp:Label> | 
                                    <br />
                                    Edited By: <a href="#"> <asp:Label ID="lbl_EditedBy" runat="server" Text=""></asp:Label></a>
                                    | Date Edited:<asp:Label ID="lbl_EditedDate" runat="server" Text=""></asp:Label> | 
                   </div>
                    
                    <img src="images/SC.png" alt="Image 01" class="image_frame image_fl"/>
                    <p><asp:Label ID="lbl_Description" runat="server" Text=""></asp:Label></p>
                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                      Text="Inbox" />
                    <asp:Button ID="btn_More" runat="server" Text="More" class="more float_r" onclick="btn_More_Click"/>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                      Text="Sent Message" />
                  <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                      Text="Compose Message" />
                    <div class="cleaner"></div>
				</div>
                <div class="col_2 float_l">
                	<h3>Recent News</h3>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/char1.png" alt="char1"/><strong> 
                        Lions Befrienders Charity Amazing Race (CAR rally) 2013</strong>
                        <p>Feb 23, 2048 - 129 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/operationhopev2.png" alt="operationhopev2"/><strong> 
                        Operation Hope Foundation</strong>
                        <p>Feb 16, 2048 - 165 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/lion.png" alt="Image 04"/><strong>Sponsor 
                        a senior to participate in the walk &amp; raise funds for them</strong>
                    	<p>Feb 10, 2048 - 182 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="cleaner"></div>
                    <a href="#" class="more"></a>
                </div>
                <div class="col_2 float_r">
                	<h3>&nbsp;</h3>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/flag.png" alt="Image 05"/>
                        <strong>NUS Community Marks the Spirit of Giving </strong>
                      <p>June 24, 2048 - 143 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/president.png" alt="Image 06"/><strong>President&#39;s 
                        Challenge 2012 Volunteer Drive</strong>
                  		<p>June 15, 2048 - 152 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="rp_pp">
                        <img class="image_frame" src="images/childrenlogo.png" alt="Image 07"/><strong>Children&#39;s 
                        Society Fundraiser</strong><a href="#"> </a>
                        <p>June 08, 2048 - 167 comments</p>
                        <div class="cleaner"></div>
                    </div>
                    <div class="cleaner"></div>
                    <a href="#" class="more"></a>
                </div>
                <div class="cleaner"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

