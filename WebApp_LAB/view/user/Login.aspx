<%@ Page Title="Login" Language="C#" MasterPageFile="~/view/master/FrontPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_LAB.view.user.Login" UnobtrusiveValidationMode="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>

    <h3>Email</h3>
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="emailValid" runat="server" ErrorMessage="Email Required" ControlToValidate="emailTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <h3>Password</h3>
    <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="passValid" runat="server" ErrorMessage="Password Required" ControlToValidate="passTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:CheckBox ID="rememberCheck" runat="server" /> <h3>Remember Me</h3>
    <br />
    <asp:Button ID="loginBtn" runat="server" Text="Login" onclick="loginBtn_Click"/>
</asp:Content>
