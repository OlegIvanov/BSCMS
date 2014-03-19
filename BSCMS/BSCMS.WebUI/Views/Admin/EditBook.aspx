<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.EditBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <a href="Index.aspx" style="color:Blue">Admin Home</a>
    <div style="margin-top:50px">
        <table cellpadding="0" cellspacing="0" width="500px">
            <tr>
                <td colspan="2">
                    <span style="font-size:30px;">Edit Book</span>
                </td>
            </tr>
            <tr>
                <td style="width:100px;">
                    <span>Title:</span>
                </td>
                <td>
                    <asp:TextBox ID="tbBookTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span>Price:</span>
                </td>
                <td>
                    <asp:TextBox ID="tbBookPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span>Cover:</span>
                </td>
                <td>
                    <asp:FileUpload ID="fuBookCover" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:LinkButton ID="lbSaveBook" runat="server" Text="Save"></asp:LinkButton>
                    <a href="Index.aspx" style="color:Blue">Cancel</a>
                </td>
            </tr>
        </table>
    </div>
    <asp:Image ID="iBookCover" runat="server" />
</asp:Content>
