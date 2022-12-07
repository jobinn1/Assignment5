<%@ Page Title="" Language="C#" MasterPageFile="~/two/master.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Assignment4.two.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Loginid" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Name" />
            <asp:CommandField DeleteText="confirm" HeaderText="confirm" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
