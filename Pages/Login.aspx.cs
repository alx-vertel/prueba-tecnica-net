using prueba_tecnica_net.Controllers;
using prueba_tecnica_net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba_tecnica_net.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        UsuarioController controllerUsuario = new UsuarioController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre");

            String user = tbuser.Text;
            String password = tbpassword.Text;

            Persona personaExists = controllerUsuario.Get(user, password);

            if (personaExists != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "validacionExitosa", "alert('Validación exitosa');", true);
            } else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "validacionFallida", "alert('Validación fallida');", true);
            }

            LimpiarTextBox();
        }

        private void LimpiarTextBox()
        {
            tbuser.Text = string.Empty;
            tbpassword.Text = string.Empty;
        }
    }
}