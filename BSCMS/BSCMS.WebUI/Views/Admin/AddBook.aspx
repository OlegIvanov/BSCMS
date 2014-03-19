<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:LinkButton runat="server" PostBackUrl="~/Views/Admin/Index.aspx" Text="Admin Home"></asp:LinkButton>
    <h2>Add Book</h2>
    <table>
        <tr>
            <td>
                Title:
            </td>
            <td>
                <asp:TextBox ID="bookTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Cover:
            </td>
            <td>
                <asp:FileUpload ID="bookCover" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Price:
            </td>
            <td>
                <asp:TextBox ID="bookPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="saveBook" runat="server" Text="Save"></asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton runat="server" PostBackUrl="~/Views/Admin/Index.aspx" Text="Cancel"></asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
