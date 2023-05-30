<%@ Page Title="Cart" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApp_LAB.view.transaction.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Cart</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white d-flex flex-column align-items-center">
            <asp:GridView ID="cartGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="cartGrid_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="AlbumID" HeaderText="Album ID" SortExpression="AlbumID"/>
                    <asp:ImageField DataImageUrlField="AlbumImage" DataImageUrlFormatString="~/assets/albums/{0}" HeaderText="Album Picture" ControlStyle-CssClass="w-25">
                        <ControlStyle CssClass="object-fit-contain border rounded" Height="200px"/>
                    </asp:ImageField>
                    <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Action" ShowHeader="True" Text="Remove"  ControlStyle-CssClass="btn btn-danger"/>
                </Columns>
            </asp:GridView>

            <asp:Button ID="checkOutBtn" runat="server" Text="Checkout" OnClick="checkOutBtn_Click" class="btn btn-success mt-5 btn-lg"/>
        </div>
    </div>

</asp:Content>
