<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="searchResult.aspx.cs" Inherits="searchResult" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Label ID="error" runat="server"></asp:Label>
    <asp:GridView ID="displayTable" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Width="586px" OnPageIndexChanged="displayTable_PageIndexChanged" OnLoad="displayTable_OnLoad" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:HyperLink ID="nameLink" Runat="server" NavigateUrl='<%#generateDetailsURL(DataBinder.Eval(Container.DataItem,"Id"), DataBinder.Eval(Container.DataItem,"Title"))%>' Text='<%#DataBinder.Eval(Container.DataItem, "Title") %>'></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Description" HeaderText="City" />
        </Columns>
        <EmptyDataTemplate></EmptyDataTemplate>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eBanglaConnectionString1 %>" SelectCommand="SELECT * FROM [eDirectory] WHERE (([Country] LIKE @Country) AND ([Category] LIKE @Category) AND ([Title] LIKE '%' + @Title + '%'))">
    </asp:SqlDataSource>
        <table id="mapTable"style="width: 40%; z-index: 1; left: 606px; top: 8px; position: absolute; height: auto;">
        <tr>
            <td><cc1:GMap ID="GMap1" runat="server" Height="275px" Width="400px" /></td>
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
    <br />
</asp:Content>

