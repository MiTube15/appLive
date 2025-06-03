using APPLIVES.APPLICATION;
using Microsoft.AspNetCore.Mvc;

namespace APPLIVE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class IptvController : Controller
    {
        private readonly APPLIVE_IIptvService _iptvService; 
        

        public IptvController(APPLIVE_IIptvService iptvService)
        {
            _iptvService = iptvService;
           
        }
        // Endpoint para obtener los canales filtrados por categoría, país y búsqueda
        [HttpGet("channels")]
        public async Task<IActionResult> GetChannels([FromQuery] string category = "general", [FromQuery] string country = "")
        {
            var channels = await _iptvService.GetChannelsAsync(category, country);
            if (channels == null || !channels.Any())
            {
                return NotFound("No channels found.");
            }
            return Ok(channels);
        }

        [HttpGet("logo-proxy")]
        public async Task<IActionResult> ProxyLogo([FromQuery] string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return BadRequest("URL inválida");

            try
            {
                using var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    return StatusCode((int)response.StatusCode, "No se pudo obtener la imagen");

                var contentType = response.Content.Headers.ContentType?.ToString() ?? "image/png";
                var imageBytes = await response.Content.ReadAsByteArrayAsync();

                return File(imageBytes, contentType);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al cargar la imagen: {ex.Message}");
            }
        }

     

    }
}
