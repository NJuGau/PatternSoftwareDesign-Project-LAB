<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/FrontPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp_LAB.view.user.Register" UnobtrusiveValidationMode="none" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="nameValid" runat="server" ErrorMessage="Name is Required" ControlToValidate="nameTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="emailValid" runat="server" ErrorMessage="Email is Required" ControlToValidate="emailTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />

    <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
    <asp:RadioButton ID="maleRadio" runat="server" GroupName="gender" />
    <asp:RadioButton ID="femaleRadio" runat="server" GroupName="gender"/>
    <br />

    <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="addressValid" runat="server" ErrorMessage="Address is Required" ControlToValidate="addressTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:Label ID="addressError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="passLbl" runat="server" Text="Pass"></asp:Label>
    <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="passValid" runat="server" ErrorMessage="Password is Required" ControlToValidate="passTxt" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:Label ID="passError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Button ID="regisBtn" runat="server" Text="Register" OnClick="regisBtn_Click"/>
</asp:Content>
