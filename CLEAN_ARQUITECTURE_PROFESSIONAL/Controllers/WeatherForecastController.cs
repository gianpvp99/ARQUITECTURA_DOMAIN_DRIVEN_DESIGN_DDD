using CLEAN_ARQ_PROF.DOMAIN.Entities;
using CLEAN_ARQ_PROF.DOMAIN.ValueObjects.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace CLEAN_ARQUITECTURE_PROFESSIONAL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [Route("prueba")]
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
            return Ok(user);
        }
    }
}
