using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLIVE.ENTITIES
{
    public class APPLIVE_Stream
    {
        public string Channel { get; set; }        // Nombre del canal
        public string Feed { get; set; }           // ¿Alimentación o fuente del stream?
        public string Url { get; set; }            // URL de la lista de reproducción .m3u8
        public string Referrer { get; set; }       // Referente (si está presente)
        public string UserAgent { get; set; }      // User agent (si está presente)
        public string Quality { get; set; }        // Calidad del stream (por ejemplo, 480p)
    }
}
