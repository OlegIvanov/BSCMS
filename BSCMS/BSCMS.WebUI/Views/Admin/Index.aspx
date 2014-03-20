<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <a href="<%: GetRouteUrl("Admin_AddBook", new object { }) %>" style="color:Blue">AddBook</a>
    <div style="margin-top:50px;">
        <asp:Repeater ID="rBooks" runat="server">
            <ItemTemplate>
                <div>
                    <img src="<%# Eval("CoverFilePath") %>" alt="" />
                    <div>
                        <a href="#" style="color:Blue"><%# Eval("Title") %></a>
                    </div>
                    <div>
                        <span style="font-size: large; color:#990000"><%# Eval("Price") %></span>
                    </div>
                    <div style="margin-bottom:40px;">
                        <asp:HiddenField ID="hfBookId" runat="server" Value='<%# Eval("Id") %>' />
                        <a href='<%# GetRouteUrl("Admin_EditBook", new { BookId = Eval("Id") }) %>' style="color:Blue">Edit</a>
                        <asp:LinkButton ID="lbDeleteBook" runat="server" Text="Delete"></asp:LinkButton>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
