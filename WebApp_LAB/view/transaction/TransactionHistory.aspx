<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="WebApp_LAB.view.transaction.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="text-white mb-5" style="text-align:center">Transaction History</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white d-flex flex-column align-items-center">
            <asp:GridView ID="transactionHistoryGrid" runat="server" AutoGenerateColumns="False" OnRowDeleting="transactionHistoryGrid_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID"/>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate"/>

                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" SortExpression="CustomerName"/>

                    <asp:ImageField DataImageUrlField="AlbumImage" DataImageUrlFormatString="~/assets/albums/{0}" HeaderText="Album Picture" ControlStyle-CssClass="w-25">
                        <ControlStyle CssClass="object-fit-contain border rounded" Height="200px"/>
                    </asp:ImageField>
                    <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice" />

                </Columns>
            </asp:GridView>


        </div>
    </div>
</asp:Content>
