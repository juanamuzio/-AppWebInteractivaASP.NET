using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Resumen_ejer2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Comprobamos si los parámetros están presentes en la sesión y si no son nulos
            if (Session["CiudadSeleccionada"] != null && Session["TemasSeleccionados"] != null)
            {
                // Recuperamos los valores 
                string Nombre = Session["txtNombre"].ToString();
                string Apellido = Session["txtApellido"].ToString();
                string Ciudad = Session["CiudadSeleccionada"].ToString();
                List<string> TemasSeleccionados = (List<string>)Session["TemasSeleccionados"];

                // Asignamos los valores a los controles de la página
                lblNombre.Visible = true;
                lblApellido.Visible = true;
                lblZonaElegida.Visible = true;
                lblTemas.Visible = true;
                lblNombre.Text = Nombre;
                lblApellido.Text = Apellido;
                lblZonaElegida.Text = Ciudad;
                lblTemas.Text =string.Join(",",TemasSeleccionados);
            }
            else
            {
                // En caso de que falten parámetros o sean nulos, mostramos un mensaje de error
                lblNombre.Text = "Nombre no proporcionado";
                lblApellido.Text = "Apellido no proporcionado";
                lblZonaElegida.Text = "No se ha seleccionado una ciudad";
                lblTemas.Text = "No se han seleccionado temas";
            }
        }
    }
}
