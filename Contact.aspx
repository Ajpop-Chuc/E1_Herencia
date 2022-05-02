<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="E1_Herencia.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" Height="260px" Width="571px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
    </asp:GridView>
&nbsp;<br />
&nbsp;</asp:Content>
