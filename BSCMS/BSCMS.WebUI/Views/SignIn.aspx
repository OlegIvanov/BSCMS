﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="BSCMS.WebUI.Views.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <table>
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
                <asp:TextBox ID="userPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="signIn" runat="server" Text="Sign In" />
            </td>
        </tr>
    </table>
</asp:Content>