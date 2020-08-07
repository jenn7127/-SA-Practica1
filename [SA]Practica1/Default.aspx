  <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_SA_Practica1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Agregar contacto</h3>

        <p class="lead">Nombre: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
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

    </asp:Content>
