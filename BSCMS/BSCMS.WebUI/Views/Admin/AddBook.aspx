<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BSCMS.WebUI.Views.Admin.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <a href='<%: GetRouteUrl("Admin_Home", new { }) %>' style="color:Blue">Admin Home</a>
    <div style="margin-top:50px">
        <table cellpadding="0" cellspacing="0" width="500px">
            <tr>
                <td colspan="2">
                    <span style="font-size:30px;">Add book</span>
                </td>
            </tr>
            <tr style="display:block; height:20px;">
            </tr>
            <tr>
                <td style="width:100px;">
                    <span>Title:</span>
                </td>
                <td>
                    <asp:TextBox ID="tbBookTitle" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBookTitle" runat="server" ControlToValidate="tbBookTitle" 
                        Display="Static" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr style="display:block; height:10px;">
            </tr>
            <tr>
                <td>
                    <span>Price:</span>
                </td>
                <td>
                    <asp:TextBox ID="tbBookPrice" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBookPrice" runat="server" ControlToValidate="tbBookPrice" 
                        Display="Static" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvBookPrice" runat="server" ControlToValidate="tbBookPrice" Type="Currency" MinimumValue="0" MaximumValue="999999999.99"
                        Display="Static" Text="Invalid Price Value" ForeColor="Red"></asp:RangeValidator>
                </td>
            </tr>
            <tr style="display:block; height:10px;">
            </tr>
            <tr>
                <td>
                    <span>Cover:</span>
                </td>
                <td>
                    <asp:FileUpload ID="fuBookCover" runat="server" />
                </td>
            </tr>
            <tr style="display:block; height:10px;">
            </tr>
            <tr>
                <td colspan="2">
                    <asp:LinkButton ID="lbSaveBook" runat="server" Text="Save"></asp:LinkButton>
                    <a href='<%: GetRouteUrl("Admin_Home", new { }) %>' style="color:Blue">Cancel</a>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
