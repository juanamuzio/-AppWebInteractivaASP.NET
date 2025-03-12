using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Trim() == "")
            {
                lblError.Text = "Porfavor, ingrese un usuario";
                return;
            }
            if (txtClave.Text.Trim() == "")
            {
                lblError.Text = "Porfavor, ingrese la contraseña";
                return;
            }

            if (txtUsuario.Text != null && txtClave.Text != null && AutenticarUsuario("claudio", "casas"))
            {
                Response.Redirect("Validacion_ejer4.aspx?Nom="+txtUsuario.Text);
               
            }
            else
            {
                Response.Redirect("Error_Ej4.aspx");
            }    
        }

        private bool AutenticarUsuario(string usuario, string clave)
        {
            return (txtUsuario.Text == "claudio" && txtClave.Text == "casas");
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.TextMode = TextBoxMode.Password;
        }
    }
}