<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <% if (Request.IsAuthenticated)
       { %>
            <a href="AddBook.aspx" style="color:Blue">Add Book</a>
            <h2>Books</h2>
            <asp:Repeater ID="rBooks" runat="server">
                <ItemTemplate>
                    <div>
                        <img src="/BookCovers/<%# Eval("FileName") %>" alt="" />
                        <div>
                            <a href="#" style="color:Blue"><%# Eval("Title") %></a>
                        </div>
                        <span style="font-size: large; color:#990000"><%# Eval("Price") %></span>
                        <div>
                            <asp:HiddenField ID="hfBookId" runat="server" Value='<%# Eval("Id") %>' />
                            <a href="EditBook.aspx?BookId=<%# Eval("Id") %>" style="color:Blue">Edit</a>
                            <asp:LinkButton ID="lbDeleteBook" runat="server" Text="Delete"></asp:LinkButton>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    <% } %>
</asp:Content>
