using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                MostrarError("Falta ingresar un Nombre");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text.Trim()))
            {
                MostrarError("Falta ingresar un Apellido");
                return;
            }

            if (cblTemas.SelectedIndex == -1)
            {
                MostrarError("Falta seleccionar al menos un tema");
                return;
            }

            if (contNum(txtNombre.Text) || contNum(txtApellido.Text))
            {
                MostrarError("El nombre o apellido no puede contener numeros");
                return;
            }

            GuardarInformacionEnSesion(ObtenerTemasSeleccionados());

            Server.Transfer("Resumen_ejer2.aspx");
        }


        private bool contNum(string cadena)
        {
            return cadena.Any(char.IsDigit);
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            foreach (ListItem item in cblTemas.Items)
            {
                item.Selected = false;
            }
        }

        private void GuardarInformacionEnSesion(List<string> temasSeleccionados)
        {
            Session["TemasSeleccionados"] = temasSeleccionados;
            Session["CiudadSeleccionada"] = ddlCiudad.SelectedValue;
            Session["txtNombre"] = txtNombre.Text;
            Session["txtApellido"] = txtApellido.Text;
        }

        private List<string> ObtenerTemasSeleccionados()
        {
            List<string> temasSeleccionados = new List<string>();

            foreach (ListItem item in cblTemas.Items)
            {
                if (item.Selected)
                {
                    temasSeleccionados.Add(item.Value);
                }
            }
            return temasSeleccionados;
        }

    }
}

