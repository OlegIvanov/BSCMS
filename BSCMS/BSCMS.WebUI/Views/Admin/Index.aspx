<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <% if (Request.IsAuthenticated)
       { %>
            <asp:LinkButton ID="addBook" runat="server" PostBackUrl="~/Views/Admin/AddBook.aspx" Text="Add book"></asp:LinkButton>
    <% } %>
</asp:Content>
