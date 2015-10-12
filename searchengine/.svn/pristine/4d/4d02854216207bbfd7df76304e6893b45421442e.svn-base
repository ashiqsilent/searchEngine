<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="/formStyle.css" />
    <script>
            $(document).keypress(function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    $('#ContentPlaceHolder1_button').click();
                }
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="confirmation" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0033CC"></asp:Label>
    <br />
    <br />
    <div><a id="go" href="/login.aspx" runat="server" visible="false">Continue</a></div>
        <div id="head" runat="server">
            <div id="wrap">
                <div id="login" class="animate form">
                    <h1> Sign up </h1>
                    <p><div>
                        <label for="usernamesignup" class="uname" data-icon="u"><strong>Your username</strong></label>
                        <input id="usernamesignup" name="usernamesignup" type="text" placeholder="mysuperusername690" runat="server"/>
                        <div class="inner"><asp:CustomValidator ID="usernameValidator" runat="server" ErrorMessage="* given username is already taken" ControlToValidate="usernamesignup" OnServerValidate="usernameValidate" ForeColor="Red"></asp:CustomValidator></div>
                        <div class="inner"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* username is required" ForeColor="Red" ControlToValidate="usernamesignup"></asp:RequiredFieldValidator></div>
                        </div>
                        <br />
                    </p>
                    <p><div>
                        <label for="emailsignup" class="youmail" data-icon="e" ><strong>Your email</strong></label>
                        <input id="emailsignup" name="emailsignup" type="text" placeholder="someone@domain.com" runat="server"/> 
                        <div class="inner"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* email has to be of someone@domain.com format" ForeColor="Red" ControlToValidate="emailsignup" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></div>
                        <div class="inner"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* email is required" ForeColor="Red" ControlToValidate="emailsignup"></asp:RequiredFieldValidator></div>
                        <div class="inner"><asp:CustomValidator ID="emailValidator" runat="server" ErrorMessage="* given email address already exists" ForeColor="Red" ControlToValidate="emailsignup" OnServerValidate="emailValidate"></asp:CustomValidator></div>
                        </div>
                        <br />
                    </p>
                    <p><div> 
                        <label for="passwordsignup" class="youpasswd" data-icon="p"><strong>Your password</strong></label>
                        <input id="passwordsignup" name="passwordsignup" type="password" placeholder="only numbers and letters" runat="server"/>
                        <div class="inner"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* password is required" ForeColor="Red" ControlToValidate="passwordsignup"></asp:RequiredFieldValidator></div>
                        <div class="inner"><asp:CustomValidator ID="passwordValidator" runat="server" ForeColor="Red" ControlToValidate="passwordsignup" OnServerValidate="passwordValidate" ></asp:CustomValidator></div>
                        </div>
                        <br />
                    </p>
                    <p><div> 
                        <label for="passwordsignup_confirm" class="youpasswd" data-icon="p"><strong>Please confirm your password</strong></label>
                        <input id="passwordsignup_confirm" name="passwordsignup_confirm" type="password" runat="server"/>
                        <div class="inner"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* confirm your password" ForeColor="Red" ControlToValidate="passwordsignup_confirm"></asp:RequiredFieldValidator></div>
                        <div class="inner"><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="* passwords didn't match" ForeColor="Red" ControlToValidate="passwordsignup_confirm" ControlToCompare="passwordsignup"></asp:CompareValidator></div>    
                        </div>
                    </p>
                    <p class="signin button">
                        <asp:Button ID="button" runat="server" Text="Sign Up" OnClick="button_Click"/>
					</p>
                    <p class="change_link">  
						Already a member ?
						<a href="/login.aspx" class="to_register"> Go and log in </a>
					</p>
                </div>						
            </div>
        </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

