<%@ Page Title="Home" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp_LAB.view.home.Home" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home</h1>
    
    <asp:Repeater ID="CardRepeater" runat="server">
        <ItemTemplate>
            <div>
                <asp:LinkButton ID="artistCard" runat="server" CommandArgument='<%#Eval("ArtistID") %>' OnClick="artistCard_Click">
                    <div>
                        <img src="../../assets/artists/<%# Eval("ArtistImage") %>" alt="...">
                        <div>
                            <p><%# Eval("ArtistName") %></p>
                        </div>
                    </div>
                </asp:LinkButton>
                <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("ArtistID") %>'/>
                <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("ArtistID") %>'/>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click"/>

</asp:Content>
