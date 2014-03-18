<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <% if (Request.IsAuthenticated)
       { %>
            <asp:LinkButton ID="addBook" runat="server" PostBackUrl="~/Views/Admin/AddBook.aspx" Text="Add book"></asp:LinkButton>
            <h2>Books</h2>
            <asp:Repeater ID="books" runat="server">
                <ItemTemplate>
                    <div>
                        <img src="/Uploads/<%# Eval("FileName") %>" alt="" />
                        <div>
                            <asp:LinkButton runat="server" PostBackUrl="#"><%# Eval("Title") %></asp:LinkButton>
                        </div>
                        <span style="font-size: large; color:#990000"><%# Eval("Price") %></span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    <% } %>
</asp:Content>
