<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="WebApp_LAB.view.artist.UpdateArtist" UnobtrusiveValidationMode="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Update Artist</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="artistImg" runat="server" />
            <asp:Label ID="imageError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="updateBtn" runat="server" Text="Update" Onclick="updateBtn_Click" class="btn btn-success"/>
        </div>
    </div>

</asp:Content>
