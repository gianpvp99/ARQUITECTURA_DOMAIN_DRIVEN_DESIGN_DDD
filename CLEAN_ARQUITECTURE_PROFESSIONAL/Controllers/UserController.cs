using CLEAN_ARQ_PROF.DOMAIN.Entities;
using CLEAN_ARQ_PROF.DOMAIN.ValueObjects.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace CLEAN_ARQUITECTURE_PROFESSIONAL.SERVICE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("Prueba")]
        public IActionResult Index()
        {
            return Ok(new { mensaje = "entro"}) ;
        }

        [Route("Prueba2")]
        [HttpGet]
        public IActionResult prueba()
        {

            var genero = GeneroValueObject.FromGenero("M");
            var locacion = new LocacionValueObject()
            {
                Departamento = "Lima",
                Direccion = "AV. NECOCHEA 389",
                Distrito = "Villa Maria del Triunfo",
                Provincia = "Lima"
            };


            var user = Usuarios.create(
                usuario: "jdoe",
                nroDocumento: "12345678",
                nombres: "John",
                apellidoPaterno: "Doe",
                apellidoMaterno: "Smith",
                genero: genero,
                direccion: locacion,
                correo: "jdoe@example.com",
                telefono: "555-1234",
                activo: true,
                eliminado: false,
                fechaCreacion: DateTime.UtcNow,
                fechaModificacion: DateTime.UtcNow,
                idUsuarioModificacion: 100,
                ultimoLogin: DateTime.UtcNow
                );
            var probando = new List<Usuarios>();
            probando.Add(user);
            probando.Add(user);
            var response = Result<Usuarios>.ListResult(probando, "Listado exitoso", true, false);
            return Ok(response);
        }
    }
}
