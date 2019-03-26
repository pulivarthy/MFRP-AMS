<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AgentCommission.aspx.cs" Inherits="AMC.AgentCommission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="fromdate" runat="server" Text="From Date" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtfromdate" runat="server" TextMode="Date" CssClass="form-control" placeholder="dd-mm-yyyy" ></asp:TextBox>
            </div>
            <div class="col-sm-4">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter from date" ControlToValidate="txtfromdate" ></asp:RequiredFieldValidator>
                <%--<asp:RangeValidator ID="RangeValidatorDob" runat="server" ErrorMessage="Invalid Format" MinimumValue="01/01/1910"></asp:RangeValidator>--%>
            </div>
            <div class="col-sm-1"></div>
        </div>
    <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="todate" runat="server" Text="To Date" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txttodate" runat="server" TextMode="Date" CssClass="form-control" placeholder="dd-mm-yyyy" ></asp:TextBox>
            </div>
            <div class="col-sm-4">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter To Date" ControlToValidate="txttodate" ></asp:RequiredFieldValidator>
                <%--<asp:RangeValidator ID="RangeValidatorDob" runat="server" ErrorMessage="Invalid Format" MinimumValue="01/01/1910"></asp:RangeValidator>--%>
            </div>
            <div class="col-sm-1"></div>
        </div>
     <div class="row form-group">
            <div class="col-sm-2"></div>
         <div class="col-sm-2">
                <asp:Label ID="Alluser" runat="server" Text="All User" CssClass="control-label"></asp:Label>
            </div>
            <%--<div class="col-sm-3">
                <asp:Label ID="submit1" runat="server"  CssClass="control-label"></asp:Label>
            </div>--%>
            <div class="col-sm-3">
                <asp:Button ID="btnsubmit1" runat="server" Text="submit" /> 
            </div>
            <div class="col-sm-4">

            </div>
            <div class="col-sm-1"></div>
        </div>
     <div class="row form-group">
            <div class="col-sm-2"></div>
            <div class="col-sm-2">
                <asp:Label ID="GetAgentId" runat="server" Text="Get Agent Id" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtGetAgentId" runat="server" CssClass="form-control"  ></asp:TextBox>
            </div>
            <div class="col-sm-4">

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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Constr %>" SelectCommand="Customers" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter Name="Customer_id" Type="Decimal" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Customer_id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Customer_id" HeaderText="Customer_id" InsertVisible="False" ReadOnly="True" SortExpression="Customer_id" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Date_of_birth" HeaderText="Date_of_birth" SortExpression="Date_of_birth" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="Contact_no" HeaderText="Contact_no" SortExpression="Contact_no" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Date_of_join" HeaderText="Date_of_join" SortExpression="Date_of_join" />
            <asp:BoundField DataField="Zipcode" HeaderText="Zipcode" SortExpression="Zipcode" />
        </Columns>
    </asp:GridView>

</asp:Content>
