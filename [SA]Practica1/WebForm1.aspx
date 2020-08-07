<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_SA_Practica1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Nombre<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Lista " OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
