﻿<%@ Page Title="Home" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp_LAB.view.home.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home</h1>
    <asp:Button ID="insertBtn" runat="server" Text="Insert Artist" OnClick="insertBtn_Click" />
    <asp:Button ID="updateBtn" runat="server" Text="Update Artist" OnClick="updateBtn_Click" />
</asp:Content>
