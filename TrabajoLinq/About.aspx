<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TrabajoLinq.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CLIENTES.</h2>
<p>&nbsp;</p>
<p>Consultas de proyeccion:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="btn btn-primary " Text="Consultar Clientes" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" class="btn btn-primary" Text="Consultar Nombres de Clientes" />
</p>
<p>Consulta de expreciones lamba:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="btn btn-warning " Text="Buscar  por Pais: " ToolTip=" " />
&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>Consulta de clases Parciales:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" class="btn btn-success btn-lg" OnClick="Button3_Click" Text="Consultar " />
</p>
<p>Consulta Join con mas de 3 clases:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" class="btn btn-info " Text="Consultar Ordenes con Join" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
    <h3>&nbsp;</h3>
</asp:Content>
