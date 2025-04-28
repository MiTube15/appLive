using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLIVE.ENTITIES
{
    public class APPI_CHANELS
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<string>? AltNames { get; set; }  // Alternativos nombres si existen
        public string? Network { get; set; }
        public List<string>? Owners { get; set; }  // Propietarios si existen
        public string? Country { get; set; }
        public string? Subdivision { get; set; }
        public string? City { get; set; }
        public List<string>? BroadcastArea { get; set; }  // Área de transmisión
        public List<string>? Languages { get; set; }
        public List<string>? Categories { get; set; }
        public bool IsNsfw { get; set; }  // Para contenido NSFW
        public string? Launched { get; set; }
        public string? Closed { get; set; }
        public string? ReplacedBy { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }  // URL del logo
        public string? StreamUrl {  get; set; }
    }
}
