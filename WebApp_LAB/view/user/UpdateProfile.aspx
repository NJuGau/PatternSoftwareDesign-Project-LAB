<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/FrontPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="WebApp_LAB.view.user.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register</h1>

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
    <asp:RadioButton ID="maleRadio" runat="server" GroupName="gender" />
    <asp:Label ID="maleLbl" runat="server" Text="Male"></asp:Label>
    <asp:RadioButton ID="femaleRadio" runat="server" GroupName="gender"/>
    <asp:Label ID="femaleLbl" runat="server" Text="Female"></asp:Label>
    <br />

    <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
    <asp:Label ID="addressError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

    <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
    <asp:Label ID="passError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Button ID="updateBtn" runat="server" Text="Register" OnClick="updateBtn_Click"/>
</asp:Content>
