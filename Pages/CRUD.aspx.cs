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
    public partial class CRUD : System.Web.UI.Page
    {
        //Inicializar controlador
        PersonaController controllerPersona = new PersonaController();
        UsuarioController controllerUsuario = new UsuarioController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            String id = Guid.NewGuid().ToString();
            Persona nuevaPersona = new Persona
            {
                Identificador = id,
                Nombres = tbnombres.Text,
                Apellidos = tbapellidos.Text,
                NumeroIdentificacion = tbnumeroidentificacion.Text,
                Email = tbemail.Text,
                TipoIdentificacion = tbtipoidentificacion.SelectedValue,
            };

            Usuario nuevoUsuario = new Usuario {
                Identificador = id,
                User = tbusuario.Text,
                Pass = tbpass.Text
            };
            //Llamado al Post de Persona
            bool resultadoP = controllerPersona.Post(nuevaPersona);

            //Llamado al Post de Usuario
            bool resultadoU = controllerUsuario.Post(nuevoUsuario);

            // Limpiar los TextBox después de procesar
            LimpiarTextBox();

        }

        private void LimpiarTextBox()
        {
            tbnombres.Text = string.Empty;
            tbapellidos.Text = string.Empty;
            tbnumeroidentificacion.Text = string.Empty;
            tbemail.Text = string.Empty;
            tbtipoidentificacion.SelectedIndex = 0; // Esto seleccionará el primer elemento en el DropDownList
            tbusuario.Text = string.Empty;
            tbpass.Text = string.Empty;
        }
    }
}