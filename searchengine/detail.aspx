<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="detail" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 75px;
        }
        .auto-style2 {
            width: 75px;
            height: 34px;
        }
        .auto-style3 {
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="font-weight: 700"><asp:HyperLink ID="name" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 7px; top: 0px; position: absolute">[name]</asp:HyperLink>
        <table style="width:45%; z-index: 1; left: 13px; top: 36px; position: absolute; height: 250px;">
            <tr>
                <td class="auto-style1"><strong>Address</strong></td>
                <td>
                    <asp:Label ID="address" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>City</strong></td>
                <td class="auto-style3">
                    <asp:Label ID="city" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Province</strong></td>
                <td class="auto-style3">
                    <asp:Label ID="province" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Country</strong></td>
                <td class="auto-style3">
                    <asp:Label ID="country" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Postal Code</td>
                <td class="auto-style3">
                    <asp:Label ID="postCode" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone</td>
                <td class="auto-style3">
                    <asp:Label ID="phone" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fax</td>
                <td class="auto-style3">
                    <asp:Label ID="fax" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="width: 40%; z-index: 1; left: 485px; top: 34px; position: absolute; height: 252px;">
            <tr>
                <td>
                    <cc1:GMap ID="GMap1" runat="server" Height="250px" Width="388px"/>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </asp:Content>
