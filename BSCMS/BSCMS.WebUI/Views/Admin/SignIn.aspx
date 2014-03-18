<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <table>
        <tr>
            <td colspan="2">
                <h2>Sign In</h2>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="authenticationError" runat="server" Visible="false" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Username:
            </td>
            <td>
                <asp:TextBox ID="userName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password:
            </td>
            <td>
                <asp:TextBox ID="userPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:LinkButton ID="signIn" runat="server" Text="Sign In"></asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
