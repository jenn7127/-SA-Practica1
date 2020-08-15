<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practica2Parte1.aspx.cs" Inherits="_SA_Practica1.Parte1.Practica2Parte1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar Contactos" />
        </div>
        <p>
            <asp:Label ID="lblLista" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
