<%@ Page Title="InsertArtist" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="WebApp_LAB.view.artist.InsertArtist" UnobtrusiveValidationMode="none"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <br />
    <asp:FileUpload ID="artistImg" runat="server" />
    <br />
    <asp:Label ID="imageError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
</asp:Content>
