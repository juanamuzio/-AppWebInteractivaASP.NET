using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Validacion_ejer4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.QueryString["Nom"];
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                lblValidacion.Text = "Bienvenido a mi pagina Sr./a "+ nombre;

        }
    }
}