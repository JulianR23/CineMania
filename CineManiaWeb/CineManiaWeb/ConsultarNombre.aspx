<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarNombre.aspx.cs" Inherits="CineManiaWeb.ConsultarNombre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
    <strong>
    <br />
    Consultar peliculas por nombre</strong></p>
<p>
    Nombre:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
</p>
<p>
    Código:&nbsp;
    <asp:TextBox ID="txCodigo" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Valor:&nbsp;
    <asp:TextBox ID="txValor" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    Codigo de sección:&nbsp;
    <asp:TextBox ID="txCodSec" runat="server" ReadOnly="True"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
</p>
</asp:Content>
