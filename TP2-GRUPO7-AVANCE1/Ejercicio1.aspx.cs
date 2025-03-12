using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO7_AVANCE1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblError.Text = "";
                lblTabla.Text = "";
            }
        }
        private bool ContieneNum(string cadena)
        {
            return cadena.Any(char.IsDigit);
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
            //bool activar = true;
            if (string.IsNullOrWhiteSpace(txtCant1.Text) || string.IsNullOrWhiteSpace(txtCant2.Text) ||
                string.IsNullOrWhiteSpace(txtProd1.Text) || string.IsNullOrWhiteSpace(txtProd2.Text))
           
           {
                
                lblError.Text = "- Debe completar todos los campos para generar la tabla - ";
                return;
            }
            
            ///verificar que los productos no sean iguales
            if (txtProd1.Text.ToLower() == txtProd2.Text.ToLower())
            
            {
                lblTabla.Text = "Error: Los nombres de los productos no pueden ser iguales.";
                return;
            }

            if (ContieneNum(txtProd1.Text) || ContieneNum(txtProd2.Text))
            {
                lblError.Text = "-Error: Los nombres de los productos no pueden contener numeros";
                return;
            }

            if ((int.TryParse(txtCant1.Text, out _)) ==false || (int.TryParse(txtCant2.Text, out _)) == false)
      
            {
                lblError.Text = "- Por favor, ingrese un numero valido ";
                return;
            }

           // btnGenerar.Enabled = activar;
            lblError.Text = "";

            int numero1 = int.Parse(txtCant1.Text);
            int numero2 = int.Parse(txtCant2.Text);

            String tabla = "<table border=2>";

            tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";
            tabla += "<tr>";
            tabla += "<td>" + txtProd1.Text + "</td>";
            tabla += "<td>" + txtCant1.Text + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + txtProd2.Text + "</td>";
            tabla += "<td>" + txtCant2.Text + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>TOTAL</td>";
            tabla += "<td> " + (numero1 + numero2) + " </td>";
            tabla += "</tr>";

            lblTabla.Text = tabla;
            txtProd1.Text = "";
            txtProd2.Text = "";
            txtCant1.Text = "";
            txtCant2.Text = "";
        }


        protected void txtProd1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}