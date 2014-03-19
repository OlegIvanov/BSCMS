<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.EditBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <a href="Index.aspx" style="color:Blue">Admin Home</a>
    <h2>Edit Book</h2>
    <asp:Image ID="iBookCover" runat="server" />
    <table>
        <tr>
            <td>
                Title:
            </td>
            <td>
                <asp:TextBox ID="tbBookTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Cover:
            </td>
            <td>
                <asp:FileUpload ID="fuBookCover" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Price:
            </td>
            <td>
                <asp:TextBox ID="tbBookPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="lbSaveBook" runat="server" Text="Save"></asp:LinkButton>
            </td>
            <td>
                <a href="Index.aspx" style="color:Blue">Cancel</a>
            </td>
        </tr>
    </table>
</asp:Content>
