<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="WebApp_LAB.view.album.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Album</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="descLbl" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="stockLbl" runat="server" Text="Stock"></asp:Label>
    <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <asp:FileUpload ID="artistImg" runat="server" />
    <asp:RequiredFieldValidator ID="uploadValid" runat="server" ErrorMessage="Image is Required" ControlToValidate="artistImg" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="imgValid" runat="server" ErrorMessage="File must be .png, .jpg, .jpeg, or .jfif" ControlToValidate="artistImg" ForeColor="Red" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jfif)$"></asp:RegularExpressionValidator>
    <asp:Label ID="errorImg" runat="server" Text="tes" ForeColor=""></asp:Label>
    <br />

    <asp:Button ID="updateBtn" runat="server" Text="Insert" OnClick="updateBtn_Click"/>
</asp:Content>
