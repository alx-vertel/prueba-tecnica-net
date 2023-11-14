using prueba_tecnica_net.Data;
using prueba_tecnica_net.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace prueba_tecnica_net.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/usuario/?query
        [HttpGet]
        public Persona Get(string User, string Pass)
        {
            return UsuarioData.ConsultarUsuarioPersona(User, Pass);
        }

        // POST api/usuario
        [HttpPost]
        public bool Post([FromBody]Usuario usuario)
        {
            return UsuarioData.RegistrarUsuario(usuario);
        }
    }
}
