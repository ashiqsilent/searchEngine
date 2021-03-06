﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DesignView.master" AutoEventWireup="true" CodeFile="reviewDetail.aspx.cs" Inherits="reviewDetail" %>
<%@ MasterType VirtualPath="~/DesignView.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        hr {
            border:double;
            width: 750px;
        }
        ContentPlaceHolder1_title:hover {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:750px; padding-left:20px">
        <div style="float:left">
            <asp:HyperLink ID="title" runat="server" Font-Underline="False" Font-Size="X-Large" Font-Bold="True" ForeColor="Blue">Title</asp:HyperLink>
        </div>
        <div style="float:right;">
            <div><asp:Label ID="address" runat="server"></asp:Label></div>
            <div><asp:Label ID="city_post" runat="server"></asp:Label></div>
        </div>
    </div>
    
    <div style="padding-left:20px;">
        <hr />
        <asp:Label ID="Label1" runat="server" Text="Review" Font-Bold="True" Font-Size="Medium"></asp:Label>
    </div>

</asp:Content>

