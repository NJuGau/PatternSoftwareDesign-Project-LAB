<%@ Page Title="InsertArtist" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="WebApp_LAB.view.artist.InsertArtist" UnobtrusiveValidationMode="none"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="nameValid" runat="server" ErrorMessage="Name is Required" ControlToValidate="nameTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <asp:FileUpload ID="artistImg" runat="server" />
    <asp:RequiredFieldValidator ID="uploadValid" runat="server" ErrorMessage="Image is Required" ControlToValidate="artistImg" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="imgValid" runat="server" ErrorMessage="File must be .png, .jpg, .jpeg, or .jfif" ControlToValidate="artistImg" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jfif)$"></asp:RegularExpressionValidator>
    <asp:Label ID="errorImg" runat="server" Text="tes" ForeColor=""></asp:Label>
    <br />

    <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
</asp:Content>
