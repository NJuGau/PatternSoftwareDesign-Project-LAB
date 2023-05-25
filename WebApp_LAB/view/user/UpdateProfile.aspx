<%@ Page Title="" Language="C#" MasterPageFile="~/view/master/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="WebApp_LAB.view.user.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-white mb-5" style="text-align:center">Update Profile</h1>

    <div class="d-flex flex-wrap justify-content-center">
        <div class="text-white border border-2 d-flex flex-column align-items-center p-3" style="width: 18rem">
            <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <asp:Label ID="nameError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            <asp:Label ID="emailError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
            <div>
                <asp:RadioButton ID="maleRadio" runat="server" GroupName="gender" />
                <asp:Label ID="maleLbl" runat="server" Text="Male" class="me-2"></asp:Label>
                <asp:RadioButton ID="femaleRadio" runat="server" GroupName="gender"/>
                <asp:Label ID="femaleLbl" runat="server" Text="Female"></asp:Label>
            </div>
            <asp:Label ID="genderError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
            <asp:Label ID="addressError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
            <asp:Label ID="passError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="updateBtn" runat="server" Text="Update Profile" OnClick="updateBtn_Click" class="btn btn-success"/>
        </div>
    </div>
</asp:Content>
