<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="WebApp_LAB.view.album.InsertAlbum" UnobtrusiveValidationMode="None"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Insert Album</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="descLbl" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
            <asp:Label ID="descError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
            <asp:Label ID="priceError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="stockLbl" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox>
            <asp:Label ID="stockError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="albumImg" runat="server" />
            <asp:Label ID="imageError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" class="btn btn-primary"/>
        </div>
    </div>
</asp:Content>
