<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="WebApp_LAB.view.artist.ArtistDetail" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>

    <asp:Label ID="imageLbl" runat="server" Text="Image"></asp:Label>
    <br />
    <asp:Image ID="artistImg" runat="server" />
    <br />

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:Label ID="artistName" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="insertBtn" runat="server" Text="Insert Album" OnClick="insertBtn_Click" Visible="false"/>

    <br />
    <asp:Label ID="albumLbl" runat="server" Text="Album Details"></asp:Label>

    <div class="card-group">
        <asp:Repeater ID="CardRepeater" runat="server" OnItemDataBound="CardRepeater_ItemDataBound">
            <ItemTemplate>
                <div class="card mx-4 my-5" style="max-width: 18rem;">
                    <asp:LinkButton ID="albumCard" runat="server" CommandArgument='<%#Eval("AlbumID") %>' OnClick="albumCard_Click" style="text-decoration: none">
                        <img src="../../assets/albums/<%# Eval("AlbumImage") %>" alt="..." class="card-img-top rounded" style="width: 18rem; height: 20rem; object-fit: cover">
                        <div class="card-body">
                            <div>
                                <p><%# Eval("AlbumName") %></p>
                            </div>
                            <div>
                                <p><%# Eval("AlbumPrice") %></p>
                            </div>
                            <div>
                                <p><%# Eval("AlbumDescription") %></p>
                            </div>
                        </div>
                    </asp:LinkButton>
                    <div class="flex-column">
                        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("AlbumID") %>' class="btn btn-success m-1"/>
                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("AlbumID") %>' class="btn btn-danger m-1"/>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
