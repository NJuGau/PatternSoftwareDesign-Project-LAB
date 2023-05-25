<%@ Page Title="Home" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp_LAB.view.home.Home" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="d-flex justify-content-between">
        <h1 class="text-white">Home</h1>
        <asp:Button ID="insertBtn" runat="server" Text="Insert Artist" Visible="false" OnClick="insertBtn_Click" class="btn btn-primary ms-3 my-3"/>
    </div>

    <div class="card-group shadow-lg mt-3 p-4 pt-0 mb-5 rounded border border-2">
        <asp:Repeater ID="CardRepeater" runat="server" OnItemDataBound="CardRepeater_ItemDataBound">
            <ItemTemplate>
                <div class="card mx-4 my-5 shadow-lg rounded align-items-center" style="max-width: 16rem; background-color: #201c24">
                    <asp:LinkButton ID="artistCard" runat="server" CommandArgument='<%#Eval("ArtistID") %>' OnClick="artistCard_Click" style="text-decoration: none">
                        <img src="../../assets/artists/<%# Eval("ArtistImage") %>" alt="..." class="card-img-top rounded-top" style="width: 16rem; height: 18rem; object-fit: cover;">
                        <div class="card-body">
                            <div>
                                <p class="fw-normal fs-4 text-white"><%# Eval("ArtistName") %></p>
                            </div>
                        </div>
                    </asp:LinkButton>
                    <div class="flex-column mb-3">
                        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("ArtistID") %>' class="btn btn-success m-1"/>
                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("ArtistID") %>' class="btn btn-danger m-1"/>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>


</asp:Content>
