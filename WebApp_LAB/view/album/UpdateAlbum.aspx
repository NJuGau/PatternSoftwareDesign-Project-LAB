<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="WebApp_LAB.view.album.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Album</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="descLbl" runat="server" Text="Description"></asp:Label>
    <br />
    <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="descError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
    <br />
    <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="priceError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="stockLbl" runat="server" Text="Stock"></asp:Label>
    <br />
    <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="stockError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <br />
    <asp:FileUpload ID="albumImg" runat="server" />
    <br />
    <asp:Label ID="imageError" runat="server" Text="" ForeColor=""></asp:Label>
    <br />

    <asp:Button ID="updateBtn" runat="server" Text="Insert" OnClick="updateBtn_Click"/>
</asp:Content>
