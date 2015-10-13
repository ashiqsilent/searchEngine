﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DesignView.master" AutoEventWireup="true" CodeFile="review.aspx.cs" Inherits="review" %>
<%@ MasterType VirtualPath="~/DesignView.master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">

    </script>
    
    <style>
        .search {
            display: inline;
            margin-right: 50px;
        }
        #ContentPlaceHolder1_goButton {
            cursor: pointer;
        }
        #ContentPlaceHolder1_DropDownList1 {
            border-width: 1px;
            border-color: black;
        }
        .comp {
            overflow : auto;        
            border-width : 1px;
            max-height: 120px;
            border-style : solid;
            list-style-type : none;
            margin:0px;
            padding:0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="color: #0000FF; font-size: x-large; font-weight: bold; text-align: center; margin-bottom: 30px">
        Select a business to review
    </div>
    
    <div style="text-align: center;">
        <div class="search"><asp:TextBox ID="TextBox1" runat="server" Width="193px" placeholder="e.g Nandos" Height="21px" BorderColor="Black" BorderWidth="1px"></asp:TextBox></div>
        <div class="search"><asp:DropDownList ID="DropDownList1" EnableViewState="true"  runat="server" Height="21px" Width="185px" DataSourceID="SqlDataSource1" DataTextField="Country" DataValueField="Country" AutoPostBack="True" ></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eBanglaConnectionString1 %>" SelectCommand="SELECT DISTINCT [Country] FROM [eDirectory] ORDER BY [Country]"></asp:SqlDataSource>
        </div>
        <div class="search"><asp:Button ID="goButton" runat="server" Text="Go" BackColor="Black" BorderColor="Black" BorderWidth="1px" ForeColor="White" OnClick="goButton_Click"/></div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:AutoCompleteExtender ID="AutoCompleteExtender1" MinimumPrefixLength="1" CompletionInterval="50" CompletionListCssClass="comp" TargetControlID="TextBox1" runat="server" ServiceMethod="GetCompletionList" UseContextKey="True"></asp:AutoCompleteExtender>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:eBanglaConnectionString1 %>" SelectCommand="SELECT DISTINCT [Title] FROM [eDirectory] WHERE ([Country] = @Country)">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:eBanglaConnectionString1 %>" SelectCommand="SELECT * FROM [eDirectory] WHERE (([Title] = @Title) AND ([Country] = @Country))">
        </asp:SqlDataSource>
    </div>
    <div style="padding-top:50px;"><asp:Label ID="Label1" runat="server" style="padding-left:50px" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label></div>
</asp:Content>

