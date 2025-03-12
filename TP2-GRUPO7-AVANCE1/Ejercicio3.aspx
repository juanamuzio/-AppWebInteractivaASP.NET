<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_GRUPO7_AVANCE1.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbRojo" runat="server" OnClick="lbRojo_Click">Rojo</asp:LinkButton>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbVerde" runat="server" OnClick="lbVerde_Click">Verde</asp:LinkButton>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbAzul" runat="server" OnClick="lbAzul_Click">Azul</asp:LinkButton>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lblAmarillo" runat="server" OnClick="lblAmarillo_Click">Amarillo</asp:LinkButton>
            <br />
&nbsp;&nbsp;
            <asp:Label ID="lblColoreado" runat="server" Text="Texto coloreado"></asp:Label>
        </div>
    </form>
</body>
</html>
