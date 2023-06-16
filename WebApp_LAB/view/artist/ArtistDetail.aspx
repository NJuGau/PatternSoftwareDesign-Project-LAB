<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="WebApp_LAB.view.artist.ArtistDetail" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="d-flex justify-content-around">
        <div class="ms-5">
            <h1 class="text-white mb-5">Artist Detail</h1>
            <div class="card shadow-lg rounded align-items-center" style="max-width: 18rem; max-height:24rem; background-color: #201c24">
                <asp:Image ID="artistImg" runat="server" style="width: 18rem; object-fit:cover" class="card-img-top"/>
                <div class="card-body">
                    <asp:Label class="h3 text-white" ID="artistName" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>

        <div class="ms-5">
            <div class="d-flex justify-content-between align-items-center mb-5 mt-0 mx-5">    
                <h2 class="text-white me-5">Album Details</h2>
                <asp:Button ID="insertBtn" runat="server" Text="Insert Album" OnClick="insertBtn_Click" Visible="false" class="btn btn-primary"/>
            </div>

            <div class="card-group ms-5">
                 <div class="row gy-4">
                     <asp:Repeater ID="CardRepeater" runat="server" OnItemDataBound="CardRepeater_ItemDataBound">
                            <ItemTemplate>
                                <div class="col gx-4">
                                    <div class="card shadow-lg rounded align-items-center" style="max-width: 18rem; background-color: #201c24">
                                        <asp:LinkButton ID="albumCard" runat="server" CommandArgument='<%#Eval("AlbumID") %>' OnClick="albumCard_Click" style="text-decoration: none">
                                            <img src="../../assets/albums/<%# Eval("AlbumImage") %>" alt="..." class="card-img-top rounded" style="width: 18rem; height: 20rem; object-fit: cover">
                                            <div class="card-body fw-normal fs-4 text-white"">
                                                <div class="d-flex justify-content-between align-items-baseline">
                                                    <p><%# Eval("AlbumName") %></p>
                                                    <p class="border border-2 p-2 rounded fs-5 fw-bold">$ <%# Eval("AlbumPrice") %></p>
                                                </div>
                                                <div>
                                                    <p class="fs-6">"<%# Eval("AlbumDescription") %>"</p>
                                                </div>
                                            </div>
                                        </asp:LinkButton>
                                        <div class="flex-column mb-3">
                                            <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" CommandArgument='<%#Eval("AlbumID") %>' class="btn btn-success m-1"/>
                                            <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" CommandArgument='<%#Eval("AlbumID") %>' class="btn btn-danger m-1"/>
                                        </div>
                                    </div>
                                 </div>
                            </ItemTemplate>
                        </asp:Repeater>
                     </div>
                 </div>
            </div>
        </div>


</asp:Content>
