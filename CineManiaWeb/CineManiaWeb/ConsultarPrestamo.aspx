<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarPrestamo.aspx.cs" Inherits="CineManiaWeb.ConsultarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <p class="text-center">
    <strong>
    <br />
    Consultar prestamos</strong></p>
<p>
    Código:&nbsp;
    <asp:TextBox ID="txCodigo" runat="server" Width="91px"></asp:TextBox>
</p>
<p>
    Nombre:&nbsp;
    <asp:TextBox ID="txNombre" runat="server" ReadOnly="True" Width="313px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" Height="33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
</p>

</asp:Content>
