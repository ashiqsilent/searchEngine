<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="/formStyle.css" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
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
    <div style="text-align:center; font-size: large; color: #000000; font-weight: bold; margin-bottom:10px"><asp:Label ID="message" runat="server"></asp:Label></div>
    <div id="wrap">
        <div id="login" class="animate form">
                <h1>Log in</h1> 
                <p> 
                    <label for="username" class="uname" data-icon="u" > Your email or username </label>
                    <input id="username" runat="server" name="username" type="text" placeholder="myusername or mymail@mail.com"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* username is required" ForeColor="Red" ControlToValidate="username"></asp:RequiredFieldValidator>
                </p>
                <p> 
                    <label for="password" class="youpasswd" data-icon="p"> Your password </label>
                    <input id="password" name="password" runat="server" type="password"/> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* password is required" ForeColor="Red" ControlToValidate="password"></asp:RequiredFieldValidator>
    
                </p>
                <p class="keeplogin"> 
			        <input type="checkbox" name="loginkeeping" id="loginkeeping" value="loginkeeping" /> 
			        <label for="loginkeeping">Keep me logged in</label>
                    <div><asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label></div>
                <p class="login button"> 
                    <asp:Button ID="button" runat="server" Text="Log In" OnClick="button_Click"/> 
		        </p>
                <p class="change_link">
			        Not a member yet ?
			        <a href="/register.aspx" class="to_register">Join us</a>
		        </p>
        </div>
    </div>
</asp:Content>

