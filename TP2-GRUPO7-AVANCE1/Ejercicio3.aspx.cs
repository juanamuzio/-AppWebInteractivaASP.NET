using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ColorSeleccionado"] != null)
                {
                    string colorHex = Session["ColorSeleccionado"].ToString();
                    lblColoreado.ForeColor = System.Drawing.ColorTranslator.FromHtml(colorHex);
                }
            }
            
        }

        protected void lbRojo_Click(object sender, EventArgs e)
        {
            CambiarColorTexto(System.Drawing.Color.Red);
        }

        protected void lbVerde_Click(object sender, EventArgs e)
        {
            CambiarColorTexto(System.Drawing.Color.Green);
        }

        protected void lbAzul_Click(object sender, EventArgs e)
        {
            CambiarColorTexto(System.Drawing.Color.Blue);
        }


        protected void lblAmarillo_Click(object sender, EventArgs e)
        {
            CambiarColorTexto(System.Drawing.Color.Yellow);

        }


        private void CambiarColorTexto(System.Drawing.Color c)
        {
            lblColoreado.ForeColor = c;
            Session["ColorSeleccionado"] = System.Drawing.ColorTranslator.ToHtml(c);
        }

    }
}