<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="WebApp_LAB.view.artist.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>

    <br />

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>

    <br />

    <asp:Label ID="albumLbl" runat="server" Text="Album Details"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update Album" ShowHeader="True" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete Album" ShowHeader="True" Text="Delete" />
        </Columns>
    </asp:GridView>
</asp:Content>
