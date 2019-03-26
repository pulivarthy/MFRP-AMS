<%@ Page Title="" Language="C#" MasterPageFile="~/Commonpg.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AMC.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="Loginid" runat="server" Text="Login id" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtLoginid" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
            <div class="col-sm-4">

            </div>
            <div class="col-sm-1"></div>
        </div>
    <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="Password" runat="server" Text="Password" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"  ></asp:TextBox>
            </div>
            <div class="col-sm-4">
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter valid Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Password" ControlToValidate="txtPassword" ValidationExpression="([A-Z]{1}[a-z]{1}[0-9]{1}){8,}"></asp:RegularExpressionValidator>--%>
            </div>
            <div class="col-sm-1"></div>
        </div>
    <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="submit" runat="server"  CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:Button ID="btnsubmit" runat="server" Text="submit" OnClick="btnsubmit_Click" /> 
            </div>
            <div class="col-sm-4">

            </div>
            <div class="col-sm-1"></div>
        </div>

</asp:Content>
