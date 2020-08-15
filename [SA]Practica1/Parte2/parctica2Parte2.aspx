<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="parctica2Parte2.aspx.cs" Inherits="_SA_Practica1.Parte2.parctica2Parte1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h3>Agregar contacto</h3>

        <p class="lead">Nombre: 
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        </p>
        <h3>Listas de contactos</h3>
        <p class="lead">
            <asp:Button ID="btnLista" runat="server" OnClick="btnLista_Click" Text="Mostar Lista" />
        </p>
        <p class="lead">
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
