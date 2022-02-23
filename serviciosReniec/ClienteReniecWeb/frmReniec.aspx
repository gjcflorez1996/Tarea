<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReniec.aspx.cs" Inherits="ClienteReniecWeb.frmReniec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--formulario del CRUD -->
    <h3>CRUD RENIEC</h3>
    <p>Dni: <asp:TextBox runat="server" Id="txtdni" /></p>
    <p> 
        <asp:Button Text = "Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p> 
        <asp:GridView runat="server" ID="gvDni"></asp:GridView>
    </p>
</asp:Content>
