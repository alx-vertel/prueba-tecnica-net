using prueba_tecnica_net.Data;
using prueba_tecnica_net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace prueba_tecnica_net.Controllers
{
    public class PersonaController : ApiController
    {
        // GET api/persona
        [HttpGet]
        public List<Persona> Get()
        {
            return PersonaData.ListarPersonas();
        }
        // POST api/persona
        [HttpPost]
        public bool Post([FromBody]Persona persona)
        {
            return PersonaData.Registrar(persona);
        }
    }
}
