<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div style="margin-top:50px">
        <span style="font-size:30px; color:#E47911;">Sign In</span>
        <div style="margin-top:20px;">
            <asp:Label ID="authenticationError" runat="server" Visible="false" ForeColor="Red"></asp:Label>
            <div>Username:</div>
            <asp:TextBox ID="userName" runat="server"></asp:TextBox>
            <div>Password:</div>
            <asp:TextBox ID="userPassword" runat="server" TextMode="Password"></asp:TextBox>
            <div>
                <asp:LinkButton ID="signIn" runat="server" Text="Sign In"></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
