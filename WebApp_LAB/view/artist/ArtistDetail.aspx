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

    <asp:Label ID="albumLbl" runat="server" Text="Album Details"></asp:Label>
   <%-- <asp:GridView ID="albumGrid" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update Album" ShowHeader="True" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete Album" ShowHeader="True" Text="Delete" />
            <asp:ImageField DataImageUrlField="AlbumImage" DataImageUrlFormatString="~/assets/albums/{0}" HeaderText="Album Image" ReadOnly="True">
            </asp:ImageField>
            <asp:BoundField DataField="AlbumName" HeaderText="Album Name" ReadOnly="True" SortExpression="AlbumName" />
            <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" ReadOnly="True" SortExpression="AlbumPrice" />
            <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" ReadOnly="True" SortExpression="AlbumDescription" />
        </Columns>
    </asp:GridView>--%>

    <asp:Repeater ID="CardRepeater" runat="server">
        <ItemTemplate>
            <div>
                <asp:LinkButton ID="albumCard" runat="server" CommandArgument='<%#Eval("AlbumID") %>' OnClick="albumCard_Click">
                    <div>
                        <img src="../../assets/albums/<%# Eval("AlbumImage") %>" alt="...">
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
                <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("AlbumID") %>'/>
                <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("AlbumID") %>'/>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Button ID="insertBtn" runat="server" Text="Insert Album" OnClick="insertBtn_Click"/>
</asp:Content>
