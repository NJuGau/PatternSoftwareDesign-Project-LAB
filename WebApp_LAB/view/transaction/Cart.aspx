<%@ Page Title="Cart" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApp_LAB.view.transaction.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Cart</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <asp:GridView ID="cartGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="cartGrid_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="AlbumID" HeaderText="Album ID" SortExpression="AlbumID" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Action" ShowHeader="True" Text="Remove"/>
                </Columns>
            </asp:GridView>

            <asp:Button ID="checkOutBtn" runat="server" Text="Checkout" OnClick="checkOutBtn_Click" class="btn btn-success" />
        </div>
    </div>

</asp:Content>
