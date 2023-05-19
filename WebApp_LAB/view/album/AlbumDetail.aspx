<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="WebApp_LAB.view.album.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Album Detail</h1>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <asp:Label ID="qtyLbl" runat="server" Text="Quantity"></asp:Label>
    <asp:TextBox ID="qtyTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="cartBtn" runat="server" Text="Add To Cart" OnClick="cartBtn_Click" />
</asp:Content>
