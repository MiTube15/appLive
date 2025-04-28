using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLIVE.ENTITIES
{
    public class APPLIVE_Country
    {
        public string Name { get; set; }       // Nombre del país (ej. "Afghanistan")
        public string Code { get; set; }       // Código del país (ej. "AF")
        public List<string> Languages { get; set; } // Lista de idiomas hablados en el país (ej. ["prs", "pus", "tuk"])
        public string Flag { get; set; }       // Bandera del país (ej. "🇦🇫")
    }
}
