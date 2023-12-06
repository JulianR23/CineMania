<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CineManiaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <!DOCTYPE html>

<html>
    <head>
    <title>CineMania</title>
    <style type="text/css">
        *{
            text-decoration: none;
            list-style: none;
        }
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
        }

        .title h1{
            font-weight: bold;
            font-size:31px;
            text-align: center;
        }
       .consultar{
           font-size: 23;
       }
        
    </style>
</head>
<body>
    <div class="title">
    <h1>&nbsp;</h1>
        <h1>Bienvenido a CineMania la tienda de prestamo de peliculas más grande de toda la ciudad</h1><br /><br /></div>
    <main>
        <a href="ConsultarNombre" class="consultar">Consultar por nombre de las peliculas</a><br />
        <a href="ConsultarPrestamo" class="consultar">Consultar prestamos</a><br /><br />
    </main>
   


</body>
</html>

</asp:Content>
