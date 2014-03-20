<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BSCMS.WebUI.Views.Home.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:960px; margin:auto; font-size:30px;">
            <div style="width:50%; float:left;">
                Book Store
            </div>
            <div style="width:100%; margin-top:50px; float:left; font-size:20px;">
                <asp:Repeater ID="rBooks" runat="server">
                    <ItemTemplate>
                        <div style="margin-bottom:40px;">
                            <img src="<%# Eval("CoverImageUrl") %>" alt="" />
                            <div>
                                <a href="#" style="color:Blue"><%# Eval("Title") %></a>
                            </div>
                            <div>
                                <span style="font-size: large; color:#990000"><%# Eval("Price") %></span>
                            </div>
                            <asp:HiddenField ID="hfBookId" runat="server" Value='<%# Eval("Id") %>' />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>    
    </form>
</body>
</html>
