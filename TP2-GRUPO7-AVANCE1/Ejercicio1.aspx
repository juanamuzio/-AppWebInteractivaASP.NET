<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_GRUPO7_AVANCE1.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese nombre del producto:&nbsp;&nbsp;
            <asp:TextBox ID="txtProd1" runat="server"></asp:TextBox>
&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
            <asp:TextBox ID="txtCant1" runat="server"></asp:TextBox>
            <br />
            <br />
            Ingrese nombre del producto:&nbsp;&nbsp;
            <asp:TextBox ID="txtProd2" runat="server"></asp:TextBox>
&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
            <asp:TextBox ID="txtCant2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
