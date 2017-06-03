<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_4.master" AutoEventWireup="true" CodeFile="Member_EventPosts.aspx.cs" Inherits="Member_EventPosts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="post">
                    <h2>
                        <asp:Label ID="lbl_tittle" runat="server" Text=""></asp:Label>
                        <asp:Label ID="lbl_status" runat="server" Text="" style="color: black;font-family: fantasy;"></asp:Label>
                    </h2>
                    <asp:Button ID="btn_Join" runat="server" Text="Join/Unjoin" 
                        onclick="btn_Join_Click" />
                  	<div class="meta"><a href="#"><asp:Label ID="lbl_CreatedBy" runat="server" Text=""></asp:Label></a>
                                    | <asp:Label ID="lbl_CreatedDate" runat="server" Text=""></asp:Label> | 
                                      <br/>
                                      <a href="#"> <asp:Label ID="lbl_EditedBy" runat="server" Text=""></asp:Label></a>
                                    | <asp:Label ID="lbl_EditedDate" runat="server" Text=""></asp:Label> | 
                   </div>
                    <asp:Image ID="Image1" runat="server" style="width: 300px;height: 200px;"/>
                    <p><asp:Label ID="lbl_Description" runat="server" Text=""></asp:Label></p>
                    <br />
                    <div class="cleaner"></div>
			  </div>
                
              <h3>Comments</h3>
                        
              <div id="comment_section">
                <ol class="comments first_level">
                
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <li>
                            <div class="comment_box commentbox1">
                                <!--
                                <div class="gravatar">
                                    <img class="image_frame" src="images/avator.png" alt="author 6" />
                                </div>
                                -->
                                <div class="comment_text">
                                    <div class="comment_author">
                                        <asp:Label ID="lbl_CommentName" runat="server" Text='<%# Eval("User_UserName") %>'></asp:Label> 
                                        <span class="date">
                                            <asp:Label ID="lbl_CommentDate" runat="server" Text='<%# Eval("Comment_Date") %>'></asp:Label> 
                                        </span> 
                                    </div>
                                    <p><asp:Label ID="lbl_Comment" runat="server" Text='<%# Eval("Comment_Description") %>'></asp:Label> </p>
                                  <!--<div class="reply"><a href="#">Reply</a></div>-->
                                </div>
                                <div class="cleaner"></div>
                            </div>                        
                        </li>
                     </ItemTemplate>
                 </asp:Repeater>
                        
                </ol>
                <div class="cleaner h20"></div>    
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
                    
                </div>
                
                <div class="cleaner h20"></div>
                
                <div id="comment_form">
                    <h3>Leave your comment</h3>
                    
                    <form action="#" method="get">
                        <div class="form_row">
                            <label>Name (* required )</label><br />
                            <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form_row">
                            <label>Comment</label><br />
                            <asp:TextBox ID="txt_Comment" runat="server" Height="256px" Width="538px"></asp:TextBox>
                        </div>
                        <asp:Button ID="btn_Comment" runat="server" Text="Comment" class="submit_btn" 
                            onclick="btn_Comment_Click1"/>
                    </form>
                
            	</div>
                <div class="cleaner"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

