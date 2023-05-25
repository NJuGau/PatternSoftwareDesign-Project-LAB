<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="WebApp_LAB.view.album.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Album Detail</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <asp:Label ID="nameLbl" runat="server" Text="Album Name"></asp:Label>
            <asp:Label ID="nameTxt" runat="server" Text=""></asp:Label>
            <br />

            <asp:Label ID="descLbl" runat="server" Text="Album Description"></asp:Label>
            <asp:Label ID="descTxt" runat="server" Text=""></asp:Label>
            <br />

            <asp:Label ID="priceLbl" runat="server" Text="Album Price"></asp:Label>
            <asp:Label ID="priceTxt" runat="server" Text=""></asp:Label>
            <br />

            <asp:Label ID="stockLbl" runat="server" Text="Album Stock"></asp:Label>
            <asp:Label ID="stockTxt" runat="server" Text=""></asp:Label>
            <br />

            <asp:Label ID="qtyLbl" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="qtyTxt" runat="server"></asp:TextBox>
            <asp:Label ID="qtyError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="cartBtn" runat="server" Text="Add To Cart" OnClick="cartBtn_Click" class="btn btn-success" />
        </div>
    </div>
</asp:Content>
