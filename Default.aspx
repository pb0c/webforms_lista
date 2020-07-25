<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Evaluacion3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="content-fluid">
        <div class="row">
        </div>
    </div>
    Rut
    <asp:TextBox ID="rut" runat="server"></asp:TextBox>
    <br />
    Nombre<asp:TextBox ID="nombre" runat="server"></asp:TextBox>
    <br />
    Apellido Paterno<asp:TextBox ID="apellidoP" runat="server"></asp:TextBox>
    <br />
    Apellido Materno<asp:TextBox ID="apellidoM" runat="server"></asp:TextBox>
    <br />
    F. de Nacimiento<asp:TextBox ID="fdenac" runat="server"></asp:TextBox>
    <br />
    Teléfono<asp:TextBox ID="tel" runat="server"></asp:TextBox>
    <br />
    Previsión<asp:TextBox ID="prev" runat="server"></asp:TextBox>
    <br />
    Calle<asp:TextBox ID="calle" runat="server"></asp:TextBox>
    <br />
    Número Calle<asp:TextBox ID="numCalle" runat="server"></asp:TextBox>
    <br />
    Actividad<asp:TextBox ID="act" runat="server"></asp:TextBox>
    <br />
    Deporte<asp:TextBox ID="dep" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />

    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"
        AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="_rut" HeaderText="Rut" />
            <asp:BoundField DataField="_nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="_apellidoP" HeaderText="Apellido" />
            <asp:BoundField DataField="_apellidoM" HeaderText="Apellido" />
            <asp:BoundField DataField="_fdenac" HeaderText="F. de Nac" />
            <asp:BoundField DataField="_telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="_prevision" HeaderText="Previsión" />
            <asp:BoundField DataField="_calle" HeaderText="Calle" />
            <asp:BoundField DataField="_numCalle" HeaderText="Calle Número" />
            <asp:BoundField DataField="_actividad" HeaderText="Actividad" />
            <asp:BoundField DataField="_deporte" HeaderText="Deporte" />
        </Columns>

    </asp:GridView>

</asp:Content>
