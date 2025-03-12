<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_GRUPO7_AVANCE1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblElija" runat="server" Font-Size="X-Large" Text="Elija su configuración" Font-Bold="True"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSeleccione" runat="server" Text="Seleccione cantidad de memoria:" Font-Bold="True"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLConfig" runat="server" Width="86px">
                <asp:ListItem Value="200">2 GB</asp:ListItem>
                <asp:ListItem Value="375">4 GB</asp:ListItem>
                <asp:ListItem Value="500">6 GB</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAccesorios" runat="server" Text="Seleccione accesorios:" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:CheckBoxList ID="CBLaccesorios" runat="server" OnSelectedIndexChanged="CBLaccesorios_SelectedIndexChanged" style="margin-left: 114px" Width="251px">
                <asp:ListItem Value="Monitor LCD">Monitor LCD</asp:ListItem>
                <asp:ListItem Value="HD 500GB">HD 500 GB</asp:ListItem>
                <asp:ListItem>Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btncalcular" runat="server" Text="Calcular Precio" OnClick="btncalcular_Click" Width="217px" />
            &nbsp;<br />
            <br />
            <asp:Label ID="lblSelecciones" runat="server" Font-Italic="False" Font-Names="Bahnschrift Condensed"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblpreciofinal" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
