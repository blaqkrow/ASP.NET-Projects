<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_6.master" AutoEventWireup="true" CodeFile="Moderator_Contact.aspx.cs" Inherits="Moderator_Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
				
                <h2>Contact Information</h2>
                <p>Etiam eget leo nisl. Morbi magna enim, lobortis vitae eu, ultrices a lacus. Praesent aliquam velit elit, vitae ornare sapien. Cras dignissim gravida risus id egestas. Validate <a href="http://validator.w3.org/check?uri=referer" rel="nofollow"><strong>XHTML</strong></a> &amp; <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow"><strong>CSS</strong></a>. </p>
                <div class="cleaner h20"></div>
              <div id="contact_form">
                	<form method="post" name="contact" action="#">
					
                        <label for="author">Name:</label> <input type="text" id="author" name="author" class="required input_field" />
                        <div class="cleaner h10"></div>
                                                                        
                        <label for="email">Email:</label> <input type="text" id="email" name="email" class="validate-email required input_field" />
                        <div class="cleaner h10"></div>
                                                                
                    	<label for="subject">Subject:</label> <input type="text" class="validate-subject required input_field" name="subject" id="subject"/>				               
                        <div class="cleaner h10"></div>
                                                
                        <label for="text">Message:</label> <textarea id="text" name="text" rows="0" cols="0" class="required"></textarea>
                        <div class="cleaner h10"></div>				
                                                                    
                        <input type="submit" value="Send" id="submit" name="submit" class="submit_btn float_l" />
                        <input type="reset" value="Reset" id="reset" name="reset" class="submit_btn float_r" />
                                            
                    </form>
                </div>
                
                <div class="cleaner h20"></div>
              <div class="col_2 float_l">
                
               		<iframe width="280" height="200" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=EN&amp;q=time+square&amp;aq=&amp;sll=40.716558,-73.931122&amp;sspn=0.40438,1.056747&amp;ie=UTF8&amp;rq=1&amp;ev=p&amp;split=1&amp;radius=33.22&amp;hq=time+square&amp;hnear=&amp;ll=37.061753,-95.677185&amp;spn=0.438347,0.769043&amp;z=9&amp;output=embed"></iframe><br /><small><a href="http://maps.google.com/maps?f=q&amp;source=embed&amp;hl=EN&amp;q=time+square&amp;aq=&amp;sll=40.716558,-73.931122&amp;sspn=0.40438,1.056747&amp;ie=UTF8&amp;rq=1&amp;ev=p&amp;split=1&amp;radius=33.22&amp;hq=time+square&amp;hnear=&amp;ll=37.061753,-95.677185&amp;spn=0.438347,0.769043&amp;z=9" style="color:#0000FF;text-align:left">View Larger Map</a></small>
                </div>
                <div class="col_2 float_r">
                	<h3>Mailing Address</h3>
                    <h6><strong>Company Name</strong></h6>
                	172-165 Aenean fringilla ornare felis, <br />
                    Mauris euismod condimentum, 15540<br />
                    Pellentesque habitant morbi<br /><br />
                    
                    <strong>Phone:</strong> 020-054-2280<br />
                    <strong>Email:</strong> <a href="mailto:info@yoursite.com">info@yoursite.com</a>
                    
              </div>
                
                <div class="cleaner"></div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

