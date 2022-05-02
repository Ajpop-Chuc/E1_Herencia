<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E1_Herencia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>Universidad
            <asp:DropDownList ID="DropDownListUniversidad" runat="server">
                <asp:ListItem>Mesomericana</asp:ListItem>
                <asp:ListItem>Landivar</asp:ListItem>
                <asp:ListItem>USAC</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Sede&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxSede" runat="server"></asp:TextBox>
        </p>
        <p>Datos del Alumno:</p>
        <p>&nbsp;Nombre&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>Apellido&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxApellido" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p>Direccion
            <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
        </p>
        <p>Fecha De Nacimiento
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>Carné
            <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Notas:</p>
        <p>&nbsp;Curso&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCurso" runat="server"></asp:TextBox>
&nbsp;&nbsp;</p>
        <p>&nbsp;Punteo&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPunteo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonGuardarNotas" runat="server" OnClick="ButtonInNotas_Click" Text="Ingresar Nota" />
&nbsp;&nbsp;&nbsp; </p>
        <p>
            <asp:Button ID="ButtonGuardarAlumno" runat="server" OnClick="ButtonInDatos_Click" Text="Ingresar Alumno a la Universidad" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="ButtonGuardarUniversidad" runat="server" OnClick="ButtonGuardarUniversidad_Click" Text="Guardar Universidad" />
        </p>
    </div>

    <div class="row">
        
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
