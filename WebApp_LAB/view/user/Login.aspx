<%@ Page Title="Login" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_LAB.view.user.Login" UnobtrusiveValidationMode="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Login</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <h5>Email</h5>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email must be filled!" ForeColor="Red" ControlToValidate="emailTxt"></asp:RequiredFieldValidator>

            <h5>Password</h5>
            <asp:TextBox ID="passTxt" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password must be filled!" ForeColor="Red" ControlToValidate="passTxt"></asp:RequiredFieldValidator>
            
            <div>
                <asp:CheckBox ID="rememberCheck" runat="server" />
                <asp:Label ID="rememberLbl" runat="server" Text="Remember Me"></asp:Label>
            </div>
            <asp:Label ID="loginError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <asp:Button ID="loginBtn" runat="server" Text="Login" onclick="loginBtn_Click" class="mt-2 btn btn-success"/>

        </div>

    </div>

</asp:Content>
