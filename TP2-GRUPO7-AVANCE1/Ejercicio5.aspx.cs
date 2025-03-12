using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CBLaccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<int, double> preciosConfiguraciones = new Dictionary<int, double>()
        {
            { 0, 200.0 },
            { 1, 375.0 },
            { 2, 500.0 }
        };
        private Dictionary<string, double> preciosAccesorios = new Dictionary<string, double>()
        {
            { "Monitor LCD", 2000.50 },
            { "HD 500GB", 550.50 },
            { "Grabador DVD", 1200.0 }
        };

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = 0.0;
            bool accesoriosSeleccionados = false;
            string selecciones = "";

            if (DDLConfig.SelectedIndex >= 0 && preciosConfiguraciones.ContainsKey(DDLConfig.SelectedIndex))
            {
                monto = preciosConfiguraciones[DDLConfig.SelectedIndex];
            }
            else
            {
                lblpreciofinal.Text = "Por favor, seleccione una cantidad de memoria";
                return;
            }

            selecciones += "Memoria seleccionada: " + DDLConfig.SelectedItem.Text + "<br />Accesorios seleccionados:<br />";

            foreach (ListItem item in CBLaccesorios.Items)
            {
                if (item.Selected && preciosAccesorios.ContainsKey(item.Value))
                {
                    monto += preciosAccesorios[item.Value];
                    accesoriosSeleccionados = true;
                    selecciones += item.Text + "<br />";
                }
            }

            if (!accesoriosSeleccionados)
            {
                lblpreciofinal.Text = "Por favor, seleccione al menos un accesorio.";
                return;
            }

            lblpreciofinal.Text = "El precio final es de: $ " + monto.ToString("0.00");
            lblSelecciones.Text = selecciones;
        }



    }
}
