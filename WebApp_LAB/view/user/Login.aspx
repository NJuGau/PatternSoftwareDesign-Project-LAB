<%@ Page Title="Login" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_LAB.view.user.Login" UnobtrusiveValidationMode="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>

    <h3>Email</h3>
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email must be filled!" ForeColor="Red" ControlToValidate="emailTxt"></asp:RequiredFieldValidator>
    <br />

    <h3>Password</h3>
    <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password must be filled!" ForeColor="Red" ControlToValidate="passTxt"></asp:RequiredFieldValidator>
    <br />

    <asp:CheckBox ID="rememberCheck" runat="server" />
    <asp:Label ID="rememberLbl" runat="server" Text="Remember Me"></asp:Label>
    <br />
    <asp:Label ID="loginError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Button ID="loginBtn" runat="server" Text="Login" onclick="loginBtn_Click"/>
</asp:Content>
