<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="parctica2Parte2.aspx.cs" Inherits="_SA_Practica1.Parte2.parctica2Parte1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Contraseña:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAutenticar" runat="server"  Text="Login" Height="29px" Width="69px" />
        </div>
        <p>
            Usuario:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
    </form>
</body>
</html>
