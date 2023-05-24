<%@ Page Title="Home" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp_LAB.view.home.Home" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home</h1>
 
    <div class="card-group">
        <asp:Repeater ID="CardRepeater" runat="server" OnItemDataBound="CardRepeater_ItemDataBound">
            <ItemTemplate>
                <div class="card mx-4 my-5" style="max-width: 18rem;">
                    <asp:LinkButton ID="artistCard" runat="server" CommandArgument='<%#Eval("ArtistID") %>' OnClick="artistCard_Click" style="text-decoration: none">
                        <img src="../../assets/artists/<%# Eval("ArtistImage") %>" alt="..." class="card-img-top rounded" style="width: 18rem; height: 20rem; object-fit: cover">
                        <div class="card-body">
                            <div>
                                <p><%# Eval("ArtistName") %></p>
                            </div>
                        </div>
                    </asp:LinkButton>
                    <div class="flex-column">
                        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("ArtistID") %>' class="btn btn-success m-1"/>
                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("ArtistID") %>' class="btn btn-danger m-1"/>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <asp:Button ID="insertBtn" runat="server" Text="Insert" Visible="false" OnClick="insertBtn_Click"/>

</asp:Content>
