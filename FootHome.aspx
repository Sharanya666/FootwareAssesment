<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FootHome.aspx.cs" Inherits="OnlineFootwareApp.FootHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        nav
        {
            float:right;
        }
        body
        {
            margin-top:300px;
            margin-left:400px;
        }
    </style>
</head>
<body>
    <header>WECOME FIND YOUR SOLE'S MATE</header>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:DropDownList ID="categories" runat="server">
                    <asp:ListItem>MEN</asp:ListItem>
                    <asp:ListItem>WOMEN</asp:ListItem>
                    <asp:ListItem>KIDS</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Vbtn" runat="server" Text="View" OnClick="Vbtn_Click"/>
            </nav>
        </div>
            <div>
            <asp:GridView ID="GVD" runat="server"></asp:GridView>
            </div>
           <div id="div1" runat="server">
               <asp:TextBox ID="txtCode"  runat="server" Placeholder="Enter Value:"></asp:TextBox>
            <asp:Button ID="Btn1" runat="server" Text="ORDER" OnClick="Btn1_Click" />
        </div>
        <div>
            <div>
            <asp:Button ID="btnStatus" runat="server" CssClass="btn btn-dark" Text="Order Status" OnClick="btnStatus_Click" />
            </div>
        </div>
    </form>
</body>
</html>
