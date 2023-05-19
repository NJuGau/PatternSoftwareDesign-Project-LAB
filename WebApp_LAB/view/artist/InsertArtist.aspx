<%@ Page Title="InsertArtist" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="WebApp_LAB.view.artist.InsertArtist" UnobtrusiveValidationMode="none"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <asp:FileUpload ID="artistImg" runat="server" />
    <asp:Label ID="imageError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <%--<asp:RegularExpressionValidator ID="imgValid" runat="server" ErrorMessage="File must be .png, .jpg, .jpeg, or .jfif" ControlToValidate="artistImg" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jfif)$"></asp:RegularExpressionValidator>--%>
    <br />

    <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
</asp:Content>
