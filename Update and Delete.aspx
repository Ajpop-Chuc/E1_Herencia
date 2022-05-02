<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update and Delete.aspx.cs" Inherits="E1_Herencia.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p class="text-center" style="font-size: large; text-decoration: underline">
        <strong>ACTUALIZAR / ELIMINAR</strong></p>
    Universidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:DropDownList ID="DropDownListUniversidad" runat="server">
    </asp:DropDownList>
&nbsp;
    <asp:Button ID="ButtonSeleccionarUni" runat="server" OnClick="ButtonSeleccionarUni_Click" Text="Seleccionar Uni" />

    <br />
    <span style="font-size: medium">Carné del Alumno</span>&nbsp;
    <asp:DropDownList ID="DropDownListCarne" runat="server" Height="16px" Width="135px">
    </asp:DropDownList>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar Alumno" />
    <br />
    <br />
    Nombre&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    <br />
    Apellido&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
    <br />
    Direccion&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonActualizar" runat="server" Text="Actualizar Datos" Width="158px" OnClick="ButtonActualizar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Borrar Alumno" />
</asp:Content>
