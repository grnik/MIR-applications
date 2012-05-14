<%@ Page Title="Домашняя страница" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ApplicationsMir._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Зарегистрированные обращения
    </h2>
    <asp:GridView ID="grdListAppl" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
        DataKeyNames="ID" runat="server">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" />
            <asp:BoundField DataField="Создана" HeaderText="Creating" ReadOnly="True" />
            <asp:BoundField DataField="Кто звонил" HeaderText="Who" />
            <asp:BoundField DataField="Комната" HeaderText="Room" />
            <asp:BoundField DataField="Телефон" HeaderText="Phone" />
            <asp:BoundField DataField="Логин" HeaderText="Login" ReadOnly="True" />
            <asp:BoundField DataField="Описание" HeaderText="Description" />
            <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" Visible="False"/>
            <asp:BoundField DataField="Проблема" HeaderText="Problem" />
            <asp:BoundField DataField="StatusID" HeaderText="StatusID" Visible="False" />
            <asp:BoundField DataField="Кооментарий" HeaderText="Comment" />
            <asp:BoundField DataField="Ответсвенный сотрудник" HeaderText="EmployeesName" />
            <asp:BoundField DataField="Статус" HeaderText="Status" />
        </Columns>
    </asp:GridView>
</asp:Content>
