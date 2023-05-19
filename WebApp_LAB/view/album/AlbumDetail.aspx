<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="WebApp_LAB.view.album.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Album Detail</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Album Name"></asp:Label>
    <br />
    <asp:Label ID="nameTxt" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="descLbl" runat="server" Text="Album Description"></asp:Label>
    <br />
    <asp:Label ID="descTxt" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="priceLbl" runat="server" Text="Album Price"></asp:Label>
    <br />
    <asp:Label ID="priceTxt" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="stockLbl" runat="server" Text="Album Stock"></asp:Label>
    <br />
    <asp:Label ID="stockTxt" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="qtyLbl" runat="server" Text="Quantity"></asp:Label>
    <br />
    <asp:TextBox ID="qtyTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="qtyError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Button ID="cartBtn" runat="server" Text="Add To Cart" OnClick="cartBtn_Click" />
</asp:Content>
