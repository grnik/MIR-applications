<%@ Page Title="Домашняя страница" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ApplicationsMir._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Добро пожаловать в ASP.NET!
    </h2>
    <p>
        Для получения дополнительных сведений об ASP.NET посетите веб-сайт <a href="http://www.asp.net"
            title="Веб-сайт ASP.NET">www.asp.net</a>.
    </p>
    <p>
        Кроме того, <a href="http://go.microsoft.com/fwlink/?LinkID=152368" title="Документация по ASP.NET на MSDN">
            документация по ASP.NET доступна на MSDN</a>.
    </p>

    <asp:GridView ID="grdApplications" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" 
        DataSourceID="EntityDataSource">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                SortExpression="ID" />
            <asp:BoundField DataField="Creating" HeaderText="Creating" ReadOnly="True" 
                SortExpression="Creating" />
            <asp:BoundField DataField="Who" HeaderText="Who" SortExpression="Who" />
            <asp:BoundField DataField="Room" HeaderText="Room" SortExpression="Room" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            <asp:BoundField DataField="Login" HeaderText="Login" ReadOnly="True" 
                SortExpression="Login" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" 
                SortExpression="EmployeeID" />
            <asp:BoundField DataField="Problem" HeaderText="Problem" 
                SortExpression="Problem" />
            <asp:BoundField DataField="StatusID" HeaderText="StatusID" 
                SortExpression="StatusID" />
            <asp:BoundField DataField="Comment" HeaderText="Comment" 
                SortExpression="Comment" />
        </Columns>
    </asp:GridView>
    <asp:EntityDataSource ID="EntityDataSource" runat="server" 
        ConnectionString="name=ApplicationsEntities" 
        DefaultContainerName="ApplicationsEntities" EnableDelete="True" 
        EnableFlattening="False" EnableUpdate="True" EntitySetName="Applications">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
    </asp:EntityDataSource>
</asp:Content>
