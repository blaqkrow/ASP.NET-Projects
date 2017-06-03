<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_3.master" AutoEventWireup="true" CodeFile="Registers.aspx.cs" Inherits="Registers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<div id="form_wrapper" class="form_wrapper">
					<form class="register">
						<h3>Register
                            <asp:Label ID="lblError" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                        </h3>
						<div class="column">
							<div>
								<label>First Name:</label>
                                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
							<div>
								<label>Last Name:</label>
								<asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
							<div>
								<label>Birthday:</label>
								<asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
						</div>
						<div class="column">
							<div>
								<label>Username:</label>
								<asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
							<div>
								<label>Email:</label>
								<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
							<div>
								<label>Password:</label>
								<asp:TextBox ID="txtPWord" runat="server"></asp:TextBox>
								<span class="error">This is an error</span>
							</div>
						</div>
						<div class="bottom">
							
                            <asp:Button ID="btnRegister" runat="server" Text="Register" 
                                onclick="btnRegister_Click" />
							<a href="index.html" rel="login" class="linkform">You have an account already? Log in here</a>
							<div class="clear"></div>
						</div>
					</form>
					
				</div>
				<div class="clear"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

