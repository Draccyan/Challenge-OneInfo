using Challenge_OneInfo.Servicios.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_OneInfo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatosController : ControllerBase
    {
        [HttpPost]
        [Route("RecibirDatos")]
        public IActionResult RecibirDatos([FromBody] CommandRequest request)
        {
            var commandHandler = new CommandHandler();
            var result = commandHandler.Handler(request);

            if (result.Mensaje.StartsWith("Error"))
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

    }
}
